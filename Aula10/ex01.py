class Ingresso:
  def __init__(self, dia, hora):
    self.set_dia(dia)
    self.set_hora(hora)
  def set_dia(self, dia):
    if dia in ["dom", "seg", "ter", "qua", "qui", "sex", "sab"]:
      self.dia = dia
    else:
      raise ValueError
  def set_hora(self, hora): 
    if 0 <= hora <= 23: self.hora = hora
    else: raise ValueError
  def get_dia(self):
    return self.dia
  def get_hora(self):
    return self.hora
  def inteira(self):
    if self.dia == "qua": return 8
    p = 16
    if self.dia in ["sex", "sab", "dom"]: p = 20
    if self.hora == 0 or self.hora >= 17: p = p * 1.5
    return p
  def meia(self):
    if self.dia == "qua": return 8
    return self.inteira() / 2  

a = Ingresso("ter", 16)
b = Ingresso("qua", 18)
c = Ingresso("sex", 18)
print(a.inteira())
print(b.inteira())
print(c.inteira())

