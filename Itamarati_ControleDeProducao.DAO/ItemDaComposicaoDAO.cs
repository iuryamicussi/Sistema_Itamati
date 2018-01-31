using Itamarati_ControleDeProducao.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.DAO
{
    public class ItemDaComposicaoDAO
    {
        private MySqlCommand con_ComandoParaSerExecutado;
        private MySqlDataAdapter ada_AdaptadorDeDados;
        private MySqlDataReader red_LeituraDoBanco;
        private int int_Retorno;

        //Busca lista de Insumos cadastrados no BD
        public DataView BuscaListaDeItemDaComposicaoDoProduto(int int_CodigoDoProduto)
        {
            DataTable lst_ItensDaComposicaoDoProduto = new DataTable();
            DataView dtv_ItensDaComposicaoDoProduto;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(Insumo.CodigoDoInsumo, 6, '0') as CodigoDoInsumo, NomeDoInsumo as DescricaoDoInsumo, UnidadeDeMedidaDoInsumo, QuantidadeUtilizada, ValorUnitarioDaUltimaCompraDoInsumo, (ValorUnitarioDaUltimaCompraDoInsumo * QuantidadeUtilizada) as TotalDoItem " +
                                                          "FROM Insumo Inner Join ComposicaoDoProduto On Insumo.CodigoDoInsumo = ComposicaoDoProduto.CodigoDoInsumo " +
                                                          "Where ComposicaoDoProduto.CodigoDoProduto = @codigoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ItensDaComposicaoDoProduto);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ItensDaComposicaoDoProduto = new DataView(lst_ItensDaComposicaoDoProduto);
            return dtv_ItensDaComposicaoDoProduto;
        }

        #region Funções de Persistência

        //Funções de Insert, Update e Delete
        public int IncluirNovoItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO, int int_CodigoDoProduto)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "INSERT INTO ComposicaoDoProduto " +
                                                          "(`CodigoDoProduto`, `CodigoDoInsumo`, `QuantidadeUtilizada`, `TotalDoItem`) " +
                                                          "VALUES (@codigoDoProduto, @codigoDoInsumo, @quantidadeUtilizada, @totalDoItem)";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("quantidadeUtilizada", MySqlDbType.Float).Value = obj_ItemDaComposicaoDTO.QuantidadeDoItem;
                con_ComandoParaSerExecutado.Parameters.Add("totalDoItem", MySqlDbType.Float).Value = obj_ItemDaComposicaoDTO.TotalDoItem;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        public int IncluirComposicao(IList<ItemDaComposicaoDTO> lst_ItemDaComposicaoDTO, int int_CodigoDoProduto)
        {
            //ItemDaComposicaoDTO obj_ItemDaComposicaoDTO = new ItemDaComposicaoDTO();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                foreach(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO in lst_ItemDaComposicaoDTO)
                {
                    con_ComandoParaSerExecutado = new MySqlCommand();
                    con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                    con_ComandoParaSerExecutado.CommandText = "INSERT INTO ComposicaoDoProduto " +
                                                              "(`CodigoDoProduto`, `CodigoDoInsumo`, `QuantidadeUtilizada`) " +
                                                              "VALUES (@codigoDoProduto, @codigoDoInsumo, @quantidadeUtilizada)";

                    con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;
                    con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo;
                    con_ComandoParaSerExecutado.Parameters.Add("quantidadeUtilizada", MySqlDbType.Float).Value = obj_ItemDaComposicaoDTO.QuantidadeDoItem;

                    con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                    int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                }
                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }


        public int AtualizaInformacoesDoItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO, int int_CodigoDoProduto, int int_CodigoDoInsumoAnterior)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update ComposicaoDoProduto " +
                                                          "Set `CodigoDoInsumo`= @codigoDoInsumo,`QuantidadeUtilizada`=@quantidadeUtilizada, " +
                                                          "`TotalDoItem`=@totalDoItem " +
                                                          "Where `CodigoDoProduto` = @codigoDoProduto And `CodigoDoInsumo` = @codigoDoInsumoAnterior";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("quantidadeUtilizada", MySqlDbType.Float).Value = obj_ItemDaComposicaoDTO.QuantidadeDoItem;
                con_ComandoParaSerExecutado.Parameters.Add("totalDoItem", MySqlDbType.Float).Value = obj_ItemDaComposicaoDTO.TotalDoItem;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumoAnterior", MySqlDbType.Int32).Value = int_CodigoDoInsumoAnterior;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        public int ExcluiInformacoesDoItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO, int int_CodigoDoProduto)
        {

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM ComposcaoDoProduto WHERE `CodigoDoInsumo` = @codigoDoInsumo And CodigoDoProduto = @codigoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = obj_ItemDaComposicaoDTO.Insumo.CodigoDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        public int ExcluiInformacoesDaComposicao(int int_CodigoDoProduto)
        {

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM ComposicaoDoProduto WHERE CodigoDoProduto = @codigoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        #endregion
    }
}
