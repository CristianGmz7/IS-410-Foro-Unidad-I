# figuras/Triangulo.py
from .Rectangulo import Rectangulo

class Triangulo(Rectangulo):
    def __init__(self, base, altura):
        super().__init__(base, altura)

    def obtener_area(self):
        area = super().obtener_area()
        return area
