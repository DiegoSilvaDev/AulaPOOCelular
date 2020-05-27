namespace AulaPOOCelular
{
    public class Celular
    {

        public string nome;
        public int tam;
        public string cor;
        public string marca;
        public string modelo;
        public bool status;

        public bool Iniciar(string condicao){
            if(condicao == "on"){
                status = true;
            }else{
                condicao = "";
                status = false;
            }
            return status;
        }
        public string ligar(string numero){
            if(status){
                return "sua ligação foi efetuada com sucesso";
            }else{
                return "sua ligação teve algum erro na digitação iremos reiniciar o sistema";
            
            }
            
        }
        public string mensagem(string msg){
            if(status){
                status = true;
                return "Sua mensagem foi enviada com sucesso!";
            }else{
                msg = "";
                status = false;
                return "favor envie novamente, sua mensagem contem algum erro de digitação";
            }
        }
        public bool desligar(){
            status = false;
            return false;
        }    
    }
}