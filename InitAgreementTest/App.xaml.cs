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
                    MainPage = new NavigationPage(new InitAgreementView()){
                        BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                        BarTextColor = Color.White
                    };
                }
                else
                {
                    AppCenter.Start("ios={secret};", typeof(Analytics));
                    MainPage = new NavigationPage(new TopView()){
                        BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                        BarTextColor = Color.White
                    };
                }
            }
            catch(KeyNotFoundException)
            {
                //初期ローンチ
                MainPage = new NavigationPage(new InitAgreementView()){
                    BarBackgroundColor = new Color(0.00, 0.44, 0.74),
                    BarTextColor = Color.White
                };
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
