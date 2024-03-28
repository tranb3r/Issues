using System;

namespace MauiAppCollectionViewReorder
{
    public partial class ItemView1
    {
        private static int _count;

        public ItemView1()
        {
            InitializeComponent();

            ++_count;
            Console.WriteLine($"==== new ItemView1 == {_count} ====");
        }

        ~ItemView1()
        {
            --_count;
            Console.WriteLine($"==== ~ItemView1 == {_count} ====");
        }
    }
}