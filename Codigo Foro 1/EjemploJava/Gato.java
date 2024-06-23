public class Gato extends Animal {
    private final String juguete_preferido;
    public Gato(String nombre, String raza, String color, String tamano, 
    String juguete_preferido) {
        super(nombre, raza, color, tamano);
        this.juguete_preferido = juguete_preferido;
    }

    @Override
    public void imprimeInformacion(){
        System.out.println("Soy un gato y mi juguete favorito es: "+juguete_preferido);
    }
}
