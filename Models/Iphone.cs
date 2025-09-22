namespace DesafioPOO.Models
{
    // Herança implementada adicionando ": Smartphone"
    public class Iphone : Smartphone
    {
        // Construtor obrigatório para passar os dados para a classe base "Smartphone"
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Método "InstalarAplicativo" sobrescrito com a implementação para Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone.");
        }
    }
}