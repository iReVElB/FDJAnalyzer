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
            tabPage_euromillions_stats.SizeChanged += TabPage_euromillions_stats_SizeChanged;
            tabPage_loto_stats.SizeChanged += TabPage_loto_stats_SizeChanged;
            this.Size = new Size(1024, 1024);
        }

        private void TabPage_loto_stats_SizeChanged(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                TabPage tabPage = (TabPage)sender;
                int w = tabPage.Size.Width / 2;
                listView_loto_stats_balls.Width = w;
                listView_loto_stats_stars.Width = w;
            }
        }

        private void TabPage_euromillions_stats_SizeChanged(object? sender, EventArgs e)
        {
            if (sender != null)
            {
                TabPage tabPage = (TabPage)sender;
                int w = tabPage.Size.Width / 2;
                listView_euromillions_stats_balls.Width = w;
                listView_euromillions_stats_stars.Width = w;
            }
        }

        private void form_Load(object sender, EventArgs e)
        {
            EuromillionsFormController euroMillionsFormController = new EuromillionsFormController(this, numericUpDown_euromillions_filter_id, comboBox_euromillions_filter_dateType, dateTimePicker_euromillions_filter_date, dateTimePicker_euromillions_filter_toDate, checkBox_euromillions_filter_all, checkBox_euromillions_filter_hasWinner, label_euromilions_filter_resultCount, button_euromillions_filter_ok, listView_euromillions_results_draws, listView_euromillions_stats_balls, listView_euromillions_stats_stars);
            LotoFormController lotoFormController = new LotoFormController(this, numericUpDown_loto_filter_id, comboBox_loto_filter_dateType, dateTimePicker_loto_filter_date, dateTimePicker_loto_filter_toDate, checkBox_loto_filter_all, checkBox_loto_filter_hasWinner, label_loto_filter_resultCount, button_loto_filter_ok, listView_loto_results_draws, listView_loto_stats_balls, listView_loto_stats_stars);
            KenoFormController kenoFormController = new KenoFormController(this, numericUpDown_keno_filter_id, comboBox_keno_filter_dateType, dateTimePicker_keno_filter_date, dateTimePicker_keno_filter_toDate, label_keno_filter_resultCount, button_keno_filter_ok, listView_keno_results_draws, listView_keno_stats_balls);
        }
    }
}