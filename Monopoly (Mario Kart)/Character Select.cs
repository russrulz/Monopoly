using System;
using System.Windows.Forms;

namespace Monopoly__Mario_Kart_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Selectedret { get; set; }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void PictureBoxBowser_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxBowser.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.bowserback;
        }

        private void PictureBoxBowser_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBowser.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Bowserfront;
        }

        private void PictureBoxDonkeyKong_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxDonkeyKong.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.donkeykongback;
        }

        private void PictureBoxDonkeyKong_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxDonkeyKong.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.donkeykongfront;
        }

        private void PictureBoxLuigi_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLuigi.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Luigiback;
        }

        private void PictureBoxLuigi_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLuigi.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Luigifront;
        }

        private void PictureBoxMario_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.mariofront;
        }

        private void PictureBoxMario_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.marioback;
        }

        private void PictureBoxMetalMario_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxMetalMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.metalmariofront;
        }

        private void PictureBoxMetalMario_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxMetalMario.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.metalmarioback;
        }

        private void PictureBoxPeach_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxPeach.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Peachback;
        }

        private void PictureBoxPeach_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxPeach.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Peachfront;
        }

        private void PictureBoxRosalina_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRosalina.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.rosalinaback;
        }

        private void PictureBoxRosalina_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRosalina.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.rosilinafront;
        }

        private void PictureBoxShyGuy_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxShyGuy.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.shyguyback;
        }

        private void PictureBoxShyGuy_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxShyGuy.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.Shyguyfront;
        }

        private void PictureBoxToad_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxToad.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.toadback;
        }

        private void PictureBoxToad_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxToad.BackgroundImage = Monopoly__Mario_Kart_.Properties.Resources.toadfront;
        }

        private void PictureBoxYoshi_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxYoshi.BackgroundImage = Properties.Resources.yoshiback;
        }

        private void PictureBoxYoshi_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxYoshi.BackgroundImage = Properties.Resources.yoshifront;
        }

        private void PictureBoxBowser_Click(object sender, EventArgs e)
        {
            //return bowser
            Selectedret = "Bowser";
            pictureBoxBowser.Enabled = false;
            this.Close();
        }

        private void PictureBoxDonkeyKong_Click(object sender, EventArgs e)
        {
            //return Donkey Kong
            Selectedret = "Donkey Kong";
            pictureBoxDonkeyKong.Enabled = false;
            this.Close();
        }

        private void PictureBoxLuigi_Click(object sender, EventArgs e)
        {
            Selectedret = "Luigi";
            pictureBoxLuigi.Enabled = false;
            this.Close();

        }

        private void PictureBoxMario_Click(object sender, EventArgs e)
        {
            Selectedret = "Mario";
            pictureBoxMario.Enabled = false;
            this.Close();
        }

        private void PictureBoxMetalMario_Click(object sender, EventArgs e)
        {
            Selectedret = "Metal Mario";
            pictureBoxMetalMario.Enabled = false;
            this.Close();
        }

        private void PictureBoxPeach_Click(object sender, EventArgs e)
        {
            Selectedret = "Princess Peach";
            pictureBoxPeach.Enabled = false;
            this.Close();
        }

        private void PictureBoxRosalina_Click(object sender, EventArgs e)
        {
            Selectedret = "Rosalina";
            pictureBoxRosalina.Enabled = false;
            this.Close();
        }

        private void PictureBoxShyGuy_Click(object sender, EventArgs e)
        {
            Selectedret = "Shy Guy";
            pictureBoxShyGuy.Enabled = false;
            this.Close();
        }

        private void PictureBoxToad_Click(object sender, EventArgs e)
        {
            Selectedret = "Toad";
            pictureBoxToad.Enabled = false;
            this.Close();
        }

        private void PictureBoxYoshi_Click(object sender, EventArgs e)
        {
            Selectedret = "Yoshi";
            pictureBoxYoshi.Enabled = false;
            this.Close();
        }
    }
}
