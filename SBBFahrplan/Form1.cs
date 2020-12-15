using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SBBFahrplan
{
	public partial class Form1 : Form
	{
		private ITransport transport = new Transport();
		
		public Form1()
		{
			InitializeComponent();
			
			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Connections con = transport.GetConnections(tbxFrom.Text, tbxTo.Text);
			foreach (var c in con.ConnectionList)
			{
				DateTime departure = Convert.ToDateTime(c.From.Departure);
				DateTime arrival = Convert.ToDateTime(c.To.Arrival);
				string platform = c.From.Platform;
				
				
				
				this.dgvResults.Rows.Add(departure, arrival, platform);
			}
		}
	}
}
