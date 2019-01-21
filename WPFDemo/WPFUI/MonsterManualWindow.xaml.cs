using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private int totalEntries = 0;
        private int entriesDisplayed = 0;

        public MonsterManualWindow()
        {
            InitializeComponent();
            update();
        }

        private int CountDisplayedEntries()
        {
            return 0;
        }

        private void update()
        {
            entriesDisplayed = monsterIndexDataGrid.Items.Count - 1;
            countText.Text = "( " + entriesDisplayed + " / " + totalEntries + " )";
        }



        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WPFUI.DungeonBuddyDataSet dungeonBuddyDataSet = ((WPFUI.DungeonBuddyDataSet)(this.FindResource("dungeonBuddyDataSet")));
            // Load data into the table MonsterIndex. You can modify this code as needed.
            WPFUI.DungeonBuddyDataSetTableAdapters.MonsterIndexTableAdapter dungeonBuddyDataSetMonsterIndexTableAdapter = new WPFUI.DungeonBuddyDataSetTableAdapters.MonsterIndexTableAdapter();
            dungeonBuddyDataSetMonsterIndexTableAdapter.Fill(dungeonBuddyDataSet.MonsterIndex);
            System.Windows.Data.CollectionViewSource monsterIndexViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("monsterIndexViewSource")));
            monsterIndexViewSource.View.MoveCurrentToFirst();

            totalEntries = dungeonBuddyDataSet.MonsterIndex.Count;
            update();
        }

        private void Btn_AddMonsters_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TB_SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
