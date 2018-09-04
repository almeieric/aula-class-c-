using System;


namespace aula
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa pessoa = new Pessoa();
            Pessoa pessoa2 = new Pessoa("12675877689 ", "Eric Almeida");
            Console.WriteLine(pessoa2.NomeCPF());
            Console.WriteLine("\n\n\nPressione qualquer tecla para sair...");
            Console.ReadKey(true);
        }
    }

}
