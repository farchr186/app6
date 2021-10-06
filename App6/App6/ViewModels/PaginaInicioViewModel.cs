using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PaginaInicioViewModel : BaseViewModel
    {
        Command _goToRoot;
        Command _goToPerfil;

        public PaginaInicioViewModel(INavigation navigation) : base(navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }

        public Command GoToPerfilCommand { get => _goToPerfil ?? (_goToPerfil = new Command(GoToPerfilAction)); }

        private void GoToPerfilAction()
        {
            Navigation.PushAsync(new NavigationPage(new PaginaPerfil()));
        }

        public Command GoToRootCommand { get => _goToRoot ?? (_goToRoot = new Command(GoToRootAction)); }

        private void GoToRootAction()
        {
            Navigation.PopToRootAsync();
        }

    }
}
