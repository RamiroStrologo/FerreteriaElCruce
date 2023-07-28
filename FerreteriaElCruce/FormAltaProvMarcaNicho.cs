using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;



namespace FerreteriaElCruce
{
    public partial class FormAltaProvMarcaNicho : Form
    {
        Producto producto;
        public int resultado { get; set; }
        public FormAltaProvMarcaNicho()
        {
            InitializeComponent();
        }

        private void FormAltaProvMarcaNicho_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            producto = new Producto();
            producto.tipoAtributo = this.Text;
            producto.nombre = txtNombre.Text;
            resultado = producto.AltaAtributo();
            Cursor.Current = Cursors.Default;
            this.Close();
        }
    }
}
