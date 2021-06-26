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
    public partial class PlayerInput : Form
    {
        public PlayerInput()
        {
            InitializeComponent();
            buttons.Add(Btn0);
            buttons.Add(Btn1);
            buttons.Add(Btn2);
            buttons.Add(Btn3);
            buttons.Add(Btn4);
            buttons.Add(Btn5);
            buttons.Add(Btnback1);
            buttons.Add(Btnback2);
            buttons.Add(Btnback3);
            buttons.Add(Btnback4);
            buttons.Add(Btnback5);
            ret = 0;
        }
        public int ret { get; set; }
        public readonly List<Button> buttons = new List<Button>();
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void PlayerInput_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Button btn in buttons) {
                btn.Enabled = false;
            }
        }

        private void Btnback5_Click(object sender, EventArgs e)
        {
            ret = -5;
            this.Close();
        }

        private void Btnback4_Click(object sender, EventArgs e)
        {
            ret = -4; this.Close();
        }

        private void Btnback2_Click(object sender, EventArgs e)
        {
            ret = -2;
            this.Close();
        }

        private void Btnback1_Click(object sender, EventArgs e)
        {
            ret = -1;
            this.Close();
        }

        private void Btnback3_Click(object sender, EventArgs e)
        {
            ret = -3;
            this.Close();
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            ret = 0;
            this.Close();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            ret = 1;
            this.Close();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            ret = 3;
            this.Close();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            ret = 2;
            this.Close();
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            ret = 4;
            this.Close();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            ret = 5;
            this.Close();
        }
    }
}
