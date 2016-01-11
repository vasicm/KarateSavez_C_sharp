using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KarateSavez.dto
{
    class Clan
    {
        private long jmb;
        private string ime;
        private string prezime;
        private string pojas;
        private DateTime godinaRodjenja;
        private string klub;

        public void popuniObjekat(MySqlDataReader reader)
        {
            this.jmb = Convert.ToInt64(reader["jmb"].ToString());
            this.ime = reader["ime"].ToString();
            this.prezime = reader["prezime"].ToString();
            this.pojas = reader["pojas"].ToString();
            DateTime.TryParse(reader["datumRodjenja"].ToString(), out this.godinaRodjenja);
            this.klub = reader["NazivKarateKluba"].ToString() + " " + reader["Sjediste"].ToString();
        }

        public System.Windows.Forms.ListViewItem ListViewItem
        {
            get
            {
                return new System.Windows.Forms.ListViewItem(new string[] {
                            Convert.ToString(jmb),
                            ime,
                            prezime,
                            klub,
                            pojas,
                            godinaRodjenja.ToString()
                            }, 
                            -1);
            }
        }

        public Clan()
        {
        }

        public Clan(long jmb, string ime, string prezime, string pojas, DateTime godinaRodjenja, string klub)
        {
            this.jmb = jmb;
            this.ime = ime;
            this.prezime = prezime;
            this.pojas = pojas;
            this.godinaRodjenja = godinaRodjenja;
            this.klub = klub;
        }

        public long Jmb
        {
            get
            {
                return jmb;
            }

            set
            {
                jmb = value;
            }
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Pojas
        {
            get
            {
                return pojas;
            }

            set
            {
                pojas = value;
            }
        }

        public DateTime GodinaRodjenja
        {
            get
            {
                return godinaRodjenja;
            }

            set
            {
                godinaRodjenja = value;
            }
        }

        public string Klub
        {
            get
            {
                return klub;
            }

            set
            {
                klub = value;
            }
        }
    }
}
