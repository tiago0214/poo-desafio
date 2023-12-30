namespace DesafioPOO.Models
{

    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }



        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o " + nomeApp + " , no Nokia");
        }
        public override void MostrarConfiguracoes()
        {
            Console.WriteLine($"A marca é Nokia\nO numero é: {Numero}\nO modelo é: {_modelo}\nCom armazenamento de: {_memoria} GB");
        }

    }
}