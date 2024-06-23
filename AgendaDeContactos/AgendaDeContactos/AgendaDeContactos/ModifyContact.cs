namespace AgendaDeContactos;
public class ModifyContact
{
    public ModifyContact()
    {
        int opc = 1;

        while (opc != 3)
        {
            Console.WriteLine(@"Proceso de modificar contacto
Seleccione el tipo de contacto que quiere modificar:
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
                    Console.WriteLine("iniciando proceso de modificar contacto personal...");
                    PersonalContact personalContact = new();
                    var foundPersonalContact = personalContact.AskPhone();

                    if (foundPersonalContact is null)
                    {
                        Console.WriteLine("El contacto que busca no existe");
                    }
                    else
                    {
                        Console.WriteLine("Datos del contacto a modificar");
                        foundPersonalContact.ShowInformation(foundPersonalContact);
                        foundPersonalContact.EditInformation(foundPersonalContact);
                        Console.WriteLine("Informacion editada correctamente");
                    }

                    break;
                case 2:
                    Console.WriteLine("iniciando proceso de modificar contacto profesional...");
                    ProfessionalContact professionalContact = new();
                    var foundProfessionalContact = professionalContact.AskPhone();

                    if (foundProfessionalContact is null)
                    {
                        Console.WriteLine("El contacto que busca no existe");
                    }
                    else
                    {
                        Console.WriteLine("Datos del contacto a modificar");
                        foundProfessionalContact.ShowInformation(foundProfessionalContact);
                        foundProfessionalContact.EditInformation(foundProfessionalContact);
                        Console.WriteLine("Informacion editada correctamente");
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
