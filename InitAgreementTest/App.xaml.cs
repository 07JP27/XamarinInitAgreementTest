using System.Collections.Generic;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace InitAgreementTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            try
            {
                var isAgreed = Application.Current.Properties["IsAgreed"] as bool?;

                if ((isAgreed is null) || ((bool)isAgreed) == false)
                {
                    //初期ローンチ
                    MainPage = new NavigationPage(new InitAgreementView());
                }
                else
                {
                    AppCenter.Start("ios={secret};", typeof(Analytics));
                    MainPage = new NavigationPage(new TopView());
                }
            }
            catch(KeyNotFoundException)
            {
                //初期ローンチ
                MainPage = new NavigationPage(new InitAgreementView());
            }
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
