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

namespace WpfApp9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

        public partial class MainWindow : Window
        {
            public static RoutedUICommand RedCommand = new RoutedUICommand("Red Command", "RedCommand", typeof(MainWindow));
            public static RoutedUICommand GreenCommand = new RoutedUICommand("Green Command", "GreenCommand", typeof(MainWindow));
            public static RoutedUICommand BlueCommand = new RoutedUICommand("Blue Command", "BlueCommand", typeof(MainWindow));

            public MainWindow()
            {
                InitializeComponent();
            }

            private void RedCommand_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                ChangeButtonColor(btnHotkey, Brushes.Red);
            }

            private void GreenCommand_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                ChangeButtonColor(btnHotkey, Brushes.Green);
            }

            private void BlueCommand_Executed(object sender, ExecutedRoutedEventArgs e)
            {
                ChangeButtonColor(btnHotkey, Brushes.Blue);
            }

            private void ChangeButtonColor(Button button, Brush color)
            {
                button.Background = color;
            }
        }
    }

