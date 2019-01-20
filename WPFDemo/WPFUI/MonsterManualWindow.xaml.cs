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
    /// Interaction logic for MonsterManualWindow.xaml
    /// </summary>
    public partial class MonsterManualWindow : Window
    {
        public MonsterManualWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WPFUI.DungeonBuddyDataSet dungeonBuddyDataSet = ((WPFUI.DungeonBuddyDataSet)(this.FindResource("dungeonBuddyDataSet")));
            // Load data into the table MonsterIndex. You can modify this code as needed.
            WPFUI.DungeonBuddyDataSetTableAdapters.MonsterIndexTableAdapter dungeonBuddyDataSetMonsterIndexTableAdapter = new WPFUI.DungeonBuddyDataSetTableAdapters.MonsterIndexTableAdapter();
            dungeonBuddyDataSetMonsterIndexTableAdapter.Fill(dungeonBuddyDataSet.MonsterIndex);
            System.Windows.Data.CollectionViewSource monsterIndexViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("monsterIndexViewSource")));
            monsterIndexViewSource.View.MoveCurrentToFirst();
        }
    }
}
