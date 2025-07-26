namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            //Simulando instalação
            Console.WriteLine($"Instalando \"{nomeApp}\" no Iphone...");
            System.Threading.Thread.Sleep(2000); // Espera 2 segundos

            // Apagar a última linha
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, currentLineCursor - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor - 1);

            Console.WriteLine($"\"{nomeApp}\" instalado com sucesso no Iphone");

        }
    }
}