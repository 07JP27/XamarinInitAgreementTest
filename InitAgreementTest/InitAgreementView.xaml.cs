using System;
using System.Collections.Generic;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace InitAgreementTest
{
    public partial class InitAgreementView : ContentPage
    {
        public InitAgreementView()
        {
            InitializeComponent();
        }

        void AgreeButtonClicked(object sender, System.EventArgs e)
        {
            /*
            Application.Current.Properties["IsAgreed"] = true;
            Application.Current.SavePropertiesAsync();
            */

            AppCenter.Start("ios={secret};", typeof(Analytics));
            Application.Current.MainPage = new NavigationPage(new TopView());

        }
    }
}
