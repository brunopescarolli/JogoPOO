using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Arqueiro : Heroi
    {
        private Random random = new Random();
        private int flechas;

        public Arqueiro(String nome, int idade) : base(nome, idade)
        {
            double buffForca = this.getStatus().getForca() * 1.3;
            this.getStatus().setForca(buffForca);
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
            double inteligencia = this.getStatus().getInteligencia();

            this.flechas -= 1;

            return ((forca + agilidade + inteligencia)/1500) * (1 + random.Next(0, (int)sorte) / 1000);
        }

        public void setFlechas(int flechas)
        {
            this.flechas = flechas;
        }

        public int getFlechas()
        {
            return this.flechas;
        }
    }
}
