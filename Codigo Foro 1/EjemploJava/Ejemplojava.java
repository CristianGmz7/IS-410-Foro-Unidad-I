public class Ejemplojava {

    public static void main(String[] args){
        Perro p = new Perro("Chanel", "Terry", 
        "Blanco con manchas cafe", 
        "Diminuta", "Purina");
        p.imprimeDatos();
        p.imprimeInformacion();

        Gato g = new Gato("Chikan", "Gato comun europeo", 
        "Gris y blanco", 
        "Mediano", "Pelota de hule");
        g.imprimeDatos();
        g.imprimeInformacion();
    }
}
