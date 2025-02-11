namespace Layout
{
    class Tela
    {
        public static void AplicarCor(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }
    }
}