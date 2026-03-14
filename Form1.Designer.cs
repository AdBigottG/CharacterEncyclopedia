namespace project2VG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gboxCharacterType = new System.Windows.Forms.GroupBox();
            this.btnArcher = new System.Windows.Forms.RadioButton();
            this.btnRogue = new System.Windows.Forms.RadioButton();
            this.btnMage = new System.Windows.Forms.RadioButton();
            this.btnWarrior = new System.Windows.Forms.RadioButton();
            this.gbDisplayOptions = new System.Windows.Forms.GroupBox();
            this.cboxDiffLvl = new System.Windows.Forms.CheckBox();
            this.cboxStartEquip = new System.Windows.Forms.CheckBox();
            this.cboxSabilities = new System.Windows.Forms.CheckBox();
            this.cboxBstats = new System.Windows.Forms.CheckBox();
            this.cboxCharcImg = new System.Windows.Forms.CheckBox();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.gboxCharacterType.SuspendLayout();
            this.gbDisplayOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxCharacterType
            // 
            this.gboxCharacterType.BackColor = System.Drawing.Color.Transparent;
            this.gboxCharacterType.Controls.Add(this.btnArcher);
            this.gboxCharacterType.Controls.Add(this.btnRogue);
            this.gboxCharacterType.Controls.Add(this.btnMage);
            this.gboxCharacterType.Controls.Add(this.btnWarrior);
            this.gboxCharacterType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gboxCharacterType.Location = new System.Drawing.Point(13, 13);
            this.gboxCharacterType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxCharacterType.Name = "gboxCharacterType";
            this.gboxCharacterType.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxCharacterType.Size = new System.Drawing.Size(269, 178);
            this.gboxCharacterType.TabIndex = 1;
            this.gboxCharacterType.TabStop = false;
            this.gboxCharacterType.Text = "Character Type";
            // 
            // btnArcher
            // 
            this.btnArcher.AutoSize = true;
            this.btnArcher.Location = new System.Drawing.Point(13, 136);
            this.btnArcher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnArcher.Name = "btnArcher";
            this.btnArcher.Size = new System.Drawing.Size(61, 19);
            this.btnArcher.TabIndex = 3;
            this.btnArcher.Text = "Archer";
            this.btnArcher.UseVisualStyleBackColor = true;
            this.btnArcher.CheckedChanged += new System.EventHandler(this.btnArcher_CheckedChanged);
            // 
            // btnRogue
            // 
            this.btnRogue.AutoSize = true;
            this.btnRogue.Location = new System.Drawing.Point(13, 97);
            this.btnRogue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRogue.Name = "btnRogue";
            this.btnRogue.Size = new System.Drawing.Size(59, 19);
            this.btnRogue.TabIndex = 2;
            this.btnRogue.Text = "Rogue";
            this.btnRogue.UseVisualStyleBackColor = true;
            this.btnRogue.CheckedChanged += new System.EventHandler(this.btnRogue_CheckedChanged);
            // 
            // btnMage
            // 
            this.btnMage.AutoSize = true;
            this.btnMage.Location = new System.Drawing.Point(13, 59);
            this.btnMage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMage.Name = "btnMage";
            this.btnMage.Size = new System.Drawing.Size(54, 19);
            this.btnMage.TabIndex = 1;
            this.btnMage.Text = "Mage";
            this.btnMage.UseVisualStyleBackColor = true;
            this.btnMage.CheckedChanged += new System.EventHandler(this.btnMage_CheckedChanged);
            // 
            // btnWarrior
            // 
            this.btnWarrior.AutoSize = true;
            this.btnWarrior.Location = new System.Drawing.Point(15, 24);
            this.btnWarrior.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWarrior.Name = "btnWarrior";
            this.btnWarrior.Size = new System.Drawing.Size(69, 19);
            this.btnWarrior.TabIndex = 0;
            this.btnWarrior.Text = "Warrior";
            this.btnWarrior.UseVisualStyleBackColor = true;
            this.btnWarrior.CheckedChanged += new System.EventHandler(this.btnWarrior_CheckedChanged);
            // 
            // gbDisplayOptions
            // 
            this.gbDisplayOptions.BackColor = System.Drawing.Color.Transparent;
            this.gbDisplayOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbDisplayOptions.Controls.Add(this.cboxDiffLvl);
            this.gbDisplayOptions.Controls.Add(this.cboxStartEquip);
            this.gbDisplayOptions.Controls.Add(this.cboxSabilities);
            this.gbDisplayOptions.Controls.Add(this.cboxBstats);
            this.gbDisplayOptions.Controls.Add(this.cboxCharcImg);
            this.gbDisplayOptions.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gbDisplayOptions.Location = new System.Drawing.Point(17, 225);
            this.gbDisplayOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDisplayOptions.Name = "gbDisplayOptions";
            this.gbDisplayOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbDisplayOptions.Size = new System.Drawing.Size(264, 196);
            this.gbDisplayOptions.TabIndex = 2;
            this.gbDisplayOptions.TabStop = false;
            this.gbDisplayOptions.Text = "Display Options";
            // 
            // cboxDiffLvl
            // 
            this.cboxDiffLvl.AutoSize = true;
            this.cboxDiffLvl.Location = new System.Drawing.Point(11, 170);
            this.cboxDiffLvl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxDiffLvl.Name = "cboxDiffLvl";
            this.cboxDiffLvl.Size = new System.Drawing.Size(115, 19);
            this.cboxDiffLvl.TabIndex = 4;
            this.cboxDiffLvl.Text = "Difficulty Level";
            this.cboxDiffLvl.UseVisualStyleBackColor = true;
            // 
            // cboxStartEquip
            // 
            this.cboxStartEquip.AutoSize = true;
            this.cboxStartEquip.Location = new System.Drawing.Point(9, 130);
            this.cboxStartEquip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxStartEquip.Name = "cboxStartEquip";
            this.cboxStartEquip.Size = new System.Drawing.Size(134, 19);
            this.cboxStartEquip.TabIndex = 3;
            this.cboxStartEquip.Text = "Starting Equipment";
            this.cboxStartEquip.UseVisualStyleBackColor = true;
            // 
            // cboxSabilities
            // 
            this.cboxSabilities.AutoSize = true;
            this.cboxSabilities.Location = new System.Drawing.Point(9, 91);
            this.cboxSabilities.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxSabilities.Name = "cboxSabilities";
            this.cboxSabilities.Size = new System.Drawing.Size(114, 19);
            this.cboxSabilities.TabIndex = 2;
            this.cboxSabilities.Text = "Special Abilities";
            this.cboxSabilities.UseVisualStyleBackColor = true;
            // 
            // cboxBstats
            // 
            this.cboxBstats.AutoSize = true;
            this.cboxBstats.Location = new System.Drawing.Point(9, 54);
            this.cboxBstats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxBstats.Name = "cboxBstats";
            this.cboxBstats.Size = new System.Drawing.Size(83, 19);
            this.cboxBstats.TabIndex = 1;
            this.cboxBstats.Text = "Base Stats";
            this.cboxBstats.UseVisualStyleBackColor = true;
            // 
            // cboxCharcImg
            // 
            this.cboxCharcImg.AutoSize = true;
            this.cboxCharcImg.Location = new System.Drawing.Point(9, 22);
            this.cboxCharcImg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxCharcImg.Name = "cboxCharcImg";
            this.cboxCharcImg.Size = new System.Drawing.Size(114, 19);
            this.cboxCharcImg.TabIndex = 0;
            this.cboxCharcImg.Text = "Character Image";
            this.cboxCharcImg.UseVisualStyleBackColor = true;
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnDisplayInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisplayInfo.Location = new System.Drawing.Point(951, 419);
            this.btnDisplayInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(100, 27);
            this.btnDisplayInfo.TabIndex = 3;
            this.btnDisplayInfo.Text = "Display Info";
            this.btnDisplayInfo.UseVisualStyleBackColor = false;
            this.btnDisplayInfo.Click += new System.EventHandler(this.btnDisplayInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Location = new System.Drawing.Point(951, 452);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 27);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(951, 486);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 27);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(791, 120);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(259, 215);
            this.lblOutput.TabIndex = 4;
            // 
            // imgCharacter
            // 
            this.imgCharacter.BackColor = System.Drawing.Color.Transparent;
            this.imgCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgCharacter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCharacter.Location = new System.Drawing.Point(397, 37);
            this.imgCharacter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(337, 377);
            this.imgCharacter.TabIndex = 10;
            this.imgCharacter.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDisplayInfo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::project2VG.Properties.Resources.dark_detailed_grunge_texture_background_1401;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayInfo);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.gbDisplayOptions);
            this.Controls.Add(this.gboxCharacterType);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Character Encyclopedia";
            this.gboxCharacterType.ResumeLayout(false);
            this.gboxCharacterType.PerformLayout();
            this.gbDisplayOptions.ResumeLayout(false);
            this.gbDisplayOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCharacterType;
        private System.Windows.Forms.RadioButton btnArcher;
        private System.Windows.Forms.RadioButton btnRogue;
        private System.Windows.Forms.RadioButton btnMage;
        private System.Windows.Forms.RadioButton btnWarrior;
        private System.Windows.Forms.GroupBox gbDisplayOptions;
        private System.Windows.Forms.CheckBox cboxDiffLvl;
        private System.Windows.Forms.CheckBox cboxStartEquip;
        private System.Windows.Forms.CheckBox cboxSabilities;
        private System.Windows.Forms.CheckBox cboxBstats;
        private System.Windows.Forms.CheckBox cboxCharcImg;
        private System.Windows.Forms.Button btnDisplayInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.PictureBox imgCharacter;
    }
}

