﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShoppingApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ShoePage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
