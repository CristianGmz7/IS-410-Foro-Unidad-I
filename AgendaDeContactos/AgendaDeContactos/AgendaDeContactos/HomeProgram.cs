namespace AgendaDeContactos;

public class HomeProgram
{
    public HomeProgram()
    {
        int opc;

        do
        {
            Console.WriteLine(@"Bienvenido a tu agenda de contactos
Selecciona la opcion que quieres realizar:
1. Agregar contacto
2. Buscar contacto
3. Modificar contacto
4. Eliminar contacto
5. Salir
Ingrese su opcion:");

            try
            {
                opc = int.Parse(Console.ReadLine());
            }
            catch (FormatException) {
                opc = 0;
            }

            PauseAndContinue();

            switch (opc)
            {
                case 1:
                    AddContact addContact = new();
                    break;
                case 2:
                    SeachContact seachContact = new();
                    break;
                case 3:
                    ModifyContact modifyContact = new();
                    break;
                case 4:
                    DeleteContact deleteContact = new();
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            PauseAndContinue();

        } while (opc != 5);
    }

    private void PauseAndContinue()
    {
        Console.ReadKey();
        Console.Clear();
    }


}
