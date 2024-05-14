using DesafioPOO.Models;

Nokia nokia = new Nokia("123456789", "Nokia V2", "IMEI1234", 128);
Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI4321", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Nokia App");

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("iPhone App");
