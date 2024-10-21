namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        int juke1, juke2, juke3;
        int timerJuke1, timerJuke2, timerJuke3;
        int ip;
        int l1, l2, l3;
        int jukeDirection1, jukeDirection2, jukeDirection3;

        Random rnd1 = new Random();
        Random rnd2 = new Random();
        Random rnd3 = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            juke1++;

            if (juke1 > 4) juke1 = 1;
            if (juke1 == 1) pictureBox1.Image = Properties.Resources._1ж;
            if (juke1 == 2) pictureBox1.Image = Properties.Resources._1ж2;
            if (juke1 == 3) pictureBox1.Image = Properties.Resources._1ж;
            if (juke1 == 4) pictureBox1.Image = Properties.Resources._1ж2;

            if (jukeDirection1 == 0) pictureBox1.Left += 10;
            if (jukeDirection1 == 1) pictureBox1.Left -= 10;
            
            if (pictureBox1.Left < 0) pictureBox1.Left = 0;

            if ((pictureBox1.Left > Width - 100) && (l1 == 3))
            {
                timer1.Enabled = false;
                if (ip == 0)
                {
                    ip = 1;
                    label1.Text = "Победил красный";
                }
            }

            if ((pictureBox1.Left > Width + 100) && (l1 < 3))
            {
                pictureBox1.Left = 0;
                l1++;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            juke2++;

            if (juke2 > 4) juke2 = 1;
            if (juke2 == 1) pictureBox2.Image = Properties.Resources._2ж;
            if (juke2 == 2) pictureBox2.Image = Properties.Resources._2ж2;
            if (juke2 == 3) pictureBox2.Image = Properties.Resources._2ж;
            if (juke2 == 4) pictureBox2.Image = Properties.Resources._2ж2;

            if (jukeDirection2 == 0) pictureBox2.Left += 10;
            if (jukeDirection2 == 1) pictureBox2.Left -= 10;

            if (pictureBox2.Left < 0) pictureBox2.Left = 0;

            if ((pictureBox2.Left > Width - 100) && (l2 == 3))
            {
                timer2.Enabled = false;
                if (ip == 0)
                {
                    ip = 2;
                    label1.Text = "Победил синий";
                }
            }

            if ((pictureBox2.Left > Width + 100) && (l2 < 3))
            {
                pictureBox2.Left = 0;
                l2++;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            juke3++;

            if (juke3 > 4) juke3 = 1;
            if (juke3 == 1) pictureBox3.Image = Properties.Resources._3ж;
            if (juke3 == 2) pictureBox3.Image = Properties.Resources._3ж2;
            if (juke3 == 3) pictureBox3.Image = Properties.Resources._3ж;
            if (juke3 == 4) pictureBox3.Image = Properties.Resources._3ж2;

            if (jukeDirection3 == 0) pictureBox3.Left += 10;
            if (jukeDirection3 == 1) pictureBox3.Left -= 10;

            if (pictureBox3.Left < 0) pictureBox3.Left = 0;

            if ((pictureBox3.Left > Width - 100) && (l3 == 3))
            {
                timer3.Enabled = false;
                if (ip == 0)
                {
                    ip = 3;
                    label1.Text = "Победил розовый";
                }
            }

            if ((pictureBox3.Left > Width + 100) && (l3 < 3))
            {
                pictureBox3.Left = 0;
                l3++;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timerJuke1 = rnd1.Next(10, 100);
            timer1.Interval = timerJuke1;

            timerJuke2 = rnd2.Next(10, 100);
            timer2.Interval = timerJuke2;
            

            timerJuke3 = rnd3.Next(10, 100);
            timer3.Interval = timerJuke3;

            if (timerJuke1 < 10)
            {
                jukeDirection1++;
                if (jukeDirection1 > 1) jukeDirection1 = 0;
            }
            
            if (timerJuke2 < 10)
            {
                jukeDirection2++;
                if (jukeDirection2 > 1) jukeDirection2 = 0;
            }

            if (timerJuke3 < 10)
            {
                jukeDirection3++;
                if (jukeDirection3 > 1) jukeDirection3 = 0;
            }
        }
    }
}
