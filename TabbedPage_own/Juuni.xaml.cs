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
    public partial class Juuni : ContentPage
    {
        public Juuni()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Juuni on Gregoriuse kalendris aasta kuues kuu. Selles on 30 päeva.",
            };

            var img = new Image()
            {
                Source = "https://api.delfi.ee/media-api-image-cropper/v1/a1644850-c29d-11eb-964c-a3650fe61001.jpg?w=1200&h=711&ch=0.8427&cw=1&cx=0&cy=0.0009&r=16:9"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}