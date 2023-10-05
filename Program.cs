using DesafioPOO.Models;


Nokia nokia = new Nokia("8199999-9999", "Asha", "123456789/987/654", 32);
Iphone iphone = new Iphone("8100000-0000", "15 Pro", "987654321/123/456", 64);

Console.WriteLine("Teste do Nokia");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("");

Console.WriteLine("Teste do Iphone");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("DIO");