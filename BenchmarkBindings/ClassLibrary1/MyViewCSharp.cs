using Microsoft.Maui.Controls;

namespace ClassLibrary1
{
    public class MyViewCSharp : ContentView
    {
        public MyViewCSharp()
        {
            var label = new Label();
            label.SetBinding(Label.TextProperty, "Title", BindingMode.OneWay);
            Content = label;
        }
    }
}
