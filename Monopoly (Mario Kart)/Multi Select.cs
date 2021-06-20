using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Monopoly__Mario_Kart_
{
    public partial class Form3 : Form
    {
        public List<Button> buttons = new List<Button>();
        public int retval { set; get; }
        public Form3()
        {
            InitializeComponent();
            buttons.Add(button0);
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            foreach (Button b in buttons) {
                b.Click += B_Click;
                b.Text = "";
                b.Enabled = false;
            }
            this.Text = "";
        }

        private void B_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buttons.Count; i++) { 
                if(buttons[i] == (Button)sender)
                {
                    retval = i;
                    this.Close();
                }
            }

            this.Close();//close form if the value isn't set
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            retval = -1;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Button b in buttons) {
                b.Text = "";
                b.Enabled = false;
            }
            this.Text = "";
        }
    }
}
