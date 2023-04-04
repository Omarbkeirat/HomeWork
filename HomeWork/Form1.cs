using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnnumberofcontrolsButton_Click(object sender, EventArgs e)
        {

            int numberOfControls = int.Parse(txtnumberofcontrols.Text);
            for (int i = 0; i < numberOfControls; i++)
            {
                Button newButton = new Button();
                newButton.Name = "DButton" + (i + 1);
                newButton.Text = "DButton" + (i + 1);
                newButton.Size = new Size(120, 40);
                newButton.Location = new Point(0, (i * 50));

                pnldy.Controls.Add(newButton);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtnumberofcontrols.Text);
            for (int i = 0; i < numberOfControls; i++)
            {
                Button newButton = new Button();
                newButton.Name = "Label" + (i + 1);
                newButton.Text = "Label" + (i + 1);
                newButton.Size = new Size(120, 40);
                newButton.Location = new Point(0, (i * 50));

                pnldy.Controls.Add(newButton);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numberOfControls = int.Parse(txtnumberofcontrols.Text);
            for (int i = 0; i < numberOfControls; i++)
            {
                Button newButton = new Button();
                newButton.Name = "TextBox" + (i + 1);
                newButton.Text = "TextBox" + (i + 1);
                newButton.Size = new Size(120, 40);
                newButton.Location = new Point(0, (i * 50));

                pnldy.Controls.Add(newButton);
            }
        }
    }
}
