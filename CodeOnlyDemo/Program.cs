using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace CodeOnlyDemo
{
    public class Program : Application
    {
        [STAThread]
        static void Main()
        {
            Program app = new Program();
            app.MainWindow =  new  CodeOnly();
            app.MainWindow.ShowDialog();
        }
    }
}
