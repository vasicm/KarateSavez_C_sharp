using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace _08_ADO.NET_MySQL
{
    public partial class NoviDogadjaj : Form
    {
        public NoviDogadjaj()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionPool.checkOutConnection();
            MySqlCommand comm = conn.CreateCommand();
            string tip="2";
            if(radioButton2.Checked) tip="1";
            else if(radioButton3.Checked) tip="3";
            comm.CommandText = "insert into dogadjaj (id,datum,opis,tip,validan) values (null,'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + textBox1.Text + "'," + tip + ",1)";
            comm.ExecuteNonQuery();
            ConnectionPool.checkInConnection(conn);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionPool.checkOutConnection();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandType = CommandType.StoredProcedure;
            comm.CommandText = "dodaj_dogadjaj";
            MySqlParameter paramDatum = new MySqlParameter("pDatum", MySqlDbType.Date);
            paramDatum.Value = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            paramDatum.Direction = ParameterDirection.Input;
            MySqlParameter paramOpis = new MySqlParameter("pOpis", MySqlDbType.VarChar);
            paramOpis.Value = textBox1.Text;
            paramOpis.Direction = ParameterDirection.Input;
            MySqlParameter paramTip = new MySqlParameter("pTip", MySqlDbType.Int32);
            string tip = "2";
            if (radioButton2.Checked) tip = "1";
            else if (radioButton3.Checked) tip = "3";
            paramTip.Value = Convert.ToInt32(tip);
            paramTip.Direction = ParameterDirection.Input;
            MySqlParameter paramId = new MySqlParameter("pId", MySqlDbType.Int32);
            paramId.Direction = ParameterDirection.Output;

            comm.Parameters.Add(paramDatum);
            comm.Parameters.Add(paramOpis);
            comm.Parameters.Add(paramTip);
            comm.Parameters.Add(paramId);

            comm.ExecuteNonQuery();
            string rezultat = paramId.Value.ToString();
            ConnectionPool.checkInConnection(conn);
            MessageBox.Show("Generisani ID: " + rezultat);
            this.Close();
        }
    }
}
