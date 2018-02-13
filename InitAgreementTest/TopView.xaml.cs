using System;
using System.Collections.Generic;
using Microsoft.AppCenter.Analytics;
using Xamarin.Forms;

namespace InitAgreementTest
{
    public partial class TopView : ContentPage
    {
        public TopView()
        {
            InitializeComponent();
            //Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "AfterAgreement" } });
        }
    }
}
