namespace AgendaDeContactos;
public class Contact
{
    public string Name { get; set; }
    public int Phone { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }

    public virtual bool AskInfo() {
        
        return true;
    }

}
