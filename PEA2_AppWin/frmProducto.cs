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

namespace PEA2_AppWin
{
    public partial class frmProducto : Form
    {
        private void frmProducto_Load(object sender, EventArgs e)
        {

        }
        /*public frmProducto()
{
   InitializeComponent();
}

private void IniciarFormulario(object sender, EventArgs e)
{
   cargarDatos();
}

private void toolStripButton1_Click(object sender, EventArgs e)
{
   var nuevoCliente = new Producto();
   var frm = new frmProductoEdit(nuevoCliente);
   if (frm.ShowDialog() == DialogResult.OK)
   {
       var exito = ProductoBL.Insertar(nuevoCliente);
       if (exito)
       {
           MessageBox.Show("El cliente ha sido registrado", "Financiera",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
           cargarDatos();
       }
       else
       {
           MessageBox.Show("No se ha podido registrar al cliente", "Financiera",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
       }
   }
}

private void cargarDatos()
{
   var listado = ProductoBL.Listar();
   dgvListado.Rows.Clear();
   foreach (var producto in listado)
   {
       dgvListado.Rows.Add(producto.IdProducto, producto.Nombre, producto.Marca, producto.Precio);
   }
}

private void editarRegistro(object sender, EventArgs e)
{
   if (dgvListado.Rows.Count > 0)
   {
       int filaActual = dgvListado.CurrentRow.Index;
       var idProducto = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
       var productoEditar = ProductoBL.BuscarPorId(idProducto);
       var frm = new frmProductoEdit(productoEditar);
       if (frm.ShowDialog() == DialogResult.OK)
       {
           var exito = ProductoBL.Actualizar(productoEditar);
           if (exito)
           {
               MessageBox.Show("El cliente ha sido actualizado", "Financiera",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
               cargarDatos();
           }
           else
           {
               MessageBox.Show("No se ha podido completar la operación de actualización",
                   "Financiera", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
   }
}

private void eliminarRegistro(object sender, EventArgs e)
{
   if (dgvListado.Rows.Count > 0)
   {
       int filaActual = dgvListado.CurrentRow.Index;
       var idProducto = int.Parse(dgvListado.Rows[filaActual].Cells[0].Value.ToString());
       var nombreProducto = dgvListado.Rows[filaActual].Cells[1].Value.ToString();
       var rpta = MessageBox.Show("¿Realmente desea eliminar al Producto " + nombreProducto + " ?",
           "Parcial", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
       if (rpta == DialogResult.Yes)
       {
           var exito = ProductoBL.Eliminar(idProducto);
           if (exito)
           {
               MessageBox.Show("El cliente ha sido eliminado.", "Financiera",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
               cargarDatos();
           }
           else
           {
               MessageBox.Show("No se ha podido completar la eliminación del cliente",
                   "Financiera", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }
   }
}*/


    }
}
