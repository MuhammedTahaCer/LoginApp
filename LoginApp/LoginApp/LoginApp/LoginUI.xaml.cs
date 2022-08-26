using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginUI : ContentPage
    {
        public LoginUI()
        {
            InitializeComponent();
             
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (sicil == null)
            {
                await DisplayAlert("uyarı", "lütfen sicil numaranızı giriniz", "ok");
            }
            else
            {
                if (string.IsNullOrEmpty(sicil.Text) == true)
                {
                    await DisplayAlert("uyarı", "lütfen sicil numaranızı girin", "ok");

                }
                //else await navigation.pushasync(new mainpage());

            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //sicil.Focus();
        }

        
    }
}