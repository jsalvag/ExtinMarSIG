using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtinMarSIG
{
    public partial class Form1 : Form
    {
        List<C_CLIENTES> listCli = new List<C_CLIENTES>();
        C_EQUIPOS eq1, eq2, eq3;
        C_CLIENTES adEqCli;

        public Form1()
        {
            InitializeComponent();
            this.pan_regCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_buscarCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan_addEquipo.Dock = System.Windows.Forms.DockStyle.Top;
            eq1 = new C_EQUIPOS("COD1", "Extintor", "Extintor para vehiculo, pequeño", "Polvo", "Recibido", "recarga", 0.5);
            eq2 = new C_EQUIPOS("COD2", "Extintor", "Extintor para oficina", "Polvo", "Recibido", "recarga", 2);
            eq3 = new C_EQUIPOS("COD3", "Extintor", "Extintor para deposito", "Polvo", "Recibido", "recarga", 2.5);

            addCli();
        }

        private void addCli()
        {
            listCli.Add(new C_CLIENTES("321", "Jose", "Guevara", "Porlmar", "04168995399", eq1));
            listCli.Add(new C_CLIENTES("654", "Maria", "Marcano", "La Asuncion", "0412558967", eq2));
            listCli.Add(new C_CLIENTES("987", "Pedro", "Pérez", "Juangriego", "04245422325", eq3));
        }

        private void ClrCli()
        {
            ci_box.Clear();
            nom_box.Clear();
            ape_box.Clear();
            dir_box.Clear();
            telf_box.Clear();
            cod1_box.Clear();
            tipo1_box.Clear();
            desc1_box.Clear();
            peso1_box.Clear();
            agente1_box.Clear();
            serv1_box.Clear();

            ci_box.Focus();
        }

        private void ClrBuscar()
        {
            bCi_box.Clear();
            bNom_box.Clear();
            bApe_box.Clear();
            bDir_box.Clear();
            btelf_box.Clear();
            bLista_dgv.Rows.Clear();

            bCi_box.Focus();
        }

        private void ClrAddEquipo()
        {
            adCli_cbox.Items.Clear();
            adCod_box.Clear();
            adTipo_box.Clear();
            adDesc_box.Clear();
            adPeso_box.Clear();
            adAgente_box.Clear();
            adServ_box.Clear();
            adListaEq_dgv.Rows.Clear();

            adCli_cbox.Text = "";

            string[] d = new string[5];
            foreach (C_CLIENTES c in listCli)
            {
                d = c.Datos();
                adCli_cbox.Items.Add(d[0] + " - " + d[2] + ", " + d[1]);
            }

            adCli_cbox.Focus();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_addEquipo.Hide();
            pan_buscarCli.Hide();
            pan_regCli.Show();
            ClrCli();
        }

        private void clrCli_btn_Click(object sender, EventArgs e)
        {
            ClrCli();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pan_addEquipo.Hide();
            pan_regCli.Hide();
            pan_buscarCli.Show();
            ClrBuscar();
        }

        private void bBuscar_btn_Click(object sender, EventArgs e)
        {
            C_CLIENTES c = listCli.Find(x => x.Datos()[0] == bCi_box.Text);
            ClrBuscar();
            if (c != null)
            {
                string[] d = new string[5];
                d = c.Datos();
                bCi_box.Text = d[0];
                bNom_box.Text = d[1];
                bApe_box.Text = d[2];
                bDir_box.Text = d[3];
                btelf_box.Text = d[4];

                foreach (C_EQUIPOS eq in c.equiposClient)
                    bLista_dgv.Rows.Add(eq.Datos());
            }
            else
            {
                MessageBox.Show("No se encuentra el cliente");
            }
        }

        private void bClr_btn_Click(object sender, EventArgs e)
        {
            ClrBuscar();
        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pan_addEquipo.Show();
            pan_buscarCli.Hide();
            pan_regCli.Hide();
            ClrAddEquipo();
        }

        private void clrAddEq_btn_Click(object sender, EventArgs e)
        {
            ClrAddEquipo();
        }

        private void adCli_cbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            adListaEq_dgv.Rows.Clear();
            string ci = adCli_cbox.Text.Split('-')[0];
            ci = ci.Trim();

            adEqCli = listCli.Find(x => x.Datos()[0] == ci);

            foreach (C_EQUIPOS eq in adEqCli.equiposClient)
                adListaEq_dgv.Rows.Add(eq.Datos());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pan_addEquipo.Hide();
            pan_buscarCli.Hide();
            pan_regCli.Show();
            ClrCli();
        }

        private void adAgregar_btn_Click(object sender, EventArgs e)
        {
            C_EQUIPOS eq = new C_EQUIPOS(adCod_box.Text, adTipo_box.Text, adDesc_box.Text, adAgente_box.Text, "Recibido", adServ_box.Text, Convert.ToDouble(adPeso_box.Text));
            adEqCli.equiposClient.Add(eq);
            adListaEq_dgv.Rows.Add(eq.Datos());
        }

        private void regCli_btn_Click(object sender, EventArgs e)
        {
            C_EQUIPOS eq = new C_EQUIPOS(cod1_box.Text, tipo1_box.Text, desc1_box.Text, agente1_box.Text, "Recibido", serv1_box.Text, Convert.ToDouble(peso1_box.Text));
            listCli.Add(new C_CLIENTES(ci_box.Text, nom_box.Text, ape_box.Text, dir_box.Text, telf_box.Text, eq));
            ClrCli();
        }
    }
}
