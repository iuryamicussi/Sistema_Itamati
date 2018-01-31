using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itamarati_ControleDeProducao.Controller
{
    public class ValidacaoGenericaDeCampos
    {
        public static String VerificaSeOCampoEstaVazio(String str_StringDeReferencia, String str_NomeDoCampo)
        {
            if(str_StringDeReferencia.Length == 0)
            {
                return "Informe " + str_NomeDoCampo;
            }
            else
            {
                return "";
            }
        }
    }
}
