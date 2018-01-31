using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.DAO
{
    public class ProducaoDAO
    {

        private MySqlCommand con_ComandoParaSerExecutado;
        private MySqlDataAdapter ada_AdaptadorDeDados;
        private MySqlDataReader red_LeituraDoBanco;
        private int int_Retorno;

        #region Funções de Busca
        //Busca dados para o relatorio controle de produção
        public DataView dadosParaImpressaoDoRelatorioControleDeProducao(List<int> lst_CodigosDosProdutosEscolhidos)
        {
            DataTable lst_Dados = new DataTable();
            DataView dtv_Dados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = 
                        "SELECT * FROM produto pr INNER JOIN composicaodoproduto cp " +
                        "ON pr.CodigoDoProduto = cp.CodigoDoProduto INNER JOIN insumo imo " +
                        "ON cp.CodigoDoInsumo = imo.CodigoDoInsumo INNER JOIN grupo gr ON " +
                        "pr.CodigoDoGrupoDoProduto = gr.CodigoDoGrupo ";

                //Adiciona produtos que serão buscados
                if (lst_CodigosDosProdutosEscolhidos.Count > 0)
                {
                    con_ComandoParaSerExecutado.CommandText += "WHERE pr.CodigoDoProduto IN (";
                    foreach (int codigo in lst_CodigosDosProdutosEscolhidos)
                        con_ComandoParaSerExecutado.CommandText += codigo + ",";
                    con_ComandoParaSerExecutado.CommandText += " -1)";
                }

                //Atribui conexão 
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_Dados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_Dados = new DataView(lst_Dados);
            return dtv_Dados;
        }
        #endregion

    }
}
