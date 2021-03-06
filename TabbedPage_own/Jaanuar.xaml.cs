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
    public partial class Jaanuar : ContentPage
    {
        public Jaanuar()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Jaanuar on Gregoriuse kalendris aasta esimene kuu. Jaanuar oli Vana-Roomas aastani 154 eKr aasta eelviimane ehk üheteistkümnes kuu. Jaanuaris on 31 päeva.",
            };

            var img = new Image()
            {
                Source = "https://lugejakiri.ee/wp-content/uploads/2019/01/t%C3%A4jistaevas.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}