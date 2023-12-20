namespace MauiAppSyncfusionMemoryLeak;

public partial class Page3_SfTextInputLayout
{
	public Page3_SfTextInputLayout()
	{
		InitializeComponent();

		Console.WriteLine("=============== new Page3_SfTextInputLayout() ===============");
	}

    ~Page3_SfTextInputLayout()
    {
		Console.WriteLine("=============== ~Page3_SfTextInputLayout() ===============");
    }
}