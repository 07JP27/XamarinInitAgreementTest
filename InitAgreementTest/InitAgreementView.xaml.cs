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
            NavigationPage.SetHasNavigationBar(this, false);
        }

        void AgreeButtonClicked(object sender, System.EventArgs e)
        {
            /*
            Application.Current.Properties["IsAgreed"] = true;
            Application.Current.SavePropertiesAsync();
            */

            AppCenter.Start("ios={secret};", typeof(Analytics));
            Application.Current.MainPage = new NavigationPage(new TopView()){
                BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                BarTextColor = Color.White
            };
        }

        void ViewAgreementClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new AgreementArticleView());
        }

        void ViewPolicyClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PolicyArticleView());
        }
    }
}
