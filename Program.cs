using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia(
    numero: "+5522987654321",
    modelo: "Série 1192",
    imei: "0000000000000000000001",
    memoria: 64
);

Smartphone iphone = new Iphone(
    numero: "+5522987650000",
    modelo: "PRO MAX",
    imei: "0000000000000000000002",
    memoria: 64
);

Console.WriteLine("Smartphone Nokia: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");
