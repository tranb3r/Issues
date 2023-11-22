using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;

// Token: 0x02000006 RID: 6
[XamlFilePath("App.xaml")]
internal class _ : Application
{
	// Token: 0x06000006 RID: 6 RVA: 0x00002089 File Offset: 0x00000289
	[NullableContext(1)]
	public _(m_ _)
	{
		this._();
		base.MainPage = new m(_);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x000020A4 File Offset: 0x000002A4
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void _()
	{
		NameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
	}
}
