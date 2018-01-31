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
    public class GrupoDAO
    {

        private MySqlCommand con_ComandoParaSerExecutado;
        private MySqlDataAdapter ada_AdaptadorDeDados;
        private MySqlDataReader red_LeituraDoBanco;
        private int retorno;

        #region Funções de Busca e Autenticação

        public DataView BuscaListaDeGruposCadastrados()
        {
            DataTable lst_GruposCadastrados = new DataTable();
            DataView dtv_ListaDeGruposCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(CodigoDoGrupo, 3, '0') as CodigoDoGrupo, NomeDoGrupo, DataHoraDeCadastroDoGrupo FROM Grupo";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_GruposCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeGruposCadastrados = new DataView(lst_GruposCadastrados);
            return dtv_ListaDeGruposCadastrados;
        }

        //Busca Codigo do Grupo
        public int BuscaGrupoPorAtributos(GrupoDTO obj_GrupoDTO)
        {
            int int_CodigoDoGrupo;
            DataTable lst_GruposCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT MAX(CodigoDoGrupo) as CodigoDoGrupo FROM Grupo Where `NomeDoGrupo` Like @nomeDoGrupo And " +
                                                                                                    "`DataHoraDeCadastroDoGrupo` = @dataHoraDeCadastroDoGrupo ";

                con_ComandoParaSerExecutado.Parameters.Add("nomeDoGrupo", MySqlDbType.VarChar).Value = "%" + obj_GrupoDTO.NomeDoGrupo + "%";
                con_ComandoParaSerExecutado.Parameters.Add("dataHoraDeCadastroDoGrupo", MySqlDbType.DateTime).Value = obj_GrupoDTO.DataHoraDeCadastroDoGrupo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_GruposCadastrados);

                if (lst_GruposCadastrados.Rows.Count > 0)
                {
                    int_CodigoDoGrupo = Convert.ToInt32(lst_GruposCadastrados.Rows[0]["CodigoDoGrupo"]);
                }
                else
                {
                    int_CodigoDoGrupo = -1;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return int_CodigoDoGrupo;
        }

        //Busca Codigo do Grupo
        public GrupoDTO BuscaGrupoPorCodigo(int int_CodigoDoGrupo)
        {
            GrupoDTO obj_GrupoDTO = new GrupoDTO();
            DataTable lst_GruposCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT * FROM Grupo Where `CodigoDoGrupo` = @codigoDoGrupo";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupo", MySqlDbType.Int32).Value = int_CodigoDoGrupo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_GruposCadastrados);

                if (lst_GruposCadastrados.Rows.Count > 0)
                {
                    obj_GrupoDTO.CodigoDoGrupo = Convert.ToInt32(lst_GruposCadastrados.Rows[0]["CodigoDoGrupo"]);
                    obj_GrupoDTO.NomeDoGrupo = lst_GruposCadastrados.Rows[0]["NomeDoGrupo"].ToString();
                }
                else
                {
                    obj_GrupoDTO.CodigoDoGrupo = 0;
                    obj_GrupoDTO.NomeDoGrupo = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_GrupoDTO;
        }

        public GrupoDTO BuscaGrupoPorDescricao(string str_DescricaoDoGrupo)
        {
            GrupoDTO obj_GrupoDTO = new GrupoDTO();
            DataTable lst_GruposCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT * FROM Grupo Where NomeDoGrupo Like @descricaoDoGrupo";

                con_ComandoParaSerExecutado.Parameters.Add("descricaoDoGrupo", MySqlDbType.VarChar).Value = "%" + str_DescricaoDoGrupo + "%";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_GruposCadastrados);

                if (lst_GruposCadastrados.Rows.Count > 0)
                {
                    obj_GrupoDTO.CodigoDoGrupo = Convert.ToInt32(lst_GruposCadastrados.Rows[0]["CodigoDoGrupo"]);
                    obj_GrupoDTO.NomeDoGrupo = lst_GruposCadastrados.Rows[0]["NomeDoGrupo"].ToString();
                }
                else
                {
                    obj_GrupoDTO.CodigoDoGrupo = -1;
                    obj_GrupoDTO.NomeDoGrupo = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_GrupoDTO;
        }

        public DataView BuscaInformacoesDoGrupoParaCombo()
        {
            DataTable lst_InsumosCadastrados = new DataTable();
            DataView dtv_ListaDeGruposCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CONCAT(LPAD(CodigoDoGrupo, 3, '0'), ' - ', NomeDoGrupo)  as Grupo FROM Grupo";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_InsumosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeGruposCadastrados = new DataView(lst_InsumosCadastrados);
            return dtv_ListaDeGruposCadastrados;
        }

        #endregion

        #region Funções de Persistência

        public int IncluirNovoGrupo(GrupoDTO obj_GrupoDTO)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "INSERT INTO Grupo " +
                                                          "(`CodigoDoGrupo`, `NomeDoGrupo`, `DataHoraDeCadastroDoGrupo`) " +
                                                          "VALUES (@codigoDoGrupo, @nomeDoGrupo, @dataHoraDeCadastroDoGrupo)";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupo", MySqlDbType.Int32).Value = obj_GrupoDTO.CodigoDoGrupo;
                con_ComandoParaSerExecutado.Parameters.Add("nomeDoGrupo", MySqlDbType.VarChar).Value = obj_GrupoDTO.NomeDoGrupo;
                con_ComandoParaSerExecutado.Parameters.Add("dataHoraDeCadastroDoGrupo", MySqlDbType.DateTime).Value = obj_GrupoDTO.DataHoraDeCadastroDoGrupo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                con_ConexaoAtiva.Close();
            }
            return retorno;
        }
        
        public int ExcluiInformacoesDoGrupo(GrupoDTO obj_GrupoDTO)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM Grupo WHERE LPAD(`CodigoDoGrupo`, 3, '0') = @codigoDoGrupo";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupo", MySqlDbType.Int32).Value = obj_GrupoDTO.CodigoDoGrupo;
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        public int AtualizaInformacoesDoGrupo(GrupoDTO obj_GrupoDTO, int codigoDoGrupo)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update Grupo " +
                                                          "Set `NomeDoGrupo`=@nomeDoGrupo " +
                                                          "Where `CodigoDoGrupo` = " + codigoDoGrupo;

                con_ComandoParaSerExecutado.Parameters.Add("nomeDoGrupo", MySqlDbType.VarChar).Value = obj_GrupoDTO.NomeDoGrupo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        #endregion
    }
}
