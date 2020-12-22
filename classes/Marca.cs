using System;
using System.Collections.Generic;

namespace Projeto_de_produtos.classes
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public List<Marca> Marcas = new List<Marca>();
        
        public Marca CadastrarMarca()
        {
            Marca novaMarca = new Marca();
            Console.WriteLine($"Digite o código da marca:");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite o nome da marca");
            NomeMarca = Console.ReadLine();
            
            DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);
            return novaMarca;
        }
        
        public void Listar()
        {
            Console.WriteLine($"Marcas cadastradas");
            
            foreach (var item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"Data do cadastro: {item.DataCadastro}");
                
            }
        }
        public void Deletar(int cod)
        {
           Marca marcaDelete = Marcas.Find(m => m.Codigo == cod);
           Marcas.Remove(marcaDelete);
        }
    }
}