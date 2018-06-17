namespace Tibia11Editor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFromFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datCountLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalSprites = new System.Windows.Forms.Label();
            this.totalOutfits = new System.Windows.Forms.Label();
            this.totalMissiles = new System.Windows.Forms.Label();
            this.totalObjects = new System.Windows.Forms.Label();
            this.totalEffects = new System.Windows.Forms.Label();
            this.totalElements = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFromFolderToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // loadFromFolderToolStripMenuItem
            // 
            this.loadFromFolderToolStripMenuItem.Name = "loadFromFolderToolStripMenuItem";
            this.loadFromFolderToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadFromFolderToolStripMenuItem.Text = "Load from folder...";
            this.loadFromFolderToolStripMenuItem.Click += new System.EventHandler(this.loadFromFolderToolStripMenuItem_Click);
            // 
            // datCountLabel
            // 
            this.datCountLabel.AutoSize = true;
            this.datCountLabel.Location = new System.Drawing.Point(12, 52);
            this.datCountLabel.Name = "datCountLabel";
            this.datCountLabel.Size = new System.Drawing.Size(77, 13);
            this.datCountLabel.TabIndex = 1;
            this.datCountLabel.Text = "Total Elements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Effects";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Objects";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total Missiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Outfits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Sprites";
            // 
            // totalSprites
            // 
            this.totalSprites.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalSprites.Location = new System.Drawing.Point(176, 141);
            this.totalSprites.Name = "totalSprites";
            this.totalSprites.Size = new System.Drawing.Size(96, 13);
            this.totalSprites.TabIndex = 12;
            this.totalSprites.Text = "0";
            this.totalSprites.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOutfits
            // 
            this.totalOutfits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalOutfits.Location = new System.Drawing.Point(176, 104);
            this.totalOutfits.Name = "totalOutfits";
            this.totalOutfits.Size = new System.Drawing.Size(96, 13);
            this.totalOutfits.TabIndex = 13;
            this.totalOutfits.Text = "0";
            this.totalOutfits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalMissiles
            // 
            this.totalMissiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalMissiles.Location = new System.Drawing.Point(176, 91);
            this.totalMissiles.Name = "totalMissiles";
            this.totalMissiles.Size = new System.Drawing.Size(96, 13);
            this.totalMissiles.TabIndex = 14;
            this.totalMissiles.Text = "0";
            this.totalMissiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalObjects
            // 
            this.totalObjects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalObjects.Location = new System.Drawing.Point(176, 78);
            this.totalObjects.Name = "totalObjects";
            this.totalObjects.Size = new System.Drawing.Size(96, 13);
            this.totalObjects.TabIndex = 15;
            this.totalObjects.Text = "0";
            this.totalObjects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalEffects
            // 
            this.totalEffects.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalEffects.Location = new System.Drawing.Point(176, 65);
            this.totalEffects.Name = "totalEffects";
            this.totalEffects.Size = new System.Drawing.Size(96, 13);
            this.totalEffects.TabIndex = 16;
            this.totalEffects.Text = "0";
            this.totalEffects.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalElements
            // 
            this.totalElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalElements.Location = new System.Drawing.Point(179, 52);
            this.totalElements.Name = "totalElements";
            this.totalElements.Size = new System.Drawing.Size(93, 13);
            this.totalElements.TabIndex = 17;
            this.totalElements.Text = "0";
            this.totalElements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.totalElements);
            this.Controls.Add(this.totalEffects);
            this.Controls.Add(this.totalObjects);
            this.Controls.Add(this.totalMissiles);
            this.Controls.Add(this.totalOutfits);
            this.Controls.Add(this.totalSprites);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datCountLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadFromFolderToolStripMenuItem;
        private System.Windows.Forms.Label datCountLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalSprites;
        private System.Windows.Forms.Label totalOutfits;
        private System.Windows.Forms.Label totalMissiles;
        private System.Windows.Forms.Label totalObjects;
        private System.Windows.Forms.Label totalEffects;
        private System.Windows.Forms.Label totalElements;
    }
}

