using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

namespace _08_ADO.NET_MySQL
{
    public enum TipPrikaza {
        SVI_DATUMI = 0,
        GODISNJI_DATUMI = 1,
        MJESECNI_DATUMI = 2,
        JEDNOKRATNI_DATUMI = 3
    }

    public partial class Form1 : Form
    {
        ArrayList monthlyDates = new ArrayList();
        ArrayList annualDates = new ArrayList();
        ArrayList oneOffDates = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            
            popuniKalendar(TipPrikaza.SVI_DATUMI);
            popuniOpisOdabranogDatuma();
        }

        private void popuniKalendar(TipPrikaza t)
        {
            annualDates.Clear();
            monthlyDates.Clear();
            oneOffDates.Clear();

            MySqlConnection conn = ConnectionPool.checkOutConnection();
            string sql = "select id,datum,tip from dogadjaj where validan=1";
            if (t != TipPrikaza.SVI_DATUMI)
            {
                 sql += " and tip=" + Convert.ToInt32(t);
            }
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = sql;
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                if (t==TipPrikaza.MJESECNI_DATUMI || t==TipPrikaza.SVI_DATUMI)
                {
                    monthlyDates.Add(varchar2Date(reader[1].ToString()));
                }
                if (t == TipPrikaza.GODISNJI_DATUMI || t == TipPrikaza.SVI_DATUMI)
                {
                    annualDates.Add(varchar2Date(reader[1].ToString()));
                }
                if (t == TipPrikaza.JEDNOKRATNI_DATUMI || t == TipPrikaza.SVI_DATUMI)
                {
                    oneOffDates.Add(varchar2Date(reader[1].ToString()));
                }
            }
            reader.Close();
            monthCalendar1.BoldedDates = (DateTime[])(oneOffDates.ToArray(typeof(DateTime)));
            monthCalendar1.MonthlyBoldedDates = (DateTime[])(monthlyDates.ToArray(typeof(DateTime)));
            monthCalendar1.AnnuallyBoldedDates = (DateTime[])(annualDates.ToArray(typeof(DateTime)));
            ConnectionPool.checkInConnection(conn);
        }

        public DateTime varchar2Date(string varchar)
        {
            string[] p = varchar.Split(new string[] { "-" }, StringSplitOptions.None);
            DateTime dt = new DateTime(Convert.ToInt32(p[0]), Convert.ToInt32(p[1]), Convert.ToInt32(p[2]));
            return dt;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) popuniKalendar(TipPrikaza.SVI_DATUMI);
            else if (radioButton2.Checked) popuniKalendar(TipPrikaza.MJESECNI_DATUMI);
            else if (radioButton3.Checked) popuniKalendar(TipPrikaza.GODISNJI_DATUMI);
            else if (radioButton4.Checked) popuniKalendar(TipPrikaza.JEDNOKRATNI_DATUMI);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            popuniOpisOdabranogDatuma();   
        }

        private void popuniOpisOdabranogDatuma()
        {
            MySqlConnection conn = ConnectionPool.checkOutConnection();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "select opis from dogadjaj where validan=1 and datum='" + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd") + "' limit 3";
            MySqlDataReader reader = comm.ExecuteReader();
            string opis = "";
            while (reader.Read())
            {
                opis += reader[0].ToString() + ", ";
            }
            reader.Close();
            ConnectionPool.checkInConnection(conn);
            if (opis.Equals("")) label2.Text = "Ništa nije planirano za odabrani datum.";
            else label2.Text = opis;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = ConnectionPool.checkOutConnection();
            MySqlCommand comm = conn.CreateCommand();
            comm.CommandText = "update dogadjaj set validan=0 where datum='" + monthCalendar1.SelectionStart.ToString("yyyy-MM-dd") + "'";
            comm.ExecuteNonQuery();
            ConnectionPool.checkInConnection(conn);
            if (radioButton1.Checked) popuniKalendar(TipPrikaza.SVI_DATUMI);
            else if (radioButton2.Checked) popuniKalendar(TipPrikaza.MJESECNI_DATUMI);
            else if (radioButton3.Checked) popuniKalendar(TipPrikaza.GODISNJI_DATUMI);
            else if (radioButton4.Checked) popuniKalendar(TipPrikaza.JEDNOKRATNI_DATUMI);
            popuniOpisOdabranogDatuma();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoviDogadjaj nd = new NoviDogadjaj();
            nd.ShowDialog();
            if (radioButton1.Checked) popuniKalendar(TipPrikaza.SVI_DATUMI);
            else if (radioButton2.Checked) popuniKalendar(TipPrikaza.MJESECNI_DATUMI);
            else if (radioButton3.Checked) popuniKalendar(TipPrikaza.GODISNJI_DATUMI);
            else if (radioButton4.Checked) popuniKalendar(TipPrikaza.JEDNOKRATNI_DATUMI);
            popuniOpisOdabranogDatuma();
        }
    }
}
