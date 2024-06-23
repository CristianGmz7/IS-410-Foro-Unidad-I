public class Perro extends Animal {

    private final String marca_croquetas;
    public Perro(String nombre, String raza, String color, String tamano, 
    String marca_croquetas) {
        super(nombre, raza, color, tamano);
        this.marca_croquetas = marca_croquetas;
    }

    @Override
    public void imprimeInformacion(){
        System.out.println("Soy un perro y mi marca favorita de croquetas es: "+marca_croquetas);
    }

}
