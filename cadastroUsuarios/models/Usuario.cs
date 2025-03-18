namespace cadastroUsuarios.Models
{   
    /*
    * Classe que representa um usuário
    */
    public class Usuario
    {
        private string Nome { get; set; }
        private string Email { get; set; }
        private int Idade { get; set; }

        /**
            Construtor padrão       
         */
        public Usuario()
        {
        }

        /**
            Construtor com parâmetros
            @param nome Nome do usuário
            @param email Email do usuário
            @param idade Idade do usuário
         */
        public Usuario(string nome, string email, int idade)
        {
            this.Nome = nome;
            this.Email = email;
            this.Idade = idade;
        }

        public string GetNome()
        {
            return this.Nome;
        }

        public string GetEmail()
        {
            return this.Email;
        }

        public int GetIdade()
        {
            return this.Idade;
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }
        
        public void SetEmail(string email)
        {
            this.Email = email;
        }

        public void SetIdade(int idade)
        {
            this.Idade = idade; 
        }

        /**
            Método que sobrescreve e permite retornar uma string com os dados do usuário
            @return string com os dados do usuário
         */
        public override string ToString()
        {
            return $"Nome: {this.Nome}, Email: {this.Email}, Idade: {this.Idade}";
        }
    }
}