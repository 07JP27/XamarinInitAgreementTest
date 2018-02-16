using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InitAgreementTest
{
    public partial class IframeView : ContentPage
    {
        public IframeView()
        {
            InitializeComponent();           
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            var html = new HtmlWebViewSource
            {
                Html = $@"<html><body><iframe src=""url"" style=""border-width:0"" width=""{width-5}"" height=""{height-10}"" frameborder=""0"" scrolling=""no""></iframe></html>",
            };

            wv.Source = html;
        }
    }
}
