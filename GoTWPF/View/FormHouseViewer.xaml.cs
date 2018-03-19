using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using GoTWPF.ViewModel;

namespace GoTWPF.View
{
    /// <summary>
    /// Logique d'interaction pour FormHouse.xaml
    /// </summary>
    public partial class FormHouseViewer : Window
    {
        private HouseViewModel houseViewModel = new HouseViewModel();

        public FormHouseViewer()
        {
            InitializeComponent();
            ucHouse.DataContext = houseViewModel;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveHouseAsync();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private async void SaveHouseAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var stringContent = new StringContent(houseViewModel.ToString());
            var response = await client.PostAsync("api/house/SaveHouse/", stringContent);
            
        }
    }
}
