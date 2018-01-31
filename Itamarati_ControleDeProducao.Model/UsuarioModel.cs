using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itamarati_ControleDeProducao.DAO;
using Itamarati_ControleDeProducao.DTO;
using System.Data;

namespace Itamarati_ControleDeProducao.Model
{
    public class UsuarioModel
    {
        private UsuarioDAO obj_UsuarioDAO = new UsuarioDAO();

        //Novo usuário
        public int IncluirNovoUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            return obj_UsuarioDAO.IncluirNovoUsuario(obj_UsuarioDTO);
        }

        //Atualizar Usuário
        public int AtualizaInformacoesDoUsuario(UsuarioDTO obj_UsuarioDTO, string str_LoginDoUsuario)
        {
            return obj_UsuarioDAO.AtualizaInformacoesDoUsuario(obj_UsuarioDTO, str_LoginDoUsuario);
        }

        //Retorna Lisa de Usuários Cadastrados
        public DataView BuscaListaDeUsuariosCadastrados()
        {
            return obj_UsuarioDAO.BuscaListaDeUsuariosCadastrados();
        }

        //Autentica Usuário no Login do Sistema
        public UsuarioDTO AutenticaUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            obj_UsuarioDTO.SenhaDoUsuario = CriptografarSenhaDoUsuario(obj_UsuarioDTO.SenhaDoUsuario);
            return obj_UsuarioDAO.AutenticaUsuario(obj_UsuarioDTO);
        }

        //Verifica se existe usuário registro como último logado
        public int VerificaSeExisteRegistroDeUsuarioLogado(String str_SerialNumber)
        {
            return obj_UsuarioDAO.VerificaSeExisteRegistroDeUsuarioLogado(str_SerialNumber);
        }

        //Criptografia a Senha ----- ridicula
        private string CriptografarSenhaDoUsuario(string str_SenhaDoUsuario)
        {
            String str_SenhaCriptografada = "";
            int int_CodigoASCdoCaractere;

            foreach(char chr_Caractere in str_SenhaDoUsuario)
            {
                int_CodigoASCdoCaractere = chr_Caractere;
                str_SenhaCriptografada = str_SenhaCriptografada + int_CodigoASCdoCaractere.ToString();
            }

            return str_SenhaCriptografada;
        }

        //Busca Usuário pelo código
        public UsuarioDTO BuscaUsuarioPorCodigo(int int_UltimoUsuarioLogado)
        {
            return obj_UsuarioDAO.BuscaUsuarioPorCodigo(int_UltimoUsuarioLogado);
        }

        //Busca Usuário pelo código
        public UsuarioDTO BuscaUsuarioPorLogin(string str_LoginDoUsuario)
        {
            return obj_UsuarioDAO.BuscaUsuarioPorLogin(str_LoginDoUsuario);
        }

        public int ExcluiInformacoesDoUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            return obj_UsuarioDAO.ExcluiInformacoesDoUsuario(obj_UsuarioDTO);
        }

        public int AlterarSenhaDoUsuario(UsuarioDTO obj_UsuarioDTO)
        {
            obj_UsuarioDTO.SenhaDoUsuario = CriptografarSenhaDoUsuario(obj_UsuarioDTO.SenhaDoUsuario);
            return obj_UsuarioDAO.AlterarSenhaDoUsuario(obj_UsuarioDTO);
        }

        #region Metodos de Validação dos Campos

        //Validar Campos
        public String VerificaSeOLoginDigitadoJaEstaSendoUsado(String str_LoginDeReferencia)
        {
            UsuarioDTO obj_UsuarioDTO = new UsuarioDTO();
            obj_UsuarioDTO = BuscaUsuarioPorLogin(str_LoginDeReferencia);

            if (obj_UsuarioDTO.LoginDoUsuario != null)
            {
                return "Já existe um Usuário cadastrado com este Login de identificção.";
            }
            else
            {
                return "";
            }
        }

        #endregion
    }
}
