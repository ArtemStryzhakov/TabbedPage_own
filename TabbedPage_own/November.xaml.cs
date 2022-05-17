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
    public partial class November : ContentPage
    {
        public November()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "November ehk kooljakuu ehk talvekuu ehk hingekuu on Gregoriuse kalendris aasta üheteistkümnes kuu. Selles on 30 päeva.",
            };

            var img = new Image()
            {
                Source = "https://www.overcome.tv/blog/november16.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}