using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace primeiroProjetoPOO
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public double tamanho;
        public bool ligado; // TRUE - LIGADO, FALSE - DESLIGADO 
        
        /// <summary>
        /// Método que ligar o celular
        /// </summary>
        /// <returns>Mensagem sobre o estado do celular</returns>
        public string ligar(){
            if(ligado == true){
                return "O celular já está ligado!";
            }else
            {
                ligado = true;
                return "Celular Ligado!";
            }
        } 

        /// <summary>
        /// Método que desliga o celular
        /// </summary>
        /// <returns>Mensagem com o estado do celular</returns>
        public string desligar(){
            if(ligado == true){
                ligado = false;
                return "Celular Desligado!";
            }else{
                return "O celular já está desligado!";
            }
                
        }

        /// <summary>
        /// Método que realiza uma ligação
        /// </summary>
        /// <returns>Mensagem se a ligação pode ser realizada</returns>
        public string fazerLigacao(){
            if(ligado == true){
                return "Realizando Ligação!";
            }else{
                return "O celular está desligado!";
            }
        }

        /// <summary>
        /// Método que envia uma mensagem
        /// </summary>
        /// <returns>Mensagem se o envio pode ser realizado</returns>
        public string enviarMensagem(){
            if(ligado == true){
                return "Enviando mensagem!";
            }else{
                return "O celular está desligado!";
            }
        }
    }
}