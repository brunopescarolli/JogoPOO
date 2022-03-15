using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jogo___POO
{
    static class Proficuo
    {
        public static String[] Personagem()
        {
            String[] retorno = new String[3];

            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                      ▄███████▄  ▄██████▄   ▄██████▄  ");
            Console.WriteLine("                                     ███    ███ ███    ███ ███    ███ ");
            Console.WriteLine("                                     ███    ███ ███    ███ ███    ███ ");
            Console.WriteLine("                                     ███    ███ ███    ███ ███    ███ ");
            Console.WriteLine("                                    ▀█████████▀ ███    ███ ███    ███ ");
            Console.WriteLine("                                     ███        ███    ███ ███    ███ ");
            Console.WriteLine("                                     ███        ███    ███ ███    ███ ");
            Console.WriteLine("                                    ▄████▀       ▀██████▀   ▀██████▀  ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");
            Thread.Sleep(1000);
            Console.WriteLine("                                              Power Of Odds           ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                                                                      ");
            Thread.Sleep(2000);
            Console.WriteLine("                                      Pressione 'Enter' para começar  ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Digite seu nome ");
            Console.WriteLine("");
            retorno[0] = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Que belo nome, " + retorno[0]);
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("Digite sua idade ");
            Console.WriteLine("");
            retorno[1] = Console.ReadLine();
            Console.WriteLine("");
            Console.Clear();

            Console.WriteLine("              ");
            Console.WriteLine("      /| ________________");
            Console.WriteLine("O|===|* >________________>                     Guerreiro - 1");
            Console.WriteLine("      \\|");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("       (");
            Console.WriteLine("        \\       ");
            Console.WriteLine("         )      ");
            Console.WriteLine(">>>---------------->                           Arqueiro - 2");
            Console.WriteLine("         )      ");
            Console.WriteLine("        /       ");
            Console.WriteLine("       (        ");

            Console.WriteLine("");
            Console.WriteLine("                      /---\\");
            Console.WriteLine("O|===================| 000 )                     Mago - 3");
            Console.WriteLine("                      \\---/");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                            Escolha uma classe");

            retorno[2] = Console.ReadLine();

            Console.Clear();

            return retorno;
        }
        public static String ArmaGuerreiro()
        {
            Console.WriteLine("Escolha uma arma para ser equipada:");
            Console.WriteLine("");
            Console.WriteLine("=={==========-               Rapiera - 1");
            Console.WriteLine("");
            Console.WriteLine("     |____________");
            Console.WriteLine("[====|_____________\\        Berserk - 2");
            Console.WriteLine("     |");
            string arma = Console.ReadLine();
            Console.Clear();

            return arma;
        }

        public static String ArmaMago()
        {
            Console.WriteLine("Escolha uma arma para ser equipada:");
            Console.WriteLine("");
            Console.WriteLine("0==========={*}                Nox - 1");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("0===========<||>              Otrix - 2");
            Console.WriteLine("");
            string arma = Console.ReadLine();
            Console.Clear();

            return arma;
        }


        public static void PrintStatus(Heroi heroi )
        {
            

            int vida = Convert.ToInt32(heroi.getStatus().getVidaMax());
            int mana = Convert.ToInt32(heroi.getStatus().getManaMax());
            int forca = Convert.ToInt32(heroi.getStatus().getForca());
            int defesa = Convert.ToInt32(heroi.getStatus().getDefesa());
            int agilidade = Convert.ToInt32(heroi.getStatus().getAgilidade());
            int inteligencia = Convert.ToInt32(heroi.getStatus().getInteligencia());
            int sorte = Convert.ToInt32(heroi.getStatus().getSorte());

            Console.WriteLine("");
            Console.WriteLine("Esses são seus status:");
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("| Vida         | {0} |", vida.ToString("D2"));
            Console.WriteLine("| Mana         | {0} |", mana.ToString("D2"));
            Console.WriteLine("| Força        | {0} |", forca.ToString("D2"));
            Console.WriteLine("| Defesa       | {0} |", defesa.ToString("D2"));
            Console.WriteLine("| Agilidade    | {0} |", agilidade.ToString("D2"));
            Console.WriteLine("| Inteligência | {0} |", inteligencia.ToString("D2"));
            Console.WriteLine("| Sorte        | {0} |", sorte.ToString("D2"));
            Console.WriteLine("---------------------");
        }
        public static void criarBatalha(Monstro monstro, Heroi heroi)
        {
            bool first = true;

            if(monstro.getStatus().getAgilidade() >= heroi.getStatus().getAgilidade())
            {
                first = false;
            }
            else
            {
                first = true;
            }

            while (monstro.getStatus().getVidaAtual() >= 0 && heroi.getStatus().getVidaAtual() >= 0)
            {
                if (first)
                {
                    heroi.atacar(monstro);
                    Console.WriteLine("{0} ataca {1}", heroi.getNome(), monstro.getNome());
                    Console.WriteLine("Vida {0} : {1:N0}", monstro.getNome(), monstro.getStatus().getVidaAtual());
                    Console.WriteLine("");
                    first = false;

                }
                else
                {
                    monstro.atacar(heroi);
                    Console.WriteLine("{0} ataca {1}", monstro.getNome(), heroi.getNome());
                    Console.WriteLine("Vida {0:N0} : {1:N0}", heroi.getNome(), heroi.getStatus().getVidaAtual());
                    Console.WriteLine("");
                    first = true;
                }
                Thread.Sleep(1000);
            }

            if (heroi.getStatus().getVidaAtual() < 0)
            {
                Console.WriteLine("{0} morreu", heroi.getNome());
            }

            else
            {
                Console.WriteLine("{0} morreu", monstro.getNome());
            }
        }
        public static String goblinAtaque()
        {
            Console.WriteLine("                  Um goblin aparece");
            Console.WriteLine("                   O que você faz?");
            Console.WriteLine("");
            Console.WriteLine("                     Fugir - 0");
            Console.WriteLine("                     Lutar - 1 ");
            string batalha = Console.ReadLine();
            Console.Clear();
            return batalha;
        }
    }
}
