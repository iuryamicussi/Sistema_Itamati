using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itamarati_ControleDeProducao.DTO;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using Itamarati_ControleDeProducao.Controller;

namespace Itamarati_ControleDeProducao.DAO
{
    public class UsuarioDAO
    {
        private MySqlCommand con_ComandoParaSerExecutado;
        private MySqlDataAdapter ada_AdaptadorDeDados;
        private MySqlDataReader red_LeituraDoBanco;
        private int retorno;

        #region Funções de Busca e Autenticação
        //Busca lista de usuários cadastrados no BD
        public DataView BuscaListaDeUsuariosCadastrados()
        {
            DataTable lst_UsuariosCadastrados = new DataTable();
            DataView dtv_ListaDeUsuariosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CodigoDoUsuario, FotoDePerfil, LoginDoUsuario, NomeDoUsuario, DataHoraDeCadastro, StatusDoUsuario, UsuarioGerente FROM Usuario";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_UsuariosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeUsuariosCadastrados = new DataView(lst_UsuariosCadastrados);
            return dtv_ListaDeUsuariosCadastrados;
        }

        //Autentica Usuário digitado
        public UsuarioDTO AutenticaUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            DataTable lst_UsuariosCadastrados = new DataTable();
            InformacoesDoHardware obj_InformacoesDoHardware = new InformacoesDoHardware();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CodigoDoUsuario, FotoDePerfil, LoginDoUsuario, NomeDoUsuario, DataHoraDeCadastro, StatusDoUsuario, UsuarioGerente FROM Usuario Where LoginDoUsuario = @loginDoUsuario And SenhaDoUsuario = @senhaDoUsuario";

                con_ComandoParaSerExecutado.Parameters.Add("loginDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.LoginDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("senhaDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.SenhaDoUsuario;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_UsuariosCadastrados);

                if(lst_UsuariosCadastrados.Rows.Count > 0)
                {
                    obj_UsuarioDTO.CodigoDoUsuario = Convert.ToInt32(lst_UsuariosCadastrados.Rows[0]["CodigoDoUsuario"]);
                    obj_UsuarioDTO.NomeDoUsuario = lst_UsuariosCadastrados.Rows[0]["NomeDoUsuario"].ToString();
                    obj_UsuarioDTO.LoginDoUsuario = lst_UsuariosCadastrados.Rows[0]["LoginDoUsuario"].ToString();
                    obj_UsuarioDTO.StatusDoUsuario = (Boolean)lst_UsuariosCadastrados.Rows[0]["StatusDoUsuario"];
                    obj_UsuarioDTO.UsuarioGerente = (Boolean)lst_UsuariosCadastrados.Rows[0]["UsuarioGerente"];
                    obj_UsuarioDTO.DataHoraDeCadastro = Convert.ToDateTime(lst_UsuariosCadastrados.Rows[0]["DataHoraDeCadastro"]);

                    using (MemoryStream mStream = new MemoryStream((byte[])lst_UsuariosCadastrados.Rows[0]["FotoDePerfil"]))
                    {
                        obj_UsuarioDTO.FotoDoUsuario = Image.FromStream(mStream);
                    }

                    //Atualiza Último usuário logado
                    if(VerificaSeExisteRegistroDeUsuarioLogado(obj_InformacoesDoHardware.BuscaNumeroDoSerial()) > 0)
                    {
                        AtualizaInformacoesDoUltimoUsuarioLogado(obj_InformacoesDoHardware.BuscaNumeroDoSerial(), obj_UsuarioDTO.CodigoDoUsuario);
                    }
                    else
                    {
                        InsereUltimoUsuarioLogado(obj_InformacoesDoHardware.BuscaNumeroDoSerial(), obj_UsuarioDTO.CodigoDoUsuario);
                    }
                }
                else
                {
                    obj_UsuarioDTO.LoginDoUsuario = null;
                    obj_UsuarioDTO.SenhaDoUsuario = null;
                }

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_UsuarioDTO;
        }

