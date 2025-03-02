namespace DesignPatternsCourse.State
{
    public class Donkey : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new Diddy();
        }
    }
}
