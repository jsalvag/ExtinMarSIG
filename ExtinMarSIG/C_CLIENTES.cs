using System.Collections.Generic;

namespace ExtinMarSIG
{
    class C_CLIENTES:C_PERSONA
    {
        public List<C_EQUIPOS> equiposClient = new List<C_EQUIPOS>();

        public C_CLIENTES(string c, string n, string a, string d, string t, C_EQUIPOS e)
            : base(c, n, a, d, t)
        {
            equiposClient.Add(e);
        }
    }
}
