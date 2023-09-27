using System.Threading;
using System;
using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.Models;

namespace TestVirtualization.MauiApp.Views
{
    public partial class View2 : ContentView
    {
        public View2()
        {
            InitializeComponent();

            Counters.Instance.View2Count++;
            Console.WriteLine("------------ View2 # " + Counters.Instance.View2Count);
            Thread.Sleep(100);
        }
    }
}