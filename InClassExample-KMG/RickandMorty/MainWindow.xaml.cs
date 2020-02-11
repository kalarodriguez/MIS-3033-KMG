using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


// Kala Rodriguez

namespace RickandMorty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string apiURL = "https://rickandmortyapi.com/api/character/";

            RickAndMortyAPIResult apiInfo;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(apiURL).Result;

                apiInfo = JsonConvert.DeserializeObject<RickAndMortyAPIResult>(json);
            }

            foreach (var character in apiInfo.results)
            {
                lstCharacter.Items.Add(character);
            }
        }

        private void lstCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // telling the app that the information is ResultObj data type. this code is used to convert.
            ResultObj selectedCharacter = (ResultObj)lstCharacter.SelectedItem;

            // find the image then create a bitmap for the image
            imgCharacter.Source = new BitmapImage(new System.Uri(selectedCharacter.image));
        }
    }
}
