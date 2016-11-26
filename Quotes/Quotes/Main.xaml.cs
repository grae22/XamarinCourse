using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Quotes
{
  public partial class Main : ContentPage
  {
    private List<string> Quotes { get; set; } = new List<string>();
    private int QuoteIndex { get; set; } = 0;

    public Main()
    {
      InitializeComponent();

      Quotes.Add( "Quote 1" );
      Quotes.Add( "Quote 2" );
      Quotes.Add( "Quote 3" );

      OnNextClicked( null, null );
    }

    private void OnNextClicked( object sender, EventArgs args )
    {
      uiQuote.Text = Quotes[ QuoteIndex++ ];

      if( QuoteIndex >= Quotes.Count )
      {
        QuoteIndex = 0;
      }
    }
  }
}
