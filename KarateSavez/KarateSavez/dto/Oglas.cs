using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KarateSavez.dto
{
    class Oglas : ListViewItem
    {
        private int idOglasa;
        private string naslovOglasa;
        private string tekstOglasa;
        private DateTime datumOglasa;
        private string tipOglasa;

        public void kreirajListViewItem()
        {
            base.Text = naslovOglasa;
            base.SubItems.AddRange(new string[] {
                                                    tekstOglasa,
                                                    datumOglasa.ToString()
                                                }
            );
        }
        
        public void popuniObjekat(MySqlDataReader reader)
        {
            this.idOglasa = Convert.ToInt32(reader["idOglasa"].ToString());
            this.naslovOglasa = reader["naslovOglasa"].ToString();
            this.tekstOglasa = reader["tekstOglasa"].ToString();
            DateTime.TryParse(reader["datumOglasa"].ToString(), out this.datumOglasa);
            this.tipOglasa = reader["tipOglasa"].ToString();
            this.kreirajListViewItem();
        }

        public Oglas()
        {
        }

        public Oglas(int idOglasa, string naslovOglasa, string tekstOglasa, DateTime datumOglasa, string tipOglasa)
        {
            this.IdOglasa = idOglasa;
            this.NaslovOglasa = naslovOglasa;
            this.TekstOglasa = tekstOglasa;
            this.DatumOglasa = datumOglasa;
            this.TipOglasa = tipOglasa;

            this.kreirajListViewItem();
        }
        public int IdOglasa
        {
            get
            {
                return idOglasa;
            }

            set
            {
                idOglasa = value;
            }
        }

        public string NaslovOglasa
        {
            get
            {
                return naslovOglasa;
            }

            set
            {
                naslovOglasa = value;
            }
        }

        public string TekstOglasa
        {
            get
            {
                return tekstOglasa;
            }

            set
            {
                tekstOglasa = value;
            }
        }

        public DateTime DatumOglasa
        {
            get
            {
                return datumOglasa;
            }

            set
            {
                datumOglasa = value;
            }
        }

        public string TipOglasa
        {
            get
            {
                return tipOglasa;
            }

            set
            {
                tipOglasa = value;
            }
        }

    }
}
