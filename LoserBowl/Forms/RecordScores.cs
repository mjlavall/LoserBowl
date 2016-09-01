using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LoserBowl.Models;

namespace LoserBowl.Forms
{
    public partial class RecordScores : Form
    {
        private LoserBowlContext Context => _loserbowl._context;
        private List<Game> Games => Context.Games.Where(g => g.Week == _week).ToList();
        private readonly LoserBowl _loserbowl;
        private readonly int _week;
        private readonly List<Label> _labels = new List<Label>();
        private readonly List<NumericUpDown> _scores = new List<NumericUpDown>();

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }

        public RecordScores(int week, LoserBowl loserbowl)
        {
            InitializeComponent();
            _loserbowl = loserbowl;
            _week = week;
            Text = $"Record Scores - Week {_week}";
            labelWeek.Text = $"Week {_week}";
            PopulateLists();
            PopulateControls();
            AddEventListeners();
        }

        private void AddEventListeners()
        {
            _scores.ForEach(nud => nud.ValueChanged += numericUpDown_ValueChanged);
        }

        private void PopulateLists()
        {
            _labels.Add(label1);
            _labels.Add(label2);
            _labels.Add(label3);
            _labels.Add(label4);
            _labels.Add(label5);
            _labels.Add(label6);
            _labels.Add(label7);
            _labels.Add(label8);
            _labels.Add(label9);
            _labels.Add(label10);
            _labels.Add(label11);
            _labels.Add(label12);
            _labels.Add(label13);
            _labels.Add(label14);
            _labels.Add(label15);
            _labels.Add(label16);
            _labels.Add(label17);
            _labels.Add(label18);
            _labels.Add(label19);
            _labels.Add(label20);
            _labels.Add(label21);
            _labels.Add(label22);
            _labels.Add(label23);
            _labels.Add(label24);
            _labels.Add(label25);
            _labels.Add(label26);
            _labels.Add(label27);
            _labels.Add(label28);
            _labels.Add(label29);
            _labels.Add(label30);
            _labels.Add(label31);
            _labels.Add(label32);

            _scores.Add(numericUpDown1);
            _scores.Add(numericUpDown2);
            _scores.Add(numericUpDown3);
            _scores.Add(numericUpDown4);
            _scores.Add(numericUpDown5);
            _scores.Add(numericUpDown6);
            _scores.Add(numericUpDown7);
            _scores.Add(numericUpDown8);
            _scores.Add(numericUpDown9);
            _scores.Add(numericUpDown10);
            _scores.Add(numericUpDown11);
            _scores.Add(numericUpDown12);
            _scores.Add(numericUpDown13);
            _scores.Add(numericUpDown14);
            _scores.Add(numericUpDown15);
            _scores.Add(numericUpDown16);
            _scores.Add(numericUpDown17);
            _scores.Add(numericUpDown18);
            _scores.Add(numericUpDown19);
            _scores.Add(numericUpDown20);
            _scores.Add(numericUpDown21);
            _scores.Add(numericUpDown22);
            _scores.Add(numericUpDown23);
            _scores.Add(numericUpDown24);
            _scores.Add(numericUpDown25);
            _scores.Add(numericUpDown26);
            _scores.Add(numericUpDown27);
            _scores.Add(numericUpDown28);
            _scores.Add(numericUpDown29);
            _scores.Add(numericUpDown30);
            _scores.Add(numericUpDown31);
            _scores.Add(numericUpDown32);
        }

        private void PopulateControls()
        {
            for (var i = 0; i < Games.Count; i++)
            {
                var home = Games[i].Teams.Single(t => t.Id == Games[i].HomeTeamId);
                var away = Games[i].Teams.Single(t => t.Id == Games[i].AwayTeamId);

                _labels[i*2].Text = away.Name;
                _scores[i*2].Value = Games[i].AwayScore;
                _labels[i*2 + 1].Text = home.Name;
                _scores[i*2 + 1].Value = Games[i].HomeScore;
            }
            for (var i = Games.Count; i < 16; i++)
            {
                _labels[i*2].Visible = false;
                _scores[i*2].Visible = false;
                _labels[i*2 + 1].Visible = false;
                _scores[i*2 + 1].Visible = false;
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            var numericUpDown = sender as NumericUpDown;
            var index = _scores.IndexOf(numericUpDown);
            var home = index%2 == 1;
            var game = Games[index/2];
            var score = numericUpDown?.Value ?? 0;
            if (home)
            {

                game.HomeScore = (int) score;
            }
            else
            {
                game.AwayScore = (int) score;
            }

            Context.SaveChanges();
            _loserbowl.BindData();
        }
    }
}
