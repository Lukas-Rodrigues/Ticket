using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket.Models
{
    public class Atendimento
    {
        public static List<Ingressos> List_IngressoComum = new List<Ingressos>();
        public static List<IngressosVip> List_IngressoVip = new List<IngressosVip>();
        public static void AtendimentoUsuario()
        {
            int opcao = 0;

            while (opcao != 4)
            {

                Console.Clear();
                Console.WriteLine("Valor do ingresso comum --> 40");
                Console.WriteLine("Cadastro de Ingressos");
                Console.WriteLine("=== 1 Cadastrar ingresso comum   ===");
                Console.WriteLine("=== 2 Cadastrar ingresso vip     ===");
                Console.WriteLine("===          3 Exibir            ===");
                Console.WriteLine("=== 4 Fechar programa ===");
                Console.Write("Digite a opção: ");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        CadastrarIngressoComum();
                        break;
                    case 2:
                        CadastrarIngressoVip();
                        break;
                    case 3:
                        Exibir();
                        break;
                    case 4:
                        opcao = 4;
                        break;
                }
            }
        }
        public static void CadastrarIngressoComum()
        {
            Ingressos ingressos = new Ingressos();
            Console.Write("Digite o seu nome: ");
            ingressos._name = Console.ReadLine();
            Console.WriteLine($"Valor do seu ingresso: {ingressos.ImprimirValor()}");
            List_IngressoComum.Add(ingressos);
            Console.ReadKey();
        }
       
        public static void CadastrarIngressoVip()
        {
            IngressosVip ingressos = new IngressosVip();
            Console.Write("Digite o seu nome: ");
            ingressos._name = Console.ReadLine();
            Console.WriteLine($"Valor do seu ingresso: {ingressos.ImprimirValor():C}");
            List_IngressoVip.Add(ingressos);
            Console.ReadKey();
        }

        public static void Exibir()
        {
            if (List_IngressoComum.Count <= 0)
            {
                Console.WriteLine("======================================\n");
                Console.WriteLine("Não possui ingressos comum");
                Console.ReadKey();
            }
            foreach (Ingressos item in List_IngressoComum)
            {
                Console.WriteLine("============Ingressos comum=========");
                Console.WriteLine("Nome do Comprador: " + item._name);
                Console.WriteLine("valor do ingresso: " + item.ImprimirValor());
                Console.ReadKey();
            }
            if (List_IngressoVip.Count <= 0)
            {
                Console.WriteLine("======================================\n");
                Console.WriteLine("Não possui ingressos vip");
                Console.ReadKey();

            }
            Console.WriteLine("============Ingressos vip=========")
            foreach (IngressosVip item in List_IngressoVip)
            {
                Console.WriteLine("Nome do Comprador: " + item._name);
                Console.WriteLine("valor do ingresso: " + item.ImprimirValor());
                Console.ReadKey();
            }
        }

    }
}
