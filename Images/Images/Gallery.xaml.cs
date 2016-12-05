using Xamarin.Forms;

namespace Images
{
  public partial class Gallery : ContentPage
  {
    //-------------------------------------------------------------------------

    private const string c_imageBaseAddress = "http://lorempixel.com/1920/1080/city/";

    private int ImageIndex { get; set; } = 1;

    //-------------------------------------------------------------------------

    public Gallery()
    {
      InitializeComponent();

      UpdateImage();
    }

    //-------------------------------------------------------------------------

    private void ShowPreviousImage()
    {
      ImageIndex--;

      if( ImageIndex < 1 )
      {
        ImageIndex = 1;
      }
      else
      {
        UpdateImage();
      }
    }

    //-------------------------------------------------------------------------

    private void ShowNextImage()
    {
      ImageIndex++;

      UpdateImage();
    }

    //-------------------------------------------------------------------------

    private void UpdateImage()
    {
      uiImage.Source = c_imageBaseAddress + ImageIndex;
    }

    //-------------------------------------------------------------------------
  }
}
