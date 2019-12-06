using System;
using System.Windows;
using System.Windows.Controls;

namespace CodeMap
{
    public class MyWindow : Window
    {

        public MyWindow()
        {
            Width = 300;
            Height = 300;

        }

        [STAThread]
        public static void Main()
        {
            Application app = new Application();

            app.Run(new MyWindow());
        }
    }
}