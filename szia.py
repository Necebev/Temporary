import turtle # ez a szükséges gyűjtemény
# innentől a turtle él, ezzel együtt használhatjuk OOP
# alapokon is a tekit
# ablak alapbeállítások
ablak = turtle.Screen()
ablak.bgcolor("lightgrey")
ablak.setup(960, 520)
# változók használata
#l= int(input("hosszúság"))
#h = int(input("magasság"))
ablak.title("Heloszia")
teki = turtle.Turtle()
# teki.fd(mennyit) .left() .right() .fillcolor("szín") .begin_fill() .end_fill() .penup() .pendown()
def rajzol():
    teki.fillcolor("grey")
    teki.begin_fill()
    teki.fd(l)
    teki.left(90)
    teki.fd(h)
    teki.left(90)   
    teki.fd(l)
    teki.left(90)
    teki.fd(h)
    teki.end_fill()

def kilep():
    turtle.bye()

ablak.onkey(rajzol, "8")
ablak.onkey(kilep, "9")

# ablak.onkey(eseménykezelő, "meghívó billentyű felirata")
# ablak.onscreenclick(eseménykezelő, 1-3)

def rajzol1():
    teki.left(60)
    color = ["blue", "red", "yellow"]
    for i in range(2,5):
        teki.fillcolor(color[i-2])
        teki.begin_fill()
        teki.fd(i*30)
        teki.right(120)
        teki.fd(i*30)
        teki.right(120)
        teki.fd(i*30)
        teki.end_fill()
    teki.left(30)

def rajzol2():
    teki.speed()
    for j in range(3):
        for i in range(390):
            teki.fd(1)
            teki.left(1)
            if i == 389:
                teki.right(120)
            

ablak.onkey(rajzol1, "q")
ablak.onkey(rajzol2, "w")
#ablak.onkey(rajzol3, "e")
turtle.listen()
ablak.mainloop()