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
    public partial class Oktoober : ContentPage
    {
        public Oktoober()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Oktoober ehk rehekuu ehk viinakuu on Gregoriuse kalendris aasta kümnes kuu. Selles on 31 päeva.",
            };

            var img = new Image()
            {
                Source = "https://1.bp.blogspot.com/-bhkkhLg6bgo/Xcp4cs24G2I/AAAAAAABhgE/HqT_1lNhvAIg6WzxFrd83rQ72OMJ5we-wCLcBGAsYHQ/s1600/eeqk2qls.nf5.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}