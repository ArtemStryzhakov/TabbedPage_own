using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabbedPage_own
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Juuli : ContentPage
    {
        public Juuli()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Juuli ehk heinakuu on Gregoriuse kalendris aasta seitsmes kuu. Selles on 31 päeva.",
            };

            var img = new Image()
            {
                Source = "https://arhiiv.karmel.ee/wp-content/uploads/2017/10/juuli-1200x800.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}