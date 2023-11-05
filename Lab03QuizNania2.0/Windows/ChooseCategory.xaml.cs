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
using System.Windows.Shapes;

namespace Lab03QuizNania2._0.Windows
{
    /// <summary>
    /// Interaction logic for ChooseCategory.xaml
    /// </summary>
    public partial class ChooseCategory : Window
    {
        public ChooseCategory()
        {
            InitializeComponent();
        }

        private void CarsCategory_Click(object sender, RoutedEventArgs e)
        {
            List<string> allCategories = new List<string>();
            allCategories.Add("Cars");
            DefeaultQuiz quiz = new DefeaultQuiz(allCategories);
            quiz.Show();
            this.Close();

        }

        private void SportsCategory_Click(object sender, RoutedEventArgs e)
        {
            List<string> allCategories = new List<string>();
            allCategories.Add("Sports");
            DefeaultQuiz quiz = new DefeaultQuiz(allCategories);
            quiz.Show();
            this.Close();
        }

        private void BrandsCategory_Click(object sender, RoutedEventArgs e)
        {
            List<string> allCategories = new List<string>();
            allCategories.Add("Brands");
            DefeaultQuiz quiz = new DefeaultQuiz(allCategories);
            quiz.Show();
            this.Close();
        }

        private void HipHopCategory_Click(object sender, RoutedEventArgs e)
        {
            List<string> allCategories = new List<string>();
            allCategories.Add("HipHop");
            DefeaultQuiz quiz = new DefeaultQuiz(allCategories);
            quiz.Show();
            this.Close();
        }
    }
}

