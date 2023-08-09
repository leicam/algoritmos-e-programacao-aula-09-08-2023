namespace MeuPrimeiroApp
{
    /*
     *  namespace: local onde a minha classe pode estar
     *  fisicamente/logicamente
     *  
     *  palavras reservadas: são palavras de uso exclusivo da 
     *  linguagem de programação. ex.: class indica que estou criando
     *  uma classe
     *  
     *  Classe: é uma receita de bolo para construir um
     *  software de uma liguagem de programação que implementa
     *  o paradigma orientado a objetos
     *  
     *  Classe Program: é a classe principal do sistema,
     *  possui um método principal chamado Main que é onde o App
     *  sempre será iniciado
     *  
     *  Método: são ações programadas que nosso App pode executar
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome: ");
            var meuNome = Console.ReadLine();
            Console.WriteLine("Olá " + meuNome);

            Console.ReadLine();
        }
    }
}