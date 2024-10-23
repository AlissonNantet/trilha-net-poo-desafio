using DesafioPOO.Models;

Nokia nokia = new Nokia("12345", "ABC", "DDD", 9);
Iphone iphone = new Iphone("67890", "DEF", "TTT", 4);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine();

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone