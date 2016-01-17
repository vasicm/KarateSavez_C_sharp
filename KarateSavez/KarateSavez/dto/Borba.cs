using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace KarateSavez.dto
{
    class Borba : ListViewItem
    {
        private string nazivTakmicenja;
        private DateTime datumTakmicenja;
        private string kategorija;
        private string plavi;
        private string crveni;
        private int poeniPlavi;
        private int poeniCrveni;
        private int kaznePlavi;
        private int kazneCrveni;
        private int krug;

        public void kreirajListViewItem()
        {
            base.Text = plavi;
            base.SubItems.AddRange(new string[] {
                                                    " "+poeniPlavi+":"+poeniCrveni+" ",
                                                    crveni
                                                }
            );
        }

        public void popuniObjekat(MySqlDataReader reader)
        {
            this.NazivTakmicenja = reader["nazivTakmicenja"].ToString();
            DateTime.TryParse(reader["datumTakmicenja"].ToString(), out this.datumTakmicenja); 
            this.Kategorija = reader["kategorija"].ToString();
            this.Plavi = reader["plavi"].ToString();
            this.Crveni = reader["crveni"].ToString();
            this.PoeniPlavi = Convert.ToInt32(reader["poeniPlavi"].ToString());
            this.PoeniCrveni = Convert.ToInt32(reader["poeniCrveni"].ToString());
            this.KaznePlavi = Convert.ToInt32(reader["KAZnePlavi"].ToString()); 
            this.KazneCrveni = Convert.ToInt32(reader["kazneCrveni"].ToString());
            this.Krug = Convert.ToInt32(reader["krug"].ToString());

            this.kreirajListViewItem();
        }

        public Borba()
        {
        }

        public Borba(string nazivTakmicenja, DateTime datumTakmicenja, string kategorija, string plavi, string crveni, int poeniPlavi, int poeniCrveni, int kaznePlavi, int kazneCrveni, int krug)
        {
            this.nazivTakmicenja = nazivTakmicenja;
            this.datumTakmicenja = datumTakmicenja;
            this.kategorija = kategorija;
            this.plavi = plavi;
            this.crveni = crveni;
            this.poeniPlavi = poeniPlavi;
            this.poeniCrveni = poeniCrveni;
            this.kaznePlavi = kaznePlavi;
            this.kazneCrveni = kazneCrveni;
            this.krug = krug;

            this.kreirajListViewItem();
        }

        public string Kategorija
        {
            get
            {
                return kategorija;
            }

            set
            {
                kategorija = value;
            }
        }

        public string Plavi
        {
            get
            {
                return plavi;
            }

            set
            {
                plavi = value;
            }
        }

        public string Crveni
        {
            get
            {
                return crveni;
            }

            set
            {
                crveni = value;
            }
        }

        public int PoeniPlavi
        {
            get
            {
                return poeniPlavi;
            }

            set
            {
                poeniPlavi = value;
            }
        }

        public int PoeniCrveni
        {
            get
            {
                return poeniCrveni;
            }

            set
            {
                poeniCrveni = value;
            }
        }

        public int KaznePlavi
        {
            get
            {
                return kaznePlavi;
            }

            set
            {
                kaznePlavi = value;
            }
        }

        public int KazneCrveni
        {
            get
            {
                return kazneCrveni;
            }

            set
            {
                kazneCrveni = value;
            }
        }

        public int Krug
        {
            get
            {
                return krug;
            }

            set
            {
                krug = value;
            }
        }

        public string NazivTakmicenja
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

        public DateTime DatumTakmicenja
        {
            get
            {
                return datumTakmicenja;
            }

            set
            {
                datumTakmicenja = value;
            }
        }
    }
}
