namespace DesignPatternsCourse.State.Exemplo2
{
    public class Documento
    {
        private IEstadoDocumento _estado;

        public Documento(IEstadoDocumento estado)
        {
            _estado = estado;
        }

        public void Renderizar()
        {
            _estado.Renderizar();
        }

        public void Publicar()
        {
            _estado.Publicar(this);
        } 
        
        public void Inativar()
        {
            _estado.Inativar(this);
        }

        public void AlteraEstado(IEstadoDocumento estado)
        {
            var estadoAntigo = _estado.GetType().Name;  
            _estado = estado;
            Console.WriteLine($"Estado alterado de: {estadoAntigo}, para: {estado.GetType().Name}");
        }
    }
}
