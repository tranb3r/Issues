using System.Threading;
using System;
using Microsoft.Maui.Controls;
using TestVirtualization.MauiApp.Models;

namespace TestVirtualization.MauiApp.Views
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