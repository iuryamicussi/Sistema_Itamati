using Itamarati_ControleDeProducao.DAO;
using Itamarati_ControleDeProducao.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.Model
{
    public class ProdutoModel
    {
        private ProdutoDAO obj_ProdutoDAO = new ProdutoDAO();

        //Novo Insumo
        public int IncluirNovoProduto(ProdutoDTO obj_ProdutoDTO)
        {
            return obj_ProdutoDAO.IncluirNovoProduto(obj_ProdutoDTO);
        }

        //Atualiza informações do Produto
        public int AtualizaInformacoesDoProduto(ProdutoDTO obj_ProdutoDTO, int int_CodigoDoProduto)
        {
            return obj_ProdutoDAO.AtualizaInformacoesDoProduto(obj_ProdutoDTO, int_CodigoDoProduto);
        }

        //Atualiza informações do Produto
        public int ExcluiInformacoesDoProduto(ProdutoDTO obj_ProdutoDTO)
        {
            return obj_ProdutoDAO.ExcluiInformacoesDoProduto(obj_ProdutoDTO);
        }

        //Retorna Lisa de Produtos Cadastrados
        public DataView BuscaListaDeProdutosCadastrados()
        {
            return obj_ProdutoDAO.BuscaListaDeProdutosCadastrados();
        }

        //Retorna Lisa de Produtos Cadastrados
        public ProdutoDTO BuscaProdutoPorCodigo(int int_CodigoDoProduto)
        {
            return obj_ProdutoDAO.BuscaProdutoPorCodigo(int_CodigoDoProduto);
        }

        //Busca insumo pela Descrição
        public ProdutoDTO BuscaProdutoPorDescricao(string str_DescricaoDoProduto)
        {
            return obj_ProdutoDAO.BuscaProdutoPorDescricao(str_DescricaoDoProduto);
        }

        //Retorno Lista de Produtos para busca (AutoComplete)
        public IList<string> BuscaDescriçãoDoProdutoParaAutocompletar()
        {
            IList<string> lst_ProdutosParaPesquisa = new List<string>();
            DataView dtv_ProdutosParaPesquisa = new DataView();
            dtv_ProdutosParaPesquisa = obj_ProdutoDAO.BuscaDescriçãoDoProdutoParaAutocompletar();

            foreach (DataRowView drw_InsumoCorrente in dtv_ProdutosParaPesquisa)
            {
                lst_ProdutosParaPesquisa.Add(drw_InsumoCorrente[0].ToString());
            }

            return lst_ProdutosParaPesquisa;
        }

        #region Metodos de Validação dos Campos

        //Validar Campos
        public String VerificaSeOCodigoDigitadoJaEstaSendoUsado(int int_CodigoDeReferencia)
        {
            ProdutoDTO obj_ProdutoDTO = new ProdutoDTO();
            obj_ProdutoDTO = BuscaProdutoPorCodigo(int_CodigoDeReferencia);

            if (obj_ProdutoDTO.DescricaoDoProduto != null)
            {
                return "Já existe um Produto cadastrado com este código de identificção.";
            }
            else
            {
                return "";
            }
        }

        #endregion
    }
}
