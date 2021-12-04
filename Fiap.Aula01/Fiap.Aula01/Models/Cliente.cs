
namespace Fiap.Aula01.Models
{
    class Cliente
    {
        //Atributos ou Campos
        //Encapsulamento - proteger o acesso aos atributos e métodos
        private string _nome;
        
        private int _idade;

        //Propriedades - Métodos de acesso aos atributos
        //prop -> tab tab (Cria uma propriedade) | propfull -> Campo e Propriedade
        public Endereco Endereco { get; set; }

        public bool Especial { get; set; }

        public float Altura { get; set; }   //Propriedade com o campo (atributo) oculto

        public int Idade
        {
            get {  return _idade; }
            set 
            { 
                //value é o valor recebido na atribuiço, no uso do set no Program
                if (value > 0) //Valida se a idade é maior do que zero para atribuir                   
                    _idade = value; 
            }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        //Métodos (Ações) 

    }
}
