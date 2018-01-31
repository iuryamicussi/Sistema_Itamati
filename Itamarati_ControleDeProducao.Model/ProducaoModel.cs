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
    public class ProducaoModel
    {

        #region Propriedade de Acesso aos Dados
        private ProducaoDAO obj_ProducaoDAO = new ProducaoDAO();
        #endregion

        #region Metodos de Acesso aos Dados
        //Buscar dados para relatório de controle de Produção
        public DataView dadosParaImpressaoDoRelatorioControleDeProducao(List<int> lst_CodigosDosProdutosEscolhidos)
        {
            return obj_ProducaoDAO.dadosParaImpressaoDoRelatorioControleDeProducao(lst_CodigosDosProdutosEscolhidos);
        }

        //Buscar lista de produtos para impressão
        public DataView BuscaListaDeProdutosCadastradosPorGrupoParaImpressao(int int_CodigoDoGrupo)
        {
            return new ProdutoDAO().BuscaListaDeProdutosCadastradosPorGrupoParaImpressao(int_CodigoDoGrupo);
        }
        #endregion

        #region Metodos de Consistência

        //Consistir Valor
        public string consistirValor(string str_Valor)
        {
            try
            {
                str_Valor = String.Format("{0:C3}", Convert.ToSingle(str_Valor)).Replace("R$", "").Trim();
                return str_Valor;
            }
            catch
            {
                return "0";
            }
        }

        #endregion

        #region Metodos de Validação dos Campos

        //Validar Campos
        public void Validar(ProducaoDTO obj_ProducaoDTO)
        {
            if (!ValidarProdutoEscolhido(obj_ProducaoDTO.CodigoDoProduto)) throw new Exception("ProdutoNaoEscolhido");
        }

        //Validar se algum produto foi escolhido
        private Boolean ValidarProdutoEscolhido(int str_CodigoDoProduto)
        {
            if (str_CodigoDoProduto == 0)
                return false;
            return true;
        }
        
        #endregion

    }
}
