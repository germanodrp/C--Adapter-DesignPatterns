using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterAPP
{
    public class Computador:TomadaABNT,IAparelho
    {
        public String On()
        {
            this.Ligado = true;
            Console.WriteLine("Iniciando windows");
            this.Ligando();
            this.produzindoVideoEmTela();
            this.Saudacao();
            this.ErroAoEfetuarLogin();



            return this.Off();
        }
        //Request
        public String Off()
        {
            this.Ligado = false;
            return "agora o computador está desligado";
        }
        public void Ligando()
        {
            Console.WriteLine("\t Iniciando...");
            Thread.Sleep(2000);
            Console.WriteLine("\t Aguarde alguns segundos...");
        }
        private void produzindoVideoEmTela()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\t renderizando e abrindo para login de usuário...");
        }
        private void Saudacao()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\t Seja Bem Vindo,digite seu login e senha...");
        }

        private void ErroAoEfetuarLogin()
        {
            Thread.Sleep(1000);
            Console.WriteLine("\t Tentativas excedidas, computador será desligado!");
        }
    }
}
