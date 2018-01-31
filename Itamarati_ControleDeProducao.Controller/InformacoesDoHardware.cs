using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Itamarati_ControleDeProducao.Controller
{
    public class InformacoesDoHardware
    {
        ManagementObjectSearcher man_BuscaInformacoesDoHardware;

        public string BuscaNumeroDoSerial()
        {
            string str_NumeroDoSerial = "";
            man_BuscaInformacoesDoHardware = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");

            foreach (ManagementObject man_InformacaoDoHardware in man_BuscaInformacoesDoHardware.Get())
            {
                if (man_InformacaoDoHardware["SerialNumber"] != null)
                {
                    str_NumeroDoSerial = man_InformacaoDoHardware["SerialNumber"].ToString();
                    break;
                }
            }
            return str_NumeroDoSerial;
        }
    }
}
