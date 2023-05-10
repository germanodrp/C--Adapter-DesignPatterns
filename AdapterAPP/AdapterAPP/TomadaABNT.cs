using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAPP
{
    public class TomadaABNT
    {
        private bool ligado;
        
        public bool Ligado {
            get
            {
                return this.ligado;
            }
            set
            {
                this.ligado = value;
                Console.WriteLine("{0}", this.ligado ? "" : "desligando");
            }
            //Definição: É um padrão que permite que duas interfaces não relacionadas trabalhem em conjunto. O link entre elas é feito pela classe adaptadora.

            //Quando usar:

            //Quando você precisa ter nomes de métodos diferentes (entre os chamados e os executados);
            //Quando você quer ter diferentes conjuntos de métodos(para propósitos diferentes);
            //Quando quiser criar classes reusáveis.
        }

    }
}
