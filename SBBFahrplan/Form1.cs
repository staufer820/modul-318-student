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
			lbxLocations.Hide();
			lbxTafel.Hide();
			
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (tbxFrom.Text != "" && tbxTo.Text != "")
			{
				try
				{
					dgvResults.Rows.Clear();
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
					else
					{
						MessageBox.Show("Keine Resultate");
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
					dgvConnections.Rows.Clear();
					StationBoardRoot station = transport.GetStationBoard(tbxStation.Text, "0");
					if (station.Entries.Count != 0)
					{
						foreach (var con in station.Entries)
						{
							dgvConnections.Rows.Add(con.Name, con.Stop.Departure.ToString().Substring(11, 5), con.To);
						}

						lblVerbindungenVon.Text = "Verbindungen von " + tbxStation.Text;
					}
					else
					{
						MessageBox.Show("Keine Resultate");
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
			lbxTafel.Hide();
		}

		private void btnSearchStations_Click(object sender, EventArgs e)
		{
			if (tbxLocation.Text != "")
			{
				try
				{
					dgvStations.Rows.Clear();
					Stations stations = transport.GetStations(tbxLocation.Text);
					if (stations.StationList.Count > 0)
					{
						foreach (var station in stations.StationList)
						{
							string stationname = station.Name;
							dgvStations.Rows.Add(stationname);
						}
					}
					else
					{
						MessageBox.Show("Keine Resultate");
					}
				}
				catch
				{
					MessageBox.Show("Etwas ist schiefgelaufen");
				}
			}
			else
			{
				MessageBox.Show("Bitte das Feld ausfüllen");
			}
			lbxLocations.Hide();
		}

		private void tbxLocation_TextChanged(object sender, EventArgs e)
		{
			if (tbxLocation.Text.Length > 2)
			{
				try
				{
					lbxLocations.Items.Clear();
					Stations stations = transport.GetStations(tbxLocation.Text);
					foreach (var station in stations.StationList)
					{
						lbxLocations.Items.Add(station.Name);
					}

					if (lbxLocations.Items.Count > 0)
					{
						lbxLocations.Show();
					}
					else
					{
						lbxLocations.Hide();
					}
				}
				catch
				{
					lbxLocations.Items.Clear();
					lbxLocations.Hide();
				}
				
			}
			else
			{
				lbxLocations.Hide();
			}
		}

		private void tbxLocation_KeyDown(object sender, KeyEventArgs e)
		{
			if (lbxLocations.Items.Count > 0)
			{
				if (e.KeyCode == Keys.Down)
				{
					lbxLocations.SetSelected(0, true);
					lbxLocations.Focus();
					
				}
			}
		}

		private void lbxLocations_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				tbxLocation.Text = lbxLocations.SelectedItem.ToString();
			}
		}

		private void tbxStation_TextChanged(object sender, EventArgs e)
		{
			if (tbxStation.Text.Length > 2)
			{
				try
				{
					lbxTafel.Items.Clear();
					Stations stations = transport.GetStations(tbxStation.Text);
					foreach (var station in stations.StationList)
					{
						lbxTafel.Items.Add(station.Name);
					}

					if (lbxTafel.Items.Count > 0)
					{
						lbxTafel.Show();
					}
					else
					{
						lbxTafel.Hide();
					}
				}
				catch
				{
					lbxTafel.Items.Clear();
					lbxTafel.Hide();
				}
			}
			else
			{
				lbxTafel.Hide();
			}
		}

		private void tbxStation_KeyDown(object sender, KeyEventArgs e)
		{
			if (lbxTafel.Items.Count > 0)
			{
				if (e.KeyCode == Keys.Down)
				{
					lbxTafel.SetSelected(0, true);
					lbxTafel.Focus();

				}
			}
		}

		private void lbxTafel_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				tbxStation.Text = lbxTafel.SelectedItem.ToString();
			}
		}
	}
}
