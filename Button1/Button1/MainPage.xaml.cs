using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Button1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        ///<Summary>
        ///<Createddate>24/07/2023</Createddate>
        ///<company>INDEL</company>
        ///<lastmodificationdate>24/07/2023</lastmodificationdate>
        ///<lastmodificationdescription>
        ///Este metodo permite cambiar el texto al boton al presionar
        ///
        ///</lastmodificationdescription>
        //////<lastmodifierautor>Fernando Jose Majano Aguirre</lastmodifierautor>
        ///</Summary>
        private void Button_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "Presióname de nuevo";
        }
    }
}
