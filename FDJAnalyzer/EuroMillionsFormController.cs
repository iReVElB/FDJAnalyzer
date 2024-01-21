using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FDJAnalyzer
{
    internal class EuroMillionsFormController
    {
        private form form;
        private NumericUpDown numericUpDown_id;
        private ComboBox comboBox_dateType; 
        private DateTimePicker dateTimePicker_date;
        private DateTimePicker dateTimePicker_toDate;
        private CheckBox checkBox_hasWinner_all;
        private CheckBox checkBox_hasWinner;
        private Label label_results_count;
        private Button button_filter;
        private ListView listView_draws;
        private ListView listView_stats_balls;
        private ListView listView_stats_stars;

        private EuroMillionsManager euroMillionsManager = new EuroMillionsManager();

        private EuroMillionsManager.Result? results = null;
        private List<EuroMillionsManager.Draw>? draws = null;
        private List<KeyValuePair<int, KeyValuePair<int, float>>>? ballsStats = null;
        private List<KeyValuePair<int, KeyValuePair<int, float>>>? starsStats = null;

        private bool b_draws_date = true;
        private bool b_draws_winner = true;
        private bool b_statsBalls_balls = true;
        private bool b_statsBalls_per = true;
        private bool b_statsStars_balls = true;
        private bool b_statsStars_per = true;
        public EuroMillionsFormController(form form, NumericUpDown numericUpDown_id, ComboBox comboBox_dateType, DateTimePicker dateTimePicker_date, DateTimePicker dateTimePicker_toDate, CheckBox checkBox_hasWinner_all, CheckBox checkBox_hasWinner, Label label_results_count, Button button_filter, ListView listView_draws, ListView listView_stats_balls, ListView listView_stats_stars) { 
            this.form = form;
            this.numericUpDown_id = numericUpDown_id;
            this.comboBox_dateType = comboBox_dateType;
            this.dateTimePicker_date = dateTimePicker_date;
            this.dateTimePicker_toDate = dateTimePicker_toDate;
            this.checkBox_hasWinner_all = checkBox_hasWinner_all;
            this.checkBox_hasWinner = checkBox_hasWinner;
            this.label_results_count = label_results_count;
            this.button_filter = button_filter;
            this.listView_draws = listView_draws;
            this.listView_stats_balls = listView_stats_balls;
            this.listView_stats_stars = listView_stats_stars;
            this.initComponents();
        }

        private async Task setResults(EuroMillionsManager.Parameters? parameters)
        {
            EuroMillionsManager.Result result = await euroMillionsManager.GetResult(parameters);
            this.results = result;
            this.draws = result.draws;
            this.ballsStats = result.ballsStats.stats;
            this.starsStats = result.starsStats.stats;
        }
        private void sortDrawsByDate(bool? reverse = null)
        {
            if(draws != null)
            {
                if (reverse != null) { this.b_draws_date = (bool)reverse; } else { this.b_draws_date = !this.b_draws_date; } 
                reverse = reverse != null ? reverse : this.b_draws_date;
                this.draws.Sort(delegate (EuroMillionsManager.Draw x, EuroMillionsManager.Draw y)
                {
                    return x.date != null && y.date != null ? x.date.CompareTo(y.date) : -1;
                });
                if ((bool)reverse) { this.draws.Reverse(); }
            }
        }
        private void sortDrawsByWinner(bool? reverse = null)
        {
            if (draws != null)
            {
                if (reverse != null){ this.b_draws_winner = (bool)reverse;} else { this.b_draws_winner = !this.b_draws_winner; }
                reverse = reverse != null ? reverse : this.b_draws_winner;
                this.draws.Sort(delegate (EuroMillionsManager.Draw x, EuroMillionsManager.Draw y)
                {
                    return x.hasWinner != null && y.hasWinner != null ? ((bool)x.hasWinner ? 1 : 0) - ((bool)y.hasWinner ? 1 : 0) : -1;
                });
                if ((bool)reverse) { this.draws.Reverse(); }
            }
        }
        private void refreshItems_listView_draws()
        {
            this.listView_draws.Items.Clear();
            if(this.draws != null)
            {
                List<ListViewItem> listViewItems = new List<ListViewItem>();
                for (int i = 0; i < this.draws.Count; i++) { 
                    EuroMillionsManager.Draw draw = this.draws[i];
                    string[] s = { draw.date != null ? draw.date.ToString() : "?", draw.balls != null ? System.String.Join(" ", draw.balls) : "?", draw.stars != null ? System.String.Join(" ", draw.stars) : "?", draw.hasWinner != null ? draw.hasWinner.ToString().Replace("True", "Oui").Replace("False", "Non") : "?" };
                    listViewItems.Add(new ListViewItem(s));
                }
                this.listView_draws.Items.AddRange(listViewItems.ToArray());
            }
        }
        private void sortStatsBallsByBalls(bool? reverse = null)
        {
            if(ballsStats != null)
            {
                if(reverse != null) { this.b_statsBalls_balls = (bool)reverse; } else { this.b_statsBalls_balls = !this.b_statsBalls_balls; }
                reverse = reverse != null ? reverse : this.b_statsBalls_balls;
                this.ballsStats.Sort(delegate (KeyValuePair<int, KeyValuePair<int, float>> x, KeyValuePair<int, KeyValuePair<int, float>> y) { 
                    return x.Key.CompareTo(y.Key);
                });
                if ((bool)reverse) { this.ballsStats.Reverse(); }
            }
        }
        private void sortStatsBallsByPer(bool? reverse = null)
        {
            if (ballsStats != null)
            {
                if (reverse != null) { this.b_statsBalls_per = (bool)reverse; } else { this.b_statsBalls_per = !this.b_statsBalls_per; }
                reverse = reverse != null ? reverse : this.b_statsBalls_per;
                this.ballsStats.Sort(delegate (KeyValuePair<int, KeyValuePair<int, float>> x, KeyValuePair<int, KeyValuePair<int, float>> y) {
                    return x.Value.Key.CompareTo(y.Value.Key);
                });
                if ((bool)reverse) { this.ballsStats.Reverse(); }
            }
        }
        private void refreshItems_listView_stats_balls()
        {
            this.listView_stats_balls.Items.Clear();
            if(ballsStats != null)
            {
                List<ListViewItem> listViewItems = new List<ListViewItem>();
                for(int i = 0; i < ballsStats.Count; i++)
                {
                    KeyValuePair<int, KeyValuePair<int, float>> keyValuePair = ballsStats[i];
                    int count = keyValuePair.Value.Key;
                    float per = keyValuePair.Value.Value;
                    string[] s = { keyValuePair.Key.ToString(), (per * 100).ToString("F2"), count.ToString() };
                    listViewItems.Add(new ListViewItem(s));
                }
                this.listView_stats_balls.Items.AddRange(listViewItems.ToArray());
            }
        }
        private void sortStatsStarsByStars(bool? reverse = null)
        {
            if (starsStats != null)
            {
                if (reverse != null) { this.b_statsStars_balls = (bool)reverse; } else { this.b_statsStars_balls = !this.b_statsStars_balls; }
                reverse = reverse != null ? reverse : this.b_statsStars_balls;
                this.starsStats.Sort(delegate (KeyValuePair<int, KeyValuePair<int, float>> x, KeyValuePair<int, KeyValuePair<int, float>> y) {
                    return x.Key.CompareTo(y.Key);
                });
                if ((bool)reverse) { this.starsStats.Reverse(); }
            }
        }
        private void sortStatsStarsByPer(bool? reverse = null)
        {
            if (starsStats != null)
            {
                if (reverse != null) { this.b_statsStars_per = (bool)reverse; } else { this.b_statsStars_per = !this.b_statsStars_per; }
                reverse = reverse != null ? reverse : this.b_statsStars_per;
                this.starsStats.Sort(delegate (KeyValuePair<int, KeyValuePair<int, float>> x, KeyValuePair<int, KeyValuePair<int, float>> y) {
                    return x.Value.Key.CompareTo(y.Value.Key);
                });
                if ((bool)reverse) { this.starsStats.Reverse(); }
            }
        }
        private void refreshItems_lisView_stats_stars()
        {
            this.listView_stats_stars.Items.Clear();
            if(starsStats != null)
            {
                List<ListViewItem> listViewItems = new List<ListViewItem>();
                for(int i = 0; i < starsStats.Count; i++)
                {
                    KeyValuePair<int, KeyValuePair<int, float>> keyValuePair = starsStats[i];
                    int count = keyValuePair.Value.Key;
                    float per = keyValuePair.Value.Value;
                    string[] s = { keyValuePair.Key.ToString(), (per * 100).ToString("F2"), count.ToString() };
                    listViewItems.Add(new ListViewItem(s));
                }
                this.listView_stats_stars.Items.AddRange(listViewItems.ToArray());
            }
        }
        private void initComponents()
        {
            this.comboBox_dateType.Items.AddRange(EuroMillionsManager.DateTypes);
            this.comboBox_dateType.SelectedIndex = 0;

            this.checkBox_hasWinner_all.CheckedChanged += CheckBox_hasWinner_all_CheckedChanged;
            this.comboBox_dateType.SelectedIndexChanged += ComboBox_dateType_SelectedIndexChanged;
            this.button_filter.Click += Button_filter_Click;
            this.listView_draws.ColumnClick += ListView_draws_ColumnClick;
            this.listView_stats_balls.ColumnClick += ListView_stats_balls_ColumnClick;
            this.listView_stats_stars.ColumnClick += ListView_stats_stars_ColumnClick;
        }

        private void ListView_stats_stars_ColumnClick(object? sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                sortStatsStarsByStars();
                refreshItems_lisView_stats_stars();
            }
            if (e.Column == 1 || e.Column == 2)
            {
                sortStatsStarsByPer();
                refreshItems_lisView_stats_stars();
            }
        }

        private void ListView_stats_balls_ColumnClick(object? sender, ColumnClickEventArgs e)
        {
            if(e.Column == 0)
            {
                sortStatsBallsByBalls();
                refreshItems_listView_stats_balls();
            }
            if(e.Column == 1 || e.Column == 2)
            {
                sortStatsBallsByPer();
                refreshItems_listView_stats_balls();
            }
        }

        private void ListView_draws_ColumnClick(object? sender, ColumnClickEventArgs e)
        {
            if (e.Column == 0)
            {
                sortDrawsByDate();
                refreshItems_listView_draws();
            }
            if (e.Column == 3)
            {
                sortDrawsByWinner();
                refreshItems_listView_draws();
            }
        }
        private void Button_filter_Click(object? sender, EventArgs e)
        {
            int id = (int)this.numericUpDown_id.Value;
            int date_type = this.comboBox_dateType.SelectedIndex;
            DateOnly date = DateOnly.FromDateTime(this.dateTimePicker_date.Value);
            DateOnly toDate = DateOnly.FromDateTime(this.dateTimePicker_toDate.Value);
            bool hasWinner_all = this.checkBox_hasWinner_all.Checked;
            bool hasWinner = this.checkBox_hasWinner.Checked;
            EuroMillionsManager.Parameters parameters = new EuroMillionsManager.Parameters
            {
                Id = id > 0 ? id : null,
                HasWinner = hasWinner_all ? null : hasWinner ? 1 : 0,
                DateType = date_type > 0 ? (EuroMillionsManager.DateType)date_type - 1 : null,
                Date = date_type > 0 ? date : null,
                ToDate = date_type > 0 && date_type == (int)EuroMillionsManager.DateType.Between ? toDate : null
            };
            Task.Run(async () =>
            {
                await setResults(parameters);
                this.form.Invoke(delegate
                {
                    if (this.draws != null) { this.label_results_count.Text = $"{draws.Count.ToString()} résultat" + (draws.Count > 1 ? "s" : null); }
                    sortDrawsByDate(true);
                    refreshItems_listView_draws();
                    sortStatsBallsByBalls(false);
                    refreshItems_listView_stats_balls();
                    sortStatsStarsByStars(false);
                    refreshItems_lisView_stats_stars();
                });

            });
        }
        private void ComboBox_dateType_SelectedIndexChanged(object? sender, EventArgs e)
        {
            EuroMillionsManager.DateType dateType = (EuroMillionsManager.DateType)this.comboBox_dateType.SelectedIndex;
            this.dateTimePicker_date.Visible = dateType != EuroMillionsManager.DateType.All;
            this.dateTimePicker_toDate.Visible = dateType == EuroMillionsManager.DateType.Between;
            if (this.dateTimePicker_date.Visible) { this.dateTimePicker_toDate.BringToFront(); }
        }
        private void CheckBox_hasWinner_all_CheckedChanged(object? sender, EventArgs e)
        {
            this.checkBox_hasWinner.Visible = !this.checkBox_hasWinner_all.Checked;
        }
    }
}
