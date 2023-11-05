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
using Lab03QuizNania2._0.Models;
using Lab03QuizNania2._0.Windows;

namespace Lab03QuizNania2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            public MainWindow()
            {
                JSON.GetAllQuizQuestionsJSON();
                InitializeComponent();
            }

            private void ListBoxItem_Quiz(object sender, RoutedEventArgs e)
            {
                List<string> allCategories = new List<string>();
                DefeaultQuiz WindowQuiz = new DefeaultQuiz(allCategories);
                WindowQuiz.Show();
                this.Close();
            }

            private void ListBoxItem_Category(object sender, RoutedEventArgs e)
            {
                ChooseCategory WindowCategory = new ChooseCategory();
                WindowCategory.Show();
                this.Close();

            }


            private void ListBoxItem_CustomQuiz(object sender, RoutedEventArgs e)
            {
                CustomQuiz WindowCustomQuiz = new CustomQuiz();
                WindowCustomQuiz.Show();
                this.Close();
            }

            private void ListBoxItem_Exit(object sender, RoutedEventArgs e)
            {
                this.Close();
            }

        }
    }

