using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAPP
{
    public class Tela: TomadaABNT,IAparelho
    {
        public String On()
        {
            this.Ligado = true;
            return "Ligando tela com computador desligado";
        }
        //Request
        public String Off()
        {
            this.Ligado = false;
            return "video não encontrado! ";
        }

    }
}
