using DesafioPOO.Models;


Smartphone nokia = new Nokia("1234", "B66", "11111111", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
nokia.MostrarConfiguracoes();

Console.WriteLine("===================================================");

Smartphone iphone = new Iphone("4567444", "3C", "0011237451", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");
iphone.MostrarConfiguracoes();