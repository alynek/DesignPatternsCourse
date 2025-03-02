namespace DesignPatternsCourse.State.Exemplo1.Implementacao
{
    public class Diddy : State
    {
        public override void Troca(Personagem contexto)
        {
            contexto.State = new Donkey();
        }
    }
}