using Microsoft.Maui.Controls;
using Syncfusion.Maui.ImageEditor;
using System.Globalization;
using System.Resources;

namespace ImageEditorLocalization;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
		SfImageEditorResources.ResourceManager = new ResourceManager("ImageEditorLocalization.Resources.SfImageEditor", Application.Current.GetType().Assembly);
	}

	protected override Window CreateWindow(IActivationState activationState)
	{
		return new Window(new AppShell());
	}
}
