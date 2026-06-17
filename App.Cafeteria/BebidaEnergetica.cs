using System;

namespace App.Cafeteria
{
    internal class BebidaEnergetica : Bebida
    {
        protected int Cafeina;

        public int cafeina
        {
            get { return Cafeina; }
            set { Cafeina = value; }
        }

        public BebidaEnergetica(string _nombre,string _tamaño,float _precio, int _cafeina)
            : base(_nombre, _tamaño, _precio)
        {
            Cafeina = _cafeina;
        }

        public override string Preparar()
        {
            return base.Preparar() + " con " + Cafeina + " mg de cafeína";
        }

       public string Mensaje()
        {
            return Nombre + " | " + Tamaño + " | $" + Precio + " | Energetica";
        }
    }
}
