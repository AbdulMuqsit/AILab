using System.Windows;
using SecondLab.ViewModel;

namespace SecondLab
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new GraphViewModel<int>();
        }
    }
}