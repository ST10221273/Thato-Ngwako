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

namespace programming2bpart1
{
    /// <summary>
    /// Interaction logic for ProgrammeCoordinator.xaml
    /// </summary>
    public partial class ProgrammeCoordinator : Window
    {
        public ProgrammeCoordinator()
        {
            InitializeComponent();
        }

        private void ApproveButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the Approve button click event
            MessageBox.Show("Approve button clicked.");
        }

        private void RejectButton_Click(object sender, RoutedEventArgs e)
        {
            // Handle the Reject button click event
            MessageBox.Show("Reject button clicked.");
        }
    }
}

