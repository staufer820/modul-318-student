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
			this.btnSearch = new System.Windows.Forms.Button();
			this.tbxTo = new System.Windows.Forms.TextBox();
			this.tbxFrom = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.tbxFrom);
			this.panel1.Controls.Add(this.tbxTo);
			this.panel1.Controls.Add(this.btnSearch);
			this.panel1.ForeColor = System.Drawing.Color.LightGray;
			this.panel1.Location = new System.Drawing.Point(60, 34);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(846, 186);
			this.panel1.TabIndex = 6;
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
			this.btnSearch.Location = new System.Drawing.Point(650, 80);
			this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(99, 42);
			this.btnSearch.TabIndex = 0;
			this.btnSearch.Text = "Suchen";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// tbxTo
			// 
			this.tbxTo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbxTo.Location = new System.Drawing.Point(410, 81);
			this.tbxTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tbxTo.Multiline = true;
			this.tbxTo.Name = "tbxTo";
			this.tbxTo.Size = new System.Drawing.Size(164, 41);
			this.tbxTo.TabIndex = 1;
			// 
			// tbxFrom
			// 
			this.tbxFrom.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tbxFrom.Location = new System.Drawing.Point(92, 80);
			this.tbxFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.tbxFrom.Multiline = true;
			this.tbxFrom.Name = "tbxFrom";
			this.tbxFrom.Size = new System.Drawing.Size(164, 41);
			this.tbxFrom.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(38, 24);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Verbindungen Suchen";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(39, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Von:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(347, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 22);
			this.label3.TabIndex = 5;
			this.label3.Text = "Nach:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel1);
			this.panel2.Location = new System.Drawing.Point(2, -2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(969, 651);
			this.panel2.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(968, 649);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "SBB CFF FFS";
			this.TransparencyKey = System.Drawing.Color.Black;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
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
	}
}

