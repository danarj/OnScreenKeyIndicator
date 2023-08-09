using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // bool numLockIsToggled = Controls.IsKeyToggled(Keys.NumLock);
            var numLockIsOn = IsKeyLocked(Keys.NumLock);
            var capsLockIsOn = IsKeyLocked(Keys.CapsLock);
            var scrollLockOn = IsKeyLocked(Keys.Scroll);
            MessageBox.Show($"numLockIsOn: {numLockIsOn}\n" +
                            $"capsLockIsOn: {capsLockIsOn}\n" +
                            $"scrollLockOn: {scrollLockOn}");
            Console.WriteLine($"numLockIsOn: {numLockIsOn}");
            Console.WriteLine($"capsLockIsOn: {capsLockIsOn}");
            Console.WriteLine($"scrollLockOn: {scrollLockOn}");
        }
    }

}