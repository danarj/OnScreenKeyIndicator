using System;
using System.Windows.Forms;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new();
            controller.SetupKeyboardHooks();
            Console.ReadKey();
        }
    }


    //Based on https://gist.github.com/Stasonix
}