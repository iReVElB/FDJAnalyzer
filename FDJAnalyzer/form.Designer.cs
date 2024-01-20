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
            tabPage4 = new TabPage();
            listView_euromillions_stats_stars = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listView_euromillions_stats_balls = new ListView();
            columnHeader_boules = new ColumnHeader();
            columnHeader_per = new ColumnHeader();
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
            tabControl_base.SuspendLayout();
            tabPage1.SuspendLayout();
            tabControl_euromillions.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            panel_euromillions_filter.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_euromillions_filter_id).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl_base
            // 
            tabControl_base.Controls.Add(tabPage1);
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
            tabControl_euromillions.Controls.Add(tabPage4);
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
            // tabPage4
            // 
            tabPage4.Controls.Add(listView_euromillions_stats_stars);
            tabPage4.Controls.Add(listView_euromillions_stats_balls);
            tabPage4.Location = new Point(4, 32);
            tabPage4.Margin = new Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(2);
            tabPage4.Size = new Size(1000, 878);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Statistiques";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView_euromillions_stats_stars
            // 
            listView_euromillions_stats_stars.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listView_euromillions_stats_stars.Dock = DockStyle.Left;
            listView_euromillions_stats_stars.FullRowSelect = true;
            listView_euromillions_stats_stars.Location = new Point(352, 2);
            listView_euromillions_stats_stars.Name = "listView_euromillions_stats_stars";
            listView_euromillions_stats_stars.Size = new Size(350, 874);
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
            // listView_euromillions_stats_balls
            // 
            listView_euromillions_stats_balls.Columns.AddRange(new ColumnHeader[] { columnHeader_boules, columnHeader_per });
            listView_euromillions_stats_balls.Dock = DockStyle.Left;
            listView_euromillions_stats_balls.FullRowSelect = true;
            listView_euromillions_stats_balls.Location = new Point(2, 2);
            listView_euromillions_stats_balls.Name = "listView_euromillions_stats_balls";
            listView_euromillions_stats_balls.Size = new Size(350, 874);
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
            checkBox_euromillions_filter_all.CheckedChanged += checkBox_euromillions_filter_all_CheckedChanged;
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
            dateTimePicker_euromillions_filter_toDate.Name = "dateTimePicker_euromillions_filter_toDate";
            dateTimePicker_euromillions_filter_toDate.Size = new Size(366, 30);
            dateTimePicker_euromillions_filter_toDate.TabIndex = 8;
            dateTimePicker_euromillions_filter_toDate.Visible = false;
            // 
            // dateTimePicker_euromillions_filter_date
            // 
            dateTimePicker_euromillions_filter_date.Dock = DockStyle.Left;
            dateTimePicker_euromillions_filter_date.Location = new Point(251, 10);
            dateTimePicker_euromillions_filter_date.Name = "dateTimePicker_euromillions_filter_date";
            dateTimePicker_euromillions_filter_date.Size = new Size(366, 30);
            dateTimePicker_euromillions_filter_date.TabIndex = 1;
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
            comboBox_euromillions_filter_dateType.SelectedIndexChanged += comboBox_euromillions_filter_dateType_SelectedIndexChanged;
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
            button_euromillions_filter_ok.Click += button_euromillions_filter_ok_Click;
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
            tabPage4.ResumeLayout(false);
            panel_euromillions_filter.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown_euromillions_filter_id).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl_base;
        private TabPage tabPage1;
        private TabControl tabControl_euromillions;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private ListView listView_euromillions_results_draws;
        private ColumnHeader columnHeader_date;
        private ColumnHeader columnHeader_balls;
        private ColumnHeader columnHeader_stars;
        private ColumnHeader columnHeader_has_winner;
        private Panel panel_euromillions_filter;
        private NumericUpDown numericUpDown_euromillions_filter_id;
        private DateTimePicker dateTimePicker_euromillions_filter_date;
        private Label label1;
        private Label label2;
        private CheckBox checkBox_euromillions_filter_all;
        private CheckBox checkBox_euromillions_filter_hasWinner;
        private Panel panel1;
        private Button button_euromillions_filter_ok;
        private ComboBox comboBox_euromillions_filter_dateType;
        private DateTimePicker dateTimePicker_euromillions_filter_toDate;
        private Panel panel2;
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
    }
}