using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.DTO
{
    public class ProducaoDTO
    {

        //Atributos
        private int codigoDaProducao;
        private int codigoDoProduto;
        private float quantidadeDoProduto;
        private List<ItemDaComposicaoDTO> listaDeInsumos = new List<ItemDaComposicaoDTO>();
        private DateTime dataHoraDeCadastroDaProducao;

        //Construtores
        public ProducaoDTO(int codigoDaProducao, int codigoDoProduto, float quantidadeDoProduto, DateTime dataHoraDeCadastroDaProducao)
        {
            this.codigoDaProducao = codigoDaProducao;
            this.codigoDoProduto = codigoDoProduto;
            this.quantidadeDoProduto = quantidadeDoProduto;
            this.dataHoraDeCadastroDaProducao = dataHoraDeCadastroDaProducao;
        }

        public ProducaoDTO() { }

        #region Encapsulamento
        //Encapsulamento
        public int CodigoDaProducao
        {
            get
            {
                return codigoDaProducao;
            }

            set
            {
                codigoDaProducao = value;
            }
        }

        public int CodigoDoProduto
        {
            get
            {
                return codigoDoProduto;
            }

            set
            {
                codigoDoProduto = value;
            }
        }

        public float QuantidadeDoProduto
        {
            get
            {
                return quantidadeDoProduto;
            }

            set
            {
                quantidadeDoProduto = value;
            }
        }

        public DateTime DataHoraDeCadastroDaProducao
        {
            get
            {
                return dataHoraDeCadastroDaProducao;
            }

            set
            {
                dataHoraDeCadastroDaProducao = value;
            }
        }

        public List<ItemDaComposicaoDTO> ListaDeInsumos
        {
            get
            {
                return listaDeInsumos;
            }
        }

        #endregion

        #region Métodos da Lista de Composicao
        //Métodos de controle da Lista de Composicão
        public void InsereItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicao)
        {
            listaDeInsumos.Add(obj_ItemDaComposicao);
        }

        public void LimpaListaDeItensDaComposicao()
        {
            listaDeInsumos.Clear();
        }

        public int QuantidadeDeItensDaComposicao()
        {
            return listaDeInsumos.Count;
        }
        #endregion

    }
}
