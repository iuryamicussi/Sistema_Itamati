using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Itamarati_ControleDeProducao.DTO
{
    public class UsuarioDTO
    {
        //Atributos
        private int codigoDoUsuario;
        private string nomeDoUsuario;
        private string loginDoUsuario;
        private string senhaDoUsuario;
        private DateTime dataHoraDeCadastro;
        private Boolean statusDoUsuario;
        private Boolean usuarioGerente;
        private System.Drawing.Image fotoDoUsuario;

        //Construtores
        public UsuarioDTO(int codigoDoUsuario, string nomeDoUsuario, string loginDoUsuario, string senhaDoUsuario, DateTime dataHoraDeCadastro, Boolean statusDoUsuario, Boolean usuarioGerente, System.Drawing.Image fotoDoUsuario)
        {
            this.codigoDoUsuario = codigoDoUsuario;
            this.nomeDoUsuario = nomeDoUsuario;
            this.loginDoUsuario = loginDoUsuario;
            this.senhaDoUsuario = senhaDoUsuario;
            this.dataHoraDeCadastro = dataHoraDeCadastro;
            this.statusDoUsuario = statusDoUsuario;
            this.UsuarioGerente = usuarioGerente;
            this.FotoDoUsuario = fotoDoUsuario;
        }

        public UsuarioDTO(string loginDoUsuario, string senhaDoUsuario)
        {
            this.loginDoUsuario = loginDoUsuario;
            this.senhaDoUsuario = senhaDoUsuario;
        }

        public UsuarioDTO() { }

        //Encapsulamento
        public int CodigoDoUsuario
        {
            get
            {
                return codigoDoUsuario;
            }

            set
            {
                codigoDoUsuario = value;
            }
        }

        public string NomeDoUsuario
        {
            get
            {
                return nomeDoUsuario;
            }

            set
            {
                nomeDoUsuario = value;
            }
        }

        public string LoginDoUsuario
        {
            get
            {
                return loginDoUsuario;
            }

            set
            {
                loginDoUsuario = value;
            }
        }

        public string SenhaDoUsuario
        {
            get
            {
                return senhaDoUsuario;
            }

            set
            {
                senhaDoUsuario = value;
            }
        }

        public DateTime DataHoraDeCadastro
        {
            get
            {
                return dataHoraDeCadastro;
            }

            set
            {
                dataHoraDeCadastro = value;
            }
        }

        public bool StatusDoUsuario
        {
            get
            {
                return statusDoUsuario;
            }

            set
            {
                statusDoUsuario = value;
            }
        }

        public bool UsuarioGerente
        {
            get
            {
                return usuarioGerente;
            }

            set
            {
                usuarioGerente = value;
            }
        }

        public Image FotoDoUsuario
        {
            get
            {
                return fotoDoUsuario;
            }

            set
            {
                fotoDoUsuario = value;
            }
        }
    }
}
