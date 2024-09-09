using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace programming2bpart1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Open the Submit Claim Window
        private void SubmitClaimButton_Click(object sender, RoutedEventArgs e)
        {
            SubmitClaim submitClaimWindow = new SubmitClaim();
            submitClaimWindow.Show();
        }

        // Open the Approve Claims Window
        private void ApproveClaimsButton_Click(object sender, RoutedEventArgs e)
        {
            ApproveClaims approveClaimsWindow = new ApproveClaims();
            approveClaimsWindow.Show();
        }

        // Open the Claim History Window
        private void ClaimHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            ClaimHistory claimHistoryWindow = new ClaimHistory();
            claimHistoryWindow.Show();
        }

        private void ProgrammeCoordinatorButton_Click(object sender, RoutedEventArgs e)
        {
            ProgrammeCoordinator programmeCoordinatorWindow = new ProgrammeCoordinator();
            programmeCoordinatorWindow.Show();
        }

    }
}
