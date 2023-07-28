using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout;
using Negocio;

namespace FerreteriaElCruce
{
    public partial class FormInformesComprasVentas : Form
    {
        Informes inf;
        DataTable dt;
        public FormInformesComprasVentas()
        {
            InitializeComponent();
        }

        private void FormInformesComprasVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormLuancher);
            frm.WindowState = FormWindowState.Normal;
            frm.BringToFront();
        }

        private void FormInformesComprasVentas_Load(object sender, EventArgs e)
        {
            DayOfWeek firstDayOfWeek = CultureInfo.CurrentCulture.DateTimeFormat.FirstDayOfWeek;
            DateTime fechaActual = DateTime.Now;
            dtpPeriodoFin.Value = fechaActual;
            while(fechaActual.DayOfWeek != firstDayOfWeek)
            {
                fechaActual = fechaActual.AddDays(-1);
            }
            dtpPeriodoIni.Value = fechaActual;
        }

        private void dtpPeriodoIni_ValueChange(object sender, EventArgs e)
        {
            ComprobarPeriodoValido();
        }
        private void dtpPeriodoFin_ValueChange(object sender, EventArgs e)
        {
            ComprobarPeriodoValido();
        }
        private void ComprobarPeriodoValido()
        {
            DateTime currentIni = dtpPeriodoIni.Value;
            DateTime currentFin = dtpPeriodoFin.Value;
            if (dtpPeriodoIni.Value > DateTime.Now || dtpPeriodoFin.Value > DateTime.Now || dtpPeriodoFin.Value < dtpPeriodoIni.Value)
            {
                FormInformesComprasVentas_Load(null, null);
                MessageBox.Show(this, "Período Inválido", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                InformesCompras();
                InformesVentas();
            }
               
        }
        private void InformesCompras()
        {     
            Cursor.Current = Cursors.WaitCursor;
            inf = new Informes();
            //////////////////Top 10 
            string lbl = "Top 10: \n ---";
            inf.fechaIni = dtpPeriodoIni.Value.ToString("yyyy/MM/dd");
            inf.fechaFin = dtpPeriodoFin.Value.ToString("yyyy/MM/dd");
            dt = inf.TopCompras();
            foreach(DataRow row in dt.Rows)
            {
                lbl += "\n\nProducto: " + row[0].ToString() + " - Total comprado: $" + row[2].ToString() + " - Cant. comprada: " + row[1].ToString();
                lbl += "\n ---";
            }
            rtbTopCompras.Text = lbl;
            Regex regex = new Regex(@"\$[\d,]+");
            MatchCollection matches = regex.Matches(rtbTopCompras.Text);
            foreach (Match coincidencia in matches)
            {
                rtbTopCompras.Select(coincidencia.Index, coincidencia.Length);
                rtbTopCompras.SelectionColor = Color.Green;
            }
            string totales = inf.InformeTotalCompras();
            lblN.Text = "$" + totales.Split(' ')[0];
            lblB.Text = "$" + totales.Split(' ')[1];
            lblT.Text = "$" + totales.Split(' ')[2];

            Cursor.Current = Cursors.Default;
        }
        public void InformesVentas()
        {
            Cursor.Current = Cursors.WaitCursor;
            inf = new Informes();
            //////////////////Top 10 
            string lbl = "Top 10: \n ---";
            inf.fechaIni = dtpPeriodoIni.Value.ToString("yyyy/MM/dd");
            inf.fechaFin = dtpPeriodoFin.Value.ToString("yyyy/MM/dd");
            dt = inf.TopVentas();
            foreach (DataRow row in dt.Rows)
            {
                lbl += "\n\nProducto: " + row[0].ToString() + " - Total vendido: $" + row[2].ToString() + " - Cant. vendido: " + row[1].ToString();
                lbl += "\n ---";
            }
            rtbTopVentas.Text = lbl;
            Regex regex = new Regex(@"\$[\d,]+");
            MatchCollection matches = regex.Matches(rtbTopVentas.Text);
            foreach (Match coincidencia in matches)
            {
                rtbTopVentas.Select(coincidencia.Index, coincidencia.Length);
                rtbTopVentas.SelectionColor = Color.Green;
            }
            string totales = inf.InformeTotalVentas();
            lblNV.Text = "$" + totales.Split(' ')[0];
            lblBV.Text = "$" + totales.Split(' ')[1];
            lblTV.Text = "$" + totales.Split(' ')[2];

            Cursor.Current = Cursors.Default;
        }


        private DateTime lastClickTime = DateTime.Now;
        private bool isClick = false;
        private void dtpPeriodoIni_MouseDown(object sender, MouseEventArgs e)
        {
            DateTimePicker clickedDtp = (DateTimePicker)sender;

            if (isClick && DateTime.Now - lastClickTime < TimeSpan.FromSeconds(1))
            {
                // Se ha producido un doble clic en el DateTimePicker "clickedDtp"
                if (clickedDtp.Name == "dtpPeriodoIni")
                    dtpPeriodoFin.Value = dtpPeriodoIni.Value;
                else
                    dtpPeriodoIni.Value = dtpPeriodoFin.Value;
                isClick = false;
            }
            else
            {
                isClick = true;
                lastClickTime = DateTime.Now;
            }
        }

        private void lnkDescargaPdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            inf = new Informes();
            inf.fechaIni = dtpPeriodoIni.Value.ToString("yyyy/MM/dd");
            inf.fechaFin = dtpPeriodoFin.Value.ToString("yyyy/MM/dd");
            string codigo, desc, cant, total;
            DataTable pdfTable = new DataTable();
            pdfTable = inf.ObtenerComprasTodo();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Crea el nombre del archivo PDF
            string fileName = Path.Combine(desktopPath, "listado_compras_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf");

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
                    codigo = row[0].ToString();
                    desc = row[1].ToString();
                    cant = row[2].ToString();
                    total = "$ " + row[3].ToString();

                    table.AddCell(new Cell().Add(new Paragraph(codigo)));
                    table.AddCell(new Cell().Add(new Paragraph(desc)));
                    table.AddCell(new Cell().Add(new Paragraph(cant)));
                    table.AddCell(new Cell().Add(new Paragraph(total)));
                }

                // Agrega la tabla al documento
                document.Add(table);

                // Cierra el documento
                document.Close();
                Cursor.Current = Cursors.Default;
            }
        }

        private void lnkDescargarPdfV_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            inf = new Informes();
            inf.fechaIni = dtpPeriodoIni.Value.ToString("yyyy/MM/dd");
            inf.fechaFin = dtpPeriodoFin.Value.ToString("yyyy/MM/dd");
            string codigo, desc, cant, total;
            DataTable pdfTable = new DataTable();
            pdfTable = inf.ObtenerVentasTodo();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            // Crea el nombre del archivo PDF
            string fileName = Path.Combine(desktopPath, "listado_ventas_" + DateTime.Now.ToString("ddMMyyyy") + ".pdf");

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
                    codigo = row[0].ToString();
                    desc = row[1].ToString();
                    cant = row[2].ToString();
                    total = "$ " + row[3].ToString();

                    table.AddCell(new Cell().Add(new Paragraph(codigo)));
                    table.AddCell(new Cell().Add(new Paragraph(desc)));
                    table.AddCell(new Cell().Add(new Paragraph(cant)));
                    table.AddCell(new Cell().Add(new Paragraph(total)));
                }

                // Agrega la tabla al documento
                document.Add(table);

                // Cierra el documento
                document.Close();
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
