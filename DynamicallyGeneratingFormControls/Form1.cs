using System;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicallyGeneratingFormControls
{
    

    public partial class Form1 : Form
    {
        //Cards cards = new Cards();
        private PictureBox[] pictures;
        public const string imagePath = @"Cards/";
        public const string meaningsPath = @"Meanings/";

        public Form1()
        {
            InitializeComponent();
            //added width and height controls for when you push the button.
            this.Width = 1600;
            this.Height = 900;
            //relocated the button to the bottom middle of the form.
            btnDealCards.Location = new Point(600, 800);
            //btnCardMeanings.Location = new Point(800, 800);
            pictures = new PictureBox[78];
        }

        private void Meaning(object sender, EventArgs e)
        {
            
            //textBox1.Width = 250;
            //textBox1.Height = 50;
            //textBox1.Multiline = true;
            //textBox1.BackColor = Color.Blue;
            //textBox1.ForeColor = Color.White;
            //textBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnDealCards_Click(object sender, EventArgs e)
        {
            //cards.CreateControls();
            ShuffleCards();
            //cards.Position();
        }

        //private void btnCardMeanings(object sender, EventArgs e)
        //{
        //    textBox1.Text(meaningsPath + i.ToString() + ".txt");
        //}

        private void ShuffleCards()
        {
            Random rand = new Random();
            for (var i = 0; i < 1000; i++)
            {
                int firstCard = rand.Next(0, 78);
                int secondCard = rand.Next(0, 78);
                if (firstCard != secondCard)
                {
                    var temp = pictures[firstCard];
                    pictures[firstCard] = pictures[secondCard];
                    pictures[secondCard] = temp;
                }
            }
        }

        private void DisposeControls()
        {
            foreach(var c in pictures)
                c.Dispose();
        }


    }
}
