using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Cafeteria
{
    internal class BebidaCaliente : Bebida
    {
        private int Temperatura;

        public int temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

        //constructor en cuando heredamos 
        public BebidaCaliente(string _nombre, string _tamaño, float _precio, int _temperatura) : base(_nombre, _tamaño, _precio)
        {
            Temperatura = _temperatura;
        }

        //metodo sobreescrito(Polimorfismo)
        public override string Preparar()
        {
            return base.Preparar () + "la Temperatura es "+ Temperatura;
        }
        public string Mensaje()
        {
            return Nombre + " | " + Tamaño + " | $" + Precio + " | Caliente";
        }
    }
}