using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        Command _loginCommand;
        private bool errorLogin;

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {

        }

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                OnPropertyChanged();
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();              
            }
        }

        public Command LoginCommand
        {
            get => _loginCommand ?? (_loginCommand = new Command(GoTologinAction));
        }
        public bool Error
        {
            get => errorLogin;
            set
            {
                errorLogin = value;
                OnPropertyChanged();
            }
        }

        private void GoTologinAction()
        {
            Error = !(string.Equals(Email, "app6@gmail.com") && string.Equals(Password, "inicio1234"));

            if (!Error)
            {
                Email = string.Empty;
                Password = string.Empty;
                Navigation.PushAsync(new PaginaInicio());
            }
        }
    }
}
