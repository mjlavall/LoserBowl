using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoserBowl.Models;

namespace LoserBowl.Forms
{
    public partial class LoserBowl : Form
    {
        private readonly LoserBowlContext _context = new LoserBowlContext();
        private List<Game> Games => _context.Games.Where(g => g.Week == (int) numericUpDownWeek.Value).ToList();
        private List<CheckedListBox> DivisionListBoxes => new List<CheckedListBox>
        {
            checkedListBoxAFCEast, checkedListBoxAFCWest, checkedListBoxAFCNorth, checkedListBoxAFCSouth,
            checkedListBoxNFCEast, checkedListBoxNFCWest, checkedListBoxNFCNorth, checkedListBoxNFCSouth
        };
        private int Week => (int) numericUpDownWeek.Value;

        public LoserBowl()
        {
            InitializeComponent();
            numericUpDownWeek.Value = _context.Teams.Count(t => t.Selected > 0) + 1;
            BindData();
            UpdateGames();
        }

        public void BindData()
        {
            UpdateGames();
            UpdateTeams();
        }

        private void UpdateGames()
        {
            listBoxGames.DataSource = Games;
            listBoxGames.DisplayMember = "MatchDisplay";
        }

        private void UpdateTeams()
        {
            var teamsPlaying = new List<Team>();
            foreach (var game in Games) teamsPlaying.AddRange(game.Teams.Where(t => t.Selected == 0 || t.Selected == Week).ToList());

            UpdateDivision(teamsPlaying.Where(t => t.Division == "AFC East"), checkedListBoxAFCEast);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "AFC West"), checkedListBoxAFCWest);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "AFC North"), checkedListBoxAFCNorth);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "AFC South"), checkedListBoxAFCSouth);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "NFC East"), checkedListBoxNFCEast);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "NFC West"), checkedListBoxNFCWest);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "NFC North"), checkedListBoxNFCNorth);
            UpdateDivision(teamsPlaying.Where(t => t.Division == "NFC South"), checkedListBoxNFCSouth);
            DivisionListBoxes.ForEach(dlb => dlb.SelectedItem = null);
        }

        private static void UpdateDivision(IEnumerable<Team> teamsPlaying, CheckedListBox checkedListBox)
        {
            checkedListBox.DataSource = teamsPlaying.OrderBy(t => t.Rank).ToList();
            checkedListBox.DisplayMember = "RankedDisplay";
            for (var i = 0; i < checkedListBox.Items.Count; i++) checkedListBox.SetItemChecked(i, ((Team)checkedListBox.Items[i]).Selected > 0);
        }

        private void numericUpDownWeek_ValueChanged(object sender, EventArgs e)
        {
            BindData();
        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var checkedListBox = (CheckedListBox)sender;
            var checkedItem = checkedListBox.Items[e.Index] as Team;
            if (checkedItem != null) checkedItem.Selected = e.NewValue == CheckState.Checked ? Week : 0;
            foreach (var clb in DivisionListBoxes)
            {
                for (var i = 0; i < clb.Items.Count; i++)
                {
                    if (clb == checkedListBox && i == e.Index) continue;
                    var team = (Team)clb.Items[i];
                    team.Selected = 0;
                    clb.SetItemChecked(i, false);
                    clb.SelectedItem = null;
                }
            }

            _context.SaveChanges();
        }
    }
}
