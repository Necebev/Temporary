# helyezés | sportolók száma | sportág | versenyszám
# 1 | 1 | atletika | kalapacsvetes

# 2. feladat
with open("helsinki.txt", 'r', encoding='ansi') as file:
    data = file.readlines()
    lines = []
    helyezes = []
    sport_szam = []
    sportag = []
    versenyszam = []
    
    for i in range(len(data)):
        lines.append(data[i].strip().split(" "))
        helyezes.append(int(lines[i][0]))
        sport_szam.append(int(lines[i][1]))
        sportag.append(lines[i][2])
        versenyszam.append(lines[i][3])
        
adat = len(helyezes)
# 3. feladat
print(f'3. feladat: \nPontszerző helyezések száma: {adat}')

# 4. feladat
pontok = [] # 7. feladathoz előkészítés
arany = 0
ezust = 0
bronz = 0
for i in range(adat):
    if helyezes[i] == 1:
        arany += 1
        pontok.append(7)
    elif helyezes[i] == 2:
        ezust += 1
        pontok.append(5)
    elif helyezes[i] == 3:
        bronz += 1
        pontok.append(4)
print(f'4. feladat: \nArany: {arany}\nEzüst: {ezust}\nBronz: {bronz}\nÖsszesen: {arany+ezust+bronz}')

# 5. feladat
negyedik = 0
otodik = 0
hatodik = 0
for i in range(adat):
    if helyezes[i] == 4:
        negyedik += 1
        pontok.append(3)
    if helyezes[i] == 5:
        otodik += 1
        pontok.append(2)
    if helyezes[i] == 6:
        hatodik += 1
        pontok.append(1)
pontszam = 7*arany + 5*ezust + 4*bronz + 3*negyedik + 2*otodik + hatodik

print(f'5. feladat: \nOlimpiai pontok száma: {pontszam}')

# 6. feladat
print(f'6. feladat')
torna = 0
uszas = 0
for i in range(adat):
    if sportag[i] == "torna" and helyezes[i] <= 3:
        torna += 1
    elif sportag[i] == "uszas" and helyezes[i] <= 3:
        uszas += 1
if torna == uszas:
    print(f'Egyenlő volt az érmek száma')
elif torna > uszas:
    print(f'Torna sportágban szereztek több érmet')
else:
    print(f'Úszás sportágban szereztek több érmet')
    
# 7. feladat
with open('helsinki2.txt', 'w') as output:
    for i in range(adat):
        if sportag[i] != "kajakkenu":
            sor = f'{helyezes[i]} {sport_szam[i]} {pontok[i]} {sportag[i]} {versenyszam[i]}\n'
            output.write(sor)
        else:
            sportag[i] = "kajak-kenu"
            sor = f'{helyezes[i]} {sport_szam[i]} {pontok[i]} {sportag[i]} {versenyszam[i]}\n'
            output.write(sor)
            
# 8. feladat
for i in range(adat):
    if sport_szam[i] == max(sport_szam):
        idx = i
print(f'8. feladat:\nHelyezés: {helyezes[idx]}\nSportág: {sportag[idx]}\nVersenyszám: {versenyszam[idx]}\nSportolók száma: {sport_szam[idx]}')