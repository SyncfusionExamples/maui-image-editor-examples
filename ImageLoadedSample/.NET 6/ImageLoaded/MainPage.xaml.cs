using Syncfusion.Maui.ImageEditor;

namespace ImageLoaded;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void imageEditorImageLoaded(object sender, EventArgs e)
    {
        imageEditor.AddShape(AnnotationShape.Circle, new ImageEditorShapeSettings() { Bounds = new Rect(0.1,0.1,0.5,0.2)});
        imageEditor.AddText("Syncfusion");
    }
}
