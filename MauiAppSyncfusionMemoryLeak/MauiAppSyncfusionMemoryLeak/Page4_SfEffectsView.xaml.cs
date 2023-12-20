namespace MauiAppSyncfusionMemoryLeak;

public partial class Page4_SfEffectsView
{
	public Page4_SfEffectsView()
	{
		InitializeComponent();

		Console.WriteLine("=============== new Page4_SfEffectsView() ===============");
	}

    ~Page4_SfEffectsView()
    {
		Console.WriteLine("=============== ~Page4_SfEffectsView() ===============");
    }
}