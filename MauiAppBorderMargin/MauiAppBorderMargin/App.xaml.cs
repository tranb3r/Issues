#if ANDROID
using Android.Graphics.Drawables;
#endif
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Platform;

namespace MauiAppBorderMargin;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();

#if ANDROID
        FrameRenderer.Mapper.AppendToMapping(CustomFrame.CornerRadiiProperty.PropertyName, (frameRenderer, frame) =>
        {
            if (frame is CustomFrame customFrame)
            {
                if (frameRenderer.Background is GradientDrawable backgroundGradient)
                {
                    var topLeftCorner = frameRenderer.Context.ToPixels(customFrame.CornerRadii.TopLeft);
                    var topRightCorner = frameRenderer.Context.ToPixels(customFrame.CornerRadii.TopRight);
                    var bottomLeftCorner = frameRenderer.Context.ToPixels(customFrame.CornerRadii.BottomLeft);
                    var bottomRightCorner = frameRenderer.Context.ToPixels(customFrame.CornerRadii.BottomRight);

                    var cornerRadii = new[]
                    {
                        topLeftCorner,
                        topLeftCorner,

                        topRightCorner,
                        topRightCorner,

                        bottomRightCorner,
                        bottomRightCorner,

                        bottomLeftCorner,
                        bottomLeftCorner,
                    };

                    backgroundGradient.SetCornerRadii(cornerRadii);
                }
            }
        });
#endif
    }
}
