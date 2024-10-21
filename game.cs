namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        char key_pressed;
        bool hasRocket = true;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            key_pressed = e.KeyChar;
            if (key_pressed == 'd') pictureBox1.Left += 10;
            if (key_pressed == 'a') pictureBox1.Left -= 10;
            if (key_pressed == 'w') pictureBox1.Top -= 10;
            if (key_pressed == 'x') pictureBox1.Top += 10;
            if (key_pressed == 32)
            {
                if (hasRocket)
                {
                    pictureBox2.Left = pictureBox1.Left + 20;
                    pictureBox2.Top = pictureBox1.Top - 30;
                    pictureBox2.Visible = true;
                    timer1.Enabled = true;
                    hasRocket = false;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Top -= 10;

            if (pictureBox2.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                timer1.Enabled = false;
                pictureBox2.Visible = false;
                hasRocket = true;

                timer2.Enabled = false;
                pictureBox3.Visible = false;
                
                pictureBox4.Left = pictureBox3.Left;
                pictureBox4.Top = pictureBox3.Top;
                pictureBox4.Visible = true;

                timer3.Enabled = true;
            }

            if (pictureBox2.Top < 10)
            {
                timer1.Enabled = false;
                pictureBox2.Visible = false;
                hasRocket = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Top += 10;

            if ((pictureBox3.Top + 120 > pictureBox1.Top) && (pictureBox3.Left > pictureBox1.Left)
                && (pictureBox3.Left < pictureBox1.Left + 100))
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;

                pictureBox4.Left = pictureBox1.Left;
                pictureBox4.Top = pictureBox1.Top;
                pictureBox4.Visible = true;
            }

            if (pictureBox3.Top > this.ClientSize.Height)
            {
                pictureBox3.Left = random.Next(0, this.ClientSize.Width - pictureBox3.Width);
                pictureBox3.Top = -pictureBox3.Height;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;

            pictureBox4.Visible = false;

            timer2.Enabled = true;
            pictureBox3.Left = random.Next(0, this.ClientSize.Width - pictureBox3.Width);
            pictureBox3.Top = -pictureBox3.Height;
            pictureBox3.Visible = true;
        }
    }
}
