using GoTWPF.ViewModel;
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
using GoTWPF.Entities;

namespace GoTWPF.View
{
    /// <summary>
    /// Logique d'interaction pour Viewer.xaml
    /// </summary>
    public partial class Viewer : Window
    {
        private List<HouseViewModel> listHouseViewModel = new List<HouseViewModel>(); 

        public Viewer()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadHouses();
            ucHouses.dataNormalGrid.ItemsSource = listHouseViewModel;
        }

        private void LoadHouses()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/house/GetAllHouses").Result;
            if (response.IsSuccessStatusCode)
            {
                listHouseViewModel = response.Content.ReadAsAsync<List<HouseViewModel>>().Result;
            }

        }

        private void AddBtnClicked(object sender, RoutedEventArgs e)
        {
            FormHouseViewer formHouseVeiwer = new FormHouseViewer();
            formHouseVeiwer.ShowDialog();
        }
    }
}
