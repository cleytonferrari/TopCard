using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace prjSystem
{
    public partial class rel_form : Form
    {
        public rel_form()
        {
            InitializeComponent();
        }

        private CrystalDecisions.CrystalReports.Engine.ReportDocument _report;
        public CrystalDecisions.CrystalReports.Engine.ReportDocument report
        {
            get
            {
                return _report;
            }
            set
            {
                _report = value;
            }
        }
        private DataSet _ds;
        public DataSet ds
        {
            get
            {
                return _ds;
            }
            set
            {
                _ds = value;
            }
        }


        private void rel_frm_bairro_Load(object sender, EventArgs e)
        {
            
            _report.SetDataSource(ds);
            crystalReportViewer.ReportSource = _report;
            crystalReportViewer.RefreshReport();
        }
    }
}
