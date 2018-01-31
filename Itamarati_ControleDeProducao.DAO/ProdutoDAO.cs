using MySql.Data.MySqlClient;
using System.Data;
using Itamarati_ControleDeProducao.DTO;
using System;

namespace Itamarati_ControleDeProducao.DAO
{
    public class ProdutoDAO
    {
        private MySqlCommand con_ComandoParaSerExecutado;
        private MySqlDataAdapter ada_AdaptadorDeDados;
        private MySqlDataReader red_LeituraDoBanco;
        private int int_Retorno;

        #region Funções de Busca
        //Busca lista de produtos cadastrados por grupo
        public DataView BuscaListaDeProdutosCadastradosPorGrupo(int codigoDoGrupo)
        {
            DataTable lst_ProdutosCadastrados = new DataTable();
            DataView dtv_ListaDeProdutosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(CodigoDoProduto, 6, '0') as CodigoDoProduto, DescricaoDoProduto, LarguraDoProduto, ComprimentoDoProduto, EspessuraDoProduto, PesoTotalDoProduto, DataHoraDeCadastro, " +
                    "(Select Sum(ComposicaoDoProduto.QuantidadeUtilizada * Insumo.ValorUnitarioDaUltimaCompraDoInsumo) From " +
                    "ComposicaoDoProduto Inner Join Insumo On ComposicaoDoProduto.CodigoDoInsumo = Insumo.CodigoDoInsumo " +
                    "Where ComposicaoDoProduto.CodigoDoProduto = Produto.CodigoDoProduto) as PrecoUnitarioDoProduto " +
                    "FROM Produto ";

                //Adiciona filtro grupo
                if (codigoDoGrupo != -1)
                {
                    //Cria filtro grupo
                    con_ComandoParaSerExecutado.CommandText = con_ComandoParaSerExecutado.CommandText +
                        "WHERE `CodigoDoGrupo` = @codigoDoGrupo ";

                    //Adiciona parametro
                    con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupo", MySqlDbType.Int32).Value = codigoDoGrupo;
                }

                //Atribui conexão
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                //Executa
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ProdutosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }

            dtv_ListaDeProdutosCadastrados = new DataView(lst_ProdutosCadastrados);
            return dtv_ListaDeProdutosCadastrados;
        }

        //Busca lista de produtos cadastrados por grupo para impressão
        public DataView BuscaListaDeProdutosCadastradosPorGrupoParaImpressao(int codigoDoGrupo)
        {
            DataTable lst_ProdutosCadastrados = new DataTable();
            DataView dtv_ListaDeProdutosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT 'T' as Imprimir, LPAD(CodigoDoProduto, 6, '0') as CodigoDoProduto, DescricaoDoProduto, LarguraDoProduto, ComprimentoDoProduto, EspessuraDoProduto, PesoTotalDoProduto, DataHoraDeCadastro, " +
                    "(Select Sum(ComposicaoDoProduto.QuantidadeUtilizada * Insumo.ValorUnitarioDaUltimaCompraDoInsumo) From " +
                    "ComposicaoDoProduto Inner Join Insumo On ComposicaoDoProduto.CodigoDoInsumo = Insumo.CodigoDoInsumo " +
                    "Where ComposicaoDoProduto.CodigoDoProduto = Produto.CodigoDoProduto) as PrecoUnitarioDoProduto " +
                    "FROM Produto ";

                //Adiciona filtro grupo
                if (codigoDoGrupo != -1)
                {
                    //Cria filtro grupo
                    con_ComandoParaSerExecutado.CommandText = con_ComandoParaSerExecutado.CommandText +
                        "WHERE `CodigoDoGrupoDoProduto` = @codigoDoGrupo ";

                    //Adiciona parametro
                    con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupo", MySqlDbType.Int32).Value = codigoDoGrupo;
                }

                //Atribui conexão
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                //Executa
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ProdutosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }

