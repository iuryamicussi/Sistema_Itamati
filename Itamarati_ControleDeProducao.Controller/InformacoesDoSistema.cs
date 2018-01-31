using Itamarati_ControleDeProducao.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itamarati_ControleDeProducao.Controller
{
    public static class InformacoesDoSistema
    {
        public static Form frm_MDIParent;
        public static UsuarioDTO obj_UsuarioLogado;

        public static void AbrirFormulario(Type typ_FormularioSelecionado)
        {
            Boolean bol_TelaAberta = false;

            foreach (Form frm_FormularioAuxiliar in System.Windows.Forms.Application.OpenForms)
            {
                if (frm_FormularioAuxiliar.GetType().Equals(typ_FormularioSelecionado))
                {
                    frm_FormularioAuxiliar.BringToFront();
                    bol_TelaAberta = true;
                    break;
                }
            }

            if (!bol_TelaAberta)
            {
                Form frm_FormularioAuxiliar = (Form)Activator.CreateInstance(typ_FormularioSelecionado);
                frm_FormularioAuxiliar.MdiParent = frm_MDIParent;
                frm_FormularioAuxiliar.Show();
            }
        }
    }
}
