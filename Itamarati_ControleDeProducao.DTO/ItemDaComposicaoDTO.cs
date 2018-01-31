using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.DTO
{
    public class ItemDaComposicaoDTO
    {
        //Objetos
        private InsumoDTO insumo = new InsumoDTO();

        //Variávies de Controle
        private float quantidadeDoItem;
        private float totalDoItem;

        //Construtores
        public ItemDaComposicaoDTO(InsumoDTO obj_InsumoDTO, float flt_QuantidadeDoItem, float flt_TotalDoItem)
        {
            this.Insumo = obj_InsumoDTO;
            this.QuantidadeDoItem = flt_QuantidadeDoItem;
            this.TotalDoItem = flt_TotalDoItem;
        }

        public ItemDaComposicaoDTO()
        { }

        //Encapsulamento
        public InsumoDTO Insumo
        {
            get
            {
                return insumo;
            }

            set
            {
                insumo = value;
            }
        }

        public float QuantidadeDoItem
        {
            get
            {
                return quantidadeDoItem;
            }

            set
            {
                quantidadeDoItem = value;
            }
        }

        public float TotalDoItem
        {
            get
            {
                return totalDoItem;
            }

            set
            {
                totalDoItem = value;
            }
        }
    }
}
