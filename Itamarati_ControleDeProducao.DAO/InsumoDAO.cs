using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itamarati_ControleDeProducao.DTO;
using MySql.Data.MySqlClient;

namespace Itamarati_ControleDeProducao.DAO
{
    public class InsumoDAO
    {
        private MySqlCommand con_ComandoParaSerExecutado;
        private MySqlDataAdapter ada_AdaptadorDeDados;
        private MySqlDataReader red_LeituraDoBanco;
        private int int_Retorno;
        
        #region Funções de Busca e Autenticação

        //Busca lista de Insumos cadastrados no BD
        public DataView BuscaListaDeInsumosCadastrados()
        {
            DataTable lst_InsumosCadastrados = new DataTable();
            DataView dtv_ListaDeInsumosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(CodigoDoInsumo, 6, '0') as CodigoDoInsumo, NomeDoInsumo, UnidadeDeMedidaDoInsumo, ValorUnitarioDaUltimaCompraDoInsumo, DataHoraDeCadastroDoInsumo FROM Insumo";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_InsumosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeInsumosCadastrados = new DataView(lst_InsumosCadastrados);
            return dtv_ListaDeInsumosCadastrados;
        }

        public InsumoDTO BuscaInsumoPorCodigo(int int_CodigoDoInsumo)
        {
            InsumoDTO obj_InumoDTO = new InsumoDTO();
            DataTable lst_InsumosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(CodigoDoInsumo, 6, '0') as CodigoDoInsumo, Insumo.* FROM Insumo Where `CodigoDoInsumo` = @codigoDoInsumo";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = int_CodigoDoInsumo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_InsumosCadastrados);

                if (lst_InsumosCadastrados.Rows.Count > 0)
                {
                    obj_InumoDTO.CodigoDoInsumo = Convert.ToInt32(lst_InsumosCadastrados.Rows[0]["CodigoDoInsumo"]);
                    obj_InumoDTO.NomeDoInsumo = lst_InsumosCadastrados.Rows[0]["NomeDoInsumo"].ToString();
                    obj_InumoDTO.UnidadeDeMedidaDoInsumo = lst_InsumosCadastrados.Rows[0]["UnidadeDeMedidaDoInsumo"].ToString();
                    obj_InumoDTO.DataHoraDeCadastroDoInsumo = Convert.ToDateTime(lst_InsumosCadastrados.Rows[0]["DataHoraDeCadastroDoInsumo"]);
                    obj_InumoDTO.ValorUnitarioDaUltimaCompraDoInsumo = (float)lst_InsumosCadastrados.Rows[0]["ValorUnitarioDaUltimaCompraDoInsumo"];
                }
                else
                {
                    obj_InumoDTO.CodigoDoInsumo = -1;
                    obj_InumoDTO.NomeDoInsumo = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_InumoDTO;
        }

        public InsumoDTO BuscaInsumoPorDescricao(string str_DescricaoDoInsumo)
        {
            InsumoDTO obj_InumoDTO = new InsumoDTO();
            DataTable lst_InsumosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CodigoDoInsumo, NomeDoInsumo, UnidadeDeMedidaDoInsumo, DataHoraDeCadastroDoInsumo, ValorUnitarioDaUltimaCompraDoInsumo FROM Insumo Where NomeDoInsumo = @descricaoDoInsumo" ;

                con_ComandoParaSerExecutado.Parameters.Add("descricaoDoInsumo", MySqlDbType.VarChar).Value = str_DescricaoDoInsumo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_InsumosCadastrados);

                if (lst_InsumosCadastrados.Rows.Count > 0)
                {
                    obj_InumoDTO.CodigoDoInsumo = Convert.ToInt32(lst_InsumosCadastrados.Rows[0]["CodigoDoInsumo"]);
                    obj_InumoDTO.NomeDoInsumo = lst_InsumosCadastrados.Rows[0]["NomeDoInsumo"].ToString();
                    obj_InumoDTO.UnidadeDeMedidaDoInsumo = lst_InsumosCadastrados.Rows[0]["UnidadeDeMedidaDoInsumo"].ToString();
                    obj_InumoDTO.DataHoraDeCadastroDoInsumo = Convert.ToDateTime(lst_InsumosCadastrados.Rows[0]["DataHoraDeCadastroDoInsumo"]);
                    obj_InumoDTO.ValorUnitarioDaUltimaCompraDoInsumo = (float)lst_InsumosCadastrados.Rows[0]["ValorUnitarioDaUltimaCompraDoInsumo"];
                }
                else
                {
                    obj_InumoDTO.CodigoDoInsumo = -1;
                    obj_InumoDTO.NomeDoInsumo = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_InumoDTO;
        }

        //retorno lista de strings de autocomplete para código
        public DataView BuscaCodigosEDescriçãoDoInsumoParaAutocompletar()
        {
            DataTable lst_InsumosCadastrados = new DataTable();
            DataView dtv_ListaDeInsumosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(CodigoDoInsumo, 6, '0') as CodigoDoInsumo, NomeDoInsumo FROM Insumo";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_InsumosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeInsumosCadastrados = new DataView(lst_InsumosCadastrados);
            return dtv_ListaDeInsumosCadastrados;
        }

        public DataView BuscaDescriçãoDoInsumoParaAutocompletar()
        {
            DataTable lst_InsumosCadastrados = new DataTable();
            DataView dtv_ListaDeInsumosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT NomeDoInsumo FROM Insumo";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_InsumosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeInsumosCadastrados = new DataView(lst_InsumosCadastrados);
            return dtv_ListaDeInsumosCadastrados;
        }
        #endregion

        #region Funções de Persistência

        //Funções de Insert, Update e Delete
        public int IncluirNovoInsumo(InsumoDTO obj_InsumoDTO)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "INSERT INTO Insumo " +
                                                          "(`CodigoDoInsumo`, `NomeDoInsumo`, `unidadeDeMedidaDoInsumo`, `valorUnitarioDaUltimaCompraDoInsumo`, `dataHoraDeCadastroDoInsumo`) " +
                                                          "VALUES (@codigoDoInsumo, @NomeDoInsumo, @unidadeDeMedidaDoInsumo, @valorUnitarioDaUltimaCompraDoInsumo, @dataHoraDeCadastroDoInsumo)";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = obj_InsumoDTO.CodigoDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("NomeDoInsumo", MySqlDbType.VarChar).Value = obj_InsumoDTO.NomeDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("unidadeDeMedidaDoInsumo", MySqlDbType.VarChar).Value = obj_InsumoDTO.UnidadeDeMedidaDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("valorUnitarioDaUltimaCompraDoInsumo", MySqlDbType.Float).Value = obj_InsumoDTO.ValorUnitarioDaUltimaCompraDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("dataHoraDeCadastroDoInsumo", MySqlDbType.DateTime).Value = obj_InsumoDTO.DataHoraDeCadastroDoInsumo;
                
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }


