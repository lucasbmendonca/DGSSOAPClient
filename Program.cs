using ServiceUtenteReference;
using System;
using System.Threading.Tasks;

namespace DGSSOAPClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string codigo = "1";
            string[] contatos = { "2", "3" };
            int addressId = 1;
            int teamId = 1;
            bool isolationStatus = true;
            bool irregularity = true;
            UtenteClient client = new UtenteClient();
            try
            {
                var response = client.Set(codigo, contatos, addressId, teamId, isolationStatus, irregularity);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
