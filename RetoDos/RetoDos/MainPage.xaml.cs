using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace RetoDos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void b_exec_Clicked(object sender, EventArgs e)
        {
            try
            {
                int veces;
                try
                {
                    veces = Convert.ToInt32(e_vibraciones.Text);
                }
                catch (Exception)
                {
                    DisplayAlert("Error", "Ingrese un numero entero!", "OK");
                    return;
                }
                var duration = TimeSpan.FromSeconds(1);
                // vibra un segundo, para y se repite las veces que le indica el usuario
                for (int i = 0; i < veces; i++)
                {
                    Vibration.Vibrate(duration);
                    Vibration.Cancel();
                }
            }
            catch (FeatureNotSupportedException ex)
            {
                DisplayAlert("Error", ex.ToString(), "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.ToString(), "OK");
            }
        }
    }
}
