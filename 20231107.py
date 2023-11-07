with open('feliratok.txt', 'r') as file:
    sorok = []
    for i in file:
        sorok.append(i.strip())
    print(sorok)
class IdozitettFelirat:
    def idozites():
        pass
    def felirat():
        pass
    def __init__():
        pass
    def SzavakSzama():
        wordcount = 0
        for i in range(len(sorok)):
            for j in sorok[i]:
                if j == ' ':
                    wordcount += 1
        return wordcount
    
IF = IdozitettFelirat

print(IF.SzavakSzama())
