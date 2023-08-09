using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System.Windows.Input;
namespace WinFormsApp1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        
        bool numLockIsToggled = Keyboard.IsKeyToggled(Keys.NumLock);
        var numLockIsOn = Control.IsKeyLocked(Keys.NumLock);
        var capsLockIsOn = Control.IsKeyLocked(Keys.CapsLock);
        var scrollLockOn = IsKeyLocked(Keys.Scroll);
        Console.WriteLine($"numLockIsOn: {numLockIsOn}");
        Console.WriteLine($"capsLockIsOn: {capsLockIsOn}");
        Console.WriteLine($"scrollLockOn: {scrollLockOn}");
    }
}