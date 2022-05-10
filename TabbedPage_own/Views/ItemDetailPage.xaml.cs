using System.ComponentModel;
using TabbedPage_own.ViewModels;
using Xamarin.Forms;

namespace TabbedPage_own.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}