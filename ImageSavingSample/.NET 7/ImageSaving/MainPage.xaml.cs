using Syncfusion.Maui.ImageEditor;

namespace ImageSaving;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnImageSaving(object sender, ImageSavingEventArgs e)
    {
        e.FileName = "Office";
        e.FileType = ImageFileType.Jpeg;
    }
}