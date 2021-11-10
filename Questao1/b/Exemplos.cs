namespace Questao1.b.Heranca
{
    public class Pessoa
    {
        public string Nome { get; set; }
    }
    
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
    }

    public class PessoaFisica2
    {
        public Pessoa Pessoa { get; set; }
        public string Cpf { get; set; }
    }

    public class Testes
    {
        public Testes()
        {
            var pessoaHeranca = new PessoaFisica
            {
                Nome = "Jonathan",
                Cpf = "32165498765"
            };

            var pessoaComposicao = new PessoaFisica2
            {
                Pessoa = new Pessoa
                {
                    Nome = "Jonathan",
                },
                Cpf = "32165498765"
            };

            var nomeHeranca = pessoaHeranca.Nome;
            var nome = pessoaComposicao.Pessoa.Nome;
        }
    }
}