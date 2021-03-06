using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo___POO
{
    class Monstro
    {
        private string nome;
        private int level;
        private Status status;
        private Random random = new Random();

        public Monstro(string nome, int level)
        {
            this.level = level;
            this.nome = nome;
            this.status = new Status();
        }

        public string getNome()
        {
            return this.nome;
        }

        public int getLevel()
        {
            return this.level;
        }

        public Status getStatus()
        {
            return this.status;
        }

        public void setLevel(int level)
        {
            this.level = level;
        }

        public void setStatus(Status status)
        {
            this.status = status;
        }

        public void RecebeDano(double forcaInimigo)
        {
            double vida = this.getStatus().getVidaAtual();
            double defesa = this.getStatus().getDefesa();
            this.getStatus().setVidaAtual(vida - (this.gerarDefesa() - forcaInimigo)/10);
        }

        private double gerarDefesa()
        {
            double defesa = this.getStatus().getDefesa();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return (defesa + agilidade) * (1 + random.Next(0, (int)sorte)/10);
        }

        public void atacar(Heroi heroi)
        {
            heroi.RecebeDano(this.gerarAtaque());
        }

        private double gerarAtaque()
        {
            double forca = this.getStatus().getForca();
            double sorte = this.getStatus().getSorte();
            double agilidade = this.getStatus().getAgilidade();

            return ((forca + agilidade)/1000) * (1 + random.Next(0, (int)sorte) /1000);
        }
    }
}
