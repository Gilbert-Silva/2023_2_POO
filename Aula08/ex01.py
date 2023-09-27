class Triangulo:
  def __init__(self, b, h, c):
    self.b = b
    self.h = h
    self.cor = c
  def __str__(self):
    return f"{self.b} {self.h} {self.cor}"

x = Triangulo(5, 5, "Amarelo")
y = Triangulo(10, 20, "Azul")
z = Triangulo(80, 2, "Cinza")
t = z
print(x)
print(y)
print(z)
print(t)
print(x.b, x.h, x.cor)
print(y.b, y.h, y.cor)
print(z.b, z.h, z.cor)
print(t.b, t.h, t.cor)








