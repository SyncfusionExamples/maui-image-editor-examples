using Syncfusion.Maui.ImageEditor;

namespace ImageLoaded;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void OnImageLoaded(object sender, EventArgs e)
    {
        this.imageEditor.AddShape(AnnotationShape.Circle, new ImageEditorShapeSettings() { Bounds = new Rect(0.1, 0.1, 0.5, 0.2) });
        this.imageEditor.AddText("Syncfusion");
    }
}

