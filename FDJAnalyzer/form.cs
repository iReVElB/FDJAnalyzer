using System.Diagnostics;
using System.Windows.Forms;
using static FDJAnalyzer.Program;

namespace FDJAnalyzer
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            EuroMillionsFormController euroMillionsFormController = new EuroMillionsFormController(this, numericUpDown_euromillions_filter_id, comboBox_euromillions_filter_dateType, dateTimePicker_euromillions_filter_date, dateTimePicker_euromillions_filter_toDate, checkBox_euromillions_filter_all, checkBox_euromillions_filter_hasWinner, label_euromilions_filter_resultCount, button_euromillions_filter_ok, listView_euromillions_results_draws, listView_euromillions_stats_balls, listView_euromillions_stats_stars);
        }
        /*

        private void button_euromillions_filter_ok_Click(object sender, EventArgs e)
        {

            int id = (int)numericUpDown_euromillions_filter_id.Value;
            int date_type = comboBox_euromillions_filter_dateType.SelectedIndex;
            DateOnly date = DateOnly.FromDateTime(dateTimePicker_euromillions_filter_date.Value);
            DateOnly toDate = DateOnly.FromDateTime(dateTimePicker_euromillions_filter_toDate.Value);
            bool all = checkBox_euromillions_filter_all.Checked;
            bool hasWinner = checkBox_euromillions_filter_hasWinner.Checked;

            EuroMillions.Parameters parameters = new EuroMillions.Parameters
            {
                Id = id > 0 ? id : null,
                HasWinner = all ? null : hasWinner ? 1 : 0,
                DateType = date_type > 0 ? (EuroMillions.DateType)date_type - 1 : null,
                Date = date_type > 0 ? date : null,
                ToDate = date_type > 0 && date_type == (int)EuroMillions.DateType.Between ? toDate : null
            };
            Task.Run(async () =>
            {
                try
                {
                    EuroMillions.Result result = await euroMillions.getResults(parameters);
                    List<EuroMillions.Draw>? draws = result.draws;
                    IDictionary<int, float> ballsPer = result.ballsStats.per;
                    IDictionary<int, float> starsPer = result.starsStats.per;
                    if (draws != null)
                    {
                        draws.Sort(delegate (EuroMillions.Draw x, EuroMillions.Draw y)
                        {
                            if (x.date != null && y.date != null)
                            {
                                return x.date.CompareTo(y.date);
                            }
                            else
                            {
                                return -1;
                            }
                        });
                        draws.Reverse();

                        List<KeyValuePair<int, float>> ballsPerList = new List<KeyValuePair<int, float>>();
                        ballsPerList = ballsPer.ToList();
                        ballsPerList.Sort(delegate (KeyValuePair<int, float> x, KeyValuePair<int, float> y)
                        {
                            return x.Key - y.Key;
                        });
                        ballsPer = ballsPerList.ToDictionary(x => x.Key, x => x.Value);

                        List<KeyValuePair<int, float>> starsPerList = new List<KeyValuePair<int, float>>();
                        starsPerList = starsPer.ToList();
                        starsPerList.Sort(delegate (KeyValuePair<int, float> x, KeyValuePair<int, float> y)
                        {
                            return x.Key - y.Key;
                        });
                        starsPer = starsPerList.ToDictionary(x => x.Key, x => x.Value);


                        Invoke(new MethodInvoker(delegate
                        {
                            label_euromilions_filter_resultCount.Text = $"{draws.Count.ToString()} résultat" + (draws.Count > 1 ? "s" : null);
                            listView_euromillions_results_draws.Items.Clear();
                            listView_euromillions_stats_balls.Items.Clear();
                            listView_euromillions_stats_stars.Items.Clear();
                        }));

                        List<ListViewItem> list = new List<ListViewItem>();

                        for (int i = 0; i < draws.Count; i++)
                        {
                            EuroMillions.Draw draw = draws[i];
                            string[] s = { draw.date != null ? draw.date.ToString() : "?", draw.balls != null ? String.Join(" ", draw.balls) : "?", draw.stars != null ? String.Join(" ", draw.stars) : "?", draw.hasWinner != null ? draw.hasWinner.ToString().Replace("True", "Oui").Replace("False", "Non") : "?" };
                            list.Add(new ListViewItem(s));
                        }
                        Invoke(new MethodInvoker(delegate
                        {
                            listView_euromillions_results_draws.Items.AddRange(list.ToArray());
                        }));

                        list = new List<ListViewItem>();
                        foreach (KeyValuePair<int, float> per in ballsPer)
                        {
                            string[] s = { per.Key.ToString(), (per.Value * 100).ToString("F2") };
                            ListViewItem listViewItem = new ListViewItem(s);
                            if (result.ballsStats.min.Contains(per.Value))
                            {
                                listViewItem.BackColor = Color.FromArgb(255, 255, 110, 110);
                            }
                            if (result.ballsStats.min[0] == per.Value)
                            {
                                listViewItem.BackColor = Color.Red;
                            }
                            if (result.ballsStats.max.Contains(per.Value))
                            {
                                listViewItem.BackColor = Color.FromArgb(255, 150, 255, 150);
                            }
                            if (result.ballsStats.max[0] == per.Value)
                            {
                                listViewItem.BackColor = Color.FromArgb(255, 0, 255, 0);
                            }
                            list.Add(listViewItem);
                        }
                        Invoke(new MethodInvoker(delegate
                        {
                            listView_euromillions_stats_balls.Items.AddRange(list.ToArray());
                        }));

                        list = new List<ListViewItem>();
                        foreach (KeyValuePair<int, float> per in result.starsStats.per)
                        {
                            string[] s = { per.Key.ToString(), (per.Value * 100).ToString("F2") };
                            ListViewItem listViewItem = new ListViewItem(s);
                            if (result.starsStats.min.Contains(per.Value))
                            {
                                listViewItem.BackColor = Color.FromArgb(255, 255, 110, 110);
                            }
                            if (result.starsStats.min[0] == per.Value)
                            {
                                listViewItem.BackColor = Color.Red;
                            }
                            if (result.starsStats.max.Contains(per.Value))
                            {
                                listViewItem.BackColor = Color.FromArgb(255, 150, 255, 150);
                            }
                            if (result.starsStats.max[0] == per.Value)
                            {
                                listViewItem.BackColor = Color.FromArgb(255, 0, 255, 0);
                            }
                            list.Add(listViewItem);
                        }
                        Invoke(new MethodInvoker(delegate
                        {
                            listView_euromillions_stats_stars.Items.AddRange(list.ToArray());
                        }));
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            });


        }*/
    }
}