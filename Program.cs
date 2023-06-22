using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia modelo1 = new Nokia("11111111","modelo 1","111111111", 64);
modelo1.Ligar();
modelo1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Iphone modelo2 = new Iphone("22222222","modelo 2","222222222", 128);
modelo2.ReceberLigacao();
modelo2.InstalarAplicativo("Telegram");