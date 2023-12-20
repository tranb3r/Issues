namespace MauiAppSyncfusionMemoryLeak;

public partial class Page1_Default
{
	public Page1_Default()
	{
		InitializeComponent();

		Console.WriteLine("=============== new Page1_Default() ===============");
	}

    ~Page1_Default()
    {
		Console.WriteLine("=============== ~Page1_Default() ===============");
    }
}