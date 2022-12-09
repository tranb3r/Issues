using System.Threading;
using System;
using TestVirtualization.Models;
using Xamarin.Forms;

namespace TestVirtualization.Views
{
    public partial class View2 : ContentView
    {
        public static int Count;

        public View2()
        {
            InitializeComponent();

            Counters.Instance.View2Count++;
            Console.WriteLine("------------ View2 # " + Counters.Instance.View2Count);
            Thread.Sleep(100);
        }
    }
}