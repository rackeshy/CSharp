using System;
using Primeiro;
using Classes;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";
     
            Pessoa person = new Pessoa();

            person.Nome = "Giovana";
            person.Idade = 18;
            person.Estados = "São Paulo";

            var person2 = new Pessoa();

            person2.Nome = "Livia";
            person2.Idade = 23;
            person2.Estados = "Minas Gerais";


            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa1);
            Console.WriteLine(pessoa2);
            Console.WriteLine(pessoa3);
        }
    }
}