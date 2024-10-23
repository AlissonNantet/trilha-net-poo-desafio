namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" -- FEITO
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" -- FEITO
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando APP {nomeApp} no Nokia {Modelo} de IMEI {IMEI} e {Memoria}GB de memoria.");
        }
    }
}