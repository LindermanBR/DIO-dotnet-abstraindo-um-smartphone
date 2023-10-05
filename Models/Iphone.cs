namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        List<string> aplicativos = new List<string>();

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o aplicativo {nomeApp} direto da apple appstore!");
            aplicativos.Add(nomeApp.ToLower());

        }
    }
}