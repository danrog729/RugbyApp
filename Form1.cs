using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RugbyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SubmitPlayerButton_Click(object sender, EventArgs e)
        {
            // check if the string is empty
            if (string.IsNullOrWhiteSpace(PlayerNameInput.Text))
            {
                MessageBox.Show("Please enter a name!");
                return;
            }

            // get the values from the various boxes
            string newName = PlayerNameInput.Text;
            int newTries = (int)TriesInput.Value;
            int newConversions = (int)ConversionsInput.Value;

            // clear the boxes
            PlayerNameInput.Text = "";
            TriesInput.Value = 0;
            ConversionsInput.Value = 0;

            AddPlayer(GameList,newName,newTries,newConversions);
        }

        private void SubmitGameButton_Click(object sender, EventArgs e)
        {
            // check if the list of players is empty
            if (GameList.Items.Count == 0)
            {
                MessageBox.Show("Please enter a player!");
                return;
            }

            // loop through all players in the game list
            for (int i=0; i<GameList.Items.Count; i++)
            {
                // add the player into the season list
                string playerName = GameList.Items[i].Text;
                int playerTries = Int32.Parse(GameList.Items[i].SubItems[1].Text);
                int playerConversions = Int32.Parse(GameList.Items[i].SubItems[2].Text);
                AddPlayer(SeasonList, playerName, playerTries, playerConversions);
            }

            // clear the game list
            GameList.Items.Clear();
        }

        private void AddPlayer(ListView targetList, string name, int tries, int conversions)
        {
            // if player already exists, add the tries and conversions onto already existing points
            bool newPlayer = true;
            for (int i = 0; i < targetList.Items.Count; i++) // loop through all the items in the game list
            {
                if (targetList.Items[i].Text == name) // found a player in the table with the same name
                {
                    newPlayer = false;
                    targetList.Items[i].SubItems[1].Text = (Int32.Parse(targetList.Items[i].SubItems[1].Text) + tries).ToString();
                    targetList.Items[i].SubItems[2].Text = (Int32.Parse(targetList.Items[i].SubItems[2].Text) + conversions).ToString();
                    break;
                }
            }

            if (newPlayer)
            {
                // new player, add the data to the game table
                ListViewItem newItem = new ListViewItem();
                newItem.Text = name;
                newItem.SubItems.Add(tries.ToString());
                newItem.SubItems.Add(conversions.ToString());
                targetList.Items.Add(newItem);
            }
        }

        private void SortListView(ListView targetList, int subItemIndex)
        {
            bool swapsOccurred = true;
            int counter = 1;
            while (swapsOccurred)
            {
                swapsOccurred = false;
                for (int index=0; index<targetList.Items.Count-counter; index++)
                {
                    if (SwapIfNecessary(targetList, subItemIndex, index, index + 1))
                    {
                        swapsOccurred = true;
                    }
                }
                counter += 1;
            }
        }

        private bool SwapIfNecessary(ListView list, int valueIndex, int Index1, int Index2)
        {
            if (valueIndex != 0) // if its not the name, and requires sorting by numeric value
            {
                int comparisonValueOne = Int32.Parse(list.Items[Index1].SubItems[valueIndex].Text);
                int comparisonValueTwo = Int32.Parse(list.Items[Index2].SubItems[valueIndex].Text);

                if (comparisonValueOne < comparisonValueTwo)
                {
                    // swap values
                    ListViewItem temp = list.Items[Index1];
                    ListViewItem tempItem2 = list.Items[Index2];
                    list.Items[Index2] = new ListViewItem();
                    list.Items[Index1] = tempItem2;
                    list.Items[Index2] = temp;
                    return true;
                }
            }
            else
            {
                string comparisonValueOne = list.Items[Index1].SubItems[valueIndex].Text;
                string comparisonValueTwo = list.Items[Index2].SubItems[valueIndex].Text;
                 
                if (String.Compare(comparisonValueOne, comparisonValueTwo) > 0) // if the first string comes after alphabetically
                {
                    // swap values
                    ListViewItem temp = list.Items[Index1];
                    ListViewItem tempItem2 = list.Items[Index2];
                    list.Items[Index2] = new ListViewItem();
                    list.Items[Index1] = tempItem2;
                    list.Items[Index2] = temp;
                    return true;
                }
            }
            return false;
        }

        private void GameList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(GameList, e.Column);
        }

        private void SeasonList_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortListView(SeasonList, e.Column);
        }
    }
}
