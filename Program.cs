using System;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class teste
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Teste com Smartphone Nokia ---");
        // Cria uma instância da classe Nokia, passando os parâmetros necessários
        Smartphone nokia = new Nokia(numero: "99999-1234", modelo: "Nokia 666", imei: "111111111111111", memoria: 64);
        
        // Exibe o número do celular
        Console.WriteLine($"Número: {nokia.Numero}");

        // Chama os métodos herdados da classe Smartphone
        nokia.Ligar();
        nokia.ReceberLigacao();

        // Chama o método sobrescrito específico da classe Nokia
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n-------------------------------------\n");

        Console.WriteLine("--- Teste com Smartphone iPhone ---");
        // Cria uma instância da classe Iphone, passando os parâmetros necessários
        Smartphone iphone = new Iphone(numero: "99999-5678", modelo: "iPhone 17 Pro", imei: "222222222222222", memoria: 256);
        
        // Exibe o número do celular
        Console.WriteLine($"Número: {iphone.Numero}");

        // Chama os métodos herdados da classe Smartphone
        iphone.Ligar();
        iphone.ReceberLigacao();

        // Chama o método sobrescrito específico da classe Iphone
        iphone.InstalarAplicativo("Telegram");
    }
}