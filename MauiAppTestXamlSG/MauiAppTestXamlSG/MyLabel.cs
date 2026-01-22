using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using SQuan.Helpers.Maui.Mvvm;

namespace MauiAppTestXamlSG
{
    public partial class MyLabel : Label
    {
        [BindableProperty]
        public partial string MyProperty { get; set; }

        [BindableProperty]
        public partial Color MyColor { get; set; }
    }
}
