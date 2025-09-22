namespace DesafioPOO.Models
{
    // Herança implementada adicionando ": Smartphone"
    public class Nokia : Smartphone
    {
        // ATENÇÃO: É obrigatório adicionar um construtor para passar os dados para a classe-mãe "Smartphone"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Método "InstalarAplicativo" sobrescrito
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia.");
        }
    }
}