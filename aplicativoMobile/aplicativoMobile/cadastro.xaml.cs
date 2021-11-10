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
    public partial class cadastro : ContentPage
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void btnConfirmar_Clicked(object sender, EventArgs e)
        {
            if ((string.IsNullOrWhiteSpace(entryNome.Text)) || (string.IsNullOrWhiteSpace(entryCPF.Text)) || (string.IsNullOrWhiteSpace(entrySenha.Text)) || (string.IsNullOrWhiteSpace(entryConfirmeSenha.Text)) || (entrySenha.Text != entryConfirmeSenha.Text))
            {
                await DisplayAlert("Atenção!", "Confira os campos 'Nome', 'CPF', 'Senha' e 'Confirmar senha'!", "OK");
            }

            else
            {
                await DisplayAlert("Parabéns!", "Cadastro realizado com sucesso!", "OK");
                await Navigation.PopToRootAsync();
            }
        }
    }
}