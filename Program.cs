using DesafioPOO.Models;

Smartphone iphone13 = new Iphone("1", "Iphone13+", "10000", 256);
Smartphone G11 = new Nokia("2", "Nokia G11 5G", "05000", 128);

iphone13.IMEI = "10000";
iphone13.Modelo = "Iphone13+";
iphone13.Numero = "1";
iphone13.Memoria = 256;
iphone13.InstalarAplicativo("Moovit");

G11.IMEI = "05000";
G11.Modelo = "Nokia G11 5G";
G11.Numero =  "2";
G11.Memoria = 128;
G11.InstalarAplicativo("Gympass");
Console.ReadLine();