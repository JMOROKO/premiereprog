using System;

namespace premiere_prog // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            { 
                int age = 0;
                string nom = "";
                /*Console.WriteLine("Bonjour quel est votre nom ?");
                string nom = Console.ReadLine();

                // boucle tantque avec condition comparaison valeur
                while(nom == "")
                {
                    Console.WriteLine("Bonjour quel est votre nom ?");
                    nom = Console.ReadLine();
                }*/
                Console.WriteLine("Bonjour quel est votre nom ?");
                nom = Console.ReadLine();

                do
                {
                    Console.WriteLine("Bonjour quel est votre nom ?");
                    nom = Console.ReadLine();
                }
                while (nom == "");
                
                Console.WriteLine("Vous vous appelez " + nom);
                Console.WriteLine("Quel est votre age ?");
                string age_str = Console.ReadLine();
                //conversion de string en entier
                age = int.Parse(age_str);

                /**
                 * Structure conditionnel
                 * vérifie si l'age est supérieur à 0
                 */
                if(age > 0)
                {
                    Console.WriteLine("Vous avez " + age);
                }
                else 
                {
                    Console.WriteLine("Vous avez " + (-age) );
                }

                //boucle pour
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Bonjour n° "+i);
                }
            }
            catch {
                Console.WriteLine("Une erreur est survenue");
            }
        }
    }
}