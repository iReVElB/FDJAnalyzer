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
    }
}