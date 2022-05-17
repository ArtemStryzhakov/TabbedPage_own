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
    public partial class Desember : ContentPage
    {
        public Desember()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Detsembrikuu rahvapärased nimetused lähtuvad talve ning jõulude kui talvepühade saabumisest: jõulukuu, Võ talvistepühakuu või talsipühakuu, Khn talvistekuu, talipühakuu. Talvekuu nimetus märgib talve saabumist ning on kasutusel enam novembri kui detsembri kohta. Kirikuaasta alguskuuna detsember rahvakalendrisse muutusi ei too, adventi hakati tähistama 1980-ndate aastate lõpul. Mängukuu nimetuse puhul on ilmsesti silmas peetud jõuluaegset mänguharrastust või üldse noorte kooskäimisi võimaldavat käsitööõhtute hooaega.",
            };

            var img = new Image()
            {
                Source = "https://secretldn.com/wp-content/uploads/2020/11/london-december-christmas1.png"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}