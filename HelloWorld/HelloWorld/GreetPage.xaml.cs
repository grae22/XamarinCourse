using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
  public partial class GreetPage : ContentPage
  {
    public GreetPage()
    {
      InitializeComponent();

      Content = new Label
      {
        HorizontalOptions = LayoutOptions.Center,
        VerticalOptions = LayoutOptions.Center,
        Text = "Hello"
      };
    }

    void OnClick( object sender, System.EventArgs e )
    {
      DisplayAlert( "Title", "Message", "OK" );
    }
  }
}
