import math

class triangle: # ez az ősosztály
    def __init__(self, a, b, c):
        self.a = a
        self.b = b
        self.c = c

    def szabalyos(self):
        if self.a == self.b == self.c:
            return True
        return False
    
    def egyenloszaru(self):
        if self.a == self.b or self.a == self.c or self.b == self.c:
            return True
        return False
    
class angles(triangle):
    def __init__(self, a, b, c):
        super().__init__(a, b, c)

    def derekszog(self):
        an = self.a**2
        bn = self.b**2
        cn = self.c**2
        if an == bn+cn or bn == an+cn or cn == an+bn:
            return True
        return False
    
    def hegyesszog(self):
        an = self.a**2
        bn = self.b**2
        cn = self.c**2
        if an < bn+cn and bn < an+cn and cn < an+bn:
            return True
        return False

    def tompaszog(self):
        if not self.derekszog() and not self.hegyesszog():
            return True
        return False

# Főprogran
tri = triangle(2,2,2)
print(tri.szabalyos())

print(tri.egyenloszaru())

ang = angles(5, 12, 13)
print(ang.derekszog(), ang.hegyesszog(), ang.tompaszog())