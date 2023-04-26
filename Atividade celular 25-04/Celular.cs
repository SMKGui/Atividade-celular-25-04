namespace Atividade_celular_25_04
{
    public class Celular
    {
        //propriedades

        public string cor;
        public string modelo;
        public float tamanho;
        public bool ligado = false;

        //metodos

        public void Ligar()
        {
            Console.WriteLine($"O celular esta ligando...");
        }

        public void Desligar()
        {
            Console.WriteLine($"O celular esta desligando...");
        }

        public void Call()
        {
            Console.WriteLine($"Fazendo ligacao...");
        }

        public void Mensagem()
        {
            Console.WriteLine($"Enviando mensagem...");
            
        }
    }
}