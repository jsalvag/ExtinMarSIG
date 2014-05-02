using System;

namespace ExtinMarSIG
{
    class C_PERSONAS:IEquatable<C_PERSONAS>
    {
        private string
               ci,
               nom,
               ape,
               dir,
               telf;

        public C_PERSONAS(string c, string n, string a, string d, string t)
        {
            this.ci = c;
            this.nom = n;
            this.ape = a;
            this.dir = d;
            this.telf = t;
        }

        public string[] Datos()
        {
            string[] d = new string[5];
            d[0] = this.ci;
            d[1] = this.nom;
            d[2] = this.ape;
            d[3] = this.dir;
            d[4] = this.telf;
            return d;
        }

        public virtual bool Equals(C_PERSONAS other)
        {
            if (other.Datos()[0] == this.ci)
                return true;
            return false;
        }
    }
}
