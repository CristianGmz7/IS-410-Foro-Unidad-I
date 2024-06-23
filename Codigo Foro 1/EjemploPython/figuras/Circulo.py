# figuras/Circulo.py
from math import pi
from .Cuadrado import Cuadrado

class Circulo(Cuadrado):
    def __init__(self, lado1):
        super().__init__(lado1)

    def obtener_area(self):
        return pi * (self.lado1 ** 2)
