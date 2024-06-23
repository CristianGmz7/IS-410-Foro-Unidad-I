namespace AgendaDeContactos;
public class SeachContact
{
    public SeachContact()
    {
        int opc = 1;

        while (opc != 3)
        {
            Console.WriteLine(@"Proceso de buscar contacto
Seleccione el tipo de contacto que quiere buscar:
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
                    Console.WriteLine("iniciando proceso de buscar contacto personal...");
                    PersonalContact personalContact = new ();
                    var foundPersonalContact = personalContact.AskPhone();

                    if(foundPersonalContact is null)
                    {
                        Console.WriteLine("El contacto que busca no existe");
                    }
                    else{
                        Console.WriteLine("Esta es la informacion del contacto que buscas:");
                        foundPersonalContact.ShowInformation(foundPersonalContact);
                    }

                    break;
                case 2:
                    Console.WriteLine("iniciando proceso de buscar contacto profesional...");
                    ProfessionalContact professionalContact = new();
                    var foundProfessionalContact = professionalContact.AskPhone();

                    if( foundProfessionalContact is null)
                    {
                        Console.WriteLine("El contacto que busca no existe");
                    }
                    else{
                        Console.WriteLine("Esta es la informacion del contacto que buscas:");
                        foundProfessionalContact.ShowInformation(foundProfessionalContact);
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
