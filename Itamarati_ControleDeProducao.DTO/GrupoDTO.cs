using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.DTO
{
    public class GrupoDTO
    {
        //Atributos
        private int codigoDoGrupo;
        private string nomeDoGrupo;
        private DateTime dataHoraDeCadastroDoGrupo;

        //Construtores
        public GrupoDTO(int codigoDoGrupo, string nomeDoGrupo, DateTime dataHoraDeCadastroDoGrupo)
        {
            this.codigoDoGrupo = codigoDoGrupo;
            this.nomeDoGrupo = nomeDoGrupo;
            this.dataHoraDeCadastroDoGrupo = dataHoraDeCadastroDoGrupo;
        }

        public GrupoDTO(string nomeDoGrupo, DateTime dataHoraDeCadastroDoGrupo)
        {
            this.nomeDoGrupo = nomeDoGrupo;
            this.dataHoraDeCadastroDoGrupo = dataHoraDeCadastroDoGrupo;
        }

        public GrupoDTO() { }

        //Encapsulamento
        public int CodigoDoGrupo
        {
            get
            {
                return codigoDoGrupo;
            }

            set
            {
                codigoDoGrupo = value;
            }
        }

        public string NomeDoGrupo
        {
            get
            {
                return nomeDoGrupo;
            }

            set
            {
                nomeDoGrupo = value;
            }
        }

        public DateTime DataHoraDeCadastroDoGrupo
        {
            get
            {
                return dataHoraDeCadastroDoGrupo;
            }

            set
            {
                dataHoraDeCadastroDoGrupo = value;
            }
        }

    }
}
