using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicTacToe_WinApp
{
    public partial class NameScreen : Form
    {
        
        public NameScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            Game.player2 = new Players() { NamePlayer = Name };
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string Name = textBox2.Text;
            Game.player1 = new Players() { NamePlayer = Name };
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please insert a name");
            }
            else
            {
                this.Close();
            }
        }

        private void NameScreen_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
