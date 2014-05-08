using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExtinMarSIG
{
	public partial class Form1 : Form
	{
		List<C_CLIENTES> listCli = new List<C_CLIENTES>();
		C_EQUIPOS ordEq, statEq, entregEq, eq1, eq2, eq3, eq4, eq5, eq6, eq7, eq8, eq9, eq10, eq11, eq12;
		C_CLIENTES adEqCli, ordCli,statCli;
		C_ORDENES estatOrd, regOrd;
		List<C_ORDENES> listOrdenes = new List<C_ORDENES>();
		int nOrden;

		public Form1()
		{
			InitializeComponent();
			this.pan1_regCli.Dock    = System.Windows.Forms.DockStyle.Top;
			this.pan2_buscarCli.Dock = System.Windows.Forms.DockStyle.Top;
			this.pan3_addEquipo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pan4_recibir.Dock = System.Windows.Forms.DockStyle.Top;
			this.pan5_statEq.Dock = System.Windows.Forms.DockStyle.Top;
			this.pan6_entregar.Dock = System.Windows.Forms.DockStyle.Top;

	      //Equipos nuevaInstancia(Codigo, Tipo, Descripcion, Agente, Agente, Peso)
            eq1 = new C_EQUIPOS("COD1", "Extintor", "Extintor para vehiculo, pequeño" + Fecha(), "Polvo", "", 0.5);
            eq2 = new C_EQUIPOS("COD2", "Extintor", "Extintor para oficina" + Fecha(), "Polvo", "", 2);
            eq3 = new C_EQUIPOS("COD3", "Extintor", "Extintor para deposito" + Fecha(), "Espuna", "", 2.5);
            eq4 = new C_EQUIPOS("COD4", "Extintor", "Extintor para vehiculo, pequeño" + Fecha(), "Polvo", "", 0.5);
            eq5 = new C_EQUIPOS("COD5", "Extintor", "Extintor para oficina" + Fecha(), "Co2", "", 2);
            eq6 = new C_EQUIPOS("COD6", "Extintor", "Extintor para deposito" + Fecha(), "Polvo", "", 2.5);
            eq7 = new C_EQUIPOS("COD7", "Extintor", "Extintor para vehiculo, pequeño" + Fecha(), "Espuna", "", 0.5);
            eq8 = new C_EQUIPOS("COD8", "Extintor", "Extintor para oficina" + Fecha(), "Espuna", "", 2);
            eq9 = new C_EQUIPOS("COD9", "Extintor", "Extintor para deposito" + Fecha(), "Polvo", "", 2.5);
            eq10 = new C_EQUIPOS("COD10", "Extintor", "Extintor para vehiculo, pequeño" + Fecha(), "Co2", "", 0.5);
            eq11 = new C_EQUIPOS("COD11", "Extintor", "Extintor para oficina" + Fecha(), "Polvo", "", 2);
            eq12 = new C_EQUIPOS("COD12", "Extintor", "Extintor para deposito" + Fecha(), "Polvo", "", 2.5);

			AddCli();
			nOrden = listOrdenes.Count + 1;
			//AddOrden();
		}

		private string Fecha()
		{
			return Convert.ToString(DateTime.Now);
		}

		private void AddCli()
		{
		// listaClinete nuevaInstancia (CI, Nnombre, Apellido, Direccion,Telefono, Equipo)
            listCli.Add(new C_CLIENTES("321", "Jose", "Guevara", "Porlmar", "04168995399", eq1));
            listCli.Add(new C_CLIENTES("654", "Maria", "Marcano", "La Asuncion", "0412558967", eq2));
            listCli.Add(new C_CLIENTES("987", "Pedro", "Pérez", "Juangriego", "04245422325", eq3));
            listCli.Add(new C_CLIENTES("123", "Jose", "Guevara", "Porlmar", "04168995399", eq4));
            listCli.Add(new C_CLIENTES("234", "Maria", "Marcano", "La Asuncion", "0412558967", eq5));
            listCli.Add(new C_CLIENTES("345", "Pedro", "Pérez", "Juangriego", "04245422325", eq6));
            listCli.Add(new C_CLIENTES("456", "Jose", "Guevara", "Porlmar", "04168995399", eq7));
            listCli.Add(new C_CLIENTES("567", "Maria", "Marcano", "La Asuncion", "0412558967", eq8));
            listCli.Add(new C_CLIENTES("678", "Pedro", "Pérez", "Juangriego", "04245422325", eq9));
            listCli.Add(new C_CLIENTES("789", "Jose", "Guevara", "Porlmar", "04168995399", eq10));
            listCli.Add(new C_CLIENTES("890", "Maria", "Marcano", "La Asuncion", "0412558967", eq11));
            listCli.Add(new C_CLIENTES("210", "Pedro", "Pérez", "Juangriego", "04245422325", eq12));
		}

		private void AddOrden()
		{
			listOrdenes.Add(new C_ORDENES(nOrden, listCli.Find(x => x.Datos()[0] == "321"), eq1));
		}

		private void ClrCli()
		{
			rCi_box.Clear();
			rNom_box.Clear();
			rApe_box.Clear();
			rDir_box.Clear();
			rTelf_box.Clear();
			rCod_box.Clear();
			rTipo_box.Clear();
			rDesc_box.Clear();
			rPeso_box.Clear();
			rAgente_box.Clear();

			rCi_box.Focus();
		}

		private void ClrBuscar()
		{
			bCi_box.Clear();
			bNom_box.Clear();
			bApe_box.Clear();
			bDir_box.Clear();
			btelf_box.Clear();
			dgv_bLista.Rows.Clear();

			bCi_box.Focus();
		}

		private void ClrAddEquipoEq()
		{
			adCod_box.Clear();
			adTipo_box.Clear();
			adDesc_box.Clear();
			adPeso_box.Clear();
			adAgente_box.Clear();

			adCod_box.Focus();
		}

		private void ClrAddEquipo()
		{
			adCli_cbox.Items.Clear();
			string[] d = new string[5];
			foreach (C_CLIENTES c in listCli)
			{
				d = c.Datos();
				adCli_cbox.Items.Add(d[0] + " - " + d[2] + ", " + d[1]);
			}
			dgv_adListaEq.Rows.Clear();

			ClrAddEquipoEq();

			adCli_cbox.Text = "";

			adCli_cbox.Focus();
		}

		private void ClrOrden()
		{
			oNOrd_lb.Text = "Orden nº:  " + Convert.ToString(nOrden);
			oCli_cbox.Items.Clear();
			oNom_box.Clear();
			oApe_box.Clear();
			oDir_box.Clear();
			oTelf_box.Clear();
			dgv_oListEqCli.Rows.Clear();
			oCli_cbox.Text = "";
			oCli_cbox.Focus();

			oAddEq_btn.Enabled = false;
			
			ordEq = null;

			ClrOrdenEq();

			string[] d = new string[5];
			foreach (C_CLIENTES c in listCli)
			{
				d = c.Datos();
				oCli_cbox.Items.Add(d[0] + " - " + d[2] + ", " + d[1]);
			}

		}

		private void ClrOrdenEq()
		{
			oCod_box.Clear();
			oTipo_box.Clear();
			oDesc_box.Clear();
			oPeso_box.Clear();
			oAgent_box.Clear();
			oServ_cbox.Text = "";
		}

		private void ClrEstatus()
		{
			dgv_eListEq.Rows.Clear();
			eCod_box.Clear();
			eTipo_box.Clear();
			eDesc_box.Clear();
			ePeso_box.Clear();
			eServ_box.Clear();
			eEstatus_cbox.Text = "";
			eOk_btn.Enabled = false;

			string[] d = new string[7];
			foreach(C_CLIENTES c in listCli)
				foreach (C_EQUIPOS eq in c.equiposClient)
				{
					d = eq.Datos();
					if (d[3] != "Listo" && d[3] != "Entregado" && d[3] != "" && d[3] != "Irrecuperable")
						dgv_eListEq.Rows.Add(d);
				}

			dgv_eListEq.Focus();
		}

		private void ClrEntregar()
		{
			enCi_box.Clear();
			enNom_box.Clear();
			enApe_box.Clear();
			enDir_box.Clear();
			enTelf_box.Clear();
			dgv_enListEq.Rows.Clear();
			enCod_box.Clear();
			enTipo_box.Clear();
			enDesc_box.Clear();
			enPeso_box.Clear();
			enServ_box.Clear();
			enEstat_box.Clear();
			entregar_btn.Enabled = false;

			
		}

		private C_CLIENTES Cliente(string d)
		{
			string ci = d.Split('-')[0];
			ci = ci.Trim();
			return listCli.Find(x => x.Datos()[0] == ci);
		}

		private C_EQUIPOS Equipo(string d)
		{
			C_EQUIPOS eq;
			C_CLIENTES c = listCli.Find(
				x => (eq = x.equiposClient.Find(y => y.Datos()[0] == d)) != null);
			if (c != null)
				return c.equiposClient.Find(y => y.Datos()[0] == d);
			else
				return null;
		}

		private void smSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void smRegCli_Click(object sender, EventArgs e)
		{
			pan3_addEquipo.Hide();
			pan2_buscarCli.Hide();
			pan4_recibir.Hide();
			pan5_statEq.Hide();
			pan6_entregar.Hide();
			pan1_regCli.Show();
			ClrCli();
		}

		private void smVerCli_Click(object sender, EventArgs e)
		{
			pan3_addEquipo.Hide();
			pan1_regCli.Hide();
			pan4_recibir.Hide();
			pan5_statEq.Hide();
			pan6_entregar.Hide();
			pan2_buscarCli.Show();
			ClrBuscar();
		}

		private void smAddEq_Click(object sender, EventArgs e)
		{
			pan2_buscarCli.Hide();
			pan1_regCli.Hide();
			pan4_recibir.Hide();
			pan5_statEq.Hide();
			pan6_entregar.Hide();
			pan3_addEquipo.Show();
			ClrAddEquipo();
		}

		private void smRecibEq_Click(object sender, EventArgs e)
		{
			pan3_addEquipo.Hide();
			pan2_buscarCli.Hide();
			pan1_regCli.Hide();
			pan5_statEq.Hide();
			pan6_entregar.Hide();
			pan4_recibir.Show();

			ClrOrden();
		}

		private void smEstatEq_Click(object sender, EventArgs e)
		{
			pan3_addEquipo.Hide();
			pan2_buscarCli.Hide();
			pan4_recibir.Hide();
			pan1_regCli.Hide();
			pan6_entregar.Hide();
			pan5_statEq.Show();
			ClrEstatus();
		}

		private void smEntregaEq_Click(object sender, EventArgs e)
		{
			pan3_addEquipo.Hide();
			pan2_buscarCli.Hide();
			pan4_recibir.Hide();
			pan1_regCli.Hide();
			pan5_statEq.Hide();
			pan6_entregar.Show();
			ClrEntregar();
		}

		private void clrCli_btn_Click(object sender, EventArgs e)
		{
			ClrCli();
		}

		private void bClr_btn_Click(object sender, EventArgs e)
		{
			ClrBuscar();
		}

		private void oClr_btn_Click(object sender, EventArgs e)
		{
			ClrOrdenEq();
		}

		private void clrAddEq_btn_Click(object sender, EventArgs e)
		{
			ClrAddEquipo();
		}

		private void enClr_btn_Click(object sender, EventArgs e)
		{
			ClrEntregar();
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
					dgv_bLista.Rows.Add(eq.Datos());
			}
			else
			{
				MessageBox.Show("No se encuentra el cliente");
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			pan3_addEquipo.Hide();
			pan1_regCli.Show();
			ClrCli();
		}

		private void adAgregar_btn_Click(object sender, EventArgs e)
		{
			C_EQUIPOS eq = new C_EQUIPOS(
				adCod_box.Text,
				adTipo_box.Text,
				adDesc_box.Text,
				adAgente_box.Text,
				"",
				Convert.ToDouble(adPeso_box.Text)
			 );
			adEqCli.equiposClient.Add(eq);
			dgv_adListaEq.Rows.Add(eq.Datos());
			ClrAddEquipoEq();
		}

		private void regCli_btn_Click(object sender, EventArgs e)
		{
			C_EQUIPOS eq = new C_EQUIPOS(rCod_box.Text, rTipo_box.Text, rDesc_box.Text, rAgente_box.Text, "Recibido", Convert.ToDouble(rPeso_box.Text));
			C_CLIENTES cli = new C_CLIENTES(rCi_box.Text, rNom_box.Text, rApe_box.Text, rDir_box.Text, rTelf_box.Text, eq);
			if (!listCli.Contains(cli))
			{
				listCli.Add(cli);
				listOrdenes.Add(new C_ORDENES(nOrden,cli,eq));
			}
			else
				MessageBox.Show("La cedula introducida ya pertenece a un cliente registrado");
			ClrCli();
		}

		private void adCli_cbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgv_adListaEq.Rows.Clear();

			adEqCli = Cliente(adCli_cbox.Text);

			foreach (C_EQUIPOS eq in adEqCli.equiposClient)
				dgv_adListaEq.Rows.Add(eq.Datos());

			adCod_box.Focus();
		}

		private void oCli_cbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			dgv_oListEqCli.Rows.Clear();
			string[] d1 = new string[7];
			string[] d2 = new string[4];
			string[] cli = new string[4];

			ordCli = Cliente(oCli_cbox.Text);

			cli = ordCli.Datos();

			oNom_box.Text = cli[1];
			oApe_box.Text = cli[2];
			oDir_box.Text = cli[3];
			oTelf_box.Text = cli[4];
			
			foreach (C_EQUIPOS eq in ordCli.equiposClient)
			{
				d1 = eq.Datos();
				if (d1[3] == "Entregado" || d1[3] == "")
				{
					d2[0] = d1[0];
					d2[1] = d1[1];
					d2[2] = d1[2];
					d2[3] = d1[5];

					dgv_oListEqCli.Rows.Add(d2);
				}
			}
		}

		private void dgv_oListEqCli_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ClrOrdenEq();
			string[] d = new string[7];
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgv_oListEqCli.Rows[e.RowIndex];
				ordEq = ordCli.equiposClient.Find(
					a => a.Datos()[0] == Convert.ToString(fila.Cells["oCode_dgvc"].Value)
				);
				d = ordEq.Datos();
				oCod_box.Text = d[0];
				oTipo_box.Text = d[1];
				oDesc_box.Text = d[2];
				oPeso_box.Text = d[6];
				oAgent_box.Text = d[5];
				oServ_cbox.Text = "";
			}
		}

		private void oAddEq_btn_Click(object sender, EventArgs e)
		{
			ordEq.setDatos("Recibido", oServ_cbox.Text, Convert.ToDouble(oPeso_box.Text));
			listOrdenes.Add(new C_ORDENES(nOrden, ordCli, ordEq));
			nOrden++;
			ClrOrden();
		}

		private void dgv_eListEq_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string[] d = new string[7];
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgv_eListEq.Rows[e.RowIndex];
				estatOrd = listOrdenes.Find(x => x.getEquipo().Datos()[0] == Convert.ToString(fila.Cells["eCod_dgvc"].Value));

				d = estatOrd.getEquipo().Datos();
				eCod_box.Text = d[0];
				eTipo_box.Text = d[1];
				eDesc_box.Text = d[2];
				eServ_box.Text = d[4];
				ePeso_box.Text = d[6];
			}

		}

		private void oServ_cbox_TextChanged(object sender, EventArgs e)
		{
			oAddEq_btn.Enabled = true;
		}

		private void eEstatus_cbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			eOk_btn.Enabled = true;
		}

		private void eOk_btn_Click(object sender, EventArgs e)
		{
			string cod = eCod_box.Text;

			statCli = listCli.Find(c => c.equiposClient.Find(eq => eq.Datos()[0] == cod) != null);

			statEq = statCli.equiposClient.Find(eq => eq.Datos()[0] == cod);

			statEq.setDatos(eEstatus_cbox.Text, eServ_box.Text, Convert.ToDouble(ePeso_box.Text));

			ClrEstatus();
		}

		private void enBuscar_btn_Click(object sender, EventArgs e)
		{
			C_CLIENTES c = listCli.Find(x => x.Datos()[0] == enCi_box.Text);
			ClrEntregar();
			if (c != null)
			{
				string[] d = new string[5];
				d = c.Datos();
				enCi_box.Text = d[0];
				enNom_box.Text = d[1];
				enApe_box.Text = d[2];
				enDir_box.Text = d[3];
				enTelf_box.Text = d[4];

				foreach (C_EQUIPOS eq in c.equiposClient)
                    if (eq.Datos()[3] != "Entregado" && (eq.Datos()[3] == "Listo" || eq.Datos()[3] == "Irrecuperable"))
						dgv_enListEq.Rows.Add(eq.Datos());
			}
			else
			{
				MessageBox.Show("No se encuentra el cliente");
			}
		}

		private void dgv_enListEq_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string[] d = new string[7];
			if (e.RowIndex >= 0)
			{
				DataGridViewRow fila = dgv_enListEq.Rows[e.RowIndex];
				if (ordCli != null)
				{
					entregEq = Equipo(Convert.ToString(fila.Cells["enCode_dgvc"].Value));

					d = entregEq.Datos();
					enCod_box.Text = d[0];
					enTipo_box.Text = d[1];
					enDesc_box.Text = d[2];
					enPeso_box.Text = d[6];
					enServ_box.Text = d[4];
					enEstat_box.Text = d[3];

					entregar_btn.Enabled = true;
				}
				else { MessageBox.Show("No hay nunguna orden registrada"); }
			}
		}

		private void entregar_btn_Click(object sender, EventArgs e)
		{
			C_EQUIPOS eq = Equipo(enCod_box.Text);
			eq.setDatos("Entregado", enServ_box.Text, Convert.ToDouble(enPeso_box.Text));
			ClrEntregar();
		}

		private void num_KeyPress(object sender, KeyPressEventArgs e)
		{
			TextBox tb = (TextBox)sender;
			tb.BackColor = System.Drawing.Color.White;
			if (Char.IsDigit(e.KeyChar))
				e.Handled = false;
			else if (Char.IsControl(e.KeyChar))
				e.Handled = false;
			else if (Char.IsPunctuation(e.KeyChar))
				e.Handled = false;
			else
			{
				e.Handled = true;
				tb.BackColor = System.Drawing.Color.Red;
			}

			if (e.KeyChar == (char)(Keys.Enter))
			{
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

		private void text_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)(Keys.Enter))
			{
				e.Handled = true;
				SendKeys.Send("{TAB}");
			}
		}

        private void enClr_btn_Click_1(object sender, EventArgs e)
        {
            ClrEntregar();
        }
	}
}
