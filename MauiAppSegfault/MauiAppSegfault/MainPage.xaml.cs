using HtmlAgilityPack;
using System;

namespace MauiAppSegfault
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            try
            {
                var node = default(HtmlNode);
                var link = node.GetAttributeValue("href", null);
            }
            catch (Exception)
            {
            }
        }
    }
}
