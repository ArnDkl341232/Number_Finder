using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Number_Finder
{
    public partial class Form1 : Form
    {
        private int myrndNumb = 0;
        int amount_of_tries = 0;
        public Form1()
        {
            InitializeComponent();
        }

        //generation our random number with button
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rng = new Random();
            myrndNumb = rng.Next(1, 1000000);

            lblRnd.Text = myrndNumb.ToString();
            amount_of_tries = 0;

            btnCheck.Visible = true;
            txtField.Clear();
            //txtField.Clear();

            //if (txtField.Text.Length > 0);
            //Application.Restart();

        }


        //cheking the height of number depending of our entered + filter of value
        public void btnCheck_Click(object sender, EventArgs e)
        {
            check();

        }



        private void check()
        {

            if (string.IsNullOrEmpty(txtField.Text))
            {
                lblStatus.Text = "Write some thing before pressing button";
            }

            int entered_Numb = 0;
            amount_of_tries = amount_of_tries + 1;
            nmb_of_tries.Text = amount_of_tries.ToString();

            if (int.TryParse(txtField.Text, out entered_Numb))
            {
                if (myrndNumb > entered_Numb)
                    lblStatus.Text = "inferieur";
                else if (myrndNumb < entered_Numb)
                    lblStatus.Text = "superieur";
                else if (myrndNumb == entered_Numb)
                {
                    lblStatus.Text = "trouver";
                    btnCheck.Visible = false;
                }
            }
            else if (string.IsNullOrEmpty(txtField.Text))
            {
                lblStatus.Text = "Write some thing before pressing button";
            }
            else
            {
                lblStatus.Text = "Wrong Forrmat";
                Refresh();
            }
        }

        private void txtField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                check();
            }
        }
    }
}


