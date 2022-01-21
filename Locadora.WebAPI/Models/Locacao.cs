namespace Locadora.WebAPI.Models
{
    public class Locacao
    {
        public Locacao() { }
        public Locacao(int clienteId, int filmeId, DateTime dataLocacao, DateTime dataDevolucao)
        {
            this.ClienteId = clienteId;
            this.FilmeId = filmeId;
            this.DataLocacao = dataLocacao;
            this.DataDevolucao = dataDevolucao;

        }
        public int ClienteId { get; set; }
        public int FilmeId { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
    }
}