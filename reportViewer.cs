using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace ETIQUETADO_ARTICULOS
{
    public partial class reportViewer : Form
    {
        public reportViewer()
        {
            InitializeComponent();
        }

        private conexion con = new conexion();
        private SqlCommand command = new SqlCommand();
        private Form1 frm = new Form1();

        public void imprimirEtiquetaA(string articulo)
        {
            try
            {

                DataTable prueba = etiquetasArticulo(articulo);
                ReportDocument crystal = new ReportDocument();
                crystal.Load(@"C:\REPORTESIZOTE\rptEtiquetasIzote.rpt");

                crystal.SetDataSource(prueba);
                ViewEtiqueta.ReportSource = crystal;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable etiquetasArticulo(string numero_articulo)
        {
            try
            {
                DataTable returnTable = new DataTable("data");
                con.connection.Open();
                command.Connection = con.connection;
                command.CommandText = $"exec sp_etiquetas_articulo"+ " '" + numero_articulo + "'";
                returnTable.Load(command.ExecuteReader());
                return returnTable;
            }
            catch (Exception ex)
            {
                //error = ex.ToString();
                return null;
            }
            finally
            {
                con.connection.Close();
            }
        }



        private void reportViewer_Load(object sender, EventArgs e)
        {

            this.ViewEtiqueta.RefreshReport();
        }


    }
}
