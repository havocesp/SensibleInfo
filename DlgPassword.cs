﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SensibleInfo
{
	public partial class DlgPassword : Form
	{
		public DlgPassword()
		{
			InitializeComponent();
		}

		private void btnDescifrar_Click(object sender, EventArgs e)
		{
			if (txtClave.Text.Length > 0)
				this.Close();
			else
				MessageBox.Show("Introduzca la clave para descifrar el fichero", "Clave no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
		}

		public string getClave()
		{
			return txtClave.Text;
		}

		public void setTexto(string str)
		{
			this.lblClave.Text = str;
		}

		public void setBtnText(string str)
		{
			this.btnDescifrar.Text = str;
		}

		private void txtClave_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Enter) {
				btnDescifrar_Click(sender, e);
			}
		}

	}
}
