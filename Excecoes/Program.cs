using System;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * EXCEÇÕES:
            - Uma exceção é qualquer condição de erro ou comportamento inesperado encontrado por um programa em execução.
            - No .NET, uma exceção é um objeto herdade da classe System.Exception
            - Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, até que seja capturada (tratada) ou o programa seja encerrado.
            
            ****** Exception (Superclasse)
            - SystemException (SubClasse do Exception) - São as exceções geradas pelo .NET, pelas bibliotecas que já vem acompanhadas no .NET
            - ApplicationException (SubClasse do Exception) - Recomendada utiliza-la para criar suas próprias exceções personalizadas.

            Obs. A existência dessas duas classes é uma forma de permitir diferenciar exceções de sistema (SystemException) e exceções de sua aplicação (ApplicationException)
            

            ****** SystemException
            - IndexOutOfRangeException (SubClasse do SystemException)
            - NullReferenceException   (SubClasse do SystemException)
            - InvalidCastException     (SubClasse do SystemException)
            - OutOfMemoryException     (SubClasse do SystemException)
            - ArgumentException        (SubClasse do SystemException)
            - ExternalException        (SubClasse do SystemException)
            - ArithmeticException      (SubClasse do SystemException)


            ***** ArgumentException
            - ArgumentNullException         (SubClasse do ArgumentException)
            - ArgumentOutOfRangeException   (SubClasse do ArgumentException)


            **** ExternalException
            - ComException   (SubClasse do ExternalException)
            - SEHException   (SubClasse do ExternalException)


            *** ArithmeticException
            - DivideByZeroException   (SubClasse do ArithmeticException)
            - OverflowException       (SubClasse do ArithmeticException)
             

            ** PRA QUE EXISTE EXCEÇÕES?
            - O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexível, usando boas práticas
            
            * VANTAGENS:
            - Delega a lógica do erro para a classe / método responsável por conhecer as regra que podem ocasionar o erro.
            - Trata de forma organizada (inclusive hierárquica) exceções de tipos diferentes.
            - A exceção pode carregar dados quaisquer.


            ** ESTRUTURA TRY-CATCH:
            
            * Bloco try
            - Contém o código que representa a execução normal do reocho de código que pode acarretar em uma exceção.

            * Bloco catch
            - Comtém o código a ser executado caso uma exceção ocorra
            - Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)
            
            * Bloco finally
            - É um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.
            - Exemplo Clássico: fechar um arquivo ou conexão de banco de dados ao final do processamento.
             
            */

            try //Irá "tentar" executar o bloco contido aqui e se acontecer alguma exceção iremos "capturar" essa exceção com o bloco catch.
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;

                Console.WriteLine(result);
            }
            catch (DivideByZeroException e) //Captura a exceção e é tratada de acordo com o especificado sem "quebrar" o programa. Para que seja possível realizar um tratamento diferenciado para cada tipo de exceção é recomendável declarar o tipo específico da exceção que pode ocorrer e não colocar a exceção mais genérica(SuperClasse Exception).
            {
                Console.WriteLine("Error! " + e.Message);
                Console.WriteLine("Division by zero is not allowed!");
            }
            catch(FormatException e) //Captura a exceção e a trata desse caso(FormatException) pode ocorrer caso seja digitada uma letra no lugar que deveria ser Número.
            {
                Console.WriteLine("Format error! " + e.Message);
            }
            finally //Executa o código especificado aqui independente se houver exceção ou não.
            {
                Console.WriteLine();
                Console.WriteLine("End");
            }
        }
    }
}
