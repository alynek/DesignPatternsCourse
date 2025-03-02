namespace DesignPatternsCourse.State.Exemplo1.Implementacao
{
    public class Donkey : State
    {
        public override void Troca(Personagem contexto)
        {
            contexto.State = new Diddy();
        }
    }
}
