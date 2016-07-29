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

namespace Mee_Maker
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

        private void Face_Button_Click(object sender, RoutedEventArgs e)
        {
            FaceOptions.Visibility = Visibility.Visible;
        }

        private void Face_Beige_Click(object sender, RoutedEventArgs e)
        {
            Head.Fill = Brushes.Beige;
        }

        private void Face_Black_Click(object sender, RoutedEventArgs e)
        {
            Head.Fill = Brushes.Black;
        }

        private void Face_Brown_Click(object sender, RoutedEventArgs e)
        {
            Head.Fill = Brushes.Brown;
        }

        private void Eyes_Button_Click(object sender, RoutedEventArgs e)
        {
            EyeOptions.Visibility = Visibility.Visible;
        }

        private void Eyes_Black_Click(object sender, RoutedEventArgs e)
        {
            Left_Eye.Fill = Brushes.Black;
            Right_Eye.Fill = Brushes.Black;
        }

        private void Eyes_Blue_Click(object sender, RoutedEventArgs e)
        {
            Left_Eye.Fill = Brushes.Blue;
            Right_Eye.Fill = Brushes.Blue;
        }

        private void Eyes_Brown_Click(object sender, RoutedEventArgs e)
        {
            Left_Eye.Fill = Brushes.Brown;
            Right_Eye.Fill = Brushes.Brown;
        }

        private void Eyes_Green_Click(object sender, RoutedEventArgs e)
        {
            Left_Eye.Fill = Brushes.Green;
            Right_Eye.Fill = Brushes.Green;
        }

        private void Nose_Button_Click(object sender, RoutedEventArgs e)
        {
            NoseOptions.Visibility = Visibility.Visible;
        }

        private void Nose_Beige_Click(object sender, RoutedEventArgs e)
        {
            Nose.Fill = Brushes.Beige;
        }

        private void Nose_Black_Click(object sender, RoutedEventArgs e)
        {
            Nose.Fill = Brushes.Black;
        }

        private void Nose_Brown_Click(object sender, RoutedEventArgs e)
        {
            Nose.Fill = Brushes.Brown;
        }

        private void Mouth_Button__Click(object sender, RoutedEventArgs e)
        {
            MouthOptions.Visibility = Visibility.Visible;
        }

        private void Mouth_Red_Click(object sender, RoutedEventArgs e)
        {
            Mouth.Fill = Brushes.Red;
        }

        private void Mouth_Black_Click(object sender, RoutedEventArgs e)
        {
            Mouth.Fill = Brushes.Black;
        }

        private void Mouth_Pink_Click(object sender, RoutedEventArgs e)
        {
           Mouth.Fill = Brushes.Pink;
        }

        private void Blemish_Button_Click(object sender, RoutedEventArgs e)
        {
            BlemishOptions.Visibility = Visibility.Visible;
        }

        private void Blemish_Red_Click(object sender, RoutedEventArgs e)
        {
            Blemish.Fill = Brushes.Red;
        }

        private void Blemish_Black_Click(object sender, RoutedEventArgs e)
        {
            Blemish.Fill = Brushes.Black;
        }

        private void Blemish_White_Click(object sender, RoutedEventArgs e)
        {
            Blemish.Fill = Brushes.White;
        }
    }
}
