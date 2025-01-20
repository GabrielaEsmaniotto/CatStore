namespace CatStore.Back
{
    public class Gato
    {
        private string nome;
        private int idade;
        private float peso;
        private string cor;

        public string Miar()
        {
            return "Miau";
        }

        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public float GetPeso()
        {
            return peso;
        }
        public void SetPeso(float peso) 
        {
            this.peso = peso;
        }
        public string GetCor()
        {
            return cor;
        }
        public void SetCor(string cor) 
        {
            this.cor = cor;   
        }
     }
}