        //Busca Usuário por Login para visualizar a Imagem
        public UsuarioDTO BuscaUsuarioPorLogin(String str_LoginDoUsuario)
        {
            UsuarioDTO obj_UsuarioDTO = new UsuarioDTO();
            DataTable lst_UsuariosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CodigoDoUsuario, FotoDePerfil, LoginDoUsuario, NomeDoUsuario, DataHoraDeCadastro, StatusDoUsuario, UsuarioGerente FROM Usuario Where `LoginDoUsuario` = @loginDoUsuario";

                con_ComandoParaSerExecutado.Parameters.Add("loginDoUsuario", MySqlDbType.VarChar).Value = str_LoginDoUsuario;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_UsuariosCadastrados);

                if (lst_UsuariosCadastrados.Rows.Count > 0)
                {
                    obj_UsuarioDTO.CodigoDoUsuario = Convert.ToInt32(lst_UsuariosCadastrados.Rows[0]["CodigoDoUsuario"]);
                    obj_UsuarioDTO.NomeDoUsuario = lst_UsuariosCadastrados.Rows[0]["NomeDoUsuario"].ToString();
                    obj_UsuarioDTO.LoginDoUsuario = lst_UsuariosCadastrados.Rows[0]["LoginDoUsuario"].ToString();
                    obj_UsuarioDTO.StatusDoUsuario = (Boolean)lst_UsuariosCadastrados.Rows[0]["StatusDoUsuario"];
                    obj_UsuarioDTO.UsuarioGerente = (Boolean)lst_UsuariosCadastrados.Rows[0]["UsuarioGerente"];
                    obj_UsuarioDTO.DataHoraDeCadastro = Convert.ToDateTime(lst_UsuariosCadastrados.Rows[0]["DataHoraDeCadastro"]);

                    using (MemoryStream mStream = new MemoryStream((byte[])lst_UsuariosCadastrados.Rows[0]["FotoDePerfil"]))
                    {
                        obj_UsuarioDTO.FotoDoUsuario = Image.FromStream(mStream);
                    }
                }
                else
                {
                    obj_UsuarioDTO.LoginDoUsuario = null;
                    obj_UsuarioDTO.SenhaDoUsuario = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_UsuarioDTO;
        }

