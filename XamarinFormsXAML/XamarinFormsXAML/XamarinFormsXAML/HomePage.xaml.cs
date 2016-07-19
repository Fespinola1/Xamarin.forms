using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinFormsXAML
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //agregamos la variable

        int count = 0;
        protected override void OnAppearing()
        {
            base.OnAppearing();

            //se ejecuta cuando la aplicación aparece

            HDCsumar.Clicked += HDCsumar_Clicked;
        }

        // el evento que creamos
        private void HDCsumar_Clicked(object sender, EventArgs e)
        {
            count++;
            HDCsumar.Text = count.ToString();
        }
    }
}
