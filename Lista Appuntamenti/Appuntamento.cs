using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAppuntamenti
{
    internal class Appuntamento 
    {
        public DateTime dataAppuntamento;
        public string nome;
        public string localitaAppuntamento;
        public bool appuntamentoValido = true;

        public Appuntamento(DateTime dataAppuntamento, string nome, string localitaAppuntamento)

            //TRY CATCH 
        {
            
            try
            {
                verificaDataAppuntamento(dataAppuntamento);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                appuntamentoValido = false;
            }

            this.nome = nome;
            this.localitaAppuntamento = localitaAppuntamento;
        }

        //metodo 
        public void verificaDataAppuntamento(DateTime dataAppuntamento)
        {
            if (dataAppuntamento < DateTime.Now)
            {
                throw new Exception("La data inserita è nel passato");
            }
            else
            {
                this.dataAppuntamento = dataAppuntamento;
            }
        }

        public string GetNome()
        { return nome; }

        public DateTime GetDataAppuntamento()
        { return dataAppuntamento; }

        //metodo 
        public DateTime cambiaData(DateTime nuovaData)
        {
            appuntamentoValido = true;
            try
            {
                verificaDataAppuntamento(nuovaData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                appuntamentoValido = false;
            }
            return dataAppuntamento;
        }

        public override string ToString()
        {
            string stampaAppuntamento = "Prova";

            stampaAppuntamento += "\n-------Appuntamento------- \n";
            stampaAppuntamento += "Nome: " + nome + "\n";
            stampaAppuntamento += "Data: " + dataAppuntamento + "\n";
            stampaAppuntamento += "Località: " + localitaAppuntamento + "\n";
            stampaAppuntamento += "--------------------------";
            return stampaAppuntamento;
        }

    }
}
