using System;

namespace DynamicallyGeneratingFormControls
{

    public class Cards
    {
        private const string imagePath = @"Cards/";
        private const string meaningsPath = @"Meanings/";
        private string meaning;

        private void CreateControls()
        {
            if (pictures[0] != null)
                DisposeControls();

            for (var i = 0; i < 78; i++)
            {
                var newPictureBox = new PictureBox();
                newPictureBox.Width = 106;
                newPictureBox.Height = 169;
                //newPictureBox.BorderStyle = BorderStyle.Fixed3D;
                pictures[i] = SizeImage(newPictureBox, i + 1);
            }
        }

        private PictureBox SizeImage(PictureBox pb, int i)
        {
            Image img = Image.FromFile(imagePath + i.ToString() + ".jpg");
            pb.Image = img;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;

            return pb;
        }

        private void Position()
        {
            for (var i = 12; i >= 0; i--)
            {
                pictures[0].Location = new Point(424, 300);
                pictures[1].Location = new Point(594, 300);
                pictures[2].Location = new Point(256, 300);
                pictures[3].Location = new Point(424, 88);
                pictures[4].Location = new Point(424, 504);
                pictures[5].Location = new Point(84, 300);
                pictures[6].Location = new Point(766, 300);
                pictures[7].Location = new Point(1020, 654);
                pictures[8].Location = new Point(1020, 460);
                pictures[9].Location = new Point(1020, 250);
                pictures[10].Location = new Point(1020, 44);
                pictures[11].Location = new Point(1200, 44);
                pictures[12].Location = new Point(1378, 44);
                this.Controls.Add(pictures[i]);
            }
        }

        //private void Meaning(object sender, EventArgs e)
        //{
            
            //textBox1.Width = 250;
            //textBox1.Height = 50;
            //textBox1.Multiline = true;
            //textBox1.BackColor = Color.Blue;
            //textBox1.ForeColor = Color.White;
            //textBox1.BorderStyle = BorderStyle.Fixed3D;
        //}
        
    }
}