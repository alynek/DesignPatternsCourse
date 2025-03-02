namespace DesignPatternsCourse.State
{
    public class Contexto
    {
        private State _estado;

        public Contexto(State estado)
        {
            _estado = estado;
        }

        public State State
        {
            get { return _estado; }
            set 
            { 
                _estado = value;
                Console.WriteLine($"Alterado para: {_estado.GetType().Name}");
            }
        }

        public void Troca()
        {
            _estado.Acao(this);
        }
    }
}
