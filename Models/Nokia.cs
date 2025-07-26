namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }
        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            //Simulando instalação
            Console.WriteLine($"Instalando \"{nomeApp}\" no Nokia...");
            System.Threading.Thread.Sleep(3000); // Espera 2 segundos

            // Apagar a última linha
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, currentLineCursor - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor - 1);

            Console.WriteLine($"\"{nomeApp}\" instalado com sucesso no Nokia");
        }
    
    }
}