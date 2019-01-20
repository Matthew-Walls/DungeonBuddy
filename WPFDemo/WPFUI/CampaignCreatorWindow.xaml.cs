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

namespace WPFUI
{
    /// <summary>
    /// Interaction logic for CampaignCreatorWindow.xaml
    /// </summary>
    public partial class CampaignCreatorWindow : Window
    {
        private DungeonBuddy.DBMain DBMain;
        public CampaignCreatorWindow(DungeonBuddy.DBMain dBMain)
        {
            InitializeComponent();
            DBMain = dBMain;
        }

        private void btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            DBMain.CreateCampaign(TB_title.Text, TB_DM.Text, tb_descrip.Text, DateTime.Now);
            Close();
        }
    }
}
