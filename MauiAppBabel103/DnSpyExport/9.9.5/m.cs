using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Internals;
using Microsoft.Maui.Controls.Xaml;

// Token: 0x02000007 RID: 7
[XamlFilePath("MainPage.xaml")]
internal class m : ContentPage
{
	// Token: 0x06000008 RID: 8 RVA: 0x000020CB File Offset: 0x000002CB
	[NullableContext(1)]
	public m(m_ _)
	{
		this._();
		base.BindingContext = _;
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000020E0 File Offset: 0x000002E0
	[GeneratedCode("Microsoft.Maui.Controls.SourceGen", "1.0.0.0")]
	private void _()
	{
		BindingExtension bindingExtension = new BindingExtension();
		Button button = new Button();
		BindingExtension bindingExtension2 = new BindingExtension();
		Label label = new Label();
		VerticalStackLayout verticalStackLayout = new VerticalStackLayout();
		NameScope nameScope = NameScope.GetNameScope(this) ?? new NameScope();
		NameScope.SetNameScope(this, nameScope);
		verticalStackLayout.SetValue(Layout.PaddingProperty, new Thickness(30.0, 0.0));
		verticalStackLayout.SetValue(StackBase.SpacingProperty, 25.0);
		verticalStackLayout.SetValue(View.VerticalOptionsProperty, LayoutOptions.Center);
		bindingExtension.Mode = 2;
		bindingExtension.Path = "ClickCommand";
		bindingExtension.TypedBinding = new TypedBinding<m_, IRelayCommand>(new Func<m_, ValueTuple<IRelayCommand, bool>>(global::m.m), null, new Tuple<Func<m_, object>, string>[]
		{
			new Tuple<Func<m_, object>, string>(new Func<m_, object>(global::m.__), "ClickCommand")
		});
		BindingBase bindingBase = bindingExtension.ProvideValue(null);
		button.SetBinding(Button.CommandProperty, bindingBase);
		button.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		button.SetValue(Button.TextProperty, "Click me");
		verticalStackLayout.Children.Add(button);
		label.SetValue(Label.FontAttributesProperty, 1);
		label.SetValue(Label.FontSizeProperty, 24.0);
		label.SetValue(View.HorizontalOptionsProperty, LayoutOptions.Center);
		bindingExtension2.Mode = 2;
		bindingExtension2.Path = "Count";
		bindingExtension2.TypedBinding = new TypedBinding<m_, int>(new Func<m_, ValueTuple<int, bool>>(global::m._m), null, new Tuple<Func<m_, object>, string>[]
		{
			new Tuple<Func<m_, object>, string>(new Func<m_, object>(global::m.m_), "Count")
		});
		BindingBase bindingBase2 = bindingExtension2.ProvideValue(null);
		label.SetBinding(Label.TextProperty, bindingBase2);
		verticalStackLayout.Children.Add(label);
		this.SetValue(ContentPage.ContentProperty, verticalStackLayout);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x000022CC File Offset: 0x000004CC
	[CompilerGenerated]
	private static ValueTuple<IRelayCommand, bool> m(m_ _)
	{
		if (_ != null)
		{
			return new ValueTuple<IRelayCommand, bool>(_._m, true);
		}
		return default(ValueTuple<IRelayCommand, bool>);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000022FC File Offset: 0x000004FC
	[CompilerGenerated]
	private static object __(m_ _)
	{
		return _;
	}

	// Token: 0x0600000C RID: 12 RVA: 0x0000230C File Offset: 0x0000050C
	[CompilerGenerated]
	private static ValueTuple<int, bool> _m(m_ _)
	{
		if (_ != null)
		{
			return new ValueTuple<int, bool>(_.__, true);
		}
		return default(ValueTuple<int, bool>);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x0000233C File Offset: 0x0000053C
	[CompilerGenerated]
	private static object m_(m_ _)
	{
		return _;
	}
}
