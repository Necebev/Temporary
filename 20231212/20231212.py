def sentencesplit():
    sentence = input("Mondat:\n")
    wordlist = sentence.split()
    print(wordlist)
    hossz = len(wordlist)
    a = hossz//3
    b = 2*hossz//3
    E = wordlist[0:a]
    K = wordlist[a:b]
    V = wordlist[b:]
    print(K + V + E)

#sentencesplit()

'''
1. Mi a "self" szó jelentése és szerepe egy osztály konstruktorában?
    - Az osztályon belül létrehozott értékeket (objekteket) jelenti.
      Szerepe: 

2. Mi az __iadd__ feladata?
    
'''
L = []
for i in range(1, 4):
    with open(f'jarat{i}.txt', 'r', encoding="utf-8") as file:
        print(file.readlines())

