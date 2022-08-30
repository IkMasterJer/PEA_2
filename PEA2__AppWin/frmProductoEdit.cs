using PEA2_Dominio;
using PEA2_Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEA2__AppWin
{
    public partial class frmProductoEdit : Form
    {
        Producto producto;
        public frmProductoEdit(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void btnlis_Click(object sender, EventArgs e)
        {
            asignarObjeto();
            this.DialogResult = DialogResult.OK;
        }

        private void iniciarFormulario(object sender, EventArgs e)
        {
            cargarDatos();
            if (producto.IdProducto > 0)
            {
                asignarControles();
            }
        }
        private void cargarDatos()
        {
            // Listar categoria
            cbocategoria.DataSource = CategoriaBL.Listar();
            cbocategoria.DisplayMember = "Nombre";
            cbocategoria.ValueMember = "IdCategoria";

        }

        private void asignarControles()
        {
            txtnombre.Text = producto.Nombre;
            txtmarca.Text = producto.Marca;
            double.Parse(txtprecio.Text = producto.Precio.ToString());
            int.Parse(txtstock.Text = producto.Stock.ToString());
            txtobservacion.Text = producto.Observacion;
            cbocategoria.SelectedValue = producto.IdCategoria;
        }

        private void asignarObjeto()
        {
            producto.Nombre = txtnombre.Text;
            producto.Marca = txtmarca.Text;
            producto.Precio = double.Parse(txtprecio.Text.ToString());
            producto.Stock = int.Parse(txtstock.Text.ToString());
            producto.Observacion = txtobservacion.Text;
            producto.IdCategoria = int.Parse(cbocategoria.SelectedValue.ToString());

        }

    }
}
