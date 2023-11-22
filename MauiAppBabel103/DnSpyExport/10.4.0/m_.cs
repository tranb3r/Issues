using System;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;

// Token: 0x0200000A RID: 10
[NullableContext(1)]
internal interface m_
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000010 RID: 16
	int Count { get; }

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000011 RID: 17
	IRelayCommand ClickCommand { get; }
}
