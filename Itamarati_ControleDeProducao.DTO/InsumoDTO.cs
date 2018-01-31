using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.DTO
{
    public class InsumoDTO
    {

        //Atributos
        private int codigoDoInsumo;
        private string nomeDoInsumo;
        private string unidadeDeMedidaDoInsumo;
        private float valorUnitarioDaUltimaCompraDoInsumo;
        private DateTime dataHoraDeCadastroDoInsumo;

        //Construtores
        public InsumoDTO(int codigoDoInsumo, string nomeDoInsumo, string unidadeDeMedidaDoInsumo, float valorUnitarioDaUltimaCompraDoInsumo, DateTime dataHoraDeCadastroDoInsumo)
        {
            this.codigoDoInsumo = codigoDoInsumo;
            this.nomeDoInsumo = nomeDoInsumo;
            this.unidadeDeMedidaDoInsumo = unidadeDeMedidaDoInsumo;
            this.valorUnitarioDaUltimaCompraDoInsumo = valorUnitarioDaUltimaCompraDoInsumo;
            this.dataHoraDeCadastroDoInsumo = dataHoraDeCadastroDoInsumo;
        }
        
        public InsumoDTO() { }

        //Encapsulamento
        public int CodigoDoInsumo
        {
            get
            {
                return codigoDoInsumo;
            }

            set
            {
                codigoDoInsumo = value;
            }
        }

        public string NomeDoInsumo
        {
            get
            {
                return nomeDoInsumo;
            }

            set
            {
                nomeDoInsumo = value;
            }
        }

        public string UnidadeDeMedidaDoInsumo
        {
            get
            {
                return unidadeDeMedidaDoInsumo;
            }

            set
            {
                unidadeDeMedidaDoInsumo = value;
            }
        }

        public float ValorUnitarioDaUltimaCompraDoInsumo
        {
            get
            {
                return valorUnitarioDaUltimaCompraDoInsumo;
            }

            set
            {
                valorUnitarioDaUltimaCompraDoInsumo = value;
            }
        }

        public DateTime DataHoraDeCadastroDoInsumo
        {
            get
            {
                return dataHoraDeCadastroDoInsumo;
            }

            set
            {
                dataHoraDeCadastroDoInsumo = value;
            }
        }

    }
}
