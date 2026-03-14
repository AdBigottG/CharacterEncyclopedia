using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2VG
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnWarrior_CheckedChanged(object sender, EventArgs e)
        {
            if (btnWarrior.Checked)
            {
                CboxWork();
            }
        }

        private void btnMage_CheckedChanged(object sender, EventArgs e)
        {
            if (btnMage.Checked)
            {
                CboxWork();
            }
        }

        private void btnRogue_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRogue.Checked)
            {
                CboxWork();
            }
        }

        private void btnArcher_CheckedChanged(object sender, EventArgs e)
        {
            if (btnArcher.Checked)
            {
                CboxWork();
            }
        }

        private void btnDisplayInfo_Click(object sender, EventArgs e)
        {
            if (!btnWarrior.Checked && !btnMage.Checked && !btnRogue.Checked && !btnArcher.Checked)
            {
                MessageBox.Show("No character option have been selected");
                return;
            }
            if (!cboxCharcImg.Checked && !cboxBstats.Checked && !cboxSabilities.Checked
                && !cboxStartEquip.Checked && !cboxDiffLvl.Checked)
            {
                MessageBox.Show("No detail option have been selected");
                return;
            }

            string info = "";
            if (btnWarrior.Checked)
            {
                info = WarriorInfo();
                lblOutput.Text = WarriorInfo();
            }
            else if (btnMage.Checked)
            {
                info = MageInfo();
                lblOutput.Text = MageInfo();
            }
            else if (btnRogue.Checked)
            {
                info = RogueInfo();
                lblOutput.Text = RogueInfo();
            }
            else if (btnArcher.Checked)
            {
                info = ArcherInfo();
                lblOutput.Text = ArcherInfo();
            }
            else
            {
                MessageBox.Show("No box have been selected");
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblOutput.Text = string.Empty;
            ClearBtn();
            imgCharacter.Image = null;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CboxWork()
        {
            cboxCharcImg.Enabled = true;
            cboxBstats.Enabled = true;
            cboxDiffLvl.Enabled = true;
            cboxSabilities.Enabled = true;
            cboxStartEquip.Enabled = true;
        }
        private void ClearBtn()
        {
            btnWarrior.Checked = false;
            btnMage.Checked = false;
            btnRogue.Checked = false;
            btnArcher.Checked = false;
            cboxCharcImg.Checked = false;
            cboxBstats.Checked = false;
            cboxSabilities.Checked = false;
            cboxStartEquip.Checked = false;
            cboxDiffLvl.Checked = false;
        }
        private string WarriorInfo()
        {
            string result = "WARRIOR CLASS:\n\n";

            if (cboxCharcImg.Checked)
            {
                imgCharacter.Image = Properties.Resources.Fighter;
                imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cboxBstats.Checked)
            {
                result += "Stats: HP 120, Attack 80, Defense 90\n\n";
            }
            if (cboxSabilities.Checked)
            {
                result += "Ability: Power Strike\n\n";
            }
            if (cboxStartEquip.Checked)
            {
                result += "Equipment: Sword, Shield\n\n";
            }
            if (cboxDiffLvl.Checked)
            {
                result += "Difficulty: Easy\n\n";
            }
            return result;
        }
        private string MageInfo()
        {
            string result = "MAGE CLASS:\n\n";

            if (cboxCharcImg.Checked)
            {
                imgCharacter.Image = Properties.Resources.Mage;
                imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cboxBstats.Checked)
            {
                result += "Stats: HP 70, Attack 95, Defense 40\n\n";
            }
            if (cboxSabilities.Checked)
            {
                result += "Ability: Fireball\n\n";
            }
            if (cboxStartEquip.Checked)
            {
                result += "Equipment: Staff, Spellbook\n\n";
            }
            if (cboxDiffLvl.Checked)
            {
                result += "Difficulty: Hard\n\n";
            }
            return result;
        }
        private string RogueInfo()
        {
            string result = "ROGUE CLASS:\n\n";

            if (cboxCharcImg.Checked)
            {
                imgCharacter.Image = Properties.Resources.Rogue;
                imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cboxBstats.Checked)
            {
                result += "Stats: HP 90, Attack 85, Defense 60\n\n";
            }
            if (cboxSabilities.Checked)
            {
                result += "Ability: Stealth Attack\n\n";
            }
            if (cboxStartEquip.Checked)
            {
                result += "Equipment: Daggers, Cloak\n\n";
            }
            if (cboxDiffLvl.Checked)
            {
                result += "Difficulty: Medium\n\n";
            }
            return result;
        }
        private string ArcherInfo()
        {
            string result = "ARCHER CLASS:\n\n";

            if (cboxCharcImg.Checked)
            {
                imgCharacter.Image = Properties.Resources.Archer;
                imgCharacter.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (cboxBstats.Checked)
            {
                result += "Stats: HP 85, Attack 88, Defense 55\n\n";
            }
            if (cboxSabilities.Checked)
            {
                result += "Ability: Precision Shot\n\n";
            }
            if (cboxStartEquip.Checked)
            {
                result += "Equipment: Bow, Quiver\n\n";
            }
            if (cboxDiffLvl.Checked)
            {
                result += "Difficulty: Medium\n\n";
            }
            return result;
        }


    }
}
