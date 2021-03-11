namespace DIO.Series
{ //Inicio namespace
    public class Serie : EntidadeBase // Referencia é a EntidadeBase pra conseguir reutilizar as implementações.
    { //Inicio Class
        
        //Atributos

    private  Genero Genero  { get; set; }
    private  string Titulo  { get; set; }
    private  string Descricao  { get; set; }
    private  int Ano  { get; set; }

    private bool Excluido {get; set;} // Vai falar se o registro ta excluido ou nao.

      //Método Construtor
    public Serie(int id, Genero genero, string titulo, string descricao, int ano )
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false; // Não exclui a informação somente marca que o objeto foi excluido.


        }

        public override string ToString() //função de retorno após alguma ação ser executada.
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + "\n";
            retorno += "Título: " + this.Titulo + "\n";
            retorno += "Descrição: " + this.Descricao + "\n";
            retorno += "Ano de Início: " + this.Ano + "\n";
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        // Encapsulamento

        public string retornaTitulo() 
        {
            return this.Titulo;

        }

        public int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }

    } //Fim Class
} //Fim namespace