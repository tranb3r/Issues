namespace MauiAppBorderMargin
{
    public class CustomFrame : Frame
    {
        public static readonly BindableProperty CornerRadiiProperty = BindableProperty.Create(nameof(CustomFrame), typeof(CornerRadius), typeof(CustomFrame));
        
        public CornerRadius CornerRadii
        {
            get => (CornerRadius)GetValue(CornerRadiiProperty);
            set => SetValue(CornerRadiiProperty, value);
        }
    }
}
