﻿using System;
using BottomSheetDemo.Pages.BottomSheetPage;
using FreshMvvm;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BottomSheetDemo
{
    public partial class App : Application
    {
        private FreshNavigationContainer _mainNavContainer;
        private Page page;

        public App()
        {
            InitializeComponent();

            SetMainPage();
        }

        public void SetMainPage()
        {
            page = FreshPageModelResolver.ResolvePageModel<BottomSheetPageModel>();
            _mainNavContainer = new FreshNavigationContainer(page);
            MainPage = _mainNavContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
