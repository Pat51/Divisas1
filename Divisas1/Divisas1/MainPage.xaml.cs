using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Divisas1
{
    public partial class MainPage : ContentPage
    {
        private ExchangeRates exchangeRates;


        public MainPage()
        {
            InitializeComponent();


            LoadPickers();
            LoadRates();



        }

        private async void LoadRates()
        {
            waitActivityIndicator.IsRunning = true;
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri("https://openexchangerates.org");
                var url = "/api/latest.json?app_id=57658348f64f4d0a8ba9b21ef5912545";
                var response = await client.GetAsync(url);
            }
            catch (Exception ex)
            {
               await DisplayAlert("Error", ex.Message, "Aceptar");
                waitActivityIndicator.IsRunning = false;
                convertButton.IsEnabled = false;
                return;
            }




            waitActivityIndicator.IsRunning = false;
            convertButton.IsEnabled = true;
        }

        private void LoadPickers()
        {
            LoadPicker(sourcePicker);
            LoadPicker(targetPicker);
        }

        private void LoadPicker(Picker picker)
        {
         
        picker.Items.Add(" AED ");
        picker.Items.Add(" AFN ");
        picker.Items.Add(" ALL ");
        picker.Items.Add(" AMD ");
        picker.Items.Add(" ANG ");
        picker.Items.Add(" AOA ");
        picker.Items.Add(" ARS ");
        picker.Items.Add(" AUD ");
        picker.Items.Add(" AWG ");
        picker.Items.Add(" AZN ");
        picker.Items.Add(" BAM ");
        picker.Items.Add(" BBD ");
        picker.Items.Add(" BDT ");
        picker.Items.Add(" BGN ");
        picker.Items.Add(" BHD ");
        picker.Items.Add(" BIF ");
        picker.Items.Add(" BMD ");
        picker.Items.Add(" BND ");
        picker.Items.Add(" BOB ");
        picker.Items.Add(" BRL ");
        picker.Items.Add(" BSD ");
        picker.Items.Add(" BTC ");
        picker.Items.Add(" BTN ");
        picker.Items.Add(" BWP ");
        picker.Items.Add(" BYN ");
        picker.Items.Add(" BZD ");
        picker.Items.Add(" CAD ");
        picker.Items.Add(" CDF ");
        picker.Items.Add(" CHF ");
        picker.Items.Add(" CLF ");
        picker.Items.Add(" CLP ");
        picker.Items.Add(" CNH ");
        picker.Items.Add(" CNY ");
        picker.Items.Add(" COP ");
        picker.Items.Add(" CRC ");
        picker.Items.Add(" CUC ");
        picker.Items.Add(" CUP ");
        picker.Items.Add(" CVE ");
        picker.Items.Add(" CZK ");
        picker.Items.Add(" DJF ");
        picker.Items.Add(" DKK ");
        picker.Items.Add(" DOP ");
        picker.Items.Add(" DZD ");
        picker.Items.Add(" EGP ");
        picker.Items.Add(" ERN ");
        picker.Items.Add(" ETB ");
        picker.Items.Add(" EUR ");
        picker.Items.Add(" FJD ");
        picker.Items.Add(" FKP ");
        picker.Items.Add(" GBP ");
        picker.Items.Add(" GEL ");
        picker.Items.Add(" GGP ");
        picker.Items.Add(" GHS ");
        picker.Items.Add(" GIP ");
        picker.Items.Add(" GMD ");
        picker.Items.Add(" GNF ");
        picker.Items.Add(" GTQ ");
        picker.Items.Add(" GYD ");
        picker.Items.Add(" HKD ");
        picker.Items.Add(" HNL ");
        picker.Items.Add(" HRK ");
        picker.Items.Add(" HTG ");
        picker.Items.Add(" HUF ");
        picker.Items.Add(" IDR ");
        picker.Items.Add(" ILS ");
        picker.Items.Add(" IMP ");
        picker.Items.Add(" INR ");
        picker.Items.Add(" IQD ");
        picker.Items.Add(" IRR ");
        picker.Items.Add(" ISK ");
        picker.Items.Add(" JEP ");
        picker.Items.Add(" JMD ");
        picker.Items.Add(" JOD ");
        picker.Items.Add(" JPY ");
        picker.Items.Add(" KES ");
        picker.Items.Add(" KGS ");
        picker.Items.Add(" KHR ");
        picker.Items.Add(" KMF ");
        picker.Items.Add(" KPW ");
        picker.Items.Add(" KRW ");
        picker.Items.Add(" KWD ");
        picker.Items.Add(" KYD ");
        picker.Items.Add(" KZT ");
        picker.Items.Add(" LAK ");
        picker.Items.Add(" LBP ");
        picker.Items.Add(" LKR ");
        picker.Items.Add(" LRD ");
        picker.Items.Add(" LSL ");
        picker.Items.Add(" LYD ");
        picker.Items.Add(" MAD ");
        picker.Items.Add(" MDL ");
        picker.Items.Add(" MGA ");
        picker.Items.Add(" MKD ");
        picker.Items.Add(" MMK ");
        picker.Items.Add(" MNT ");
        picker.Items.Add(" MOP ");
        picker.Items.Add(" MRO ");
        picker.Items.Add(" MRU ");
        picker.Items.Add(" MUR ");
        picker.Items.Add(" MVR ");
        picker.Items.Add(" MWK ");
        picker.Items.Add(" MXN ");
        picker.Items.Add(" MYR ");
        picker.Items.Add(" MZN ");
        picker.Items.Add(" NAD ");
        picker.Items.Add(" NGN ");
        picker.Items.Add(" NIO ");
        picker.Items.Add(" NOK ");
        picker.Items.Add(" NPR ");
        picker.Items.Add(" NZD ");
        picker.Items.Add(" OMR ");
        picker.Items.Add(" PAB ");
        picker.Items.Add(" PEN ");
        picker.Items.Add(" PGK ");
        picker.Items.Add(" PHP ");
        picker.Items.Add(" PKR ");
        picker.Items.Add(" PLN ");
        picker.Items.Add(" PYG ");
        picker.Items.Add(" QAR ");
        picker.Items.Add(" RON ");
        picker.Items.Add(" RSD ");
        picker.Items.Add(" RUB ");
        picker.Items.Add(" RWF ");
        picker.Items.Add(" SAR ");
        picker.Items.Add(" SBD ");
        picker.Items.Add(" SCR ");
        picker.Items.Add(" SDG ");
        picker.Items.Add(" SEK ");
        picker.Items.Add(" SGD ");
        picker.Items.Add(" SHP ");
        picker.Items.Add(" SLL ");
        picker.Items.Add(" SOS ");
        picker.Items.Add(" SRD ");
        picker.Items.Add(" SSP ");
        picker.Items.Add(" STD ");
        picker.Items.Add(" STN ");
        picker.Items.Add(" SVC ");
        picker.Items.Add(" SYP ");
        picker.Items.Add(" SZL ");
        picker.Items.Add(" THB ");
        picker.Items.Add(" TJS ");
        picker.Items.Add(" TMT ");
        picker.Items.Add(" TND ");
        picker.Items.Add(" TOP ");
        picker.Items.Add(" TRY ");
        picker.Items.Add(" TTD ");
        picker.Items.Add(" TWD ");
        picker.Items.Add(" TZS ");
        picker.Items.Add(" UAH ");
        picker.Items.Add(" UGX ");
        picker.Items.Add(" USD ");
        picker.Items.Add(" UYU ");
        picker.Items.Add(" UZS ");
        picker.Items.Add(" VEF ");
        picker.Items.Add(" VES ");
        picker.Items.Add(" VND ");
        picker.Items.Add(" VUV ");
        picker.Items.Add(" WST ");
        picker.Items.Add(" XAF ");
        picker.Items.Add(" XAG ");
        picker.Items.Add(" XAU ");
        picker.Items.Add(" XCD ");
        picker.Items.Add(" XDR ");
        picker.Items.Add(" XOF ");
        picker.Items.Add(" XPD ");
        picker.Items.Add(" XPF ");
        picker.Items.Add(" XPT ");
        picker.Items.Add(" YER ");
        picker.Items.Add(" ZAR ");
        picker.Items.Add(" ZMW ");
        picker.Items.Add(" ZWL ");
    }
    }
}
