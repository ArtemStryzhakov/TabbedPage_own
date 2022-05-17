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
    public partial class September : ContentPage
    {
        public September()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "September ehk mihklikuu on Gregoriuse kalendris aasta üheksas kuu. Septembris on 30 päeva.",
            };

            var img = new Image()
            {
                Source = "https://static.chasecdn.com/content/services/structured-image/image.desktopLarge.jpg/articles/thumbnail-image-large/should-i-be-worried-about-the-september-effect-2560x1440.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}