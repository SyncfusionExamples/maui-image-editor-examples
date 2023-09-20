using Syncfusion.Maui.ImageEditor;

namespace ToolbarCustomization;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        Image image = new Image();
        image.Source = ImageSource.FromFile("browse.png");
        image.WidthRequest = 30;
        image.HeightRequest = 30;

        this.imageEditor.SetToolbarItemVisibility("Shape", false);

        ImageEditorToolbar headerToolbar = this.imageEditor.Toolbars[0];
        ImageEditorToolbarGroupItem browseGroup = (ImageEditorToolbarGroupItem)headerToolbar.ToolbarItems[0];
        ImageEditorToolbarItem browseItem = browseGroup.Items.FirstOrDefault(i => i.Name == "Browse");
        browseItem.View = image;

        ImageEditorToolbar footerToolbar = this.imageEditor.Toolbars[1];
        ImageEditorToolbarItem cropItem = (ImageEditorToolbarItem)footerToolbar.ToolbarItems.FirstOrDefault(i => i.Name == "Crop");
        cropItem.SubToolbarOverlay = false;
        cropItem.SubToolbars = new List<ImageEditorToolbar>()
        {
            new ImageEditorToolbar()
            {
                ToolbarItems = new List<IImageEditorToolbarItem>()
                {
                    new ImageEditorToolbarItem(){ Name = "original"},
                    new ImageEditorToolbarItem(){ Name = "square"},
                    new ImageEditorToolbarItem(){ Name = "custom"}
                },
            }
        };
    }
}

