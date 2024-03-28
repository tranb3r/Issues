using System;

namespace MauiAppCollectionViewReorder
{
    public partial class ItemView2
    {
        private static int _count;

        public ItemView2()
        {
            InitializeComponent();

            ++_count;
            Console.WriteLine($"==== new ItemView2 == {_count} ====");
        }

        ~ItemView2()
        {
            --_count;
            Console.WriteLine($"==== ~ItemView2 == {_count} ====");
        }
    }
}