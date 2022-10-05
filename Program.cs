using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "967778530", modelo: "Modelo 1", imei: "111111", memoria: 52);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "92537468", modelo: "Modelo 2", imei: "2222222", memoria: 123);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");