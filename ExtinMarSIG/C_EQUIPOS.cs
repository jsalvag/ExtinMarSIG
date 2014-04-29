using System;

namespace ExtinMarSIG
{
    class C_EQUIPOS:IEquatable<C_EQUIPOS>
    {
        private string
            cod,
            nom,
            desc,
            agente,
            estatus,
            servico;
        private double
            peso;

        public C_EQUIPOS(string c, string n, string d, string a, string e, string s, double p)
        {
            this.cod = c;
            this.nom = n;
            this.desc = d;
            this.agente = a;
            this.estatus = e;
            this.servico = s;
            this.peso = p;
        }

        public string[] Datos()
        {
            string[] d = new string[7];
            d[0] = this.cod;
            d[1] = this.nom;
            d[2] = this.desc;
            d[3] = this.estatus;
            d[4] = this.servico;
            d[5] = this.agente;
            d[6] = Convert.ToString(this.peso);
            return d;
        }

        public bool Equals(C_EQUIPOS other)
        {
            if (other.Datos()[0] == this.cod)
                return true;
            return false;
        }
    }
}
