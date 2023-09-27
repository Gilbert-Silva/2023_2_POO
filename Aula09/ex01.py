class Triangulo:
  def __init__(self, b, h):
    self.set_base(b)
    self.set_altura(h)
  def get_base(self):
    return self.__b
  def get_altura(self):
    return self.__h
  def set_base(self, b):
    if b >= 0: self.__b = b
    else: raise ValueError
  def set_altura(self, h):
    if h >= 0: self.__h = h
    else: raise ValueError
  def calc_area(self):
    return self.__b * self.__h / 2
  def __str__(self):
    return f"Base = {self.__b}  Altura = {self.__h}  Área = {self.calc_area()}"

x = Triangulo(5, 5)
print(x)

y = Triangulo(10, 20)
print(y)
