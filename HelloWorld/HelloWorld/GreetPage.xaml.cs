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

      slider.Value = 0.5;
    }

    public void Slider_ValueChanged( object sender,
                                     Xamarin.Forms.ValueChangedEventArgs args )
    {
      label.Text = string.Format( "Value is {0:F2}", args.NewValue );
    }
  }
}
