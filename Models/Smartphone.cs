namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string _modelo;
        protected string _imei;
        protected int _memoria;

        // TODO: Implementar as propriedades faltantes de acordo com o diagrama


        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            _modelo = modelo;
            _imei = imei;
            _memoria = memoria;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        public abstract void MostrarConfiguracoes();


    }
}