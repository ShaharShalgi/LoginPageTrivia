﻿
using LoginPage.Views;

namespace LoginPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPageView();
        }
    }
}