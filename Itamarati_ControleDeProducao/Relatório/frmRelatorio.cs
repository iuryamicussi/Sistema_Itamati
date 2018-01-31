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

namespace Itamarati_ControleDeProducao.Relatório
{
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
        }

        public void imprimir(string str_NomeDoRelatorio, List<DataView> lst_Dados)
        {
            int int_indiceDaDefinicaoDosDados = 0;

            //Atribui nome ao relatório
            this.rpt_Relatorio.LocalReport.ReportPath = @"Relatório\Arquivos\" + str_NomeDoRelatorio;

            //Alimenta o relatório com os dados da lista
            this.rpt_Relatorio.LocalReport.DataSources.Clear();
            foreach (DataView dados in lst_Dados)
                if (dados != null)
                {
                    this.rpt_Relatorio.LocalReport.DataSources.Add
                    (
                        new ReportDataSource
                        (
                            this.rpt_Relatorio.LocalReport.GetDataSourceNames()[int_indiceDaDefinicaoDosDados],
                            dados
                        )
                    );
                    int_indiceDaDefinicaoDosDados++;
                }

            //Atualiza e imprime na tela
            this.rpt_Relatorio.RefreshReport();
            this.Show();
        }
    }
}
