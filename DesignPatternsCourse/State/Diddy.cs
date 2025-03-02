namespace DesignPatternsCourse.State
{
    public class Diddy : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new Donkey();
        }
    }
}