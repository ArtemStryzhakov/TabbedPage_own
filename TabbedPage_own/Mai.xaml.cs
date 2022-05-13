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
    public partial class Mai : ContentPage
    {
        public Mai()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Mai ehk lehekuu on Gregoriuse kalendris aasta viies kuu. Selles on 31 päeva. Mai oli Vana - Roomas aastani 154 eKr aasta kolmas kuu.Nimetus tuleb ladinakeelsest nimetusest Maius, mis oli antud kas jumalatar Maia või kasvujumal Maiuse järgi.",
            };

            var img = new Image()
            {
                Source = "https://www.seedripuukool.ee/pics/21584966628_23032020143027//etoile-de-mai.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}