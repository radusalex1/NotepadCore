using System.Windows;

namespace WPFDynamicTab
{
    /// <summary>
    /// Interaction logic for TabProperty.xaml
    /// </summary>
    public partial class TabProperty : Window
    {
        public TabProperty()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
