namespace Locadora.WebAPI.Models
{
    public class Filme
    {
        public Filme() { }

        public Filme(int id, string titulo, int classificacaoIndicativa, byte lancamento)
        {
            this.Id = id;
            this.Titulo = titulo;
            this.ClassificacaoIndicativa = classificacaoIndicativa;
            this.Lancamento = lancamento;

        }
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public byte Lancamento { get; set; }
    }
}