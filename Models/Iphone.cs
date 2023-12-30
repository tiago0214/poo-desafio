namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        { }


        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o " + nomeApp + " , no Iphone");
        }
        public override void MostrarConfiguracoes()
        {
            Console.WriteLine($"A marca é Iphone\nO numero é: {Numero}\nO modelo é: {_modelo}\nCom armazenamento de: {_memoria} GB");
        }
    }
}