using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        List<string> aplicativos = new List<string>();

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o aplicativo {nomeApp} direto da google appstore!");
            aplicativos.Add(nomeApp.ToUpper());

        }
    }
}