using System.Runtime.ConstrainedExecution;
using System;
using System.Security.Cryptography;

namespace Primo_progetto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. chiediamo all'utente se vuole criptare o decriptare un testo
            Console.WriteLine("Criptare o decriptare?");
            string mode = Console.ReadLine();



            //3. chiede di inserire il testo da criptare/decriptare
            Console.Write("Inserisci una frase:");
            string fraseUtente = Console.ReadLine();
            char[] frase = new char[fraseUtente.Length];


            if (mode == "decodifica")
            {
                Console.WriteLine("possibili decriptazioni:");
                for (int k = 1; k <= 10; k++)
                {
                    Console.Write("key:" + k + " --> ");

                    for (int i = 0; i < frase.Length; i++)
                    {
                        
                        Console.Write(Convert.ToChar(fraseUtente[i] - k));
                    }

                    Console.WriteLine();
                }

               
            }
            else
            {
                //2. chiedete una chiave numero da 1 a 10
                Console.Write("Inserisci la chiave (numero da 1 a 10):");
                int key = Convert.ToInt32(Console.ReadLine());

                //4. il sistema effettua la criptazione / decriptazione
                switch (mode)
                {
                    case "criptare":

                        for (int i = 0; i < frase.Length; i++)
                        {
                            frase[i] = Convert.ToChar(fraseUtente[i] + key);
                        }

                        break;

                    case "decriptare":

                        for (int i = 0; i < frase.Length; i++)
                        {
                            frase[i] = Convert.ToChar(fraseUtente[i] - key);
                        }

                        break;


                }




                //5. il sistema mostra a video il testo criptato
                Console.Write("Questa la tua frase {0}:", mode == "criptare" ? "criptata" : "decriptata");

                for (int i = 0; i < frase.Length; i++)
                {
                    Console.Write(frase[i]);
                }
            }

          


            // chiave di criptazione: 1
            // frase da criptare: "devo comprare le uova"
            // "EFWP DPNQSBSF MF VPWB"



        }
    }
}