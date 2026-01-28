using System;
using System.Windows;

namespace _3SC.Widgets.Breathe
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            var app = new Application();
            var window = new BreatheWindow();
            app.Run(window);
        }
    }
}
