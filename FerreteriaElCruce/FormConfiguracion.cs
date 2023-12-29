using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;



namespace FerreteriaElCruce
{
    public partial class FormConfiguracion : Form
    {
        public string configCall { get; set; }
        public int productoIdMod { get; set; } = 0;
        public string productoNomMod { get; set; } = "";
        Producto producto;
        DataBase db;
        public FormConfiguracion()
        {
            InitializeComponent();
        }

        private void FormConfiguracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frmI = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormInventario);
            Form frmL = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormLuancher);
            if(frmI != null)
            {
                frmI.BringToFront();
                (frmI as FormInventario)?.OnFormBroughtToFront();
            }
            else
            {
                frmL.WindowState = FormWindowState.Normal;
                frmL.BringToFront();
            }
            
        }



        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            configCallMethod(configCall);
        }

        public void configCallMethod(string configCall)
        {
            switch (configCall)
            {
                case "AltaProducto":
                    lnkAltaProducto_LinkClicked(null, null);
                    break;
                case "ModificarProducto":
                    lnkModificarProducto_LinkClicked(null, null);
                    break;
            }
        }

        public void AbrirFormulario(Form formulario)
        {
            pnlPantallasConfg.Controls.Clear();
            Form fh = formulario as Form; // Aca creo un objeto de tipo formulario y le asigno como parametro lo que recibe como formhijo 
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPantallasConfg.Controls.Add(fh);
            pnlPantallasConfg.Tag = fh;
            fh.Show();
        }

        public void lnkAltaProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPantallasConfg.Controls.Clear();
            FormAltaProducto fh = new FormAltaProducto();
            fh.Modificar = false;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPantallasConfg.Controls.Add(fh);
            pnlPantallasConfg.Tag = fh;
            fh.Show();
        }

        private void lnkModificarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPantallasConfg.Controls.Clear();
            FormAltaProducto fh = new FormAltaProducto();
            fh.Modificar = true;
            if(productoIdMod != 0)
            {
                fh.productoIdMod = productoIdMod;
                fh.productoNomMod = productoNomMod;
            }
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPantallasConfg.Controls.Add(fh);
            pnlPantallasConfg.Tag = fh;
            fh.Show();
        }

        private void lnkModModPrecioMas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPantallasConfg.Controls.Clear();
            FormModPrecioMasivo fh = new FormModPrecioMasivo();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPantallasConfg.Controls.Add(fh);
            pnlPantallasConfg.Tag = fh;
            fh.Show();
        }

        private void lnkPdfCodigos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            producto = new Producto();
            string prodC, prodD, precioFinal;
            DataTable pdfTable = new DataTable();
            pdfTable = producto.ObtenerListaDeProductos();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Cursor.Current = Cursors.WaitCursor;
            // Crea el nombre del archivo PDF
            string fileName = Path.Combine(desktopPath, "listado_productos_" + DateTime.Now.ToString("ddMMyyyy") +".pdf");

            // Crea un flujo de salida para escribir en el archivo PDF
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                // Crea un objeto PDF Document
                PdfDocument pdf = new PdfDocument(new PdfWriter(fileStream));

                // Crea un documento iText7
                Document document = new Document(pdf);

                // Crea una tabla
                Table table = new Table(pdfTable.Columns.Count);

                // Agrega las cabeceras de columna
                foreach (DataColumn column in pdfTable.Columns)
                {
                    table.AddCell(new Cell().Add(new Paragraph(column.ColumnName)));
                }
                // Agrega los datos de las filas
                foreach (DataRow row in pdfTable.Rows)
                {
                    prodC = row[0].ToString();
                    prodD = row[1].ToString();
                    precioFinal = "$ " + row[2].ToString();

                        table.AddCell(new Cell().Add(new Paragraph(prodC)));
                        table.AddCell(new Cell().Add(new Paragraph(prodD)));
                        table.AddCell(new Cell().Add(new Paragraph(precioFinal)));
                }

                // Agrega la tabla al documento
                document.Add(table);

                // Cierra el documento
                document.Close();
                Cursor.Current = Cursors.Default;

            }
        }

        private void lnkUsuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlPantallasConfg.Controls.Clear();
            ABMUsuarios fh = new ABMUsuarios();
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPantallasConfg.Controls.Add(fh);
            pnlPantallasConfg.Tag = fh;
            fh.Show();
        }

        private void lnkBackUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            db = new DataBase();
            Cursor.Current = Cursors.WaitCursor;
            bool res = db.BackUpBd();
            Cursor.Current = Cursors.Default;
            string msj = res ? "Base de datos respaldada con éxito" : "Error al conectar con la Base de Datos";
            MessageBox.Show(msj, "BackUp Data Base");
        }
    }
}
