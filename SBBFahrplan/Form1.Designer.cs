namespace SBBFahrplan
{
	partial class Form
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lblVerbindung = new System.Windows.Forms.Label();
			this.dgvResults = new System.Windows.Forms.DataGridView();
			this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbxFrom = new System.Windows.Forms.TextBox();
			this.tbxTo = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lblVerbindungenVon = new System.Windows.Forms.Label();
			this.btnStation = new System.Windows.Forms.Button();
			this.dgvConnections = new System.Windows.Forms.DataGridView();
			this.StationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tbxStation = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lbxLocations = new System.Windows.Forms.ListBox();
			this.dgvStations = new System.Windows.Forms.DataGridView();
			this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSearchStations = new System.Windows.Forms.Button();
			this.tbxLocation = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblConnection = new System.Windows.Forms.Label();
			this.lbxTafel = new System.Windows.Forms.ListBox();
			this.panel2.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tabControl);
			this.panel2.Controls.Add(this.lblConnection);
			this.panel2.Location = new System.Drawing.Point(1, -1);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(713, 650);
			this.panel2.TabIndex = 7;
			// 
			// tabControl
			// 
			this.tabControl.AccessibleName = "";
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(4, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(709, 647);
			this.tabControl.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lblVerbindung);
			this.tabPage1.Controls.Add(this.dgvResults);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 30);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(701, 613);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Verbindungen";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// lblVerbindung
			// 
			this.lblVerbindung.AutoSize = true;
			this.lblVerbindung.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVerbindung.ForeColor = System.Drawing.Color.SaddleBrown;
			this.lblVerbindung.Location = new System.Drawing.Point(51, 205);
			this.lblVerbindung.Name = "lblVerbindung";
			this.lblVerbindung.Size = new System.Drawing.Size(0, 22);
			this.lblVerbindung.TabIndex = 8;
			// 
			// dgvResults
			// 
			this.dgvResults.AllowUserToAddRows = false;
			this.dgvResults.BackgroundColor = System.Drawing.Color.SandyBrown;
			this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Gleis,
            this.Verspätung});
			this.dgvResults.GridColor = System.Drawing.Color.Silver;
			this.dgvResults.Location = new System.Drawing.Point(-3, 256);
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.RowHeadersWidth = 71;
			this.dgvResults.RowTemplate.Height = 24;
			this.dgvResults.Size = new System.Drawing.Size(705, 354);
			this.dgvResults.TabIndex = 7;
			// 
			// Abfahrt
			// 
			this.Abfahrt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Abfahrt.HeaderText = "Abfahrt";
			this.Abfahrt.MinimumWidth = 6;
			this.Abfahrt.Name = "Abfahrt";
			this.Abfahrt.Width = 140;
			// 
			// Ankunft
			// 
			this.Ankunft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Ankunft.HeaderText = "Ankunft";
			this.Ankunft.MinimumWidth = 6;
			this.Ankunft.Name = "Ankunft";
			this.Ankunft.Width = 163;
			// 
			// Gleis
			// 
			this.Gleis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Gleis.HeaderText = "Gleis";
			this.Gleis.MinimumWidth = 6;
			this.Gleis.Name = "Gleis";
			this.Gleis.Width = 163;
			// 
			// Verspätung
			// 
			this.Verspätung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Verspätung.HeaderText = "Verspätung";
			this.Verspätung.MinimumWidth = 6;
			this.Verspätung.Name = "Verspätung";
			this.Verspätung.Width = 170;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.dtpTime);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dtpDate);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.tbxFrom);
			this.panel1.Controls.Add(this.tbxTo);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.ForeColor = System.Drawing.Color.LightGray;
			this.panel1.Location = new System.Drawing.Point(3, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(691, 150);
			this.panel1.TabIndex = 6;
			// 
			// dtpTime
			// 
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtpTime.Location = new System.Drawing.Point(362, 97);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.Size = new System.Drawing.Size(164, 28);
			this.dtpTime.TabIndex = 9;
			this.dtpTime.Value = new System.DateTime(2020, 12, 17, 9, 5, 0, 0);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label5.Location = new System.Drawing.Point(310, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 22);
			this.label5.TabIndex = 8;
			this.label5.Text = "Zeit:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label1.Location = new System.Drawing.Point(24, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 22);
			this.label1.TabIndex = 7;
			this.label1.Text = "Datum:";
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(100, 97);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(164, 28);
			this.dtpDate.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label3.Location = new System.Drawing.Point(299, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nach:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label2.Location = new System.Drawing.Point(47, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Von:";
			// 
			// tbxFrom
			// 
			this.tbxFrom.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbxFrom.Location = new System.Drawing.Point(100, 38);
			this.tbxFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tbxFrom.Multiline = true;
			this.tbxFrom.Name = "tbxFrom";
			this.tbxFrom.Size = new System.Drawing.Size(164, 25);
			this.tbxFrom.TabIndex = 2;
			// 
			// tbxTo
			// 
			this.tbxTo.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbxTo.Location = new System.Drawing.Point(362, 38);
			this.tbxTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tbxTo.Multiline = true;
			this.tbxTo.Name = "tbxTo";
			this.tbxTo.Size = new System.Drawing.Size(164, 26);
			this.tbxTo.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.White;
			this.btnSearch.Location = new System.Drawing.Point(560, 33);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(99, 37);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "Suchen";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.lbxTafel);
			this.tabPage3.Controls.Add(this.lblVerbindungenVon);
			this.tabPage3.Controls.Add(this.btnStation);
			this.tabPage3.Controls.Add(this.dgvConnections);
			this.tabPage3.Controls.Add(this.tbxStation);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Location = new System.Drawing.Point(4, 30);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(701, 613);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Anzeigetafel";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// lblVerbindungenVon
			// 
			this.lblVerbindungenVon.AutoSize = true;
			this.lblVerbindungenVon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblVerbindungenVon.ForeColor = System.Drawing.Color.SaddleBrown;
			this.lblVerbindungenVon.Location = new System.Drawing.Point(37, 143);
			this.lblVerbindungenVon.Name = "lblVerbindungenVon";
			this.lblVerbindungenVon.Size = new System.Drawing.Size(0, 22);
			this.lblVerbindungenVon.TabIndex = 4;
			// 
			// btnStation
			// 
			this.btnStation.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnStation.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnStation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
			this.btnStation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
			this.btnStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStation.ForeColor = System.Drawing.Color.White;
			this.btnStation.Location = new System.Drawing.Point(317, 46);
			this.btnStation.Name = "btnStation";
			this.btnStation.Size = new System.Drawing.Size(114, 31);
			this.btnStation.TabIndex = 3;
			this.btnStation.Text = "Suchen";
			this.btnStation.UseVisualStyleBackColor = false;
			this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
			// 
			// dgvConnections
			// 
			this.dgvConnections.BackgroundColor = System.Drawing.Color.SandyBrown;
			this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StationName,
            this.Departure,
            this.Endstation});
			this.dgvConnections.GridColor = System.Drawing.SystemColors.ControlDarkDark;
			this.dgvConnections.Location = new System.Drawing.Point(0, 191);
			this.dgvConnections.Name = "dgvConnections";
			this.dgvConnections.RowHeadersWidth = 51;
			this.dgvConnections.RowTemplate.Height = 24;
			this.dgvConnections.Size = new System.Drawing.Size(701, 397);
			this.dgvConnections.TabIndex = 2;
			// 
			// StationName
			// 
			this.StationName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.StationName.HeaderText = "Name";
			this.StationName.MinimumWidth = 6;
			this.StationName.Name = "StationName";
			this.StationName.Width = 218;
			// 
			// Departure
			// 
			this.Departure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Departure.HeaderText = "Abfahrt";
			this.Departure.MinimumWidth = 6;
			this.Departure.Name = "Departure";
			this.Departure.Width = 215;
			// 
			// Endstation
			// 
			this.Endstation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Endstation.HeaderText = "Endstation";
			this.Endstation.MinimumWidth = 6;
			this.Endstation.Name = "Endstation";
			this.Endstation.Width = 215;
			// 
			// tbxStation
			// 
			this.tbxStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tbxStation.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbxStation.Location = new System.Drawing.Point(112, 46);
			this.tbxStation.Name = "tbxStation";
			this.tbxStation.Size = new System.Drawing.Size(184, 28);
			this.tbxStation.TabIndex = 1;
			this.tbxStation.TextChanged += new System.EventHandler(this.tbxStation_TextChanged);
			this.tbxStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxStation_KeyDown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
			this.label4.Location = new System.Drawing.Point(33, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Station:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.lbxLocations);
			this.tabPage2.Controls.Add(this.dgvStations);
			this.tabPage2.Controls.Add(this.btnSearchStations);
			this.tabPage2.Controls.Add(this.tbxLocation);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Location = new System.Drawing.Point(4, 30);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(701, 613);
			this.tabPage2.TabIndex = 3;
			this.tabPage2.Text = "Stationen";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// lbxLocations
			// 
			this.lbxLocations.FormattingEnabled = true;
			this.lbxLocations.ItemHeight = 21;
			this.lbxLocations.Location = new System.Drawing.Point(103, 76);
			this.lbxLocations.Name = "lbxLocations";
			this.lbxLocations.Size = new System.Drawing.Size(170, 214);
			this.lbxLocations.TabIndex = 4;
			this.lbxLocations.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxLocations_KeyDown);
			// 
			// dgvStations
			// 
			this.dgvStations.BackgroundColor = System.Drawing.Color.SandyBrown;
			this.dgvStations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SName});
			this.dgvStations.Location = new System.Drawing.Point(-1, 142);
			this.dgvStations.Name = "dgvStations";
			this.dgvStations.RowHeadersWidth = 51;
			this.dgvStations.RowTemplate.Height = 24;
			this.dgvStations.Size = new System.Drawing.Size(702, 475);
			this.dgvStations.TabIndex = 3;
			// 
			// SName
			// 
			this.SName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.SName.HeaderText = "Name";
			this.SName.MinimumWidth = 6;
			this.SName.Name = "SName";
			this.SName.Width = 650;
			// 
			// btnSearchStations
			// 
			this.btnSearchStations.BackColor = System.Drawing.Color.SaddleBrown;
			this.btnSearchStations.FlatAppearance.BorderColor = System.Drawing.Color.SaddleBrown;
			this.btnSearchStations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnSearchStations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
			this.btnSearchStations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearchStations.ForeColor = System.Drawing.Color.White;
			this.btnSearchStations.Location = new System.Drawing.Point(313, 43);
			this.btnSearchStations.Name = "btnSearchStations";
			this.btnSearchStations.Size = new System.Drawing.Size(107, 36);
			this.btnSearchStations.TabIndex = 2;
			this.btnSearchStations.Text = "Suchen";
			this.btnSearchStations.UseVisualStyleBackColor = false;
			this.btnSearchStations.Click += new System.EventHandler(this.btnSearchStations_Click);
			// 
			// tbxLocation
			// 
			this.tbxLocation.Location = new System.Drawing.Point(103, 48);
			this.tbxLocation.Name = "tbxLocation";
			this.tbxLocation.Size = new System.Drawing.Size(171, 28);
			this.tbxLocation.TabIndex = 1;
			this.tbxLocation.TextChanged += new System.EventHandler(this.tbxLocation_TextChanged);
			this.tbxLocation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxLocation_KeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 22);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ort:";
			// 
			// lblConnection
			// 
			this.lblConnection.AutoSize = true;
			this.lblConnection.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConnection.ForeColor = System.Drawing.Color.Red;
			this.lblConnection.Location = new System.Drawing.Point(40, 255);
			this.lblConnection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblConnection.Name = "lblConnection";
			this.lblConnection.Size = new System.Drawing.Size(0, 28);
			this.lblConnection.TabIndex = 8;
			// 
			// lbxTafel
			// 
			this.lbxTafel.FormattingEnabled = true;
			this.lbxTafel.ItemHeight = 21;
			this.lbxTafel.Location = new System.Drawing.Point(112, 76);
			this.lbxTafel.Name = "lbxTafel";
			this.lbxTafel.Size = new System.Drawing.Size(183, 172);
			this.lbxTafel.TabIndex = 5;
			this.lbxTafel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbxTafel_KeyDown);
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(713, 649);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.SaddleBrown;
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximizeBox = false;
			this.Name = "Form";
			this.ShowIcon = false;
			this.Text = "SBB CFF FFS";
			this.TransparencyKey = System.Drawing.Color.Black;
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblConnection;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label lblVerbindung;
		private System.Windows.Forms.DataGridView dgvResults;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbxFrom;
		private System.Windows.Forms.TextBox tbxTo;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label lblVerbindungenVon;
		private System.Windows.Forms.Button btnStation;
		private System.Windows.Forms.DataGridView dgvConnections;
		private System.Windows.Forms.DataGridViewTextBoxColumn StationName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
		private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
		private System.Windows.Forms.TextBox tbxStation;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
		private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DateTimePicker dtpTime;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DataGridView dgvStations;
		private System.Windows.Forms.Button btnSearchStations;
		private System.Windows.Forms.TextBox tbxLocation;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn SName;
		private System.Windows.Forms.ListBox lbxLocations;
		private System.Windows.Forms.ListBox lbxTafel;
	}
}

