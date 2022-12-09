using System.Threading;
using System;
using TestVirtualization.Models;
using Xamarin.Forms;

namespace TestVirtualization.Views
{
    public partial class View1 : ContentView
    {
        public View1()
        {
            InitializeComponent();

            Counters.Instance.View1Count++;
            Console.WriteLine("------------ View1 # " + Counters.Instance.View1Count);
            Thread.Sleep(100);
        }
    }
}