# figuras/Cuadrado.py
from .Rectangulo import Rectangulo

class Cuadrado(Rectangulo):
    def __init__(self, lado):
        super().__init__(lado, lado)
