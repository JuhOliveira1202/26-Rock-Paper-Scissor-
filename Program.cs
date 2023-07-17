using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player = "";
        string computer = "";

        /*------------------------------------- AVALIAR AS ESCOLHAS --------------------------------------------*/

        while (playAgain)
        {
            player = "";
            computer = "";

            while(player != "PEDRA" && player != "PAPEL" && player != "TESOURA")
            {
                Console.WriteLine("Escolha uma das 3 palavras seguintes:\nPEDRA, PAPEL, TESOURA");
                player = Console.ReadLine();
            }

            switch(random.Next(1, 4))
            {
                case 1:
                    computer = "PEDRA";
                    break;

                case 2:
                    computer = "PAPEL";
                    break;

                case 3:
                    computer = "TESOURA";
                    break;
            }

            Console.WriteLine("Jogador: " + player);
            Console.WriteLine("Computador: " + computer);

            /*------------------------------------- VER QUEM DOS DOIS GANHA --------------------------------------------*/

            switch (player)
            {
                case "PEDRA":
                    
                    if (computer == "PEDRA")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else if (computer == "PAPEL")
                    {
                        Console.WriteLine("Tu perdes-te!");
                    }
                    else
                    {
                        Console.WriteLine("Tu ganhas-te!");
                    }
                    break;

                case "PAPEL":

                    if(computer == "PEDRA")
                    {
                        Console.WriteLine("Tu ganhas-te!");
                    }
                    else if (computer == "PAPEL")
                    {
                        Console.WriteLine("Empate!");
                    }
                    else
                    {
                        Console.WriteLine("Tu perdes-te!");
                    }
                    break;

                case "TESOURA":

                    if(computer == "PEDRA")
                    {
                        Console.WriteLine("Tu perdes-te!");
                    }
                    else if (computer == "PAPEL")
                    {
                        Console.WriteLine("Tu ganhas-te!");
                    }
                    else
                    {
                        Console.WriteLine("Empate");
                    }
                    break;
            }

            /*------------------------------------- VER SE O JOGADOR QUER VOLTAR A JOGAR --------------------------------------------*/

            string resposta = "";

            Console.Write("Quer jogar novamente? (S/N)" + resposta);
            resposta = Console.ReadLine();

            if(resposta == "S")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
                Console.WriteLine("Obrigado por teres jogado connosco!");
            }


        }
    }
}
