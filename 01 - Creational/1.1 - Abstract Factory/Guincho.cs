using System;

namespace DesignPatterns.AbstractFactory
{
    public abstract class Guincho
    {
        public Porte Porte { get; set; }
        protected Guincho(Porte porte)
        {
            Porte = porte;
        }

        public abstract void Socorrer(Veiculo veiculo);
    }

    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo Carro Pequeno - Modelo {0}", veiculo.Modelo);
        }

    }

    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorrendo Carro Medio - Modelo {0}", veiculo.Modelo);
        }
    }

    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte) { }

        public override void Socorrer(Veiculo veiculo)
        {
            Console.WriteLine("Socorendo Carro Grande - Modelo {0}", veiculo.Modelo);
        }
    }

    public class GuinchoCreator
    {
        public static Guincho Criar(Porte porte)
        {
            switch (porte)
            {
                case Porte.Pequeno:
                    return new GuinchoPequeno(porte);

                case Porte.Medio:
                    return new GuinchoMedio(porte);

                case Porte.Grande:
                    return new GuinchoGrande(porte);

                default:
                    throw new ApplicationException("Porte de Guincho desconhecido");
            }
        }
    }

}

