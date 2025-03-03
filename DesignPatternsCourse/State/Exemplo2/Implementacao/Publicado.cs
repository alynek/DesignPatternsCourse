namespace DesignPatternsCourse.State.Exemplo2.Implementacao
{
    public class Publicado : IEstadoDocumento
    {
        public void Inativar(Documento documento)
        {
            Console.WriteLine("\nO documento está em modo Publicado");
            documento.AlteraEstado(new Inativo());
        }

        public void Publicar(Documento documento)
        {
            Console.WriteLine("\nO documento está em modo Publicado");
        }

        public void Renderizar()
        {
            Console.WriteLine("Exibe o documento e todos os seus detalhes na tela");
        }
    }
}