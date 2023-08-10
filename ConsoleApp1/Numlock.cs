using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OnScreenKeyDisplay
{
    public partial class Numlock : Form
    {
        private const int DisplayDuration = 5;
        private int tick = 1;

        public Numlock()
        {
            InitializeComponent();
            var numLockIsOn = IsKeyLocked(Keys.NumLock);
            notifyIcon1.Icon = numLockIsOn ? Properties.Resources.NumlockOnIcon : Properties.Resources.NumlockOffIcon;
        }

        public void ChangeNumLockStatus(bool status)
        {
            try
            {
                tick = 1;
                numLockPictureBox.Image = status ? Properties.Resources.NumlockOn : Properties.Resources.NumlockOff;
                // numLockPictureBox.Image =
                //     Image.FromFile(status ? NumLockOnImage : NumLockOffImage);
                // notifyIcon1.Icon = new Icon(status ? NotifyNumLockOnImage : NotifyNumLockOffImage);
                notifyIcon1.Icon = status ? Properties.Resources.NumlockOnIcon : Properties.Resources.NumlockOffIcon;
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

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}