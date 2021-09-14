
namespace project_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.idformat = new MetroFramework.Controls.MetroComboBox();
            this.yes = new MetroFramework.Controls.MetroCheckBox();
            this.DateTime = new MetroFramework.Controls.MetroDateTime();
            this.female = new MetroFramework.Controls.MetroRadioButton();
            this.male = new MetroFramework.Controls.MetroRadioButton();
            this.name = new MetroFramework.Controls.MetroTextBox();
            this.id = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.viewall = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Search = new System.Windows.Forms.Button();
            this.searchbox = new MetroFramework.Controls.MetroTextBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.filenamebox = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearall = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.viewReport = new System.Windows.Forms.Button();
            this.metroPanel1.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel3);
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(-1, 28);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1182, 643);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.White;
            this.metroPanel3.Controls.Add(this.idformat);
            this.metroPanel3.Controls.Add(this.yes);
            this.metroPanel3.Controls.Add(this.DateTime);
            this.metroPanel3.Controls.Add(this.female);
            this.metroPanel3.Controls.Add(this.male);
            this.metroPanel3.Controls.Add(this.name);
            this.metroPanel3.Controls.Add(this.id);
            this.metroPanel3.Controls.Add(this.metroPanel4);
            this.metroPanel3.Controls.Add(this.label7);
            this.metroPanel3.Controls.Add(this.label6);
            this.metroPanel3.Controls.Add(this.label5);
            this.metroPanel3.Controls.Add(this.label4);
            this.metroPanel3.Controls.Add(this.label3);
            this.metroPanel3.Controls.Add(this.label2);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(328, 0);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(854, 643);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // idformat
            // 
            this.idformat.FormattingEnabled = true;
            this.idformat.ItemHeight = 23;
            this.idformat.Items.AddRange(new object[] {
            "Passport",
            "Birth Certificate",
            "ID",
            "License"});
            this.idformat.Location = new System.Drawing.Point(616, 149);
            this.idformat.Name = "idformat";
            this.idformat.Size = new System.Drawing.Size(200, 29);
            this.idformat.TabIndex = 21;
            this.idformat.UseSelectable = true;
            // 
            // yes
            // 
            this.yes.AutoSize = true;
            this.yes.Location = new System.Drawing.Point(630, 94);
            this.yes.Name = "yes";
            this.yes.Size = new System.Drawing.Size(40, 15);
            this.yes.TabIndex = 20;
            this.yes.Text = "Yes";
            this.yes.UseSelectable = true;
            // 
            // DateTime
            // 
            this.DateTime.Location = new System.Drawing.Point(616, 25);
            this.DateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.DateTime.Name = "DateTime";
            this.DateTime.Size = new System.Drawing.Size(200, 29);
            this.DateTime.TabIndex = 19;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(247, 154);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(61, 15);
            this.female.TabIndex = 18;
            this.female.Text = "Female";
            this.female.UseSelectable = true;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(161, 155);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(49, 15);
            this.male.TabIndex = 17;
            this.male.Text = "Male";
            this.male.UseSelectable = true;
            // 
            // name
            // 
            // 
            // 
            // 
            this.name.CustomButton.Image = null;
            this.name.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.name.CustomButton.Name = "";
            this.name.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.name.CustomButton.TabIndex = 1;
            this.name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.name.CustomButton.UseSelectable = true;
            this.name.CustomButton.Visible = false;
            this.name.Lines = new string[0];
            this.name.Location = new System.Drawing.Point(149, 83);
            this.name.MaxLength = 32767;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.ShortcutsEnabled = true;
            this.name.Size = new System.Drawing.Size(227, 32);
            this.name.TabIndex = 16;
            this.name.UseSelectable = true;
            this.name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // id
            // 
            // 
            // 
            // 
            this.id.CustomButton.Image = null;
            this.id.CustomButton.Location = new System.Drawing.Point(197, 2);
            this.id.CustomButton.Name = "";
            this.id.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.id.CustomButton.TabIndex = 1;
            this.id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.id.CustomButton.UseSelectable = true;
            this.id.CustomButton.Visible = false;
            this.id.Lines = new string[0];
            this.id.Location = new System.Drawing.Point(149, 25);
            this.id.MaxLength = 32767;
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.id.SelectedText = "";
            this.id.SelectionLength = 0;
            this.id.SelectionStart = 0;
            this.id.ShortcutsEnabled = true;
            this.id.Size = new System.Drawing.Size(227, 32);
            this.id.TabIndex = 15;
            this.id.UseSelectable = true;
            this.id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.viewall);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Controls.Add(this.Search);
            this.metroPanel4.Controls.Add(this.searchbox);
            this.metroPanel4.Controls.Add(this.metroGrid1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 208);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(851, 435);
            this.metroPanel4.TabIndex = 14;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // viewall
            // 
            this.viewall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.viewall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewall.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold);
            this.viewall.ForeColor = System.Drawing.Color.White;
            this.viewall.Location = new System.Drawing.Point(310, 380);
            this.viewall.Name = "viewall";
            this.viewall.Size = new System.Drawing.Size(200, 49);
            this.viewall.TabIndex = 19;
            this.viewall.Text = "Refresh";
            this.viewall.UseVisualStyleBackColor = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "Search By Name";
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Microsoft YaHei", 13F, System.Drawing.FontStyle.Bold);
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(616, 20);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(129, 32);
            this.Search.TabIndex = 17;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // searchbox
            // 
            // 
            // 
            // 
            this.searchbox.CustomButton.Image = null;
            this.searchbox.CustomButton.Location = new System.Drawing.Point(380, 2);
            this.searchbox.CustomButton.Name = "";
            this.searchbox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchbox.CustomButton.TabIndex = 1;
            this.searchbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchbox.CustomButton.UseSelectable = true;
            this.searchbox.CustomButton.Visible = false;
            this.searchbox.Lines = new string[0];
            this.searchbox.Location = new System.Drawing.Point(149, 20);
            this.searchbox.MaxLength = 32767;
            this.searchbox.Name = "searchbox";
            this.searchbox.PasswordChar = '\0';
            this.searchbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchbox.SelectedText = "";
            this.searchbox.SelectionLength = 0;
            this.searchbox.SelectionStart = 0;
            this.searchbox.ShortcutsEnabled = true;
            this.searchbox.Size = new System.Drawing.Size(410, 32);
            this.searchbox.TabIndex = 16;
            this.searchbox.UseSelectable = true;
            this.searchbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(89, 71);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(701, 303);
            this.metroGrid1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(401, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(197, 36);
            this.label7.TabIndex = 13;
            this.label7.Text = "Identity Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(401, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 36);
            this.label6.TabIndex = 12;
            this.label6.Text = "Married";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(401, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date Of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(29, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 36);
            this.label4.TabIndex = 10;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.button1);
            this.metroPanel2.Controls.Add(this.filenamebox);
            this.metroPanel2.Controls.Add(this.label1);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.clearall);
            this.metroPanel2.Controls.Add(this.save);
            this.metroPanel2.Controls.Add(this.viewReport);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(329, 642);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(217, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filenamebox
            // 
            // 
            // 
            // 
            this.filenamebox.CustomButton.Image = null;
            this.filenamebox.CustomButton.Location = new System.Drawing.Point(155, 1);
            this.filenamebox.CustomButton.Name = "";
            this.filenamebox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.filenamebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.filenamebox.CustomButton.TabIndex = 1;
            this.filenamebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.filenamebox.CustomButton.UseSelectable = true;
            this.filenamebox.CustomButton.Visible = false;
            this.filenamebox.Lines = new string[] {
        "File Location"};
            this.filenamebox.Location = new System.Drawing.Point(24, 237);
            this.filenamebox.MaxLength = 32767;
            this.filenamebox.Name = "filenamebox";
            this.filenamebox.PasswordChar = '\0';
            this.filenamebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.filenamebox.SelectedText = "";
            this.filenamebox.SelectionLength = 0;
            this.filenamebox.SelectionStart = 0;
            this.filenamebox.ShortcutsEnabled = true;
            this.filenamebox.Size = new System.Drawing.Size(177, 23);
            this.filenamebox.TabIndex = 8;
            this.filenamebox.Text = "File Location";
            this.filenamebox.UseSelectable = true;
            this.filenamebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.filenamebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(18, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "CV";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(82, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 196);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // clearall
            // 
            this.clearall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.clearall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clearall.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearall.ForeColor = System.Drawing.Color.White;
            this.clearall.Location = new System.Drawing.Point(0, 532);
            this.clearall.Name = "clearall";
            this.clearall.Size = new System.Drawing.Size(329, 111);
            this.clearall.TabIndex = 5;
            this.clearall.Text = "Clear All";
            this.clearall.UseVisualStyleBackColor = false;
            this.clearall.Click += new System.EventHandler(this.clearall_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.save.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.Location = new System.Drawing.Point(0, 415);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(329, 111);
            this.save.TabIndex = 2;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // viewReport
            // 
            this.viewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(140)))));
            this.viewReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewReport.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewReport.ForeColor = System.Drawing.Color.White;
            this.viewReport.Location = new System.Drawing.Point(0, 298);
            this.viewReport.Name = "viewReport";
            this.viewReport.Size = new System.Drawing.Size(329, 111);
            this.viewReport.TabIndex = 4;
            this.viewReport.Text = "View Report";
            this.viewReport.UseVisualStyleBackColor = false;
            this.viewReport.Click += new System.EventHandler(this.viewReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 670);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroComboBox idformat;
        private MetroFramework.Controls.MetroCheckBox yes;
        private MetroFramework.Controls.MetroDateTime DateTime;
        private MetroFramework.Controls.MetroRadioButton female;
        private MetroFramework.Controls.MetroRadioButton male;
        private MetroFramework.Controls.MetroTextBox name;
        private MetroFramework.Controls.MetroTextBox id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Search;
        private MetroFramework.Controls.MetroTextBox searchbox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button clearall;
        private System.Windows.Forms.Button viewReport;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button viewall;
        private MetroFramework.Controls.MetroTextBox filenamebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

