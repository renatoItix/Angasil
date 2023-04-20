using ControleCofre.DAL;
using ControleCofre.DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleCofre
{
    public partial class frmReciboMov : Form
    {
        MovimentoDTO _movi;

        public frmReciboMov()
        {
            InitializeComponent();
        }

        public frmReciboMov(MovimentoDTO movi)
        {
            _movi = movi;
            InitializeComponent();
        }

        private void frmReciboMov_Load(object sender, EventArgs e)
        {
            AtualizaRelatorio();
          //  this.reportViewer1.RefreshReport();
        }

        private void AtualizaRelatorio()
        {
            try
            {
                DataTable oTable = new DataTable();
                IList<MovimentoDTO> ListMov = new List<MovimentoDTO>();

                oTable = MovimentoDAL.CarregaRelatorioRecibo(_movi.codigo);
                string strReportPath = @"Report2.rdlc";

                reportViewer1.LocalReport.ReportPath = strReportPath;
                ReportDataSource myReportDataSource = new ReportDataSource();
                myReportDataSource = new ReportDataSource("DataSet1Relat2", oTable);

                reportViewer1.Clear();
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(myReportDataSource);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
