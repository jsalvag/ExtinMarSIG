using System.Collections.Generic;
using System;

namespace ExtinMarSIG
{
    class C_CLIENTES : C_PERSONAS, IEquatable<C_CLIENTES>
    {
        public List<C_EQUIPOS> equiposClient = new List<C_EQUIPOS>();

        public C_CLIENTES(string c, string n, string a, string d, string t, C_EQUIPOS e)
            : base(c, n, a, d, t)
        {
            equiposClient.Add(e);
        }

        public bool Equals(C_CLIENTES other)
        {
            if (other.Datos()[0] == base.Datos()[0])
                return true;
            return false;
        }
    }
}
