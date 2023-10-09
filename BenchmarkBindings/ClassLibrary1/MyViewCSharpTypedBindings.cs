using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;

namespace ClassLibrary1
{
    public class MyViewCSharpTypedBindings : ContentView
    {
        public MyViewCSharpTypedBindings()
        {
            Content = new Label().Bind(Label.TextProperty, static (MyViewModel vm) => vm.Title, mode: BindingMode.OneWay);
        }
    }
}
