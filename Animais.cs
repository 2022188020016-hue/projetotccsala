namespace ProjetoAnimais.Models
{
    public abstract class Animais
    {
        public int Id { get; set; }
        public string NomePopular { get; set; }
        public string Sintomas { get; set; }
        public string PrimeirosSocorros { get; set; }
        public string Imagem { get; set; }
        public int CategoriaId { get; set; }
        public string NaoFazer { get; set; }
        public string RegiaoOcorrencia { get; set; }

        public Animais()
        { 
        }

           
       public Animais( int id, string nomePopular, string sintomas, string primeirosSocorros, string imagem, int categoriaId, string naoFazer, string regiaoOcorrencia)
       {
       Id = id;
       NomePopular = nomePopular;
       Sintomas = sintomas;
       PrimeirosSocorros = primeirosSocorros;
       Imagem = imagem;
       CategoriaId = categoriaId;
       NaoFazer = naoFazer;
       RegiaoOcorrencia = regiaoOcorrencia;
       }

       public virtual void ExibirDetalhes()
       {
        Console.WriteLine($"=== ANIMAL ID: {Id} ===");
        Console.WriteLine($"Nome Popular: {NomePopular}");
        Console.WriteLine($"Sintomas: {Sintomas}");
        Console.WriteLine($"Primeiros Socorros: {PrimeirosSocorros}");
        Console.WriteLine($"Não Fazer: {NaoFazer}");
        Console.WriteLine($"Região de Ocorrência: {RegiaoOcorrencia}");
        Console.WriteLine($"Categoria ID: {CategoriaId}");
            }
        }
    }

    

