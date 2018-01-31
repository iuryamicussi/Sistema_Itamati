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
    public class ItemDaComposicaoModel
    {
        private ItemDaComposicaoDAO obj_ItemDaComposicaoDAO = new ItemDaComposicaoDAO();

        //Busca lista de Insumos cadastrados no BD
        public DataView BuscaListaDeItemDaComposicaoDoProduto(int int_CodigoDoProduto)
        {
            return obj_ItemDaComposicaoDAO.BuscaListaDeItemDaComposicaoDoProduto(int_CodigoDoProduto);
        }

        #region Funções de Persistência
        //Funções de Insert, Update e Delete
        public int IncluirNovoItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO, int int_CodigoDoProduto)
        {
            return obj_ItemDaComposicaoDAO.IncluirNovoItemDaComposicao(obj_ItemDaComposicaoDTO, int_CodigoDoProduto);
        }

        public int IncluirComposicao(IList<ItemDaComposicaoDTO> lst_ItemDaComposicaoDTO, int int_CodigoDoProduto)
        {
            return obj_ItemDaComposicaoDAO.IncluirComposicao(lst_ItemDaComposicaoDTO, int_CodigoDoProduto);
        }

        public int AtualizaInformacoesDoItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO, int int_CodigoDoProduto, int int_CodigoDoInsumoAnterior)
        {
            return obj_ItemDaComposicaoDAO.AtualizaInformacoesDoItemDaComposicao(obj_ItemDaComposicaoDTO, int_CodigoDoProduto, int_CodigoDoInsumoAnterior);
        }

        public int ExcluiInformacoesDoItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicaoDTO, int int_CodigoDoProduto)
        {
            return obj_ItemDaComposicaoDAO.ExcluiInformacoesDoItemDaComposicao(obj_ItemDaComposicaoDTO, int_CodigoDoProduto);
        }

        public int ExcluiInformacoesDaComposicao(int int_CodigoDoProduto)
        {
            return obj_ItemDaComposicaoDAO.ExcluiInformacoesDaComposicao(int_CodigoDoProduto);
        }
        #endregion
    }
}
