using Newtonsoft.Json;

namespace AgendaDeContactos;
public class ProfessionalContact : Contact
{

    public readonly string _JSON_FILE;
    public string Position { get; set; }
    public string Company {  get; set; }
    public int WorkPhone { get; set; }
    public string WorkEmail { get; set; }

    public ProfessionalContact()
    {
        _JSON_FILE = "SeedData/professionalContacs.json";
    }

    public override bool AskInfo()
    {
        var contacts = ReadContactsFile();

        var contact = new ProfessionalContact();

        Console.WriteLine("Ingrese nombre del contacto:");
        contact.Name = Console.ReadLine();

        Console.WriteLine("Ingrese numero telefonico: ");
        contact.Phone = int.Parse(Console.ReadLine());
        int phone = contact.Phone;

        if (!CheckPhone(phone))
        {
            return false;
        }

        Console.WriteLine("Ingrese direccion donde vive: ");
        contact.Address = Console.ReadLine();

        Console.WriteLine("Ingrese correo electronico: ");
        contact.Email = Console.ReadLine();

        Console.WriteLine("Ingrese la posicion en la empresa donde trabaja: ");
        contact.Position = Console.ReadLine();

        Console.WriteLine("Ingrese nombre de la compañia donde trabaja: ");
        contact.Company = Console.ReadLine();

        Console.WriteLine("Ingrese numero telefonico del trabajo: ");
        contact.WorkPhone = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese correo electronico del trabajo: ");
        contact.WorkEmail = Console.ReadLine();

        contacts.Add(contact);

        WriteContactsFile(contacts);

        return true;
    }

    private List<ProfessionalContact> ReadContactsFile()
    {
        if(!File.Exists(_JSON_FILE))
        {
            return new List<ProfessionalContact>();
        }

        var json = File.ReadAllText(_JSON_FILE);

        var contacts = JsonConvert.DeserializeObject<List<ProfessionalContact>>(json);

        return contacts;
    }

    private void WriteContactsFile(List<ProfessionalContact> contacts)
    {
        var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);

        if (File.Exists(_JSON_FILE))
        {
            File.WriteAllText(_JSON_FILE, json);
        }
    }

    private bool CheckPhone(int phone)
    {
        var contacts = ReadContactsFile();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (phone == contacts[i].Phone)
            {
                return false;
            }
        }

        return true;
    }

    public ProfessionalContact AskPhone()
    {
        var contacts = ReadContactsFile();

        Console.WriteLine("Ingrese numero del contacto que desea:");
        int phone = int.Parse(Console.ReadLine() ?? "0");

        ProfessionalContact searchedContact = contacts.FirstOrDefault(c => c.Phone == phone);

        return searchedContact;
    }

    public void ShowInformation(ProfessionalContact contact)
    {
        Console.WriteLine($"Nombre: {contact.Name}");
        Console.WriteLine($"Numero de telefono: {contact.Phone}");
        Console.WriteLine($"Direccion: {contact.Address}");
        Console.WriteLine($"Correo electronico: {contact.Email}");
        Console.WriteLine($"Posicion en la empresa: {contact.Position}");
        Console.WriteLine($"Nombre de la empresa: {contact.Company}");
        Console.WriteLine($"Numero de telefono de trabajo: {contact.WorkPhone}");
        Console.WriteLine($"Correo electronico de trabajo: {contact.WorkEmail}");
    }

    public void EditInformation(ProfessionalContact contact)
    {
        var contacts = ReadContactsFile();

        Console.WriteLine("Ingrese nuevo nombre del contacto:");
        contact.Name = Console.ReadLine();

        Console.WriteLine("Ingrese nueva direccion donde vive: ");
        contact.Address = Console.ReadLine();

        Console.WriteLine("Ingrese nuevo correo electronico: ");
        contact.Email = Console.ReadLine();

        Console.WriteLine("Ingrese nueva posicion en la empresa: ");
        contact.Position = Console.ReadLine();

        Console.WriteLine("Ingrese nombre nueva empresa donde trabaja: ");
        contact.Company = Console.ReadLine();

        Console.WriteLine("Ingrese nuevo numero telefonico del trabajo: ");
        contact.WorkPhone = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese nuevo correo electronico del trabajo: ");
        contact.WorkEmail = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].Phone == contact.Phone)
            {
                contacts[i] = contact;
            }
        }

        WriteContactsFile(contacts);
    }

    public void DeleteInformation(int phone)
    {
        var contacts = ReadContactsFile();
        var contactToDelete = contacts.FirstOrDefault(c => c.Phone == phone);

        contacts.Remove(contactToDelete);

        WriteContactsFile(contacts);


    }
}
