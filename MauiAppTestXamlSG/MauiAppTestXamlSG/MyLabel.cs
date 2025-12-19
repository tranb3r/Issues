using Microsoft.Maui.Controls;
using SQuan.Helpers.Maui.Mvvm;

namespace MauiAppTestXamlSG
{
    public partial class MyLabel : Label
    {
        [BindableProperty]
        public partial string MyProperty { get; set; }
    }
}
