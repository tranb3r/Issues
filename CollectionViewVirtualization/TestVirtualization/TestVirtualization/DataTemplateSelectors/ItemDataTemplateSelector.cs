using System;
using TestVirtualization.Models;
using Xamarin.Forms;

namespace TestVirtualization.DataTemplateSelectors
{
    public class ItemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate View1Template { get; set; }
        public DataTemplate View2Template { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return item switch
            {
                Item1Model => View1Template,
                Item2Model => View2Template,
                _ => throw new ArgumentOutOfRangeException(nameof(item), item, null)
            };
        }
    }
}
