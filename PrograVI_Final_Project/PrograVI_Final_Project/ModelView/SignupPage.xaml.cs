using RealWorldApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrograVI_Final_Project.ModelView;
using PrograVI_Final_Project.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrograVI_Final_Project.ModelView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignupPage : ContentPage
    {
        public SignupPage()
        {
            InitializeComponent();
        }

        private async void BtnSignUp_Clicked(object sender, EventArgs e)
        {
            if (!EntPassword.Text.Equals(EntConfirmPassword.Text))
            {
                await DisplayAlert("Contraseña incorrecta", "Por favor confirmar si la contraseña es corrrecta", "Cancel");
            }
            else
            {
                var response = await ApiService.RegisterUser(EntName.Text, EntEmail.Text, EntPassword.Text);
                if (response)
                {
                    await DisplayAlert("su cuenta a sido creada", "Muchas Gracias", ":)");
                    await Navigation.PushModalAsync(new Login());
                }
                else
                {
                    await DisplayAlert("!!!", "Hubo un error al crear la cuenta", "Cancelar");
                }
            }
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Login());
        }
    }
}