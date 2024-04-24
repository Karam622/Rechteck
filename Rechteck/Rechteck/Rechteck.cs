using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Rechteck
    {
        private double hoehe;
        private double breite;

        public double Hoehe
        {
            get { return hoehe; }
            set
            {
                if (value >= 0)
                {
                    hoehe = value;
                }
                else
                {
                    throw new Exception("Das Program darf keine negative werte für Hoehe enthalten");
                }
            }
        }

        public double Breite
        {
            get { return breite; }
            set
            {
                if (value >= 0)
                {
                    breite = value;
                }
                else
                {
                    throw new Exception("Das Program darf keine negative werte für Breite enthalten");
                }
            }

        }

        public double Umfang
        {
            get { return 2 * breite + 2 * hoehe; }
        }

        public double Flaeche
        {
            get { return breite * hoehe; }
        }

        public Rechteck(double SeiteA, double SeiteB)
        {
            Hoehe = SeiteA;
            Breite = SeiteB;


        }
        public Rechteck(double SeiteA)
        {
            Hoehe = SeiteA;
            Breite = SeiteA;

        }

        public void ZoomIN(double faktor)
        {
            Hoehe = Hoehe * faktor;
            Breite = Breite * faktor;
        }


        public void Drehen()
        {
            double c = 0;
            c = Hoehe;
            Hoehe = Breite;
            Breite = c;
        }
    }
}

