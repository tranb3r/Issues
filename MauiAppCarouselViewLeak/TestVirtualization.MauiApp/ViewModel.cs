using System.Collections.Generic;

namespace TestVirtualization.MauiApp
{
    internal class ViewModel
    {
        public List<Model> Items { get; set; }

        public ViewModel()
        {
            Items = new List<Model>
            {
                new Model { Name = "Item1" },
                new Model { Name = "Item2" },
                new Model { Name = "Item3" },
                new Model { Name = "Item4" }
            };
        }
    }
}
