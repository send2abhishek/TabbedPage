using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedViewApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
           var response=  await DisplayAlert("Waring", "Are you Sure ?", "Yes", "No");

            if (response)
            {
                await DisplayAlert("Done", "your Response has been Added", "Okay");
            }
        }
    }
}