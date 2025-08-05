import time
nome = input("Digite seu nome: ")

def carregamento():
  total = 30
  for i in range(1, 101):
      blocos = int(i * total / 100)
      barra = "▉" * blocos + "-" * (total - blocos)
      print(f"\r|{barra}| {i}%", end='', flush=True)
      time.sleep(0.02)

carregamento()