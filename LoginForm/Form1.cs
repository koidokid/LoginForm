using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void loginBtn_Click(object sender, EventArgs e)
		{
			string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koidokid\Documents\Data5.mdf;Integrated Security=True;Connect Timeout=30";
			using (SqlConnection connection = new SqlConnection(strConn))
			{
				string commandString = "Select Count(*) from USERINFO where USERNAME='" + this.idTextBox.Text + "' and PASSWORD ='" + this.pwTextBox.Text + "'";
				using (SqlDataAdapter adapter = new SqlDataAdapter(commandString, connection))
				{
					DataTable newTable = new DataTable();
					adapter.Fill(newTable);

					if (newTable.Rows[0][0].ToString() == "1")
					{
						Hide();
						MainForm mainForm = new MainForm();
						mainForm.Show();
					}
					else
					{
						MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
					}
				}
			}

			//string strConn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\koidokid\Documents\Data5.mdf;Integrated Security=True;Connect Timeout=30";
			//using (SqlConnection connection = new SqlConnection(strConn))
			//{
			//	string commandString = "Select Count(*) from USERINFO where USERNAME='" + this.idTextBox.Text + "' and PASSWORD ='" + this.pwTextBox.Text + "'";
			//	using (SqlDataAdapter adapter = new SqlDataAdapter(commandString, connection))
			//	{
			//		DataSet dataSet = new DataSet();
			//		adapter.Fill(dataSet);

			//		DataTable dataTable = dataSet.Tables[0];

			//		if (dataTable.Rows[0][0].ToString() == "1")
			//		{
			//			Hide();
			//			MainForm mainForm = new MainForm();
			//			mainForm.Show();
			//		}
			//		else
			//		{
			//			MessageBox.Show("아이디와 비밀번호를 확인해주세요.");
			//		}
			//	}
			//}
		}
	}
}
