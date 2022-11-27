namespace USING2_C_SHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nesse caso temos um texto que a classe StringReader fará a leitura /
            string linhas = @"Esta é a primeira linha 
                            Esta é a segunda linha
                            Está é a penultima linha
                            Esta é a última linha";

            //Aqui utilizamos o using pois está instrução fornece uma abordagem melhor para destruição de arquivos
            //criamos a variável leitor do tipo var que recebe a Classe StringReader derivada da classe TextReader que fará a leitura do arquivo linhas.
            using (var leitor = new StringReader(linhas))

                try // serve para tratamento de exceções, tratamento de códigos que podem não ser totalmente atendidos e gerarem alguma exceção/erro
                {
                    //Criamos uma variável do tipo string com o nome de item
                    string item;

                    //Estrutura de repetição Do while (Faça enquanto), irá executar se o arquivo dentro de item for diferente de nulo.

                    do
                    {
                        //Item recebe o leitor que é o tipo var(maneira implícita ou indireta de definir os dados),
                        //que dentro do leitor tem o arquivo linhas
                        item = leitor.ReadLine();
                        Console.WriteLine(item);
                        //Comando que fará a impressão do aquivo linhas.

                    } while (item != null);

                }
                finally // bloco que nos permite liberar recursos que foram alocados na execução do programa e que, após a execução do try, não precisam mais ser utilizados.
                {
                    //O método Dispose é uma convenção do . NET Framework para que as classes disponibilizem ao programador
                    //um meio de liberar a memória usada sem ter que esperar o Garbage Collector fazer isso.
                    leitor.Dispose();    
                }
        }
    }
}