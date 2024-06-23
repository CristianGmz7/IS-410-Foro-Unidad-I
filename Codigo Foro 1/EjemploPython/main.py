# main.py
from figuras.Rectangulo import Rectangulo
from figuras.Cuadrado import Cuadrado
from figuras.Triangulo import Triangulo
from figuras.Circulo import Circulo
from figuras.Hexagono import Hexagono

def main():
    rectangulo = Rectangulo(10, 5)
    print(rectangulo)
    
    cuadrado = Cuadrado(5)
    print(cuadrado)
    
    triangulo = Triangulo(10, 5)
    print(triangulo)
    
    circulo = Circulo(3)
    print(circulo)
    
    hexagono = Hexagono(6)
    print(hexagono)

if __name__ == "__main__":
    main()