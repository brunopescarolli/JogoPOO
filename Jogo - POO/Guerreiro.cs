using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Guerreiro : Heroi 
    {
        private Random random = new Random();

        public Guerreiro(String nome, int idade) : base(nome, idade)
        {
            double buffVida = this.getStatus().getVidaMax() * 1.3;
            this.getStatus().setVidaMax(buffVida);
            double debuffForca = this.getStatus().getForca() * 0.9;
            this.getStatus().setForca(debuffForca);
            double manaZero = this.getStatus().getManaMax() * 0;
            this.getStatus().setManaMax(manaZero);
        }

        public override void atacar(Monstro monstro)
        {
            monstro.RecebeDano(this.gerarDano());
        }

        private double gerarDano()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return ((forca + agilidade)/1000) * (1 + random.Next(0, (int)sorte) / 1000);
        }
    }
}
