using System;
using System.Collections.Generic;
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

// Kala Rodriguez


namespace WPFExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirstName.Text = "";
            txtLastName.Text = string.Empty;
            txtBirthDate.Text = string.Empty;

        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            listLetters.Items.Clear(); // clear statement must be added at the top, not at the bottom of code.
            string firstName, lastName, birthDate;

            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            birthDate = txtBirthDate.Text;

            string fullName = firstName + " " + lastName;
            DateTime dob = Convert.ToDateTime(birthDate);

            // output every letter of their name into the list box

            foreach (var letter in fullName)
            {
                listLetters.Items.Add(letter);
            }

            listLetters.Items.Add($"You were born on a {dob.DayOfWeek}.");

        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Thank you for using our app!");

            Close();
        }
    }
}
