using Newtonsoft.Json.Linq;
using SevenZip.Compression.LZMA;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Tibia.Protobuf.Appearances;

namespace Tibia11Editor
{
    class Loader
    {
        public Appearances appearances;
        public List<Image> sprites;
        String _assetsPath;

        public void load(String path) {
            _assetsPath = path;

            //Open the Json.
            string json = File.ReadAllText(path + "catalog-content.json");
            JObject stuff = JObject.Parse("{ data: " + json + "}");
            //Get Tokens for sprites and appearances.
            IEnumerable<JToken> allSprites = stuff.SelectTokens("$.data[?(@.type == 'sprite')]");
            JToken appearancesToken = stuff.SelectToken("$.data[?(@.type == 'appearances')]");

            //Load appearances
            loadAppearances(appearancesToken.Value<String>("file"));
            //Load Sprites
            loadSprites(allSprites);
        }

        private void loadAppearances(String file) {
            using (var input = File.OpenRead(file))
            {
                appearances = Appearances.Parser.ParseFrom(input);
            }  
        }

        private void loadSprites(IEnumerable<JToken> allSprites)
        {
            sprites = new List<Image>();
            MemoryStream spriteBuffer = new MemoryStream(0x100000);
            foreach (JToken sprite in allSprites)
            {
                string filePath = String.Format("{0}{1}.lzma", _assetsPath, sprite.Value<String>("file"));
                try
                {
                    sprites.Add(decodeSpriteSheet(spriteBuffer, filePath));
                } catch (FileNotFoundException)  {
                    //TODO:Maybe log the errors.
                }
            }
        }


        private Image decodeSpriteSheet(MemoryStream spriteBuffer,String filePath) {
            if (File.Exists(filePath))
            {
                Decoder decoder = new Decoder();
                using (BinaryReader reader = new BinaryReader(File.OpenRead(filePath)))
                {
                    Stream input = reader.BaseStream;
                    /*
                        CIP's header, 32 bytes

                        Padded with a variable number of NULL bytes (depending on LZMA file size) at the start then the constant
                        byte sequence of "70 0A FA 80 24" followed by the LZMA file size encoded as a 7-bit integer
                    */

                    // Since there may be a variable number of NULL bytes just loop until we get through them all, then skip past
                    // the remaining 4 bytes of the constant (really should check their values for file validity but just assume it is)
                    while (reader.ReadByte() == 0) { }
                    reader.ReadUInt32();

                    while ((reader.ReadByte() & 0x80) == 0x80) { } // LZMA size, 7-bit integer where MSB = flag for next byte used

                    // LZMA file
                    decoder.SetDecoderProperties(reader.ReadBytes(5));
                    reader.ReadUInt64(); // Should be the decompressed size but CIP writes the compressed sized, so just use a large buffer size

                    // Disabled arithmetic underflow/overflow check in debug mode so this won't cause an exception
                    spriteBuffer.Position = 0;
                    decoder.Code(input, spriteBuffer, input.Length - input.Position, 0x100000, null);
                }
                spriteBuffer.Position = 0;
                return Image.FromStream(spriteBuffer);
            } else {
                throw new FileNotFoundException("Could not load file " + filePath);
            }
        }

    }
}