        public int AtualizaInformacoesDoInsumo(InsumoDTO obj_InsumoDTO, int int_CodigoDoInsumo)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update Insumo " +
                                                          "Set `NomeDoInsumo`=@nomeDoInsumo,`UnidadeDeMedidaDoInsumo`=@unidadeDeMedidaDoInsumo, " +
                                                          "`ValorUnitarioDaUltimaCompraDoInsumo`=@valorUnitarioDaUltimaCompraDoInsumo " +
                                                          "Where `CodigoDoInsumo` = " + int_CodigoDoInsumo;

                con_ComandoParaSerExecutado.Parameters.Add("nomeDoInsumo", MySqlDbType.VarChar).Value = obj_InsumoDTO.NomeDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("unidadeDeMedidaDoInsumo", MySqlDbType.VarChar).Value = obj_InsumoDTO.UnidadeDeMedidaDoInsumo;
                con_ComandoParaSerExecutado.Parameters.Add("valorUnitarioDaUltimaCompraDoInsumo", MySqlDbType.Float).Value = obj_InsumoDTO.ValorUnitarioDaUltimaCompraDoInsumo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        public int ExcluiInformacoesDoInsumo(InsumoDTO obj_InsumoDTO)
        {

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM Insumo WHERE `CodigoDoInsumo` = @codigoDoInsumo";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoInsumo", MySqlDbType.Int32).Value = obj_InsumoDTO.CodigoDoInsumo;
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        #endregion

    }
}