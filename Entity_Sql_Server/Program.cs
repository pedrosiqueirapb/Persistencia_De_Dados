using Entity_Sql_Server.Entidades;

namespace Entity_Sql_Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                var usuario = new Usuario()
                {
                    NomeUser = "Pedro Siqueira Pereira Bitarães",
                    EmailUser = "pedrosiqueirapb@gmail.com",
                    SenhaUser = "12345",
                    EnderecoUser = "Rua Central, 123\r\nBairro São José\r\nCidade Exemplo",
                    LembreteSenha = "Sequência de números",
                    IdadeUser = 20,
                    SexoUser = 'M'
                };
                context.Usuarios.Add(usuario);
                context.SaveChanges();

                var produto = new Produto()
                {
                    NomeProd = "Camisa Cruzeiro temporada 2024",
                    PrecoProd = 250.0,
                    DescricaoProd = "Camisa oficial do Cruzeiro utilizada pelos jogadores na temporada 2024",
                    QuantidadeProd = 100,
                    AvaliacaoProd = 5,
                    CategoriaProd = "Esporte",
                    UserId = usuario.Id
                };
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }
    }
}
