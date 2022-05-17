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
    public partial class August : ContentPage
    {
        public August()
        {
            InitializeComponent();
            Label text = new Label()
            {
                Text = "August ehk lõikuskuu on Gregoriuse kalendris aasta kaheksas kuu. Selles on 31 päeva. Augusti rahvapärased nimetused on ka põimukuu, viljakuu, rukkikuu, mädakuu ehk mädanemiskuu, hallituskuu, kirbukuu ja pärtlikuu.",
            };

            var img = new Image()
            {
                Source = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRcNwFm6zPnjCY4CRvAgoQ82n62z8wCnzC9Ig&usqp=CAU"
            };
            Content = new StackLayout { Children = { text, img } };
        }
    }
}