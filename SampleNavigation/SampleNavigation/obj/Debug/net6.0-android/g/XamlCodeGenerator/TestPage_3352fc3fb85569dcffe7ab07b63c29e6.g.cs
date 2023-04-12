// <autogenerated />
#pragma warning disable 618 // Ignore obsolete members warnings
#pragma warning disable 105 // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
#pragma warning disable CS8669 // Ignore annotation for nullable reference types
#pragma warning disable CS0114
#pragma warning disable CS0108
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Uno.UI.Xaml;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using Uno.UI.Helpers.Xaml;
using SampleNavigation;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif UNO_REFERENCE_API || NET461
using _View = Microsoft.UI.Xaml.UIElement;
#endif

namespace SampleNavigation
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("dotnet", "CA1001", Justification="Generated code")]
	partial class TestPage : Microsoft.UI.Xaml.Controls.Page
	{
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_prefix_TestPage_3352fc3fb85569dcffe7ab07b63c29e6 = "ms-appx:///SampleNavigation/";
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		private const string __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6 = "ms-appx:///SampleNavigation/TestPage.xaml";
				global::Microsoft.UI.Xaml.NameScope __nameScope = new global::Microsoft.UI.Xaml.NameScope();
		private void InitializeComponent()
		{
			InitializeComponent_0();
		}
		private void InitializeComponent_0()
		{
			var __resourceLocator = new global::System.Uri("file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml");
			if(global::Uno.UI.ApplicationHelper.IsLoadableComponent(__resourceLocator))
			{
				global::Microsoft.UI.Xaml.Application.LoadComponent(this, __resourceLocator);
				return;
			}
			NameScope.SetNameScope(this, __nameScope);
			var __that = this;
			base.IsParsing = true;
			// Source ..\..\..\..\..\..\TestPage.xaml (Line 1:2)
			base.Content = 
			new global::Microsoft.UI.Xaml.Controls.StackPanel
			{
				IsParsing = true,
				Margin = new global::Microsoft.UI.Xaml.Thickness(32)/* Microsoft.UI.Xaml.Thickness/, 32, StackPanel/Margin */,
				// Source ..\..\..\..\..\..\TestPage.xaml (Line 11:6)
				Children = 
				{
					new global::Microsoft.UI.Xaml.Controls.TextBox
					{
						IsParsing = true,
						// Source ..\..\..\..\..\..\TestPage.xaml (Line 12:10)
					}
					.GenericApply(__that, __nameScope, ((c0, __that, __nameScope) => 
					{
						c0.SetBinding(
							global::Microsoft.UI.Xaml.Controls.TextBox.TextProperty,
							new Microsoft.UI.Xaml.Data.Binding()
							{
								Path = @"Content"/* Microsoft.UI.Xaml.PropertyPath/Microsoft.UI.Xaml.PropertyPath, Content, /_PositionalParameters */,
								Mode = global::Microsoft.UI.Xaml.Data.BindingMode.TwoWay/* Microsoft.UI.Xaml.Data.BindingMode/Microsoft.UI.Xaml.Data.BindingMode, TwoWay, Binding/Mode */,
							}
						);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c0, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 12, 10);
						c0.CreationComplete();
					}
					))
					,
					new global::Microsoft.UI.Xaml.Controls.Button
					{
						IsParsing = true,
						Content = @"Submit"/* object/, Submit, Button/Content */,
						// Source ..\..\..\..\..\..\TestPage.xaml (Line 14:10)
					}
					.GenericApply(__that, __nameScope, ((c1, __that, __nameScope) => 
					{
						c1.SetBinding(
							global::Microsoft.UI.Xaml.Controls.Button.CommandProperty,
							new Microsoft.UI.Xaml.Data.Binding()
							{
								Path = @"Submit"/* Microsoft.UI.Xaml.PropertyPath/Microsoft.UI.Xaml.PropertyPath, Submit, /_PositionalParameters */,
							}
						);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c1, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 14, 10);
						c1.CreationComplete();
					}
					))
					,
					new global::Microsoft.UI.Xaml.Controls.TextBlock
					{
						IsParsing = true,
						// Source ..\..\..\..\..\..\TestPage.xaml (Line 17:10)
					}
					.GenericApply(__that, __nameScope, ((c2, __that, __nameScope) => 
					{
						c2.SetBinding(
							global::Microsoft.UI.Xaml.Controls.TextBlock.TextProperty,
							new Microsoft.UI.Xaml.Data.Binding()
							{
								Path = @"Result"/* Microsoft.UI.Xaml.PropertyPath/Microsoft.UI.Xaml.PropertyPath, Result, /_PositionalParameters */,
							}
						);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c2, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 17, 10);
						c2.CreationComplete();
					}
					))
					,
					new global::Microsoft.UI.Xaml.Controls.Button
					{
						IsParsing = true,
						Content = @"Navigate to setting section"/* object/, Navigate to setting section, Button/Content */,
						// Source ..\..\..\..\..\..\TestPage.xaml (Line 19:10)
					}
					.GenericApply(__that, __nameScope, ((c3, __that, __nameScope) => 
					{
						c3.SetBinding(
							global::Microsoft.UI.Xaml.Controls.Button.CommandProperty,
							new Microsoft.UI.Xaml.Data.Binding()
							{
								Path = @"NavigateToSettingSection"/* Microsoft.UI.Xaml.PropertyPath/Microsoft.UI.Xaml.PropertyPath, NavigateToSettingSection, /_PositionalParameters */,
							}
						);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 19, 10);
						c3.CreationComplete();
					}
					))
					,
					new global::Microsoft.UI.Xaml.Controls.Button
					{
						IsParsing = true,
						Content = @"Navigate back"/* object/, Navigate back, Button/Content */,
						// Source ..\..\..\..\..\..\TestPage.xaml (Line 22:10)
					}
					.GenericApply(__that, __nameScope, ((c4, __that, __nameScope) => 
					{
						c4.SetBinding(
							global::Microsoft.UI.Xaml.Controls.Button.CommandProperty,
							new Microsoft.UI.Xaml.Data.Binding()
							{
								Path = @"NavigateBack"/* Microsoft.UI.Xaml.PropertyPath/Microsoft.UI.Xaml.PropertyPath, NavigateBack, /_PositionalParameters */,
							}
						);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c4, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 22, 10);
						c4.CreationComplete();
					}
					))
					,
				}
			}
			.GenericApply(__that, __nameScope, ((c5, __that, __nameScope) => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 11, 6);
				c5.CreationComplete();
			}
			))
			;
			
			this
			.GenericApply(__that, __nameScope, ((c6, __that, __nameScope) => 
			{
				// Source C:\Test\NET_WinUI\Navigation\SampleNavigation\SampleNavigation\TestPage.xaml (Line 1:2)
				
				// WARNING Property c6.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Page, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			.GenericApply(__that, __nameScope, ((c7, __that, __nameScope) => 
			{
				/* _isTopLevelDictionary:False */
				__that._component_0 = c7;
				// Class SampleNavigation.TestPage
				global::Uno.UI.ResourceResolverSingleton.Instance.ApplyResource(c7, global::Microsoft.UI.Xaml.Controls.Page.BackgroundProperty, "ApplicationPageBackgroundThemeBrush", isThemeResourceExtension: true, isHotReloadSupported: true, context: global::SampleNavigation.GlobalStaticResources.__ParseContext_);
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, __baseUri_TestPage_3352fc3fb85569dcffe7ab07b63c29e6, "file:///C:/Test/NET_WinUI/Navigation/SampleNavigation/SampleNavigation/TestPage.xaml", 1, 2);
				c7.CreationComplete();
			}
			))
			;
			OnInitializeCompleted();

			Bindings = new TestPage_Bindings(this);
			global::Uno.UI.Helpers.MarkupHelper.SetElementProperty(__that, "owner", __that);
			Loading += (s, e) => 
			{
				var __that = global::Uno.UI.Helpers.MarkupHelper.GetElementProperty<global::SampleNavigation.TestPage>(s, "owner");
				__that.Bindings.UpdateResources();
			}
			;
		}
		partial void OnInitializeCompleted();
		private global::Microsoft.UI.Xaml.Markup.ComponentHolder _component_0_Holder { get; set; } = new global::Microsoft.UI.Xaml.Markup.ComponentHolder(isWeak: true);
		private global::Microsoft.UI.Xaml.Controls.Page _component_0
		{
			get
			{
				return (global::Microsoft.UI.Xaml.Controls.Page)_component_0_Holder.Instance;
			}
			set
			{
				_component_0_Holder.Instance = value;
			}
		}
		private interface ITestPage_Bindings
		{
			void Initialize();
			void Update();
			void UpdateResources();
			void StopTracking();
		}
		#pragma warning disable 0169 //  Suppress unused field warning in case Bindings is not used.
		private ITestPage_Bindings Bindings;
		#pragma warning restore 0169
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
		private class TestPage_Bindings : ITestPage_Bindings
		{
			#if UNO_HAS_UIELEMENT_IMPLICIT_PINNING
			private global::System.WeakReference _ownerReference;
			private global::SampleNavigation.TestPage Owner { get => (global::SampleNavigation.TestPage)_ownerReference?.Target; set => _ownerReference = new global::System.WeakReference(value); }
			#else
			private global::SampleNavigation.TestPage Owner { get; set; }
			#endif
			public TestPage_Bindings(global::SampleNavigation.TestPage owner)
			{
				Owner = owner;
			}
			void ITestPage_Bindings.Initialize()
			{
			}
			void ITestPage_Bindings.Update()
			{
				var owner = Owner;
			}
			void ITestPage_Bindings.UpdateResources()
			{
				var owner = Owner;
				owner._component_0.UpdateResourceBindings();
			}
			void ITestPage_Bindings.StopTracking()
			{
			}
		}

	}
}
