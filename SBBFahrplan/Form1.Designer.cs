namespace SBBFahrplan
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbxFrom = new System.Windows.Forms.TextBox();
			this.tbxTo = new System.Windows.Forms.TextBox();
			this.btnSearch = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dgvResults = new System.Windows.Forms.DataGridView();
			this.Abfahrt = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ankunft = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Verspätung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Station = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.lblConnection = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbxStation = new System.Windows.Forms.TextBox();
			this.dgvConnections = new System.Windows.Forms.DataGridView();
			this.Platform = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Endstation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnStation = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbxFrom);
			this.panel1.Controls.Add(this.tbxTo);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.ForeColor = System.Drawing.Color.LightGray;
			this.panel1.Location = new System.Drawing.Point(3, 23);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(691, 173);
			this.panel1.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(295, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nach:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(29, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Von:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(28, 27);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Verbindungen Suchen";
			// 
			// tbxFrom
			// 
			this.tbxFrom.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbxFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbxFrom.Location = new System.Drawing.Point(82, 97);
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
			this.tbxTo.Location = new System.Drawing.Point(358, 97);
			this.tbxTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tbxTo.Multiline = true;
			this.tbxTo.Name = "tbxTo";
			this.tbxTo.Size = new System.Drawing.Size(164, 26);
			this.tbxTo.TabIndex = 1;
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.White;
			this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
			this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.ForeColor = System.Drawing.Color.Red;
			this.btnSearch.Location = new System.Drawing.Point(578, 86);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(99, 42);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "Suchen";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(4, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(709, 647);
			this.tabControl.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dgvResults);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 30);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage1.Size = new System.Drawing.Size(701, 613);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Verbindungen";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dgvResults
			// 
			this.dgvResults.AllowUserToAddRows = false;
			this.dgvResults.BackgroundColor = System.Drawing.Color.White;
			this.dgvResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrt,
            this.Ankunft,
            this.Gleis,
            this.Verspätung});
			this.dgvResults.GridColor = System.Drawing.Color.Silver;
			this.dgvResults.Location = new System.Drawing.Point(0, 280);
			this.dgvResults.Name = "dgvResults";
			this.dgvResults.RowHeadersWidth = 71;
			this.dgvResults.RowTemplate.Height = 24;
			this.dgvResults.Size = new System.Drawing.Size(705, 327);
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
			this.Verspätung.Width = 163;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Station);
			this.tabPage2.Location = new System.Drawing.Point(4, 30);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage2.Size = new System.Drawing.Size(701, 613);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Stationen";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Station
			// 
			this.Station.AutoSize = true;
			this.Station.Location = new System.Drawing.Point(68, 64);
			this.Station.Name = "Station";
			this.Station.Size = new System.Drawing.Size(61, 22);
			this.Station.TabIndex = 0;
			this.Station.Text = "label4";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnStation);
			this.tabPage3.Controls.Add(this.dgvConnections);
			this.tabPage3.Controls.Add(this.tbxStation);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Location = new System.Drawing.Point(4, 30);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPage3.Size = new System.Drawing.Size(701, 613);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Anzeigetafel";
			this.tabPage3.UseVisualStyleBackColor = true;
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
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(33, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Station:";
			// 
			// tbxStation
			// 
			this.tbxStation.Location = new System.Drawing.Point(112, 46);
			this.tbxStation.Name = "tbxStation";
			this.tbxStation.Size = new System.Drawing.Size(184, 28);
			this.tbxStation.TabIndex = 1;
			// 
			// dgvConnections
			// 
			this.dgvConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Platform,
            this.Endstation,
            this.Departure});
			this.dgvConnections.Location = new System.Drawing.Point(36, 135);
			this.dgvConnections.Name = "dgvConnections";
			this.dgvConnections.RowHeadersWidth = 51;
			this.dgvConnections.RowTemplate.Height = 24;
			this.dgvConnections.Size = new System.Drawing.Size(606, 453);
			this.dgvConnections.TabIndex = 2;
			// 
			// Platform
			// 
			this.Platform.HeaderText = "Gleis";
			this.Platform.MinimumWidth = 6;
			this.Platform.Name = "Platform";
			this.Platform.Width = 125;
			// 
			// Endstation
			// 
			this.Endstation.HeaderText = "Endstation";
			this.Endstation.MinimumWidth = 6;
			this.Endstation.Name = "Endstation";
			this.Endstation.Width = 125;
			// 
			// Departure
			// 
			this.Departure.HeaderText = "Abfahrt";
			this.Departure.MinimumWidth = 6;
			this.Departure.Name = "Departure";
			this.Departure.Width = 125;
			// 
			// btnStation
			// 
			this.btnStation.Location = new System.Drawing.Point(317, 46);
			this.btnStation.Name = "btnStation";
			this.btnStation.Size = new System.Drawing.Size(114, 31);
			this.btnStation.TabIndex = 3;
			this.btnStation.Text = "Suchen";
			this.btnStation.UseVisualStyleBackColor = true;
			this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(713, 649);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "SBB CFF FFS";
			this.TransparencyKey = System.Drawing.Color.Black;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvConnections)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxFrom;
		private System.Windows.Forms.TextBox tbxTo;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgvResults;
		private System.Windows.Forms.Label lblConnection;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrt;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ankunft;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
		private System.Windows.Forms.DataGridViewTextBoxColumn Verspätung;
		private System.Windows.Forms.Label Station;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Button btnStation;
		private System.Windows.Forms.DataGridView dgvConnections;
		private System.Windows.Forms.DataGridViewTextBoxColumn Platform;
		private System.Windows.Forms.DataGridViewTextBoxColumn Endstation;
		private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
		private System.Windows.Forms.TextBox tbxStation;
		private System.Windows.Forms.Label label4;
	}
}

