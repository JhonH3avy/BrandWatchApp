using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using TesisFrontEnd.Views;

namespace TesisFrontEnd.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;

        public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;

            LoginCommand = new Command(async () =>
            {
                await Navigation.PushAsync(new CategoryCharts());
            });
        }

        public INavigation Navigation { get; set; }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; }

        public ICommand RegisterCommand { get; }
    }
}
