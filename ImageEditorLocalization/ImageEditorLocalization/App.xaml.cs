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

		MainPage = new AppShell();
		CultureInfo.CurrentUICulture = new CultureInfo("fr-FR");
		SfImageEditorResources.ResourceManager = new ResourceManager("ImageEditorLocalization.Resources.SfImageEditor", Application.Current.GetType().Assembly);
	}
}
