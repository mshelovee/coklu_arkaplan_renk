using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arkaplanrenk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBlue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbYellow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYellow.Checked == true)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbDarkBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDarkBlue.Checked == true)
            {
                this.BackColor = Color.DarkBlue;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRed.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }

        private void cbPurple_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPurple.Checked == true)
            {
                this.BackColor = Color.Purple;
            }
            else
            {
                this.BackColor = Color.White;
            }
        }
    }
}
