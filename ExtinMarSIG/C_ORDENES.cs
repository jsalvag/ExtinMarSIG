using System.Collections.Generic;

namespace ExtinMarSIG
{
    class C_ORDENES
    {
        private int numero;

        private C_CLIENTES cli;

        public C_EQUIPOS equipo;

        public C_ORDENES(int n, C_CLIENTES c,C_EQUIPOS eq)
        {
            this.numero = n;
            this.cli = c;
            this.equipo = eq;
        }

        public C_CLIENTES getCliente()
        {
            return this.cli;
        }
        public C_EQUIPOS getEquipo()
        {
            return this.equipo;
        }
    }
}
