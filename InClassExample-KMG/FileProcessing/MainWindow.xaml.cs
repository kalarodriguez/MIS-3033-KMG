using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

namespace FileProcessing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FlowDocument fd = new FlowDocument();
            Paragraph p = new Paragraph();
            Run r = new Run();

            // Read in file

            var bookContents = File.ReadAllText("Pride and Prejudice by Jane Austen.txt");
            r.Text = bookContents;
            r.Foreground = Brushes.BlanchedAlmond;
            r.Background = Brushes.BurlyWood;
            r.FontWeight = FontWeights.Bold;

            p.Inlines.Add(r);
            fd.Blocks.Add(p);
            rtbPride.Document = fd;



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        // Straight forward way of reading in a file
            //string path = @"C:\Users\rodr0095\Downloads\SalesJan2009.csv";
            //var contents = File.ReadAllLines(path);

        //  Alternate way to read in a file - something we would have to use on an exam because of the lab computers

            string path = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Downloads\SalesJan2009.csv";
            var contents = File.ReadAllLines(path);

            lstbxSales.Items.Add(contents);

            

            for (int i = 1; i < contents.Length; i++)
            {
                string row = contents[i];
                var pieces = row.Split(',');
                
                lstbxSales.Items.Add(pieces[1] + " - " + pieces[2]);

            }



            //foreach (var row in contents)
            //{
            //    lstbxSales.Items.Add(row);
            //}


        }
    }
}
