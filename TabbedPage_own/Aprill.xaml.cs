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
    public partial class Aprill : ContentPage
    {
        public Aprill()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "Aprill on Gregoriuse kalendris aasta neljas kuu. Selles on 30 päeva. Aprill oli Vana - Roomas aastani 154 eKr aasta teine kuu.Nimetus tuleb ladinakeelsest nimetusest Aprilis ja tähendab arvatavasti 'avav'.",
            };

            var img = new Image()
            {
                Source = "https://p.ocdn.ee/53/i/2015/4/10/rtr55uvo.ttj.jpg"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}