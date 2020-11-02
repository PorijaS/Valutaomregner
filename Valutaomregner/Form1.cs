using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Valutaomregner
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
		
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			using var reader = XmlReader.Create("https://www.nationalbanken.dk/_vti_bin/DN/DataService.svc/CurrencyRatesXML?lang=en");
			
			var xs = new XmlSerializer(typeof(Valutakurser));
			Valutakurser VK = (Valutakurser)xs.Deserialize(reader);

			DataTable DT = new DataTable();
			DT.Columns.Add("text");
			DT.Columns.Add("value");
			DT.Rows.Add("---SELECT---", 0);

			DataTable DT2 = new DataTable();
			DT2.Columns.Add("text2");
			DT2.Columns.Add("value2");
			DT2.Rows.Add("---SELECT---", 0);

			foreach (Currency CS in VK.dailyRates.Currencies)
			{
				DT.Rows.Add(CS.Code, CS.Rate);
				DT2.Rows.Add(CS.Code, CS.Rate);
			}

			comboBox1.DataSource = DT.DefaultView;
			comboBox1.DisplayMember = "text";
			comboBox1.ValueMember = "value";
			comboBox1.SelectedIndex = 0;


			comboBox2.DataSource = DT2.DefaultView;
			comboBox2.DisplayMember = "text2";
			comboBox2.ValueMember = "value2";
			comboBox2.SelectedIndex = 0;
		}

		[XmlRoot(ElementName = "exchangerates")]
		public class Valutakurser
		{
			[XmlAttribute]
			public DateTime id { get; set; }

			[XmlElement("dailyrates")]
			public DailyRates dailyRates { get; set; }
		}

		public class DailyRates
		{
			[XmlElement("currency")]
			public List<Currency> Currencies { get; set; }
		}

		public class Currency
		{
			[XmlAttribute("code")]
			public string Code { get; set; }

			[XmlAttribute("desc")]
			public string Desc { get; set; }

			[XmlAttribute("rate")]
			public double Rate { get; set; }

			public Currency() { }

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		public void conv_btn_Click(object sender, EventArgs e)
		{
			double ConvertedValue;

			if (amount_text.Text == null || amount_text.Text.Trim() == "")
			{
				MessageBox.Show("Please Enter Currency", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				amount_text.Focus();
				return;
			}
			else if (comboBox1.SelectedValue == null || comboBox1.SelectedIndex == 0)
			{
				MessageBox.Show("Please Select Currency From", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				comboBox1.Focus();
				return;
			}
			else if (comboBox2.SelectedValue == null || comboBox2.SelectedIndex == 0)
			{
				MessageBox.Show("Please Select Currency To", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				comboBox2.Focus();
				return;
			}

			if (comboBox1.Text == comboBox2.Text)
			{
				ConvertedValue = double.Parse(amount_text.Text);
				display_txt.Text = comboBox2.Text + " " + ConvertedValue.ToString("N3");
			}
			else
			{
				ConvertedValue = (double.Parse(comboBox1.SelectedValue.ToString()) * double.Parse(amount_text.Text)) / double.Parse(comboBox2.SelectedValue.ToString());
				display_txt.Text = comboBox2.Text + " " + ConvertedValue.ToString("N3");
			}
		}

		private void clear_btn_Click(object sender, EventArgs e)
		{
			ClearControls();
		}

		private void ClearControls()
		{
			amount_text.Text = string.Empty;
			if (comboBox1.Items.Count > 0)
				comboBox1.SelectedIndex = 0;
			if (comboBox2.Items.Count > 0)
				comboBox2.SelectedIndex = 0;
			display_txt.Text = "";
			amount_text.Focus();
		}

		private void display_txt_Click(object sender, EventArgs e)
		{

		}

		private void SwitchBTN_Click(object sender, EventArgs e)
		{
			SwitchControls();
		}

		private void SwitchControls()
		{
			int temp;

			if (comboBox1.SelectedIndex > 0)
			{

				temp = comboBox1.SelectedIndex;
				comboBox1.SelectedIndex = comboBox2.SelectedIndex;
				comboBox2.SelectedIndex = temp;
			}
		}
	}
}	
