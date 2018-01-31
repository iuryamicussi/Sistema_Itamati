using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Itamarati_ControleDeProducao.DTO;
using Itamarati_ControleDeProducao.DAO;

namespace Itamarati_ControleDeProducao.Model
{
    public class GrupoModel
    {

        private GrupoDAO obj_GrupoDAO = new GrupoDAO();

        //Retorno Lista de Inusmos para busca (AutoComplete)
        public IList<string> BuscaInformacoesDoGrupoParaCombo()
        {
            IList<string> lst_InsumosParaPesquisa = new List<string>();
            DataView dtv_GruposParaPesquisa = new DataView();
            dtv_GruposParaPesquisa = obj_GrupoDAO.BuscaInformacoesDoGrupoParaCombo();

            foreach (DataRowView drw_GrupoCorrente in dtv_GruposParaPesquisa)
            {
                lst_InsumosParaPesquisa.Add(drw_GrupoCorrente[0].ToString());
            }

            return lst_InsumosParaPesquisa;
        }

        //Busca insumo pela Descrição
        public GrupoDTO BuscaGrupoPorDescricao(string str_DescricaoDoGrupo)
        {
            return obj_GrupoDAO.BuscaGrupoPorDescricao(str_DescricaoDoGrupo);
        }

        //Busca por Código
        public GrupoDTO BuscaGrupoPorCodigo(int int_CodigoDoGrupo)
        {
            return obj_GrupoDAO.BuscaGrupoPorCodigo(int_CodigoDoGrupo);
        }

        //Novo Grupo
        public int IncluirNovoGrupo(GrupoDTO obj_GrupoDTO)
        {
            return obj_GrupoDAO.IncluirNovoGrupo(obj_GrupoDTO);
        }

        //Retorna Lisa de Grupo Cadastrados
        public DataView BuscaListaDeGruposCadastrados()
        {
            return obj_GrupoDAO.BuscaListaDeGruposCadastrados();
        }

        //Excluir Grupo
        public int ExcluiInformacoesDoGrupo(GrupoDTO obj_GrupoDTO)
        {
            return obj_GrupoDAO.ExcluiInformacoesDoGrupo(obj_GrupoDTO);
        }

        //Atualizar Grupo
        public int AtualizaInformacoesDoGrupo(GrupoDTO obj_GrupoDTO, int codigoDoGrupo)
        {
            return obj_GrupoDAO.AtualizaInformacoesDoGrupo(obj_GrupoDTO, codigoDoGrupo);
        }

        #region Metodos de Validação dos Campos

        //Validar Campos
        public String VerificaSeOCodigoDigitadoJaEstaSendoUsado(int int_CodigoDeReferencia)
        {
            GrupoDTO obj_GrupoDTO = new GrupoDTO();
            obj_GrupoDTO = BuscaGrupoPorCodigo(int_CodigoDeReferencia);

            if (obj_GrupoDTO.NomeDoGrupo != null)
            {
                return "Já existe um Grupo cadastrado com este código de identificção.";
            }
            else
            {
                return "";
            }
        }

        #endregion

    }
}
