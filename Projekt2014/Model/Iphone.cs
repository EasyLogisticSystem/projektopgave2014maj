using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt2014
{
    class Iphone
    {
        using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Input;

namespace App4.Common
{
    class Iphone
    {   //Attributer
        public string Model { get; set; }
        public int Pris { get; set; }
        public string Farve { get; set; }
        public string Kapacitet { get; set; }
        public string Beskrivelse { get; set; }

        //constructor
        public Iphone(string model, int pris, string farve, string kapacitet, string beskrivelse)
        {
            Model = model;
            Pris = pris;
            Farve = farve;
            Kapacitet = kapacitet;
            Beskrivelse = beskrivelse;
        }

        public override string ToString()
        {
            string returStr = "";
            returStr = "Model: " + Model + "\nPris: " + Pris + "\nFarve" + Farve + "\nKapacitet:" + Kapacitet +
                       "\nBeskrivelse: " + Beskrivelse;
            
            return returStr;
        }
    }
}

    }
}
