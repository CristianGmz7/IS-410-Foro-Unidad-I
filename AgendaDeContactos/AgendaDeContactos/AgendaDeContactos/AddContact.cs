namespace AgendaDeContactos;
public class AddContact
{
    public AddContact()
    {

        int opc = 1;

        while (opc != 3)
        {
            Console.WriteLine(@"Proceso de agregar contacto
Seleccione el tipo de contacto que quiere ingresar:
1. Contacto Personal
2. Contacto Profesional
3. Regresar al menu principal");

            try
            {
                opc = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                opc = 0;
            }

            PauseAndContinue();

            switch (opc)
            {
                case 1:
                    Console.WriteLine("iniciando proceso de agregar contacto personal...");
                    PersonalContact personalContact = new();
                    var successfulPersonalContact = personalContact.AskInfo();

                    if (successfulPersonalContact)
                    {
                        Console.WriteLine("El contacto fue agregado exitosamente");
                    }
                    else{
                        Console.WriteLine("Error\nYa existe un contacto con el nombre/numero ingresado");
                    }

                    break;
                case 2:
                    Console.WriteLine("iniciando proceso de agregar contacto profesional...");
                    ProfessionalContact professionalContact = new();
                    var successfulProfessionalContact = professionalContact.AskInfo();

                    if (successfulProfessionalContact)
                    {
                        Console.WriteLine("El contacto fue agregado exitosamente");
                    }
                    else
                    {
                        Console.WriteLine("Error\nYa existe un contacto con el nombre/numero ingresado");
                    }

                    break;
                case 3:
                    Console.WriteLine("regresando al menu principal...");
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            PauseAndContinue();
        }

    }

    private void PauseAndContinue()
    {
        Console.ReadKey();
        Console.Clear();
    }
}
