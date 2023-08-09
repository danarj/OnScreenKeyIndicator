using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OnScreenKeyDisplay
{
    public partial class Numlock : Form
    {
        // private string numLockOnImage =
        private const string NumLockOnImage = "C:/onscreenkeydisplay/images/numlock.png";
        private const string NumLockOffImage = "C:/onscreenkeydisplay/images/numlockoff.png";
        private const int DisplayDuration = 5;
        private int tick = 1;

        public Numlock()
        {
            InitializeComponent();
        }

        public void ChangeNumLockStatus(bool status)
        {
            try
            {
                tick = 1;
                numLockPictureBox.Image =
                    Image.FromFile(status ? NumLockOnImage : NumLockOffImage);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                File.AppendAllText("d:/log.txt", exception.ToString());
            }
        }

        private void Numlock_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tick <= DisplayDuration)
            {
                tick++;
            }
            else
            {
                Hide();
            }
        }

        private void numLockPictureBox_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Numlock_MouseClick(object sender, MouseEventArgs e)
        {
            Hide();
        }
    }
}