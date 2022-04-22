
using ListaAppuntamenti;

Console.WriteLine("AGENDA \n");

List<Appuntamento> listaAppuntamenti = new List<Appuntamento>();

Console.Write("Quanti appuntamenti hai? ");
int numeroAppuntamenti = Convert.ToInt32(Console.ReadLine());

DateTime dataDaAggiungere;
string nomeAppuntamento;
string localita;

while (numeroAppuntamenti > 0)
{
    Console.WriteLine("\n-------Appuntamento-------");
    Console.Write("Inserisci il nome : ");
    nomeAppuntamento = Console.ReadLine();
    Console.Write("Inserisci la data : ");
    dataDaAggiungere = DateTime.Parse(Console.ReadLine());
    Console.Write("Inserisci la località : ");
    localita = Console.ReadLine();
    Console.WriteLine("--------------------------");


    listaAppuntamenti.Add(new Appuntamento(dataDaAggiungere, nomeAppuntamento, localita));
    if (listaAppuntamenti[listaAppuntamenti.Count - 1].appuntamentoValido)
    {
        numeroAppuntamenti--;
    }
    else
    {
        listaAppuntamenti.RemoveAt(listaAppuntamenti.Count - 1);
    }
}


