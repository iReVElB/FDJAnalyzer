namespace FDJAnalyzer
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl_base = new TabControl();
            tabPage1 = new TabPage();
            tabControl_euromillions = new TabControl();
            tabPage3 = new TabPage();
            listView_euromillions_results_draws = new ListView();
            columnHeader_date = new ColumnHeader();
            columnHeader_balls = new ColumnHeader();
            columnHeader_stars = new ColumnHeader();
            columnHeader_has_winner = new ColumnHeader();
            tabPage_euromillions_stats = new TabPage();
            listView_euromillions_stats_stars = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            listView_euromillions_stats_balls = new ListView();
            columnHeader_boules = new ColumnHeader();
            columnHeader_per = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            panel_euromillions_filter = new Panel();
            panel4 = new Panel();
            checkBox_euromillions_filter_hasWinner = new CheckBox();
            checkBox_euromillions_filter_all = new CheckBox();
            label3 = new Label();
            panel3 = new Panel();
            dateTimePicker_euromillions_filter_toDate = new DateTimePicker();
            dateTimePicker_euromillions_filter_date = new DateTimePicker();
            comboBox_euromillions_filter_dateType = new ComboBox();
            label2 = new Label();
            panel2 = new Panel();
            numericUpDown_euromillions_filter_id = new NumericUpDown();
            label1 = new Label();
            panel1 = new Panel();
            label_euromilions_filter_resultCount = new Label();
            button_euromillions_filter_ok = new Button();
            tabPage2 = new TabPage();
            tabControl1 = new TabControl();
            tabPage5 = new TabPage();
            listView_loto_results_draws = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            tabPage_loto_stats = new TabPage();
            listView_loto_stats_stars = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            listView_loto_stats_balls = new ListView();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            panel5 = new Panel();
            panel6 = new Panel();
            checkBox_loto_filter_hasWinner = new CheckBox();
            checkBox_loto_filter_all = new CheckBox();
            label4 = new Label();
            panel7 = new Panel();
            dateTimePicker_loto_filter_toDate = new DateTimePicker();
            dateTimePicker_loto_filter_date = new DateTimePicker();
            comboBox_loto_filter_dateType = new ComboBox();
            label5 = new Label();
            panel8 = new Panel();
            numericUpDown_loto_filter_id = new NumericUpDown();
            label6 = new Label();
            panel9 = new Panel();
            label_loto_filter_resultCount = new Label();
            button_loto_filter_ok = new Button();
            tabPage4 = new TabPage();
            tabControl2 = new TabControl();
            tabPage6 = new TabPage();
            listView_keno_results_draws = new ListView();
            columnHeader15 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            tabPage7 = new TabPage();
            listView_keno_stats_balls = new ListView();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            columnHeader24 = new ColumnHeader();
            panel13 = new Panel();
            panel12 = new Panel();
            label_keno_filter_resultCount = new Label();
            button_keno_filter_ok = new Button();
            panel11 = new Panel();
            dateTimePicker_keno_filter_toDate = new DateTimePicker();
            dateTimePicker_keno_filter_date = new DateTimePicker();
            comboBox_keno_filter_dateType = new ComboBox();
            label8 = new Label();
            panel10 = new Panel();
            numericUpDown_keno_filter_id = new NumericUpDown();
            label7 = new Label();
            tabControl_base.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl_euromillions.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage_euromillions_stats.SuspendLayout();
            panel_euromillions_filter.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_euromillions_filter_id).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage_loto_stats.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_loto_filter_id).BeginInit();
            panel9.SuspendLayout();
            tabPage4.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_keno_filter_id).BeginInit();
            SuspendLayout();
            // 
            // tabControl_base
            // 
            tabControl_base.Controls.Add(tabPage1);
            tabControl_base.Controls.Add(tabPage2);
            tabControl_base.Controls.Add(tabPage4);
            tabControl_base.Dock = DockStyle.Fill;
            tabControl_base.Location = new Point(0, 0);
            tabControl_base.Margin = new Padding(2);
            tabControl_base.Name = "tabControl_base";
            tabControl_base.SelectedIndex = 0;
            tabControl_base.Size = new Size(1020, 1143);
            tabControl_base.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabControl_euromillions);
            tabPage1.Controls.Add(panel_euromillions_filter);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1012, 1107);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Euro Millions";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl_euromillions
            // 
            tabControl_euromillions.Controls.Add(tabPage3);
            tabControl_euromillions.Controls.Add(tabPage_euromillions_stats);
            tabControl_euromillions.Dock = DockStyle.Fill;
            tabControl_euromillions.Location = new Point(2, 191);
            tabControl_euromillions.Margin = new Padding(2);
            tabControl_euromillions.Name = "tabControl_euromillions";
            tabControl_euromillions.SelectedIndex = 0;
            tabControl_euromillions.Size = new Size(1008, 914);
            tabControl_euromillions.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(listView_euromillions_results_draws);
            tabPage3.Location = new Point(4, 32);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(1000, 878);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Résultats";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView_euromillions_results_draws
            // 
            listView_euromillions_results_draws.Columns.AddRange(new ColumnHeader[] { columnHeader_date, columnHeader_balls, columnHeader_stars, columnHeader_has_winner });
            listView_euromillions_results_draws.Dock = DockStyle.Fill;
            listView_euromillions_results_draws.FullRowSelect = true;
            listView_euromillions_results_draws.Location = new Point(2, 2);
            listView_euromillions_results_draws.MultiSelect = false;
            listView_euromillions_results_draws.Name = "listView_euromillions_results_draws";
            listView_euromillions_results_draws.Size = new Size(996, 874);
            listView_euromillions_results_draws.TabIndex = 0;
            listView_euromillions_results_draws.UseCompatibleStateImageBehavior = false;
            listView_euromillions_results_draws.View = View.Details;
            // 
            // columnHeader_date
            // 
            columnHeader_date.Text = "Date";
            columnHeader_date.Width = 150;
            // 
            // columnHeader_balls
            // 
            columnHeader_balls.Text = "Boules";
            columnHeader_balls.Width = 200;
            // 
            // columnHeader_stars
            // 
            columnHeader_stars.Text = "Etoilles";
            columnHeader_stars.Width = 200;
            // 
            // columnHeader_has_winner
            // 
            columnHeader_has_winner.Text = "Gagnant";
            columnHeader_has_winner.Width = 100;
            // 
            // tabPage_euromillions_stats
            // 
            tabPage_euromillions_stats.Controls.Add(listView_euromillions_stats_stars);
            tabPage_euromillions_stats.Controls.Add(listView_euromillions_stats_balls);
            tabPage_euromillions_stats.Location = new Point(4, 29);
            tabPage_euromillions_stats.Margin = new Padding(2);
            tabPage_euromillions_stats.Name = "tabPage_euromillions_stats";
            tabPage_euromillions_stats.Padding = new Padding(2);
            tabPage_euromillions_stats.Size = new Size(1000, 881);
            tabPage_euromillions_stats.TabIndex = 1;
            tabPage_euromillions_stats.Text = "Statistiques";
            tabPage_euromillions_stats.UseVisualStyleBackColor = true;
            // 
            // listView_euromillions_stats_stars
            // 
            listView_euromillions_stats_stars.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4 });
            listView_euromillions_stats_stars.Dock = DockStyle.Left;
            listView_euromillions_stats_stars.FullRowSelect = true;
            listView_euromillions_stats_stars.Location = new Point(462, 2);
            listView_euromillions_stats_stars.Name = "listView_euromillions_stats_stars";
            listView_euromillions_stats_stars.Size = new Size(460, 877);
            listView_euromillions_stats_stars.TabIndex = 1;
            listView_euromillions_stats_stars.UseCompatibleStateImageBehavior = false;
            listView_euromillions_stats_stars.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Etoiles";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "% de sorties";
            columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombre de sorties";
            columnHeader4.Width = 180;
            // 
            // listView_euromillions_stats_balls
            // 
            listView_euromillions_stats_balls.Columns.AddRange(new ColumnHeader[] { columnHeader_boules, columnHeader_per, columnHeader3 });
            listView_euromillions_stats_balls.Dock = DockStyle.Left;
            listView_euromillions_stats_balls.FullRowSelect = true;
            listView_euromillions_stats_balls.Location = new Point(2, 2);
            listView_euromillions_stats_balls.Name = "listView_euromillions_stats_balls";
            listView_euromillions_stats_balls.Size = new Size(460, 877);
            listView_euromillions_stats_balls.TabIndex = 0;
            listView_euromillions_stats_balls.UseCompatibleStateImageBehavior = false;
            listView_euromillions_stats_balls.View = View.Details;
            // 
            // columnHeader_boules
            // 
            columnHeader_boules.Text = "Boules";
            columnHeader_boules.Width = 100;
            // 
            // columnHeader_per
            // 
            columnHeader_per.Text = "% de sorties";
            columnHeader_per.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nombre de sorties";
            columnHeader3.Width = 180;
            // 
            // panel_euromillions_filter
            // 
            panel_euromillions_filter.Controls.Add(panel4);
            panel_euromillions_filter.Controls.Add(panel3);
            panel_euromillions_filter.Controls.Add(panel2);
            panel_euromillions_filter.Controls.Add(panel1);
            panel_euromillions_filter.Dock = DockStyle.Top;
            panel_euromillions_filter.Location = new Point(2, 2);
            panel_euromillions_filter.Name = "panel_euromillions_filter";
            panel_euromillions_filter.Size = new Size(1008, 189);
            panel_euromillions_filter.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(checkBox_euromillions_filter_hasWinner);
            panel4.Controls.Add(checkBox_euromillions_filter_all);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 100);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(0, 10, 0, 10);
            panel4.Size = new Size(1008, 50);
            panel4.TabIndex = 11;
            // 
            // checkBox_euromillions_filter_hasWinner
            // 
            checkBox_euromillions_filter_hasWinner.AutoSize = true;
            checkBox_euromillions_filter_hasWinner.Dock = DockStyle.Left;
            checkBox_euromillions_filter_hasWinner.Location = new Point(173, 10);
            checkBox_euromillions_filter_hasWinner.Name = "checkBox_euromillions_filter_hasWinner";
            checkBox_euromillions_filter_hasWinner.Size = new Size(107, 30);
            checkBox_euromillions_filter_hasWinner.TabIndex = 5;
            checkBox_euromillions_filter_hasWinner.Text = "Gagnant";
            checkBox_euromillions_filter_hasWinner.UseVisualStyleBackColor = true;
            checkBox_euromillions_filter_hasWinner.Visible = false;
            // 
            // checkBox_euromillions_filter_all
            // 
            checkBox_euromillions_filter_all.AutoSize = true;
            checkBox_euromillions_filter_all.Checked = true;
            checkBox_euromillions_filter_all.CheckState = CheckState.Checked;
            checkBox_euromillions_filter_all.Dock = DockStyle.Left;
            checkBox_euromillions_filter_all.Location = new Point(100, 10);
            checkBox_euromillions_filter_all.Name = "checkBox_euromillions_filter_all";
            checkBox_euromillions_filter_all.Size = new Size(73, 30);
            checkBox_euromillions_filter_all.TabIndex = 4;
            checkBox_euromillions_filter_all.Text = "Tous";
            checkBox_euromillions_filter_all.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Left;
            label3.Location = new Point(0, 10);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 2;
            label3.Text = "Gagnant";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(dateTimePicker_euromillions_filter_toDate);
            panel3.Controls.Add(dateTimePicker_euromillions_filter_date);
            panel3.Controls.Add(comboBox_euromillions_filter_dateType);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 10, 0, 10);
            panel3.Size = new Size(1008, 50);
            panel3.TabIndex = 10;
            // 
            // dateTimePicker_euromillions_filter_toDate
            // 
            dateTimePicker_euromillions_filter_toDate.Dock = DockStyle.Left;
            dateTimePicker_euromillions_filter_toDate.Location = new Point(617, 10);
            dateTimePicker_euromillions_filter_toDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker_euromillions_filter_toDate.MinDate = new DateTime(2004, 2, 13, 0, 0, 0, 0);
            dateTimePicker_euromillions_filter_toDate.Name = "dateTimePicker_euromillions_filter_toDate";
            dateTimePicker_euromillions_filter_toDate.Size = new Size(366, 30);
            dateTimePicker_euromillions_filter_toDate.TabIndex = 8;
            dateTimePicker_euromillions_filter_toDate.Visible = false;
            // 
            // dateTimePicker_euromillions_filter_date
            // 
            dateTimePicker_euromillions_filter_date.Dock = DockStyle.Left;
            dateTimePicker_euromillions_filter_date.Location = new Point(251, 10);
            dateTimePicker_euromillions_filter_date.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker_euromillions_filter_date.MinDate = new DateTime(2004, 2, 13, 0, 0, 0, 0);
            dateTimePicker_euromillions_filter_date.Name = "dateTimePicker_euromillions_filter_date";
            dateTimePicker_euromillions_filter_date.Size = new Size(366, 30);
            dateTimePicker_euromillions_filter_date.TabIndex = 1;
            dateTimePicker_euromillions_filter_date.Value = new DateTime(2004, 2, 13, 0, 0, 0, 0);
            dateTimePicker_euromillions_filter_date.Visible = false;
            // 
            // comboBox_euromillions_filter_dateType
            // 
            comboBox_euromillions_filter_dateType.Dock = DockStyle.Left;
            comboBox_euromillions_filter_dateType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_euromillions_filter_dateType.Location = new Point(100, 10);
            comboBox_euromillions_filter_dateType.Name = "comboBox_euromillions_filter_dateType";
            comboBox_euromillions_filter_dateType.Size = new Size(151, 31);
            comboBox_euromillions_filter_dateType.TabIndex = 7;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Left;
            label2.Location = new Point(0, 10);
            label2.Name = "label2";
            label2.Size = new Size(100, 30);
            label2.TabIndex = 3;
            label2.Text = "Date";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown_euromillions_filter_id);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 10, 0, 10);
            panel2.Size = new Size(1008, 50);
            panel2.TabIndex = 9;
            // 
            // numericUpDown_euromillions_filter_id
            // 
            numericUpDown_euromillions_filter_id.Dock = DockStyle.Left;
            numericUpDown_euromillions_filter_id.Location = new Point(100, 10);
            numericUpDown_euromillions_filter_id.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown_euromillions_filter_id.Name = "numericUpDown_euromillions_filter_id";
            numericUpDown_euromillions_filter_id.Size = new Size(150, 30);
            numericUpDown_euromillions_filter_id.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Left;
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 2;
            label1.Text = "ID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.Controls.Add(label_euromilions_filter_resultCount);
            panel1.Controls.Add(button_euromillions_filter_ok);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 149);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 40);
            panel1.TabIndex = 6;
            // 
            // label_euromilions_filter_resultCount
            // 
            label_euromilions_filter_resultCount.Dock = DockStyle.Right;
            label_euromilions_filter_resultCount.Location = new Point(488, 0);
            label_euromilions_filter_resultCount.Name = "label_euromilions_filter_resultCount";
            label_euromilions_filter_resultCount.Size = new Size(426, 40);
            label_euromilions_filter_resultCount.TabIndex = 1;
            label_euromilions_filter_resultCount.Text = "0 résultat";
            label_euromilions_filter_resultCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_euromillions_filter_ok
            // 
            button_euromillions_filter_ok.Dock = DockStyle.Right;
            button_euromillions_filter_ok.Location = new Point(914, 0);
            button_euromillions_filter_ok.Name = "button_euromillions_filter_ok";
            button_euromillions_filter_ok.Size = new Size(94, 40);
            button_euromillions_filter_ok.TabIndex = 0;
            button_euromillions_filter_ok.Text = "Filtrer";
            button_euromillions_filter_ok.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tabControl1);
            tabPage2.Controls.Add(panel5);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1012, 1110);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Loto";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage_loto_stats);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 192);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1006, 915);
            tabControl1.TabIndex = 3;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(listView_loto_results_draws);
            tabPage5.Location = new Point(4, 32);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(2);
            tabPage5.Size = new Size(998, 879);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Résultats";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // listView_loto_results_draws
            // 
            listView_loto_results_draws.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView_loto_results_draws.Dock = DockStyle.Fill;
            listView_loto_results_draws.FullRowSelect = true;
            listView_loto_results_draws.Location = new Point(2, 2);
            listView_loto_results_draws.MultiSelect = false;
            listView_loto_results_draws.Name = "listView_loto_results_draws";
            listView_loto_results_draws.Size = new Size(994, 875);
            listView_loto_results_draws.TabIndex = 0;
            listView_loto_results_draws.UseCompatibleStateImageBehavior = false;
            listView_loto_results_draws.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Date";
            columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Boules";
            columnHeader6.Width = 200;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Etoille";
            columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Gagnant";
            columnHeader8.Width = 100;
            // 
            // tabPage_loto_stats
            // 
            tabPage_loto_stats.Controls.Add(listView_loto_stats_stars);
            tabPage_loto_stats.Controls.Add(listView_loto_stats_balls);
            tabPage_loto_stats.Location = new Point(4, 29);
            tabPage_loto_stats.Margin = new Padding(2);
            tabPage_loto_stats.Name = "tabPage_loto_stats";
            tabPage_loto_stats.Padding = new Padding(2);
            tabPage_loto_stats.Size = new Size(998, 882);
            tabPage_loto_stats.TabIndex = 1;
            tabPage_loto_stats.Text = "Statistiques";
            tabPage_loto_stats.UseVisualStyleBackColor = true;
            // 
            // listView_loto_stats_stars
            // 
            listView_loto_stats_stars.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10, columnHeader11 });
            listView_loto_stats_stars.Dock = DockStyle.Left;
            listView_loto_stats_stars.FullRowSelect = true;
            listView_loto_stats_stars.Location = new Point(462, 2);
            listView_loto_stats_stars.Name = "listView_loto_stats_stars";
            listView_loto_stats_stars.Size = new Size(460, 878);
            listView_loto_stats_stars.TabIndex = 1;
            listView_loto_stats_stars.UseCompatibleStateImageBehavior = false;
            listView_loto_stats_stars.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Etoiles";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "% de sorties";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Nombre de sorties";
            columnHeader11.Width = 180;
            // 
            // listView_loto_stats_balls
            // 
            listView_loto_stats_balls.Columns.AddRange(new ColumnHeader[] { columnHeader12, columnHeader13, columnHeader14 });
            listView_loto_stats_balls.Dock = DockStyle.Left;
            listView_loto_stats_balls.FullRowSelect = true;
            listView_loto_stats_balls.Location = new Point(2, 2);
            listView_loto_stats_balls.Name = "listView_loto_stats_balls";
            listView_loto_stats_balls.Size = new Size(460, 878);
            listView_loto_stats_balls.TabIndex = 0;
            listView_loto_stats_balls.UseCompatibleStateImageBehavior = false;
            listView_loto_stats_balls.View = View.Details;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Boules";
            columnHeader12.Width = 100;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "% de sorties";
            columnHeader13.Width = 150;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Nombre de sorties";
            columnHeader14.Width = 180;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel9);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(1006, 189);
            panel5.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(checkBox_loto_filter_hasWinner);
            panel6.Controls.Add(checkBox_loto_filter_all);
            panel6.Controls.Add(label4);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 100);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(0, 10, 0, 10);
            panel6.Size = new Size(1006, 50);
            panel6.TabIndex = 11;
            // 
            // checkBox_loto_filter_hasWinner
            // 
            checkBox_loto_filter_hasWinner.AutoSize = true;
            checkBox_loto_filter_hasWinner.Dock = DockStyle.Left;
            checkBox_loto_filter_hasWinner.Location = new Point(173, 10);
            checkBox_loto_filter_hasWinner.Name = "checkBox_loto_filter_hasWinner";
            checkBox_loto_filter_hasWinner.Size = new Size(107, 30);
            checkBox_loto_filter_hasWinner.TabIndex = 5;
            checkBox_loto_filter_hasWinner.Text = "Gagnant";
            checkBox_loto_filter_hasWinner.UseVisualStyleBackColor = true;
            checkBox_loto_filter_hasWinner.Visible = false;
            // 
            // checkBox_loto_filter_all
            // 
            checkBox_loto_filter_all.AutoSize = true;
            checkBox_loto_filter_all.Checked = true;
            checkBox_loto_filter_all.CheckState = CheckState.Checked;
            checkBox_loto_filter_all.Dock = DockStyle.Left;
            checkBox_loto_filter_all.Location = new Point(100, 10);
            checkBox_loto_filter_all.Name = "checkBox_loto_filter_all";
            checkBox_loto_filter_all.Size = new Size(73, 30);
            checkBox_loto_filter_all.TabIndex = 4;
            checkBox_loto_filter_all.Text = "Tous";
            checkBox_loto_filter_all.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Location = new Point(0, 10);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 2;
            label4.Text = "Gagnant";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            panel7.Controls.Add(dateTimePicker_loto_filter_toDate);
            panel7.Controls.Add(dateTimePicker_loto_filter_date);
            panel7.Controls.Add(comboBox_loto_filter_dateType);
            panel7.Controls.Add(label5);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 50);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(0, 10, 0, 10);
            panel7.Size = new Size(1006, 50);
            panel7.TabIndex = 10;
            // 
            // dateTimePicker_loto_filter_toDate
            // 
            dateTimePicker_loto_filter_toDate.Dock = DockStyle.Left;
            dateTimePicker_loto_filter_toDate.Location = new Point(617, 10);
            dateTimePicker_loto_filter_toDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker_loto_filter_toDate.MinDate = new DateTime(2008, 10, 6, 0, 0, 0, 0);
            dateTimePicker_loto_filter_toDate.Name = "dateTimePicker_loto_filter_toDate";
            dateTimePicker_loto_filter_toDate.Size = new Size(366, 30);
            dateTimePicker_loto_filter_toDate.TabIndex = 8;
            dateTimePicker_loto_filter_toDate.Visible = false;
            // 
            // dateTimePicker_loto_filter_date
            // 
            dateTimePicker_loto_filter_date.Dock = DockStyle.Left;
            dateTimePicker_loto_filter_date.Location = new Point(251, 10);
            dateTimePicker_loto_filter_date.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker_loto_filter_date.MinDate = new DateTime(2008, 10, 6, 0, 0, 0, 0);
            dateTimePicker_loto_filter_date.Name = "dateTimePicker_loto_filter_date";
            dateTimePicker_loto_filter_date.Size = new Size(366, 30);
            dateTimePicker_loto_filter_date.TabIndex = 1;
            dateTimePicker_loto_filter_date.Visible = false;
            // 
            // comboBox_loto_filter_dateType
            // 
            comboBox_loto_filter_dateType.Dock = DockStyle.Left;
            comboBox_loto_filter_dateType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_loto_filter_dateType.Location = new Point(100, 10);
            comboBox_loto_filter_dateType.Name = "comboBox_loto_filter_dateType";
            comboBox_loto_filter_dateType.Size = new Size(151, 31);
            comboBox_loto_filter_dateType.TabIndex = 7;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Left;
            label5.Location = new Point(0, 10);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 3;
            label5.Text = "Date";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            panel8.Controls.Add(numericUpDown_loto_filter_id);
            panel8.Controls.Add(label6);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(0, 10, 0, 10);
            panel8.Size = new Size(1006, 50);
            panel8.TabIndex = 9;
            // 
            // numericUpDown_loto_filter_id
            // 
            numericUpDown_loto_filter_id.Dock = DockStyle.Left;
            numericUpDown_loto_filter_id.Location = new Point(100, 10);
            numericUpDown_loto_filter_id.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown_loto_filter_id.Name = "numericUpDown_loto_filter_id";
            numericUpDown_loto_filter_id.Size = new Size(150, 30);
            numericUpDown_loto_filter_id.TabIndex = 0;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Left;
            label6.Location = new Point(0, 10);
            label6.Name = "label6";
            label6.Size = new Size(100, 30);
            label6.TabIndex = 2;
            label6.Text = "ID";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            panel9.Controls.Add(label_loto_filter_resultCount);
            panel9.Controls.Add(button_loto_filter_ok);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 149);
            panel9.Name = "panel9";
            panel9.Size = new Size(1006, 40);
            panel9.TabIndex = 6;
            // 
            // label_loto_filter_resultCount
            // 
            label_loto_filter_resultCount.Dock = DockStyle.Right;
            label_loto_filter_resultCount.Location = new Point(486, 0);
            label_loto_filter_resultCount.Name = "label_loto_filter_resultCount";
            label_loto_filter_resultCount.Size = new Size(426, 40);
            label_loto_filter_resultCount.TabIndex = 1;
            label_loto_filter_resultCount.Text = "0 résultat";
            label_loto_filter_resultCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_loto_filter_ok
            // 
            button_loto_filter_ok.Dock = DockStyle.Right;
            button_loto_filter_ok.Location = new Point(912, 0);
            button_loto_filter_ok.Name = "button_loto_filter_ok";
            button_loto_filter_ok.Size = new Size(94, 40);
            button_loto_filter_ok.TabIndex = 0;
            button_loto_filter_ok.Text = "Filtrer";
            button_loto_filter_ok.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(tabControl2);
            tabPage4.Controls.Add(panel13);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1012, 1107);
            tabPage4.TabIndex = 2;
            tabPage4.Text = "Keno";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage6);
            tabControl2.Controls.Add(tabPage7);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 144);
            tabControl2.Margin = new Padding(2);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1012, 963);
            tabControl2.TabIndex = 14;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(listView_keno_results_draws);
            tabPage6.Location = new Point(4, 32);
            tabPage6.Margin = new Padding(2);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(2);
            tabPage6.Size = new Size(1004, 927);
            tabPage6.TabIndex = 0;
            tabPage6.Text = "Résultats";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // listView_keno_results_draws
            // 
            listView_keno_results_draws.Columns.AddRange(new ColumnHeader[] { columnHeader15, columnHeader16 });
            listView_keno_results_draws.Dock = DockStyle.Fill;
            listView_keno_results_draws.FullRowSelect = true;
            listView_keno_results_draws.Location = new Point(2, 2);
            listView_keno_results_draws.MultiSelect = false;
            listView_keno_results_draws.Name = "listView_keno_results_draws";
            listView_keno_results_draws.Size = new Size(1000, 923);
            listView_keno_results_draws.TabIndex = 0;
            listView_keno_results_draws.UseCompatibleStateImageBehavior = false;
            listView_keno_results_draws.View = View.Details;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Date";
            columnHeader15.Width = 180;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Boules";
            columnHeader16.Width = 600;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(listView_keno_stats_balls);
            tabPage7.Location = new Point(4, 29);
            tabPage7.Margin = new Padding(2);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(2);
            tabPage7.Size = new Size(1004, 930);
            tabPage7.TabIndex = 1;
            tabPage7.Text = "Statistiques";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // listView_keno_stats_balls
            // 
            listView_keno_stats_balls.Columns.AddRange(new ColumnHeader[] { columnHeader22, columnHeader23, columnHeader24 });
            listView_keno_stats_balls.Dock = DockStyle.Fill;
            listView_keno_stats_balls.FullRowSelect = true;
            listView_keno_stats_balls.Location = new Point(2, 2);
            listView_keno_stats_balls.Name = "listView_keno_stats_balls";
            listView_keno_stats_balls.Size = new Size(1000, 926);
            listView_keno_stats_balls.TabIndex = 0;
            listView_keno_stats_balls.UseCompatibleStateImageBehavior = false;
            listView_keno_stats_balls.View = View.Details;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Boules";
            columnHeader22.Width = 100;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "% de sorties";
            columnHeader23.Width = 150;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Nombre de sorties";
            columnHeader24.Width = 180;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel12);
            panel13.Controls.Add(panel11);
            panel13.Controls.Add(panel10);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 0);
            panel13.Name = "panel13";
            panel13.Size = new Size(1012, 144);
            panel13.TabIndex = 13;
            // 
            // panel12
            // 
            panel12.Controls.Add(label_keno_filter_resultCount);
            panel12.Controls.Add(button_keno_filter_ok);
            panel12.Dock = DockStyle.Bottom;
            panel12.Location = new Point(0, 104);
            panel12.Name = "panel12";
            panel12.Size = new Size(1012, 40);
            panel12.TabIndex = 13;
            // 
            // label_keno_filter_resultCount
            // 
            label_keno_filter_resultCount.Dock = DockStyle.Right;
            label_keno_filter_resultCount.Location = new Point(492, 0);
            label_keno_filter_resultCount.Name = "label_keno_filter_resultCount";
            label_keno_filter_resultCount.Size = new Size(426, 40);
            label_keno_filter_resultCount.TabIndex = 1;
            label_keno_filter_resultCount.Text = "0 résultat";
            label_keno_filter_resultCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button_keno_filter_ok
            // 
            button_keno_filter_ok.Dock = DockStyle.Right;
            button_keno_filter_ok.Location = new Point(918, 0);
            button_keno_filter_ok.Name = "button_keno_filter_ok";
            button_keno_filter_ok.Size = new Size(94, 40);
            button_keno_filter_ok.TabIndex = 0;
            button_keno_filter_ok.Text = "Filtrer";
            button_keno_filter_ok.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(dateTimePicker_keno_filter_toDate);
            panel11.Controls.Add(dateTimePicker_keno_filter_date);
            panel11.Controls.Add(comboBox_keno_filter_dateType);
            panel11.Controls.Add(label8);
            panel11.Dock = DockStyle.Top;
            panel11.Location = new Point(0, 50);
            panel11.Name = "panel11";
            panel11.Padding = new Padding(0, 10, 0, 10);
            panel11.Size = new Size(1012, 50);
            panel11.TabIndex = 12;
            // 
            // dateTimePicker_keno_filter_toDate
            // 
            dateTimePicker_keno_filter_toDate.Dock = DockStyle.Left;
            dateTimePicker_keno_filter_toDate.Location = new Point(617, 10);
            dateTimePicker_keno_filter_toDate.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker_keno_filter_toDate.MinDate = new DateTime(2004, 2, 13, 0, 0, 0, 0);
            dateTimePicker_keno_filter_toDate.Name = "dateTimePicker_keno_filter_toDate";
            dateTimePicker_keno_filter_toDate.Size = new Size(366, 30);
            dateTimePicker_keno_filter_toDate.TabIndex = 8;
            dateTimePicker_keno_filter_toDate.Visible = false;
            // 
            // dateTimePicker_keno_filter_date
            // 
            dateTimePicker_keno_filter_date.Dock = DockStyle.Left;
            dateTimePicker_keno_filter_date.Location = new Point(251, 10);
            dateTimePicker_keno_filter_date.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker_keno_filter_date.MinDate = new DateTime(2004, 2, 13, 0, 0, 0, 0);
            dateTimePicker_keno_filter_date.Name = "dateTimePicker_keno_filter_date";
            dateTimePicker_keno_filter_date.Size = new Size(366, 30);
            dateTimePicker_keno_filter_date.TabIndex = 1;
            dateTimePicker_keno_filter_date.Value = new DateTime(2004, 2, 13, 0, 0, 0, 0);
            dateTimePicker_keno_filter_date.Visible = false;
            // 
            // comboBox_keno_filter_dateType
            // 
            comboBox_keno_filter_dateType.Dock = DockStyle.Left;
            comboBox_keno_filter_dateType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_keno_filter_dateType.Location = new Point(100, 10);
            comboBox_keno_filter_dateType.Name = "comboBox_keno_filter_dateType";
            comboBox_keno_filter_dateType.Size = new Size(151, 31);
            comboBox_keno_filter_dateType.TabIndex = 7;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Left;
            label8.Location = new Point(0, 10);
            label8.Name = "label8";
            label8.Size = new Size(100, 30);
            label8.TabIndex = 3;
            label8.Text = "Date";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            panel10.Controls.Add(numericUpDown_keno_filter_id);
            panel10.Controls.Add(label7);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 0);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(0, 10, 0, 10);
            panel10.Size = new Size(1012, 50);
            panel10.TabIndex = 11;
            // 
            // numericUpDown_keno_filter_id
            // 
            numericUpDown_keno_filter_id.Dock = DockStyle.Left;
            numericUpDown_keno_filter_id.Location = new Point(100, 10);
            numericUpDown_keno_filter_id.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            numericUpDown_keno_filter_id.Name = "numericUpDown_keno_filter_id";
            numericUpDown_keno_filter_id.Size = new Size(150, 30);
            numericUpDown_keno_filter_id.TabIndex = 0;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Left;
            label7.Location = new Point(0, 10);
            label7.Name = "label7";
            label7.Size = new Size(100, 30);
            label7.TabIndex = 2;
            label7.Text = "ID";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 1143);
            Controls.Add(tabControl_base);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 5, 4, 5);
            Name = "form";
            Text = "FDJ Analyzer";
            Load += form_Load;
            tabControl_base.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabControl_euromillions.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage_euromillions_stats.ResumeLayout(false);
            panel_euromillions_filter.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_euromillions_filter_id).EndInit();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage_loto_stats.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_loto_filter_id).EndInit();
            panel9.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPage6.ResumeLayout(false);
            tabPage7.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_keno_filter_id).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_base;
        private TabPage tabPage1;
        private TabControl tabControl_euromillions;
        private TabPage tabPage3;
        private TabPage tabPage_euromillions_stats;
        private ListView listView_euromillions_results_draws;
        private ColumnHeader columnHeader_date;
        private ColumnHeader columnHeader_balls;
        private ColumnHeader columnHeader_stars;
        private ColumnHeader columnHeader_has_winner;
        private Panel panel_euromillions_filter;
        private DateTimePicker dateTimePicker_euromillions_filter_date;
        private Label label2;
        private CheckBox checkBox_euromillions_filter_all;
        private CheckBox checkBox_euromillions_filter_hasWinner;
        private Panel panel1;
        private Button button_euromillions_filter_ok;
        private ComboBox comboBox_euromillions_filter_dateType;
        private DateTimePicker dateTimePicker_euromillions_filter_toDate;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label_euromilions_filter_resultCount;
        private ListView listView_euromillions_stats_balls;
        private ColumnHeader columnHeader_boules;
        private ColumnHeader columnHeader_per;
        private ListView listView_euromillions_stats_stars;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader3;
        private TabPage tabPage2;
        private Panel panel5;
        private Panel panel6;
        private CheckBox checkBox_loto_filter_hasWinner;
        private CheckBox checkBox_loto_filter_all;
        private Label label4;
        private Panel panel7;
        private DateTimePicker dateTimePicker_loto_filter_toDate;
        private DateTimePicker dateTimePicker_loto_filter_date;
        private ComboBox comboBox_loto_filter_dateType;
        private Label label5;
        private Panel panel8;
        private NumericUpDown numericUpDown_loto_filter_id;
        private Label label6;
        private Panel panel9;
        private Label label_loto_filter_resultCount;
        private Button button_loto_filter_ok;
        private TabControl tabControl1;
        private TabPage tabPage5;
        private ListView listView_loto_results_draws;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private TabPage tabPage_loto_stats;
        private ListView listView_loto_stats_stars;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ListView listView_loto_stats_balls;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private TabPage tabPage4;
        private Panel panel2;
        private NumericUpDown numericUpDown_euromillions_filter_id;
        private Label label1;
        private Panel panel13;
        private Panel panel12;
        private Label label_keno_filter_resultCount;
        private Button button_keno_filter_ok;
        private Panel panel11;
        private DateTimePicker dateTimePicker_keno_filter_toDate;
        private DateTimePicker dateTimePicker_keno_filter_date;
        private ComboBox comboBox_keno_filter_dateType;
        private Label label8;
        private Panel panel10;
        private NumericUpDown numericUpDown_keno_filter_id;
        private Label label7;
        private TabControl tabControl2;
        private TabPage tabPage6;
        private ListView listView_keno_results_draws;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader16;
        private TabPage tabPage7;
        private ListView listView_keno_stats_balls;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private ColumnHeader columnHeader24;
    }
}