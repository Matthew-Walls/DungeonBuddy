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

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DungeonBuddy.DBMain DBMain = new DungeonBuddy.DBMain();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
            System.Windows.Data.CollectionViewSource campaignViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("campaignViewSource")));
            campaignViewSource.View.MoveCurrentToFirst();
        }

        private void LoadData()
        {
            WPFUI.DungeonBuddyDataSet dungeonBuddyDataSet = ((WPFUI.DungeonBuddyDataSet)(this.FindResource("dungeonBuddyDataSet")));
            // Load data into the table Campaign. You can modify this code as needed.
            WPFUI.DungeonBuddyDataSetTableAdapters.CampaignTableAdapter dungeonBuddyDataSetCampaignTableAdapter = new WPFUI.DungeonBuddyDataSetTableAdapters.CampaignTableAdapter();
            dungeonBuddyDataSetCampaignTableAdapter.Fill(dungeonBuddyDataSet.Campaign);

        }

        private void btn_NewCampaign_Click(object sender, RoutedEventArgs e)
        {
            CampaignCreatorWindow CCwindow = new CampaignCreatorWindow(DBMain);
            CCwindow.ShowDialog();
            LoadData(); 
        }

        private void menuItem_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void menuItemMM_Click(object sender, RoutedEventArgs e)
        {
            MonsterManualWindow window = new MonsterManualWindow();
            window.ShowDialog();
        }
    }
}
