using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEA2_AppWin
{
    public partial class frmProductoEdit : Form
    {
        //Producto producto;
        public frmProductoEdit(/*Producto producto*/)
        {
            InitializeComponent();
            //this.producto = producto;
        }

        private void iniciarFormulario(object sender, EventArgs e)
        {
            /*cargarDatos();
            if (producto.IdProducto > 0)
            {
                asignarControles();
            }*/
        }
       /* private void cargarDatos()
        {
            // Listar los tipo de documentos
            cbocategoria.DataSource = CategoriaBL.Listar();
            cbocategoria.DisplayMember = "Nombre";
            cbocategoria.ValueMember = "IdCategoria";

        }

        private void asignarControles()
        {
            txtnombre.Text = producto.Nombre;
            txtmarca.Text = producto.Marca;
            Double txtprecio= producto.Precio;
            cbocategoria.SelectedValue = producto.IdCategoria;
        }

        private void asignarObjeto()
        {
            txtnombre.Text = producto.Nombre;
            txtmarca.Text = producto.Marca;
            Double txtprecio = producto.Precio;
            cbocategoria.SelectedValue = producto.IdCategoria;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            asignarObjeto();
            this.DialogResult = DialogResult.OK;
        }
       */

    }
}
