﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

using simhoppprojekt;

namespace simhopp_TEST
{
    [TestFixture]
    class tavlingsTest
    {
        private TavlingsClass T1 = null;
        [SetUp]
        public void setup()
        {
            List<Hopplist> Hopplistor1 = new List<Hopplist>();

            #region Kurt
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(10);
            tempbetyg.Add(8.5f);
            tempbetyg.Add(9f);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(6);
            Hopp temphopp1 = new Hopp( 101, "A", 1.5f, 3, tempbetyg);

            Hopplist hl1 = new Hopplist(1, "Kurt", "gyttorp sf", 1990, "man", "gyttorp");
            hl1.AddHopp(temphopp1);

            tempbetyg.Clear();

            tempbetyg.Add(10);
            tempbetyg.Add(9.5f);
            tempbetyg.Add(7);
            tempbetyg.Add(5);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            tempbetyg.Add(9.5f);
            Hopp temphopp2 = new Hopp(302, "B", 2f, 3, tempbetyg);

            hl1.AddHopp(temphopp2);

            tempbetyg.Clear();

            tempbetyg.Add(10);
            tempbetyg.Add(8.5f);
            tempbetyg.Add(9);
            tempbetyg.Add(8);
            tempbetyg.Add(8);
            tempbetyg.Add(6);
            tempbetyg.Add(6.5f);
            Hopp temphopp3 = new Hopp(201, "C", 3f, 3, tempbetyg);

            hl1.AddHopp(temphopp2);
            Hopplistor1.Add(hl1);
            #endregion

            #region Sven

            tempbetyg.Clear();
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            tempbetyg.Add(1f);
            tempbetyg.Add(1);
            tempbetyg.Add(1);
            tempbetyg.Add(2);
            tempbetyg.Add(2);
            Hopp temphopp4 = new Hopp(101, "A", 1.5f, 3, tempbetyg);

            Hopplist hl2 = new Hopplist(2, "Sven", "gyttorp sf", 1990, "man", "gyttorp");
            hl2.AddHopp(temphopp4);

            tempbetyg.Clear();

            tempbetyg.Add(1);
            tempbetyg.Add(2.5f);
            tempbetyg.Add(2);
            tempbetyg.Add(3);
            tempbetyg.Add(3);
            tempbetyg.Add(4);
            tempbetyg.Add(4.5f);
            Hopp temphopp5 = new Hopp(302, "B", 2f, 3, tempbetyg);

            hl2.AddHopp(temphopp5);

            tempbetyg.Clear();

            tempbetyg.Add(1);
            tempbetyg.Add(3.5f);
            tempbetyg.Add(1);
            tempbetyg.Add(5);
            tempbetyg.Add(3);
            tempbetyg.Add(1);
            tempbetyg.Add(1.5f);
            Hopp temphopp6 = new Hopp(201, "C", 3f, 3, tempbetyg);

            hl2.AddHopp(temphopp6);
            Hopplistor1.Add(hl2);
            #endregion

            #region Bert
            tempbetyg.Clear();

            tempbetyg.Add(8);
            tempbetyg.Add(7.5f);
            tempbetyg.Add(8.5f);
            tempbetyg.Add(7.5f);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            Hopp temphopp7 = new Hopp(101, "A", 1.5f, 3, tempbetyg);

            Hopplist hl3 = new Hopplist(3,"Bert", "gyttorp sf", 1990, "man", "gyttorp");
            hl3.AddHopp(temphopp7);

            tempbetyg.Clear();

            tempbetyg.Add(3);
            tempbetyg.Add(5.5f);
            tempbetyg.Add(6);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(5.5f);
            Hopp temphopp8 = new Hopp(302, "B", 2f, 3, tempbetyg);

            hl3.AddHopp(temphopp8);

            tempbetyg.Clear();

            tempbetyg.Add(2);
            tempbetyg.Add(4.5f);
            tempbetyg.Add(5);
            tempbetyg.Add(8);
            tempbetyg.Add(3);
            tempbetyg.Add(2);
            tempbetyg.Add(2.5f);
            Hopp temphopp9 = new Hopp(201, "C", 3f, 3, tempbetyg);

            hl3.AddHopp(temphopp9);
            Hopplistor1.Add(hl3);
            #endregion

            this.T1 = new TavlingsClass("gyttorp simtävling","2014-01-04", Hopplistor1);
        }

        [Test]
        public void AntalTavlande()
        {
            Assert.AreEqual(3, T1.AntalTavlande());
        }

        [Test]
        public void sortTavlande()
        {
            T1.PlaceringSort();
            Assert.AreEqual("Kurt", T1.getHopplistor()[0].getNamn());
            Assert.AreEqual(133.25f, T1.getHopplistor()[0].UtraknadPoangSumma());

            Assert.AreEqual("Bert", T1.getHopplistor()[1].getNamn());
            Assert.AreEqual(99.5f, T1.getHopplistor()[1].UtraknadPoangSumma());

            Assert.AreEqual("Sven", T1.getHopplistor()[2].getNamn());
            Assert.AreEqual(38.75f, T1.getHopplistor()[2].UtraknadPoangSumma());
                        
        }
    }
}
