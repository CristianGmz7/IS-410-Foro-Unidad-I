# figuras/Hexagono.py
from math import sqrt
from .Cuadrado import Cuadrado

class Hexagono(Cuadrado):
    def obtener_area(self):
        return (3 * sqrt(3) * self.lado1 ** 2) / 2
