using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace primeiroProjetoPOO
{
    public class Celular
    {
        public string cor = "Amarelo";
        public string modelo = "Samsung A10";
        public double tamanho = 10.5;

        public bool estadoCelular = true; // TRUE - LIGADO, FALSE - DESLIGADO 
        
        public string ligar(){
            if(estadoCelular == true){
                return "O celular já está ligado!";
            }else
            {
                estadoCelular = true;
                return "Celular Ligado!";
            }
        } 
        public string desligar(){
            if(estadoCelular == true){
                estadoCelular = false;
                return "Celular Desligado!";
            }else{
                return "O celular já está desligado!";
            }
                
        }
        public string fazerLigacao(){
            if(estadoCelular == true){
                return "Realizando Ligação!";
            }else{
                return "O celular está desligado!";
            }
        }
        public string enviarMensagem(){
            if(estadoCelular == true){
                return "Enviando mensagem!";
            }else{
                return "O celular está desligado!";
            }
        }
    }
}