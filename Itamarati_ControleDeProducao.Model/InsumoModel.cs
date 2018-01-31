using Itamarati_ControleDeProducao.DAO;
using Itamarati_ControleDeProducao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows;
using System.Data;

namespace Itamarati_ControleDeProducao.Model
{
    public class InsumoModel
    {

        private InsumoDAO obj_InsumoDAO = new InsumoDAO();

        //Novo insumo
        public int IncluirNovoUsuario(InsumoDTO obj_InsumoDTO)
        {
            return obj_InsumoDAO.IncluirNovoInsumo(obj_InsumoDTO);
        }

        //Retorna Lista de Insumos Cadastrados
        public DataView BuscaListaDeInsumosCadastrados()
        {
            return obj_InsumoDAO.BuscaListaDeInsumosCadastrados();
        }

        //Busca insumo pela Descrição
        public InsumoDTO BuscaInsumoPorDescricao(string str_DescricaoDoInsumo)
        {
            return obj_InsumoDAO.BuscaInsumoPorDescricao(str_DescricaoDoInsumo);
        }

        //Busca Insumo por Código
        public InsumoDTO BuscaInsumoPorCodigo(int int_CodigoDoInsumo)
        {
            return obj_InsumoDAO.BuscaInsumoPorCodigo(int_CodigoDoInsumo);
        }

        //Retorno Lista de Inusmos para busca (AutoComplete)
        public IList<string> BuscaCodigosEDescriçãoDoInsumoParaAutocompletar()
        {
            IList<string> lst_InsumosParaPesquisa = new List<string>();
            DataView dtv_InsumosParaPesquisa = new DataView();
            dtv_InsumosParaPesquisa = obj_InsumoDAO.BuscaCodigosEDescriçãoDoInsumoParaAutocompletar();

            foreach(DataRowView drw_InsumoCorrente in dtv_InsumosParaPesquisa)
            {
                lst_InsumosParaPesquisa.Add(drw_InsumoCorrente[0].ToString() + " - " + drw_InsumoCorrente[1].ToString());
            }

            return lst_InsumosParaPesquisa;
        }

        //Retorno Lista de Inusmos para busca (AutoComplete)
        public IList<string> BuscaDescriçãoDoInsumoParaAutocompletar()
        {
            IList<string> lst_InsumosParaPesquisa = new List<string>();
            DataView dtv_InsumosParaPesquisa = new DataView();
            dtv_InsumosParaPesquisa = obj_InsumoDAO.BuscaDescriçãoDoInsumoParaAutocompletar();

            foreach (DataRowView drw_InsumoCorrente in dtv_InsumosParaPesquisa)
            {
                lst_InsumosParaPesquisa.Add(drw_InsumoCorrente[0].ToString() );
            }

            return lst_InsumosParaPesquisa;
        }

        //Atualizar Insumo
        public int AtualizaInformacoesDoInsumo(InsumoDTO obj_InsumoDTO, int int_CodigoDoInsumo)
        {
            return obj_InsumoDAO.AtualizaInformacoesDoInsumo(obj_InsumoDTO, int_CodigoDoInsumo);
        }

        //Excluir Insumo
        public int ExcluiInformacoesDoInsumo(InsumoDTO obj_InsumoDTO)
        {
            return obj_InsumoDAO.ExcluiInformacoesDoInsumo(obj_InsumoDTO);
        }

        #region Metodos de Validação dos Campos

        //Validar Campos
        public String VerificaSeOCodigoDigitadoJaEstaSendoUsado(int int_CodigoDeReferencia)
        {
            InsumoDTO obj_InsumoDTO = new InsumoDTO();
            obj_InsumoDTO = BuscaInsumoPorCodigo(int_CodigoDeReferencia);

            if (obj_InsumoDTO.NomeDoInsumo != null)
            {
                return "Já existe um Insumo cadastrado com este código de identificção.";
            }
            else
            {
                return "";
            }
        }

        #endregion

        #region Metodos de Consistência

        //Consistir Valor Unitário da Última Compra
        public string consistirValor(string str_ValorUnitarioDaUltimaCompra)
        {
            try
            {
                str_ValorUnitarioDaUltimaCompra = String.Format("{0:C3}", Convert.ToSingle(str_ValorUnitarioDaUltimaCompra)).Replace("R$", "").Trim();
                return str_ValorUnitarioDaUltimaCompra;
            }
            catch
            {
                return "0,000";
            }
        }

        #endregion

    }
}
