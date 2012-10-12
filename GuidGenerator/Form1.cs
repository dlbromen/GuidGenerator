using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuidGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GenerateGuids(1);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtDisplayGuids.Text = string.Empty;
            int guids = 1;

            if (!string.IsNullOrEmpty(txtNumGuids.Text.Trim()))
            {
                try
                {
                    guids = Convert.ToInt32(txtNumGuids.Text.Trim());
                }
                catch
                {
                    txtDisplayGuids.Text = "Enter a NUMBER, not a letter, stupid. :)";
                }
            }

            GenerateGuids(guids);
        }

        private void GenerateGuids(int guids)
        {
            if (guids > 50 && guids < 1000)
            {
                txtDisplayGuids.Text += "Are you sure??  Well, here goes.." + Environment.NewLine;
            }
            else if (guids >= 1000)
            {
                txtDisplayGuids.Text += "Oh, hellz no!" + Environment.NewLine;
            }
            else if (guids > 0)
            {
                if (guids == 1)
                {
                    Guid g = Guid.NewGuid();
                    Clipboard.SetText(g.ToString().ToUpper());
                    txtDisplayGuids.Text = g.ToString().ToUpper() + Environment.NewLine;
                    txtDisplayGuids.Text += "(Automatically copied to clipboard)";
                }
                else
                {
                    for (int i = 0; i < guids; i++)
                    {
                        txtDisplayGuids.Text += Guid.NewGuid().ToString().ToUpper() + Environment.NewLine;
                    }
                }
            }
        }
    }
}
