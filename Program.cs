string opcao;

while (true)
{
    Console.WriteLine ("Digite sua opcao");
    Console.WriteLine ("1 - Cadastrar cliente");
    Console.WriteLine ("2 - Buscar cliente");
    Console.WriteLine ("3 - Apagar cliente");
    Console.WriteLine ("4 - Encerrar cliente");

    opcao = Console.ReadLine();

    switch (opcao){
        case "1":
            Console.WriteLine ("Cadastro Cliente");
            break;
    
        case "2":
            Console.WriteLine ("Buscar Cliente");
            break;
        
        case "3":
            Console.WriteLine ("Apagar Cliente");
            break;
        
        case "4 -  encerra cliente":
            Console.WriteLine ("Encerrar Cliente");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine ("Opção errada");
            break;
    }
    
}