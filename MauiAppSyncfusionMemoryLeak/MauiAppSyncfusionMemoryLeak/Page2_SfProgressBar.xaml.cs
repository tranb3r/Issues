namespace MauiAppSyncfusionMemoryLeak;

public partial class Page2_SfProgressBar
{
	public Page2_SfProgressBar()
	{
		InitializeComponent();

		Console.WriteLine("=============== new Page2_SfProgressBar() ===============");
	}

    ~Page2_SfProgressBar()
    {
		Console.WriteLine("=============== ~Page2_SfProgressBar() ===============");
    }
}