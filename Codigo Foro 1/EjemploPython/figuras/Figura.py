# figuras/Figura.py
class Figura:
    def __init__(self, lado1, lado2):
        self.lado1 = lado1
        self.lado2 = lado2

    def obtener_area(self):
        return self.lado1 * self.lado2

    def __str__(self):
        return f'El area de {self.__class__.__name__} es: {self.obtener_area()}'
