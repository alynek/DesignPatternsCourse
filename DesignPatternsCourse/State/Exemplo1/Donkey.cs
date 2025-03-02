namespace DesignPatternsCourse.State.Exemplo1
{
    public class Donkey : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new Diddy();
        }
    }
}
