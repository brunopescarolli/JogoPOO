using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] infoPersonagem;

            infoPersonagem = Proficuo.Personagem();

            switch (infoPersonagem[2])
            {
                case "1":
                    Proficuo.ArmaGuerreiro();
                    break;
                case "3":
                    Proficuo.ArmaMago();
                    break;
            }

            string batalha = Proficuo.goblinAtaque();

            if (batalha == "1")
            {
                Goblin monstro1 = new Goblin("Goblin", 1);

                Guerreiro warrior = new Guerreiro(infoPersonagem[0], Int32.Parse(infoPersonagem[1]));
                Mago mage = new Mago(infoPersonagem[0], Int32.Parse(infoPersonagem[1]));
                Arqueiro archer = new Arqueiro(infoPersonagem[0], Int32.Parse(infoPersonagem[1]));

                switch (infoPersonagem[2])
                {
                    case "1":

                        Proficuo.PrintStatus(warrior);

                        Proficuo.criarBatalha(monstro1, warrior);
                        break;
                    case "2":
                        Proficuo.PrintStatus(archer);
                        Proficuo.criarBatalha(monstro1, archer);
                        break;
                    case "3":
                        Proficuo.PrintStatus(mage);

                        Proficuo.criarBatalha(monstro1, mage);
                        break;
                }
                Console.ReadLine();
            }
            else
            {
                
            }
        }
    }
}
