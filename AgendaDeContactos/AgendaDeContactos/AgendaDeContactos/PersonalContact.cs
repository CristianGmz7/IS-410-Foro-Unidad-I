using Newtonsoft.Json;

namespace AgendaDeContactos;
public class PersonalContact : Contact
{
    public readonly string _JSON_FILE;

    public PersonalContact()
    {
        _JSON_FILE = "SeedData/personalContacts.json";
    }

    public DateTime Birthday { get; set; }
    public string Relation { get; set; }
    public string CivilStatus { get; set; }

    public override bool AskInfo()
    {

        var contacts = ReadContactsFile();

        var contact = new PersonalContact();

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

        int year, month, day;
        Console.WriteLine("Ingrese anio de nacimiento del contacto:"); year = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese mes de nacimiento del contacto (en numero):"); month = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese dia de nacimiento del contacto"); day = int.Parse(Console.ReadLine());
        contact.Birthday = new DateTime(year, month, day);

        Console.WriteLine("Ingrese su tipo de relacion con el contacto: ");
        contact.Relation = Console.ReadLine();

        Console.WriteLine("Ingrese el Estado Civil del contacto: ");
        contact.CivilStatus = Console.ReadLine();

        contacts.Add(contact);

        WriteContactFile(contacts);

        return true;
    }

    private List<PersonalContact> ReadContactsFile()
    {
        if (!File.Exists(_JSON_FILE))
        {
            return new List<PersonalContact>();
        }

        var json = File.ReadAllText(_JSON_FILE);

        var contacts = JsonConvert.DeserializeObject<List<PersonalContact>>(json);

        return contacts;
    }

    private void WriteContactFile(List<PersonalContact> contacts)
    {
        var json = JsonConvert.SerializeObject(contacts, Formatting.Indented);

        if (File.Exists(_JSON_FILE)) { 
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

    public PersonalContact AskPhone() {
        var contacts = ReadContactsFile();

        Console.WriteLine("Ingrese numero del contacto que desea:");
        int phone = int.Parse(Console.ReadLine() ?? "0");

        PersonalContact searchedContact = contacts.FirstOrDefault(c => c.Phone == phone);

        return searchedContact;
    }

    public void ShowInformation(PersonalContact contact)
    {
        Console.WriteLine($"Nombre: {contact.Name}");
        Console.WriteLine($"Numero de telefono: {contact.Phone}");
        Console.WriteLine($"Direccion: {contact.Address}");
        Console.WriteLine($"Correo electronico: {contact.Email}");
        Console.WriteLine($"Fecha de cumpleaños: {contact.Birthday}");
        Console.WriteLine($"Tipo de relacion: {contact.Relation}");
        Console.WriteLine($"Estado civil: {contact.CivilStatus}");
    }

    public void EditInformation(PersonalContact contact)
    {
        var contacts = ReadContactsFile();

        Console.WriteLine("Ingrese nuevo nombre del contacto:");
        contact.Name = Console.ReadLine();

        Console.WriteLine("Ingrese nueva direccion donde vive: ");
        contact.Address = Console.ReadLine();

        Console.WriteLine("Ingrese nuevo correo electronico: ");
        contact.Email = Console.ReadLine();

        int year, month, day;
        Console.WriteLine("Ingrese anio de nacimiento del contacto:"); year = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese mes de nacimiento del contacto (en numero):"); month = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese dia de nacimiento del contacto"); day = int.Parse(Console.ReadLine());
        contact.Birthday = new DateTime(year, month, day);

        Console.WriteLine("Ingrese su nuevo tipo de relacion con el contacto: ");
        contact.Relation = Console.ReadLine();

        Console.WriteLine("Ingrese el nuevo Estado Civil del contacto: ");
        contact.CivilStatus = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].Phone == contact.Phone)
            {
                contacts[i] = contact;
            }
        }

        WriteContactFile(contacts);

    }

    public void DeleteInformation(int phone)
    {
        var contacts = ReadContactsFile();
        var contactToDelete = contacts.FirstOrDefault(c => c.Phone == phone);

        contacts.Remove(contactToDelete);

        WriteContactFile(contacts);

    }

}
