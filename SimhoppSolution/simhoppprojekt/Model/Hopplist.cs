﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simhoppprojekt
{
    /// <summary>
    ///  Klassen hopplist har koll på en person. Varje person har en lista med hopp, ett ID,
    ///  ett namn, en förening, ett födelseår, ett kön och en ort.
    /// </summary>
    public class Hopplist
    {
        #region data
        private List<Hopp> Hopplista;
        private int id;
        private string namn;
        private string forening;
        private int fodelsear;
        private string kon;
        private string ort;
        #endregion

        #region constructs

        public Hopplist()
        {
            Hopplista = new List<Hopp>();
            id = -1;
            namn = "";
            forening = "";
            fodelsear = 0;
            kon = "";
            ort = "";
        }

        public Hopplist(int id, string namn, string forening, int fodelsear, string kon, string ort)
        {
            this.Hopplista = new List<Hopp>();
            this.id = id;
            this.namn = namn;
            this.forening = forening;
            this.fodelsear = fodelsear;
            this.kon = kon;
            this.ort = ort;
        }
        #endregion

        #region funks
        public float SvarighetsSumma()
        {
            float sum = 0;
            for (int i = 0; i < this.Hopplista.Count(); i++)
            {
                sum += this.Hopplista[i].getSvarighet();
            }

            return sum;
        }

        public float PoangSumma()
        {
            float sum = 0;
            for (int i = 0; i < this.Hopplista.Count(); i++ )
            {
                sum += this.Hopplista[i].getPoang().poang;
            }

                return sum;
        }

        public float UtraknadPoangSumma()
        {
            float sum = 0;
            for (int i = 0; i < this.Hopplista.Count(); i++)
            {
                sum += this.Hopplista[i].getPoang().utraknadpoang;
            }

            return sum;
        }

        public void AddHopp(Hopp h)
        {
            this.Hopplista.Add(h);
        }

        public void RemoveHopp(int index)
        {
            this.Hopplista.RemoveAt(index);
        }

        public int AntalHopp()
        {
            return this.Hopplista.Count();
        }
        #endregion

        ~Hopplist() { }

        #region getters
        public List<Hopp> getHopplista() { return Hopplista; }
        public string getNamn() { return namn; }
        public int getID() { return id; }
        public string getForening() { return forening; }
        public int getFodelsear() { return fodelsear; }
        public string getKon() { return kon; }
        public string getOrt() { return ort; }
        #endregion

        #region setters
        public void setNamn(string n) { namn = n; }
        public void setID(int id) { this.id = id; }
        public void setForening(string f) { forening = f; }
        public void setFodelsear(int f) { fodelsear = f; }
        public void setKon(string k) { kon = k; }
        public void setOrt(string o) { ort = o; }
        #endregion
    }
}
