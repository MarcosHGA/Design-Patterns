using System.Collections.Generic;

namespace DesignPatterns.AbstractFactory
{
    public class ExecucaoAbstractFactory
    {
        public static void Executar()
        {
            List<Veiculo> veiculoSocorro = new List<Veiculo>
            {
                VeiculoCreator.Criar("Celta", Porte.Pequeno),
                VeiculoCreator.Criar("Jetta", Porte.Medio),
                VeiculoCreator.Criar("BMW X6", Porte.Grande)
            };

            veiculoSocorro.ForEach(x => AutoSocorro.CriarAutoSocorro(x).RealizarAtendimento());
        }
    }
}
