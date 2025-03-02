namespace DesignPatternsCourse.State.Exemplo1
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
                var estadoAntigo = _estado.GetType().Name;
                _estado = value;
                Console.WriteLine($"Alterado de: {estadoAntigo}, para: {_estado.GetType().Name}");
            }
        }

        public void Troca()
        {
            _estado.Acao(this);
        }
    }
}
