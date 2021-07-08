using System.Windows;
using MyStandardLibrary;

namespace dotNetWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = NameBox.Text;
            
            MyTextBox.Text = MyLogger.PrintGreeting(name);
            
        }        
    }
}
