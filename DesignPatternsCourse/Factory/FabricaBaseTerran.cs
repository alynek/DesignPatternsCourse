using DesignPatternsCourse.EnergiaBase;
using DesignPatternsCourse.RevestimentoBase;

namespace DesignPatternsCourse.Factory
{
    public class FabricaBaseTerran : IFabricaBase
    {
        private readonly IRevestimento _revestimento;
        private readonly IEnergia _energia;

        public FabricaBaseTerran(IRevestimento revestimento, IEnergia energia)
        {
            _revestimento = revestimento;
            _energia = energia;

            CriarBase();
        }
        public void CriarBase()
        {
            _revestimento.Composicao();
            _energia.Composicao();
            Console.WriteLine("base terran criada!");
        }
    }
}
