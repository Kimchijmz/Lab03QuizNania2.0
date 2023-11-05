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
using Lab03QuizNania2._0.Models;

namespace Lab03QuizNania2._0.Windows
{
    /// <summary>
    /// Interaction logic for CustomQuiz.xaml
    /// </summary>
    public partial class CustomQuiz : Window
    {
        public CustomQuiz()
        {
            InitializeComponent();
        }

        private void SaveQuiz_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
