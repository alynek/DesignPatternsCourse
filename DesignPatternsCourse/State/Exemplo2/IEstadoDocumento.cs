
namespace DesignPatternsCourse.State.Exemplo2
{
    public interface IEstadoDocumento
    {
        public void Renderizar();
        public void Publicar(Documento documento);
        public void Inativar(Documento documento);
    }
}