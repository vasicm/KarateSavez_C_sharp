using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KarateSavez.dto
{
    class Takmicenje
    {
        private int idTakmicenja;
        private string nazivTakmicenja;
        private DateTime datumPocetka;
        private string organizator;
        private string adresa;

        public void popuniObjekat(MySqlDataReader reader)
        {
            this.idTakmicenja = Convert.ToInt32(reader["idTakmicenja"].ToString());
            this.nazivTakmicenja = reader["nazivTakmicenja"].ToString();
            DateTime.TryParse(reader["datumPocetka"].ToString(), out this.datumPocetka);
            //this.organizator = reader["organizator"].ToString();
            this.adresa = reader["adresa"].ToString();
        }

        public Takmicenje()
        {
        }

        public Takmicenje(int id, string naziv, DateTime datum, string organizator, string adresa)
        {
            this.idTakmicenja = id;
            this.nazivTakmicenja = naziv;
            this.datumPocetka = datum;
            this.organizator = organizator;
            this.adresa = adresa;
        }

        public int Id
        {
            get
            {
                return idTakmicenja;
            }

            set
            {
                idTakmicenja = value;
            }
        }

        public string Naziv
        {
            get
            {
                return nazivTakmicenja;
            }

            set
            {
                nazivTakmicenja = value;
            }
        }

        public DateTime Datum
        {
            get
            {
                return datumPocetka;
            }

            set
            {
                datumPocetka = value;
            }
        }

        public string Organizator
        {
            get
            {
                return organizator;
            }

            set
            {
                organizator = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }
    }
}
