using System;
using System.Collections.Generic;
using TabbedPage_own.ViewModels;
using TabbedPage_own.Views;
using Xamarin.Forms;

namespace TabbedPage_own
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
