namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" -- FEITO
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" __ FEITO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando APP {nomeApp} no Iphone {Modelo} de IMEI {IMEI} e {Memoria}GB de memoria.");
        }
    }
}