using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

// Token: 0x0200000B RID: 11
internal class mm : ObservableObject, m_
{
	// Token: 0x06000012 RID: 18 RVA: 0x0000236C File Offset: 0x0000056C
	[RelayCommand]
	private void _()
	{
		int count = this.Count;
		this.Count = count + 1;
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000013 RID: 19 RVA: 0x00002389 File Offset: 0x00000589
	// (set) Token: 0x06000014 RID: 20 RVA: 0x00002391 File Offset: 0x00000591
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.ObservablePropertyGenerator", "8.2.0.0")]
	[ExcludeFromCodeCoverage]
	public int Count
	{
		get
		{
			return this._;
		}
		set
		{
			if (!EqualityComparer<int>.Default.Equals(this._, value))
			{
				this.OnPropertyChanging(__._);
				this._ = value;
				this.OnPropertyChanged(_m._);
			}
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000015 RID: 21 RVA: 0x000023C4 File Offset: 0x000005C4
	[Nullable(1)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.2.0.0")]
	[ExcludeFromCodeCoverage]
	public IRelayCommand ClickCommand
	{
		[NullableContext(1)]
		get
		{
			RelayCommand relayCommand;
			if ((relayCommand = this.m) == null)
			{
				relayCommand = (this.m = new RelayCommand(new Action(this._)));
			}
			return relayCommand;
		}
	}

	// Token: 0x04000003 RID: 3
	[ObservableProperty]
	private int _;

	// Token: 0x04000004 RID: 4
	[Nullable(2)]
	[GeneratedCode("CommunityToolkit.Mvvm.SourceGenerators.RelayCommandGenerator", "8.2.0.0")]
	private RelayCommand m;
}