        //Busca Usuário por Login para visualizar a Imagem
        public UsuarioDTO BuscaUsuarioPorCodigo(int int_CodigoDoUsuario)
        {
            UsuarioDTO obj_UsuarioDTO = new UsuarioDTO();
            DataTable lst_UsuariosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CodigoDoUsuario, FotoDePerfil, LoginDoUsuario, NomeDoUsuario, DataHoraDeCadastro, StatusDoUsuario, UsuarioGerente FROM Usuario Where CodigoDoUsuario = " + int_CodigoDoUsuario;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_UsuariosCadastrados);

                if (lst_UsuariosCadastrados.Rows.Count > 0)
                {
                    obj_UsuarioDTO.CodigoDoUsuario = Convert.ToInt32(lst_UsuariosCadastrados.Rows[0]["CodigoDoUsuario"]);
                    obj_UsuarioDTO.NomeDoUsuario = lst_UsuariosCadastrados.Rows[0]["NomeDoUsuario"].ToString();
                    obj_UsuarioDTO.LoginDoUsuario = lst_UsuariosCadastrados.Rows[0]["LoginDoUsuario"].ToString();
                    obj_UsuarioDTO.StatusDoUsuario = (Boolean)lst_UsuariosCadastrados.Rows[0]["StatusDoUsuario"];
                    obj_UsuarioDTO.UsuarioGerente = (Boolean)lst_UsuariosCadastrados.Rows[0]["UsuarioGerente"];
                    obj_UsuarioDTO.DataHoraDeCadastro = Convert.ToDateTime(lst_UsuariosCadastrados.Rows[0]["DataHoraDeCadastro"]);

                    using (MemoryStream mStream = new MemoryStream((byte[])lst_UsuariosCadastrados.Rows[0]["FotoDePerfil"]))
                    {
                        obj_UsuarioDTO.FotoDoUsuario = Image.FromStream(mStream);
                    }
                }
                else
                {
                    obj_UsuarioDTO.LoginDoUsuario = null;
                    obj_UsuarioDTO.SenhaDoUsuario = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_UsuarioDTO;
        }

        //Verifica se existe usuário registro como último logado
        public int VerificaSeExisteRegistroDeUsuarioLogado(String str_SerialNumber)
        {
            int int_NumeroDeRegistros = 0;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT * FROM UltimoUsuarioLogado Where NumeroDoSerial = @numeroDoSerial";

                con_ComandoParaSerExecutado.Parameters.Add("numeroDoSerial", MySqlDbType.VarChar).Value = str_SerialNumber;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                red_LeituraDoBanco = con_ComandoParaSerExecutado.ExecuteReader();

                if(red_LeituraDoBanco.HasRows)
                {
                    red_LeituraDoBanco.Read();
                    int_NumeroDeRegistros = red_LeituraDoBanco.GetInt32(1);
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }

            return int_NumeroDeRegistros;
        }
        #endregion

        #region Funções de Persistência
        //Funções de Insert, Update e Delete
        public int IncluirNovoUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            byte[] arr_ArrayDeBytesDaImagem;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Converter Imagem em vetor de Bytes
                ImageConverter icv_ConversorDeImagem = new ImageConverter();
                arr_ArrayDeBytesDaImagem = (byte[])icv_ConversorDeImagem.ConvertTo(obj_UsuarioDTO.FotoDoUsuario, typeof(byte[]));

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "INSERT INTO Usuario " + 
                                                          "(`NomeDoUsuario`, `LoginDoUsuario`, `SenhaDoUsuario`, `DataHoraDeCadastro`, " + 
                                                          "`StatusDoUsuario`, `UsuarioGerente`, `FotoDePerfil`) " + 
                                                          "VALUES (@nomeDoUsuario, @loginDoUsuario, @senhaDoUsuario, @dataDeCadastro, " + 
                                                          "@statusDoUsuario, @usuarioGerente, @fotoDePerfil)";

                con_ComandoParaSerExecutado.Parameters.Add("nomeDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.NomeDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("loginDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.LoginDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("senhaDoUsuario", MySqlDbType.VarChar).Value = "495051525354";
                con_ComandoParaSerExecutado.Parameters.Add("dataDeCadastro", MySqlDbType.DateTime).Value = obj_UsuarioDTO.DataHoraDeCadastro;
                con_ComandoParaSerExecutado.Parameters.Add("statusDoUsuario", MySqlDbType.Bit).Value = obj_UsuarioDTO.StatusDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("usuarioGerente", MySqlDbType.Bit).Value = obj_UsuarioDTO.UsuarioGerente;
                con_ComandoParaSerExecutado.Parameters.Add("fotoDePerfil", MySqlDbType.LongBlob).Value = arr_ArrayDeBytesDaImagem;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        public int AtualizaInformacoesDoUsuario(UsuarioDTO obj_UsuarioDTO, String str_LoginDoUsuario)
        {
            byte[] arr_ArrayDeBytesDaImagem;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Converter Imagem em vetor de Bytes
                ImageConverter icv_ConversorDeImagem = new ImageConverter();
                arr_ArrayDeBytesDaImagem = (byte[])icv_ConversorDeImagem.ConvertTo(obj_UsuarioDTO.FotoDoUsuario, typeof(byte[]));

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update Usuario " +
                                                          "Set `NomeDoUsuario`=@nomeDoUsuario,`LoginDoUsuario`=@loginDoUsuario, " +
                                                          "`StatusDoUsuario`=@statusDoUsuario,`UsuarioGerente`=@usuarioGerente, " +
                                                          "`FotoDePerfil`=@fotoDePerfil Where `LoginDoUsuario` = @loginAnteriorDoUsuario";

                con_ComandoParaSerExecutado.Parameters.Add("nomeDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.NomeDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("loginDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.LoginDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("statusDoUsuario", MySqlDbType.Bit).Value = obj_UsuarioDTO.StatusDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("usuarioGerente", MySqlDbType.Bit).Value = obj_UsuarioDTO.UsuarioGerente;
                con_ComandoParaSerExecutado.Parameters.Add("fotoDePerfil", MySqlDbType.LongBlob).Value = arr_ArrayDeBytesDaImagem;
                con_ComandoParaSerExecutado.Parameters.Add("loginAnteriorDoUsuario", MySqlDbType.VarChar).Value = str_LoginDoUsuario;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        //Aterar Senha do Usuário
        public int AlterarSenhaDoUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update Usuario " +
                                                          "Set `SenhaDoUsuario`= @senhaDoUsuario Where `CodigoDoUsuario` = @codigoDoUsuario";

                con_ComandoParaSerExecutado.Parameters.Add("senhaDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.SenhaDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoUsuario", MySqlDbType.VarChar).Value = obj_UsuarioDTO.CodigoDoUsuario;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        //Inserir Usuário Logado na tabela de últimos logados
        private int InsereUltimoUsuarioLogado(String str_NumeroDeSerie, int int_CodigoDoUsuario)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "INSERT INTO UltimoUsuarioLogado " +
                                                          "(`NumeroDoSerial`, `CodigoDoUsuario`) " +
                                                          "VALUES (@numeroDoSerial, @codigoDoUsuario)";

                con_ComandoParaSerExecutado.Parameters.Add("numeroDoSerial", MySqlDbType.VarChar).Value = str_NumeroDeSerie;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoUsuario", MySqlDbType.Int32).Value = int_CodigoDoUsuario;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        //Atualizar Ultimo Usuário Logado
        private int AtualizaInformacoesDoUltimoUsuarioLogado(String str_NumeroDeSerie, int int_CodigoDoUsuario)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update UltimoUsuarioLogado " +
                                                          "Set `CodigoDoUsuario` = @codigoeDoUsuario Where `NumeroDoSerial` = @numeroDoSerial";

                con_ComandoParaSerExecutado.Parameters.Add("codigoeDoUsuario", MySqlDbType.Int32).Value = int_CodigoDoUsuario;
                con_ComandoParaSerExecutado.Parameters.Add("numeroDoSerial", MySqlDbType.VarChar).Value = str_NumeroDeSerie;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        public int ExcluiInformacoesDoUsuario(UsuarioDTO obj_UsuarioDTO)
        {

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM Usuario WHERE `CodigoDoUsuario` = @codigoDoUsuario";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoUsuario", MySqlDbType.Int32).Value = obj_UsuarioDTO.CodigoDoUsuario;
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                //Se o usuário foi excluído, excluí também o registro de entrada
                if(retorno > 0)
                {
                    ExcluiInformacoesDoUltimoUsuarioLogado(obj_UsuarioDTO.CodigoDoUsuario);
                }

                con_ConexaoAtiva.Close();
            }
            return retorno;
        }

        private int ExcluiInformacoesDoUltimoUsuarioLogado(int int_CodigoDoUsuario)
        {

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM UltimoUsuarioLogado WHERE `CodigoDoUsuario` = @codigoDoUsuario";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoUsuario", MySqlDbType.Int32).Value = int_CodigoDoUsuario;
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                con_ComandoParaSerExecutado.ExecuteNonQuery();
                con_ConexaoAtiva.Close();
            }
            return retorno;
        }
        #endregion
    }
}
