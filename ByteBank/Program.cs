using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CalcularBonificacao();
            UsarSistema();
            Console.ReadLine();  
        }
        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            GerenteDeConta eloizi = new GerenteDeConta(7000, "875.965.874-21");
            eloizi.Nome = "Eloizi";            
            eloizi.Senha = "12345";
            sistemaInterno.Logar(eloizi, "54123");

            Diretor sonia = new Diretor(8000, "451.632.584-98");
            sonia.Nome = "Sonia";
            sonia.Senha = "54321";
            sistemaInterno.Logar(sonia, "54321");

            ParceiroComercial parceiro = new ParceiroComercial();
            parceiro.Senha = "123456";

            sistemaInterno.Logar(parceiro, "123456");
        }
        public static void CalcularBonificacao()
        {
            GerencimentoBonificacao gerenciamentoBonificacao = new GerencimentoBonificacao();

            Funcionario pedro = new Designer("584.658.953-97");
            pedro.Nome = "Pedro";

            Funcionario roberta = new Diretor(5000, "512.632.478-52");
            roberta.Nome = "Roberta";
                      
            Funcionario igor = new Auxiliar("847.512.369-85");
            igor.Nome = "Igor";
            
            Funcionario camila = new GerenteDeConta(6000, "745.312.684-59");
            camila.Nome = "Camila";
                                    
            Funcionario jonatas = new Desenvolvedor("431.652.365-87");
            jonatas.Nome = "Jonatas";
                        
            gerenciamentoBonificacao.Registrar(pedro);
            gerenciamentoBonificacao.Registrar(roberta);
            gerenciamentoBonificacao.Registrar(igor);
            gerenciamentoBonificacao.Registrar(camila);
            gerenciamentoBonificacao.Registrar(jonatas);
            
            Console.WriteLine("Total de bonificações do mês " + gerenciamentoBonificacao.GetTotalBonificacao());

        }
    }
}
