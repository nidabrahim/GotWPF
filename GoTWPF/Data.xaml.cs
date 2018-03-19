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

namespace GoTWPF
{
    /// <summary>
    /// Logique d'interaction pour Data.xaml
    /// </summary>
    public partial class Data : Window
    {
 
        public List<House> objList = new List<House>();

        public Data()
        {
            InitializeComponent();

            LoadHouses();
      
            dataNormalGrid.ItemsSource = objList;
    
        }

        private void LoadHouses()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:56063/");

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/house/GetAllHouses").Result;
            if (response.IsSuccessStatusCode)
            {
                objList = response.Content.ReadAsAsync<List<House>>().Result;
            }
            
        }

        private void LoadStubHouse()
        {
            objList.Add(new House("Youssef", 10));
            objList.Add(new House("Youssef", 10));
            objList.Add(new House("Youssef", 10));
            objList.Add(new House("Youssef", 10));
            objList.Add(new House("Youssef", 10));
            objList.Add(new House("Youssef", 10));
            objList.Add(new House("Youssef", 10));
        }
    }
   
}

