namespace DesignPatternsCourse.State.Exemplo1
{
    public class Diddy : State
    {
        public override void Acao(Contexto contexto)
        {
            contexto.State = new Donkey();
        }
    }
}