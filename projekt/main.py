import webbrowser


def szorzas(a,b):
    if b == 0:
        return 0
    else:
        return a + szorzas(a, b-1)

def hatvanyozas(a, b):
    if b == 0:
        return 1
    else:
        return szorzas(hatvanyozas(a, b-1), a)
    
def euler(n, k=None):
    if n == 0:
        return 1
    if k == None:
        k = 1+1/n
    return k * euler(n-1,k)

def fibonacci(n):
    if n <= 1:
        return n
    k = fibonacci(n-1) + fibonacci(n-2)
    return k

def binomialis(k, n):
    if k==0 or k==n:
        return 1
    return binomialis(k-1, n-1) + binomialis(k, n-1)

def binomialis2(f, k=0):
    while k < f+1:
        print(binomialis(k,f),end= ' ')
        k += 1

def main():
    stmt = True
    choice = input("Függvények megtekintése / html file megnyitása (func / html) \n - ")
    while stmt:
        if choice.lower() == "func":
            print(f'Rekurzív függvények')
            print("-- Szorzás -- \n")
            print(f'{szorzas(float(input("Szorzó: ")), float(input("Szorzandó: ")))}\n')
            print("-- Hatványozás -- \n")
            print(f'{hatvanyozas(float(input("Alap: ")), int(input("Kitevő: ")))}\n')
            print("-- Euler-féle szám -- \n")
            print(f'{euler(int(input("Euler n-edik eleme/hatványa: ")))}\n')
            print("-- Fibonacci sorozat -- \n")
            print(f'{fibonacci(int(input("Fibonacci sorozat n-edik eleme: ")))}\n')
            print("-- Binomiális együtthatók szorzata -- \n")
            binomialis2(int(input("Binomiális együttható szorzat fokszáma: ")))
            stmt = False
        elif choice.lower() == "html":
            webbrowser.open("index.html")
            stmt = False
        else:
            print("Nincs ilyen opció")
            choice = input("Függvények megtekintése / html file megnyitása (func / html) \n - ")
main()