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
    public partial class Veebruar : ContentPage
    {
        public Veebruar()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Veebruar on Juliuse kalendris ja Gregoriuse kalendris aasta teine kuu, samuti aasta kõige lühem kuu. Selles on lihtaastal 28 päeva ja liigaastal 29 päeva.Nimetus 'veebruar' on üle võetud roomlaste kalendrist, kus Februarius tähendas puhastuskuud; Februa oli puhastusjumal ning tähendas ka puhastus - ja lepituspüha.Veebruar oli Vana - Roomas aastani 154 eKr aasta viimane, kaheteistkümnes kuu.",
            };

            var img = new Image()
            {
                Source = "https://rahajutud.ee/wp-content/uploads/2018/03/snow-3254341_1920.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}