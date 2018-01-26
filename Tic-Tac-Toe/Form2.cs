using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Options : Form
    {
        public Form1 form1;

        public Options(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            InitializeComponentState();
        }

        public void InitializeComponentState()
        {
            this.numericUpDown1.Value = this.form1.boardSize;
            this.singlePlayerCheckBox.Checked = this.form1.onePlayer;
            if (this.form1.chooseRandomStart) //random start
                this.randomRadioButton.Checked = true;
            else
            {
                this.ComputerStartsCheckBox.Checked = this.form1.computerStarts;
                if (this.form1.xstarts) //true - x goes first
                    this.XradioButton.Checked = true;
                else
                    this.OradioButton.Checked = true;
            }
            this.player1color.BackColor = this.form1.player1Color;
            this.player2color.BackColor = this.form1.player2Color;
        }

        public void UpdateGameOptions(object sender, EventArgs e)
        {
            this.form1.boardSize = (int)this.numericUpDown1.Value;
            this.form1.onePlayer = this.singlePlayerCheckBox.Checked;
            this.form1.chooseRandomStart = this.randomRadioButton.Checked;
            this.form1.computerStarts = this.ComputerStartsCheckBox.Checked;
            //NOTE: boardSize bigger than 3 is ONLY for multiplayer
            if (this.form1.boardSize > 3)
            {
                this.form1.onePlayer = false;
                this.form1.computerStarts = false; //computer doest play in multiplayer
            }
            // if the computerStarts option is checked, change the onePlayer option to true even if it isn't checked
            if (this.form1.computerStarts)
                this.form1.onePlayer = true;
            this.form1.xstarts = this.XradioButton.Checked;
            this.form1.player1Color = this.player1color.BackColor;
            this.form1.player2Color = this.player2color.BackColor;
            this.Close();
        }

        private void player_color_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.colorDialog1.ShowDialog();
            btn.BackColor = this.colorDialog1.Color;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            //reset to default settings
            this.form1.boardSize = 3;
            this.form1.xstarts = true;
            this.form1.onePlayer = true;
            this.form1.computerStarts = false;
            this.form1.player1Color = System.Drawing.Color.Red;
            this.form1.player2Color = System.Drawing.Color.Blue;
            InitializeComponentState();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.form1.cancel = true;
            this.Close();
        }
    }
}
