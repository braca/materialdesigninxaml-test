using System.Windows;
using DialogHostTest.ViewModels;

namespace DialogHostTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ApplicationViewModel();
        }
    }
}
