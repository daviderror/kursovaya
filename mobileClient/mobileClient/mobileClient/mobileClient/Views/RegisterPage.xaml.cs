﻿using mobileClient.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace mobileClient.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            this.BindingContext = new RegisterPageViewModel();
        }
    }
}