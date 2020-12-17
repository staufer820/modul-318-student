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
	public partial class Form : System.Windows.Forms.Form
	{
		private ITransport transport = new Transport();
		
		public Form()
		{
			InitializeComponent();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (tbxFrom.Text != "" && tbxTo.Text != "")
			{
				try
				{
					Connections con = transport.GetConnections(tbxFrom.Text, tbxTo.Text, Convert.ToDateTime(dtpDate.Text), Convert.ToDateTime(dtpTime.Text));
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

						lblVerbindung.Text = "Von " + tbxFrom.Text + " nach " + tbxTo.Text;
					}
				}
				catch
				{
					MessageBox.Show("Bitte überprüfen Sie Ihre Eingaben");
				}
			}
			else
			{
				MessageBox.Show("Bitte beide Felder ausfüllen");
			}
		}

		private void btnStation_Click(object sender, EventArgs e)
		{
			

			if (tbxStation.Text != "")
			{
				try
				{
					StationBoardRoot station = transport.GetStationBoard(tbxStation.Text, "0");
					if (station.Entries.Count != 0)
					{
						foreach (var con in station.Entries)
						{
							dgvConnections.Rows.Add(con.Name, con.Stop.Departure.ToString().Substring(11, 5), con.To);
						}

						lblVerbindungenVon.Text = "Verbindungen von " + tbxStation.Text;
					}
				}
				catch
				{
					MessageBox.Show("Bitte überprüfen Sie Ihre Eingaben");
				}
			}
			else
			{
				MessageBox.Show("Bitte Feld ausfüllen");
			}
			
		}
	}
}
