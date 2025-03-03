namespace DesignPatternsCourse.State.Exemplo2.Implementacao
{
    public class Inativo : IEstadoDocumento
    {
        public void Inativar(Documento documento)
        {
            Console.WriteLine("\nO documento está inativo");
        }

        public void Publicar(Documento documento)
        {
            Console.WriteLine("\nO documento está inativo");
            documento.AlteraEstado(new Rascunho());
        }

        public void Renderizar()
        {
            Console.WriteLine("Exibe o documento e todos os seus detalhes na tela");
        }
    }
}
