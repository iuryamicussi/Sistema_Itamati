using System;
using System.Collections.Generic;

namespace Itamarati_ControleDeProducao.DTO
{
    public class ProdutoDTO
    {
        //Atributos
        private int codigoDoProduto;
        private string descricaoDoProduto;
        private float larguraDoProduto;
        private float comprimentoDoProduto;
        private float espessuraDoProduto;
        private DateTime dataHoraDeCadastroDoProduto;
        private List<ItemDaComposicaoDTO> insumosDoProduto = new List<ItemDaComposicaoDTO>();
        private float pesoTotalDoProduto;
        private GrupoDTO grupoDoProduto;

        //Construtores
        public ProdutoDTO(int codigoDoProduto, string descricaoDoProduto, float larguraDoProduto, float alturaDoInsumo, float espessuraDoProduto, DateTime dataHoraDeCadastroDoProduto, List<ItemDaComposicaoDTO> insumosDoProduto, float pesoTotalDoProduto, GrupoDTO grupoDoProduto)
        {
            this.codigoDoProduto = codigoDoProduto;
            this.descricaoDoProduto = descricaoDoProduto;
            this.larguraDoProduto = larguraDoProduto;
            this.comprimentoDoProduto = alturaDoInsumo;
            this.EspessuraDoProduto = espessuraDoProduto;
            this.dataHoraDeCadastroDoProduto = dataHoraDeCadastroDoProduto;
            this.insumosDoProduto = insumosDoProduto;
            this.PesoTotalDoProduto = pesoTotalDoProduto;
            this.GrupoDoProduto = grupoDoProduto;
        }

        public ProdutoDTO()
        {
            grupoDoProduto = new GrupoDTO();
        }

        #region Encapsulamento
        //Encapsulamento
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

        public string DescricaoDoProduto
        {
            get
            {
                return descricaoDoProduto;
            }

            set
            {
                descricaoDoProduto = value;
            }
        }

        public float LarguraDoProduto
        {
            get
            {
                return larguraDoProduto;
            }

            set
            {
                larguraDoProduto = value;
            }
        }

        public float ComprimentoDoProduto
        {
            get
            {
                return comprimentoDoProduto;
            }

            set
            {
                comprimentoDoProduto = value;
            }
        }

        public DateTime DataHoraDeCadastroDoProduto
        {
            get
            {
                return dataHoraDeCadastroDoProduto;
            }

            set
            {
                dataHoraDeCadastroDoProduto = value;
            }
        }

        public List<ItemDaComposicaoDTO> InsumosDoProduto
        {
            get
            {
                return insumosDoProduto;
            }

            set
            {
                insumosDoProduto = value;
            }
        }

        public float EspessuraDoProduto
        {
            get
            {
                return espessuraDoProduto;
            }

            set
            {
                espessuraDoProduto = value;
            }
        }

        public float PesoTotalDoProduto
        {
            get
            {
                return pesoTotalDoProduto;
            }

            set
            {
                pesoTotalDoProduto = value;
            }
        }

        public GrupoDTO GrupoDoProduto
        {
            get
            {
                return grupoDoProduto;
            }

            set
            {
                grupoDoProduto = value;
            }
        }
        #endregion

        #region Métodos da Lista de Composicao
        //Métodos de controle da Lista de Composicão
        public void InsereItemDaComposicao(ItemDaComposicaoDTO obj_ItemDaComposicao)
        {
            insumosDoProduto.Add(obj_ItemDaComposicao);
        }

        public void LimpaListaDeItensDaComposicao()
        {
            insumosDoProduto.Clear();
        }

        public int QuantidadeDeItensDaComposicao()
        {
            return insumosDoProduto.Count;
        }
        #endregion
    }
}
