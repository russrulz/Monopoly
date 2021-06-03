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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxBowser_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBowser.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.bowserback;
        }

        private void pictureBoxBowser_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBowser.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Bowserfront;
        }

        private void pictureBoxDonkeyKong_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDonkeyKong.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.donkeykongback;
        }

        private void pictureBoxDonkeyKong_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDonkeyKong.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.donkeykongfront;
        }

        private void pictureBoxLuigi_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLuigi.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Luigiback;
        }

        private void pictureBoxLuigi_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLuigi.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Luigifront;
        }

        private void pictureBoxMario_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.mariofront;
        }

        private void pictureBoxMario_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.marioback;
        }

        private void pictureBoxMetalMario_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMetalMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.metalmariofront;
        }

        private void pictureBoxMetalMario_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMetalMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.metalmarioback;
        }

        private void pictureBoxPeach_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPeach.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Peachback;
        }

        private void pictureBoxPeach_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPeach.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Peachfront;
        }

        private void pictureBoxRosalina_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRosalina.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.rosalinaback;
        }

        private void pictureBoxRosalina_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRosalina.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.rosilinafront;
        }

        private void pictureBoxShyGuy_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxShyGuy.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.shyguyback;
        }

        private void pictureBoxShyGuy_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxShyGuy.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Shyguyfront;
        }

        private void pictureBoxToad_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxToad.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.toadback;
        }

        private void pictureBoxToad_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxToad.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.toadfront;
        }

        private void pictureBoxYoshi_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxYoshi.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.yoshiback;
        }

        private void pictureBoxYoshi_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxYoshi.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.yoshifront;
        }
    }
}
