using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

//Teste com Nokia
Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123456", 16);
nokia.Ligar();  
nokia.ReceberLigacao();     
nokia.InstalarAplicativo("WhatsApp");

//Teste com Iphone
Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI654321", 128);
iphone.Ligar();     
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");     