            dtv_ListaDeProdutosCadastrados = new DataView(lst_ProdutosCadastrados);
            return dtv_ListaDeProdutosCadastrados;
        }

        //Busca lista de Produtos cadastrados no BD
        public DataView BuscaListaDeProdutosCadastrados()
        {
            DataTable lst_ProdutosCadastrados = new DataTable();
            DataView dtv_ListaDeProdutosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT LPAD(CodigoDoProduto, 6, '0') as CodigoDoProduto, DescricaoDoProduto, LarguraDoProduto, ComprimentoDoProduto, EspessuraDoProduto, PesoTotalDoProduto, DataHoraDeCadastro, " +
                    "(Select Sum(ComposicaoDoProduto.QuantidadeUtilizada * Insumo.ValorUnitarioDaUltimaCompraDoInsumo) From " +
                    "ComposicaoDoProduto Inner Join Insumo On ComposicaoDoProduto.CodigoDoInsumo = Insumo.CodigoDoInsumo " +
                    "Where ComposicaoDoProduto.CodigoDoProduto = Produto.CodigoDoProduto) as PrecoUnitarioDoProduto,  " +
                    "CONCAT(LPAD(CodigoDoGrupo, 3, '0'), ' - ', NomeDoGrupo)  as Grupo " +
                    "FROM Produto Left Join Grupo On Produto.CodigoDoGrupoDoProduto = Grupo.CodigoDoGrupo";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ProdutosCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeProdutosCadastrados = new DataView(lst_ProdutosCadastrados);
            return dtv_ListaDeProdutosCadastrados;
        }

        //Busca Produto por Código
        public ProdutoDTO BuscaProdutoPorCodigo(int int_CodigoDoProduto)
        {
            ProdutoDTO obj_ProdutoDTO = new ProdutoDTO();
            DataTable lst_ProdutosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT * FROM Produto Left Join Grupo On Produto.CodigoDoGrupoDoProduto = Grupo.CodigoDoGrupo Where `CodigoDoProduto` = @codigoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ProdutosCadastrados);

                if (lst_ProdutosCadastrados.Rows.Count > 0)
                {
                    obj_ProdutoDTO.CodigoDoProduto = Convert.ToInt32(lst_ProdutosCadastrados.Rows[0]["CodigoDoProduto"]);
                    obj_ProdutoDTO.DescricaoDoProduto = lst_ProdutosCadastrados.Rows[0]["DescricaoDoProduto"].ToString();
                    obj_ProdutoDTO.LarguraDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["LarguraDoProduto"];
                    obj_ProdutoDTO.ComprimentoDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["ComprimentoDoProduto"];
                    obj_ProdutoDTO.EspessuraDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["EspessuraDoProduto"];
                    obj_ProdutoDTO.DataHoraDeCadastroDoProduto = Convert.ToDateTime(lst_ProdutosCadastrados.Rows[0]["DataHoraDeCadastro"]);
                    obj_ProdutoDTO.PesoTotalDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["PesoTotalDoProduto"];

                    obj_ProdutoDTO.GrupoDoProduto = new GrupoDAO().BuscaGrupoPorCodigo(Convert.ToInt32(lst_ProdutosCadastrados.Rows[0]["CodigoDoGrupoDoProduto"]));
                }
                else
                {
                    obj_ProdutoDTO.CodigoDoProduto = -1;
                    obj_ProdutoDTO.DescricaoDoProduto = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_ProdutoDTO;
        }

        public ProdutoDTO BuscaProdutoPorDescricao(string str_DescricaoDoInsumo)
        {
            ProdutoDTO obj_ProdutoDTO = new ProdutoDTO();
            DataTable lst_ProdutosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT * FROM Produto Left Join Grupo On Produto.CodigoDoGrupoDoProduto = Grupo.CodigoDoGrupo Where DescricaoDoProduto Like @descricaoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("descricaoDoProduto", MySqlDbType.VarChar).Value = "%" + str_DescricaoDoInsumo + "%";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ProdutosCadastrados);

                if (lst_ProdutosCadastrados.Rows.Count > 0)
                {
                    obj_ProdutoDTO.CodigoDoProduto = Convert.ToInt32(lst_ProdutosCadastrados.Rows[0]["CodigoDoProduto"]);
                    obj_ProdutoDTO.DescricaoDoProduto = lst_ProdutosCadastrados.Rows[0]["DescricaoDoProduto"].ToString();
                    obj_ProdutoDTO.LarguraDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["LarguraDoProduto"];
                    obj_ProdutoDTO.ComprimentoDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["ComprimentoDoProduto"];
                    obj_ProdutoDTO.EspessuraDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["EspessuraDoProduto"];
                    obj_ProdutoDTO.DataHoraDeCadastroDoProduto = Convert.ToDateTime(lst_ProdutosCadastrados.Rows[0]["DataHoraDeCadastro"]);
                    obj_ProdutoDTO.PesoTotalDoProduto = (float)lst_ProdutosCadastrados.Rows[0]["PesoTotalDoProduto"];

                    obj_ProdutoDTO.GrupoDoProduto = new GrupoDAO().BuscaGrupoPorCodigo(Convert.ToInt32(lst_ProdutosCadastrados.Rows[0]["CodigoDoGrupoDoProduto"]));
                }
                else
                {
                    obj_ProdutoDTO.CodigoDoProduto = -1;
                    obj_ProdutoDTO.DescricaoDoProduto = null;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return obj_ProdutoDTO;
        }

        //Busca Produto por Código
        public int BuscaProdutoPorAtributos(ProdutoDTO obj_ProdutoDTO)
        {
            int int_CodigoDoProduto;
            DataTable lst_UsuariosCadastrados = new DataTable();

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT CodigoDoProduto FROM Produto Where `DescricaoDoProduto` Like @descricaoDoProduto And " +
                                                                                                    "`DataHoraDeCadastro` = @dataHoraDeCadastro ";

                con_ComandoParaSerExecutado.Parameters.Add("descricaoDoProduto", MySqlDbType.VarChar).Value = "%" + obj_ProdutoDTO.DescricaoDoProduto + "%";
                con_ComandoParaSerExecutado.Parameters.Add("dataHoraDeCadastro", MySqlDbType.Datetime).Value = obj_ProdutoDTO.DataHoraDeCadastroDoProduto;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;
                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_UsuariosCadastrados);

                if (lst_UsuariosCadastrados.Rows.Count > 0)
                {
                    int_CodigoDoProduto = Convert.ToInt32(lst_UsuariosCadastrados.Rows[0]["CodigoDoProduto"]);
                }
                else
                {
                    int_CodigoDoProduto = -1;
                }
                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            return int_CodigoDoProduto;
        }

        public DataView BuscaDescriçãoDoProdutoParaAutocompletar()
        {
            DataTable lst_ProdutoCadastrados = new DataTable();
            DataView dtv_ListaDeProdutosCadastrados;

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "SELECT DescricaoDoProduto FROM Produto";

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                ada_AdaptadorDeDados = new MySqlDataAdapter(con_ComandoParaSerExecutado);
                ada_AdaptadorDeDados.Fill(lst_ProdutoCadastrados);

                con_ComandoParaSerExecutado.Dispose();
                con_ConexaoAtiva.Close();
            }
            dtv_ListaDeProdutosCadastrados = new DataView(lst_ProdutoCadastrados);
            return dtv_ListaDeProdutosCadastrados;
        }
        #endregion

        #region Funções de Persistência
        //Funções de Insert, Update e Delete
        public int IncluirNovoProduto(ProdutoDTO obj_ProdutoDTO)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "INSERT INTO Produto " +
                                                          "(`CodigoDoProduto`,`DescricaoDoProduto`, `LarguraDoProduto`, `ComprimentoDoProduto`, `EspessuraDoProduto`, `DataHoraDeCadastro`, `PesoTotalDoProduto`, `CodigoDoGrupoDoProduto`) " +
                                                          "VALUES (@codigoDoProduto, @descricaoDoProduto, @larguraDoProduto, @comprimentoDoProduto, @espessuraDoProduto, @dataHoraDeCadastroDoProduto, " +
                                                          "@pesoTotalDoProduto, @codigoDoGrupoDoProduto)";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = obj_ProdutoDTO.CodigoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("descricaoDoProduto", MySqlDbType.VarChar).Value = obj_ProdutoDTO.DescricaoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("larguraDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.LarguraDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("comprimentoDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.ComprimentoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("espessuraDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.EspessuraDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("dataHoraDeCadastroDoProduto", MySqlDbType.DateTime).Value = obj_ProdutoDTO.DataHoraDeCadastroDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("pesoTotalDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.PesoTotalDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupoDoProduto", MySqlDbType.Int32).Value = obj_ProdutoDTO.GrupoDoProduto.CodigoDoGrupo;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                //Verifica se o registro foi incluído e adiciona os Itens
                if(int_Retorno > 0)
                {
                    obj_ProdutoDTO.CodigoDoProduto = BuscaProdutoPorAtributos(obj_ProdutoDTO);

                    if (obj_ProdutoDTO.ComprimentoDoProduto != -1)
                    {
                        if (obj_ProdutoDTO.QuantidadeDeItensDaComposicao() > 0)
                        {
                            int_Retorno = new ItemDaComposicaoDAO().IncluirComposicao(obj_ProdutoDTO.InsumosDoProduto, obj_ProdutoDTO.CodigoDoProduto);
                        }
                    }
                }

                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        public int AtualizaInformacoesDoProduto(ProdutoDTO obj_ProdutoDTO, int int_CodigoDoProduto)
        {
            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {

                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "Update Produto " +
                                                          "Set `DescricaoDoProduto`=@descricaoDoProduto,`LarguraDoProduto`=@larguraDoProduto, " +
                                                          "`ComprimentoDoProduto`=@comprimentoDoProduto, " +
                                                          "`EspessuraDoProduto`=@espessuraDoProduto, " +
                                                          "`pesoTotalDoProduto`=@pesoTotalDoProduto, " +
                                                          "`CodigoDoGrupoDoProduto` = @codigoDoGrupoDoProduto " +
                                                          " Where `CodigoDoProduto` = @codigoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("descricaoDoProduto", MySqlDbType.VarChar).Value = obj_ProdutoDTO.DescricaoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("larguraDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.LarguraDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("comprimentoDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.ComprimentoDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("espessuraDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.EspessuraDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("pesoTotalDoProduto", MySqlDbType.Float).Value = obj_ProdutoDTO.PesoTotalDoProduto;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoGrupoDoProduto", MySqlDbType.Int32).Value = obj_ProdutoDTO.GrupoDoProduto.CodigoDoGrupo;
                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = int_CodigoDoProduto;

                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                //Verifica se o registro foi incluído e adiciona os Itens
                if (int_Retorno > 0)
                {
                    int_Retorno += new ItemDaComposicaoDAO().ExcluiInformacoesDaComposicao(obj_ProdutoDTO.CodigoDoProduto);
                    int_Retorno += new ItemDaComposicaoDAO().IncluirComposicao(obj_ProdutoDTO.InsumosDoProduto, obj_ProdutoDTO.CodigoDoProduto);
                }

                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }

        public int ExcluiInformacoesDoProduto(ProdutoDTO obj_ProdutoDTO)
        {

            using (MySqlConnection con_ConexaoAtiva = new MySqlConnection())
            {
                //Atribui a string de conexão
                con_ConexaoAtiva.ConnectionString = Properties.Settings.Default.dboStringDeConexao;
                con_ConexaoAtiva.Open();

                con_ComandoParaSerExecutado = new MySqlCommand();
                con_ComandoParaSerExecutado.CommandType = System.Data.CommandType.Text;
                con_ComandoParaSerExecutado.CommandText = "DELETE FROM Produto WHERE `CodigoDoProduto` = @codigoDoProduto";

                con_ComandoParaSerExecutado.Parameters.Add("codigoDoProduto", MySqlDbType.Int32).Value = obj_ProdutoDTO.CodigoDoProduto;
                con_ComandoParaSerExecutado.Connection = con_ConexaoAtiva;

                int_Retorno = con_ComandoParaSerExecutado.ExecuteNonQuery();

                //Verifica se o registro foi incluído e exclui a composicao
                if (int_Retorno > 0)
                {
                    int_Retorno += new ItemDaComposicaoDAO().ExcluiInformacoesDaComposicao(obj_ProdutoDTO.CodigoDoProduto);
                }

                con_ConexaoAtiva.Close();
            }
            return int_Retorno;
        }
        #endregion

    }
}
