using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace KarateSavez.dto
{
    class Oglas
    {
        private int id;
        private string naziv;
        private string tekst;
        private DateTime datumObjave;

        public void popuniObjekat(MySqlDataReader reader)
        {
            this.id = Convert.ToInt32(reader["id"].ToString());
            this.naziv = reader["naziv"].ToString();
            this.tekst = reader["tekst"].ToString();
            DateTime.TryParse(reader["datumObjave"].ToString(), out this.datumObjave);
        }

        public Oglas()
        {
        }

        public Oglas(int id, string naziv, string tekst, DateTime datumObjave)
        {
            this.id = id;
            this.naziv = naziv;
            this.tekst = tekst;
            this.datumObjave = datumObjave;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public string Tekst
        {
            get
            {
                return tekst;
            }

            set
            {
                tekst = value;
            }
        }

        public DateTime DatumObjave
        {
            get
            {
                return datumObjave;
            }

            set
            {
                datumObjave = value;
            }
        }
    }
}
