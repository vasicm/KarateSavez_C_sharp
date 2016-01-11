using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KarateSavez.dto
{
    class Borba
    {
        private string takmicenje;
        private string kategorija;
        private string plavi;
        private string crveni;
        private int poeniPlavi;
        private int poeniCrveni;
        private int kaznePlavi;
        private int kazneCrveni;
        private int krug;

        public void popuniObjekat(MySqlDataReader reader)
        {
            //TODO
            this.Takmicenje = reader["takmicenje"].ToString();
            this.Kategorija = reader["kategorija"].ToString();
            this.Plavi = reader["plavi"].ToString();
            this.Crveni = reader["crveni"].ToString();
            this.PoeniPlavi = Convert.ToInt32( reader["poeniPlavi"].ToString());
            this.PoeniCrveni = Convert.ToInt32(reader["poeniCrveni"].ToString());
            this.KaznePlavi = Convert.ToInt32(reader["kaznePlavi"].ToString()); 
            this.KazneCrveni = Convert.ToInt32(reader["kazneCrveni"].ToString());
            this.Krug = Convert.ToInt32(reader["krug"].ToString()); ;
        }

        public Borba()
        {
        }

        public Borba(string takmicenje, string kategorija, string plavi, string crveni, int poeniPlavi, int poeniCrveni, int kaznePlavi, int kazneCrveni, int krug)
        {
            this.Takmicenje = takmicenje;
            this.Kategorija = kategorija;
            this.Plavi = plavi;
            this.Crveni = crveni;
            this.PoeniPlavi = poeniPlavi;
            this.PoeniCrveni = poeniCrveni;
            this.KaznePlavi = kaznePlavi;
            this.KazneCrveni = kazneCrveni;
            this.Krug = krug;
        }

        public string Takmicenje
        {
            get
            {
                return takmicenje;
            }

            set
            {
                takmicenje = value;
            }
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


    }
}
