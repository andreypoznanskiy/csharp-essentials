using System.Windows;
using NET_Essentials.CodeSamples;

namespace NET_Essentials
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Test(object sender, RoutedEventArgs e)
        {
            AsyncVoidProblem.TestAsyncVoid().Wait();
        }
    }
}