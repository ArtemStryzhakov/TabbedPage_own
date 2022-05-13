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
    public partial class Marts : ContentPage
    {
        public Marts()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Märts on Gregoriuse kalendris aasta kolmas kuu. Selles on 31 päeva. Märts on tuletatud nimetusest Martius, mis roomlaste kalendris tähendas sõjajumal Marsile pühendatud kuud.Märts oli Vana - Roomas aastani 154 eKr aasta esimene kuu. Martius oli muistsetel roomlastel aasta hakatus,kevadkuu, aeg põllutöid alustada.Mars oli tegelikult etruskide, põllu - ja karjajumal.Roomlased võtsid ta etruskidelt üle(nagu palju muudki, ka nonde sõjakunsti) ja tegid tast endale verejanulise sõjajumala, nagu seda oli kreeklaste Ares.Kevadkuu nimetus jäi endiseks. Märts on ka paastukuu. Paast kestab kuni lihavõttepühadeni aprillis.",
            };

            var img = new Image()
            {
                Source = "https://mentoritekoda.ee/wp-content/uploads/2018/10/spring-720x380.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}