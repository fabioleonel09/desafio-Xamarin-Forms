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
    public partial class principal : ContentPage
    {
        public principal()
        {
            InitializeComponent();
        }

        private async void btnVoltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void btnExecutar_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(entryPalavra.Text))
            {
                await DisplayAlert("Atenção!", "Digite uma palavra no campo!", "OK");
            }

            else
            {
                removeRepeatedChars(entryPalavra.Text);
            }  
        }

        public string removeRepeatedChars(string _str)
        {
            string str = _str;
            char J, I;
            int i, j;
            i = j = 0;
            J = I = ' ';
            while (i < str.Length - 1)
            {
                j = i + 1;
                while (j < str.Length)
                {
                    J = str[j];
                    I = str[i];
                    if (J == I)
                        str = str.Remove(j, 1);
                    else
                        j++;
                }
                i++;
            }
            return lblResultado.Text = str;
        }

        private void btnLimpar_Clicked(object sender, EventArgs e)
        {
            entryPalavra.Text = "";
            lblResultado.Text = "Veja o resultado!";
        }
    }
}