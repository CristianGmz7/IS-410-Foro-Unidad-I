namespace AgendaDeContactos;
public class DeleteContact
{
    public DeleteContact()
    {
        int opc = 1;

        while (opc != 3)
        {
            Console.WriteLine(@"Proceso de eliminar contacto
Seleccione el tipo de contacto que quiere eliminar:
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

            int confir = 0;
            switch (opc)
            {
                case 1:
                    Console.WriteLine("iniciando proceso de eliminar contacto personal...");
                    PersonalContact personalContact = new();
                    var foundPersonalContact = personalContact.AskPhone();

                    if (foundPersonalContact is null)
                    {
                        Console.WriteLine("El contacto que busca no existe");
                    }
                    else
                    {
                        Console.WriteLine("Esta es la informacion del contacto que buscas:");
                        foundPersonalContact.ShowInformation(foundPersonalContact);
                        Console.WriteLine("Confirme si esta seguro de eliminar el contacto\n1. Si\n2. No");
                        confir = int.Parse (Console.ReadLine() ?? "2");
                        if(confir == 1)
                        {
                            foundPersonalContact.DeleteInformation(foundPersonalContact.Phone);
                            Console.WriteLine("Contacto eliminado correctamente");
                        }
                        else {
                            Console.WriteLine("Cancelando proceso");
                        }
                    }

                    break;
                case 2:
                    Console.WriteLine("iniciando proceso de eliminar contacto profesional...");
                    ProfessionalContact professionalContact = new();
                    var foundProfessionalContact = professionalContact.AskPhone();

                    if (foundProfessionalContact is null)
                    {
                        Console.WriteLine("El contacto que busca no existe");
                    }
                    else
                    {
                        Console.WriteLine("Esta es la informacion del contacto que buscas:");
                        foundProfessionalContact.ShowInformation(foundProfessionalContact);
                        Console.WriteLine("Confirme si esta seguro de eliminar el contacto\n1. Si\n2. No");
                        confir = int.Parse(Console.ReadLine() ?? "2");
                        if (confir == 1)
                        {
                            foundProfessionalContact.DeleteInformation(foundProfessionalContact.Phone);
                            Console.WriteLine("Contacto eliminado correctamente");
                        }
                        else
                        {
                            Console.WriteLine("Cancelando proceso");
                        }
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
