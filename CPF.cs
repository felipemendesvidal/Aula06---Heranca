namespace quartoPOO
{
    public class CPF : Pessoa
    {
        public string cpf;
        public string rg;
        public bool ValidaCpf(){
            if(cpf != null){
                return true;
            }
            return false;
        }
    }
}