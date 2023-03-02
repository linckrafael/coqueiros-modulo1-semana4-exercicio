using M1S4;

bool show = true;
var opcao = Menu.MostrarMenu();

switch (opcao) 
{
    case 1:
        Bebida bebida = new Bebida(1, "refri", 100, "coca", 4);
        Repositorio.AdicionarBebida(bebida);
        show = Menu.ReiniciarDisplayConsole();
        break;
    case 2:
        bebida = new Bebida(1, "suco", 150, "vale", 3);
        Repositorio.Alterar(bebida);
        show = Menu.ReiniciarDisplayConsole();
        break;
    case 3:
        var listaAntesExcluir = Repositorio.Listar();
        Repositorio.Remover(1);
        show = Menu.ReiniciarDisplayConsole();
        break;
    case 4:
        Repositorio.Listar();
        show = Menu.ReiniciarDisplayConsole();
        break;
    case 5:
        Repositorio.ExecutarSuco();
        show = Menu.ReiniciarDisplayConsole();
        break;
    case 6:
        Repositorio.ExecutarRefri();
        show = Menu.ReiniciarDisplayConsole();
        break;
    case 7:
        Console.WriteLine("Tchau !!!");
        show = false;
        break;
    default:
        Console.WriteLine("Dados com erros, aguarde 2 segundos para a tela carregar display inicial");
        Thread.Sleep(2000);
        Menu.MostrarMenu();
        break;
}