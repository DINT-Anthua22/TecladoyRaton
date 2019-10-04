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

namespace TecladoRaton
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Mayusculas_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Mayusculas_TextBox.CharacterCasing = CharacterCasing.Upper;
        }


        private void AyudaTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "TextBox 2";
        }

        private void Mayusculas_TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "TextBox 1";
        }

        private void SinVocalesTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "TextBox 3";
        }

        private void AyudaTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "";
        }

        private void SinVocalesTextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "";
        }

        private void Mayusculas_TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "";
        }

        private void SinVocalesTextBox_MouseEnter_1(object sender, MouseEventArgs e)
        {
            RatonSobreTextBox.Text = "TextBox 3";
        }

        private void Mayusculas_TextBox_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            FocoTextBox.Text = "TextBox 1";
        }

        private void AyudaTextBox_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            FocoTextBox.Text = "TextBox 2";
        }



        private void SinVocalesTextBox_IsKeyboardFocusWithinChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            FocoTextBox.Text = "TextBox 3";
        }

        private void ClicksColor(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                BotonIzquierdoTextBox.Background = Brushes.Green;
            }
            else
            {
                BotonIzquierdoTextBox.Background = Brushes.White;
            }
            if (e.RightButton == MouseButtonState.Pressed)
            {
                BotonDerechoTextBox.Background = Brushes.Green;
            }
            else
            {
                BotonDerechoTextBox.Background = Brushes.White;
            }
        }

        private void AyudaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                AyudaTextBox.Text = "Ayuda";
            }
        }

        private void SinVocalesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.A || e.Key == Key.E || e.Key == Key.I || e.Key == Key.O || e.Key == Key.U)
            {
                e.Handled = true;
            }
        }

    }
}
