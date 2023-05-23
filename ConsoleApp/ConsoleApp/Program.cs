public class Menu
{
    static void Main(string[] args)
    {
        ClientOperations operationsC = new ClientOperations();
        bool sair = false;

        while (!sair)
        {
            Console.Clear();

            Console.WriteLine("-----------CLIENTES-----------");
            Console.WriteLine("1 - VER TODOS");
            Console.WriteLine("2 - ADCIONAR");
            Console.WriteLine("3 - ATUALIZAR");
            Console.WriteLine("4 - DELETAR");
            Console.WriteLine("5 - SAIR");
            Console.WriteLine("\n");
            Console.WriteLine("Insira o número da operaçao: ");

            switch (Console.ReadLine())
            {

                case "1":
                    Console.Clear();
                    operationsC.Read();


                    break;
                case "2":
                    Console.Clear();
                    operationsC.Write();
                    Console.ReadLine();


                    break;
                case "3":
                    Console.Clear();
                    operationsC.Read();
                    Console.WriteLine("\n");
                    operationsC.Update();
                    Console.ReadLine();


                    break;
                case "4":
                    Console.Clear();
                    operationsC.Read();
                    Console.WriteLine("\n");
                    operationsC.Delete();

                    break;

                case "5":

                    sair = true;

                    break;

            }
        }
    }
}


