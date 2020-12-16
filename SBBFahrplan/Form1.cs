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
			if (con.ConnectionList.Count > 0)
			{
				foreach (var c in con.ConnectionList)
				{
					
					string departure = c.From.Departure.ToString().Substring(11, 5);
					string arrival = c.To.Arrival.ToString().Substring(11, 5);
					string platform = c.From.Platform;
					string delay = c.From.Delay.ToString();

					this.dgvResults.Rows.Add(departure, arrival, platform);
				}

				lblConnection.Text = "Von " + tbxFrom.Text + " nach " + tbxTo.Text;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnStation_Click(object sender, EventArgs e)
		{
			Stations station = transport.GetStations(tbxStation.Text);
			
		}
	}
}
