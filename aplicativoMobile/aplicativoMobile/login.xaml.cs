using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicativoMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private async void btnCadastrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new cadastro(), true);
            entryCPF.Text = "";
            entrySenha.Text = "";
        }

        private async void btnEnter_Clicked(object sender, EventArgs e)
        {
            if (entryCPF.Text == "03722303699" && entrySenha.Text == "abc456")
            {
                await Navigation.PushAsync(new principal(), true);
                entryCPF.Text = "";
                entrySenha.Text = "";
            }

            else
            {
                await DisplayAlert("Atenção!", "CPF e/ou senha incorretos. Tente novamente!", "OK");
                entryCPF.Text = "";
                entrySenha.Text = "";
            }
        }
    }
}