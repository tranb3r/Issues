using CommunityToolkit.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

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
