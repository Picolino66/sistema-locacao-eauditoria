namespace Locadora.WebAPI.Models
{
    public class Cliente
    {
        public Cliente() { }
        public Cliente(int id, string nome, string cpf, DateTime dataNascimento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.DataNascimento = dataNascimento;

        }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}