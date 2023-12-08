import tkinter as tk

class SzamlaloAlkalmazas:
    def __init__(self, ablak):
        self.ablak = ablak
        self.ablak.title("Számláló alkalmazás")
        self.ablak.geometry("960x540")
        self.ablak.configure(bg='beige')
        
        self.ertek = tk.IntVar() # a kiírt szám változója        
        self.ertek.set(0) # kezdőérték beállítása
        
        gomb_novel = tk.Button(ablak, text='Növel', font=("Times", 20), command=self.novel)
        gomb_csokkent = tk.Button(ablak, text='Csökkent', font=("Times", 20), command=self.csokkent)
        gomb_novel.pack(side=tk.LEFT, padx = 10)
        gomb_csokkent.pack(side=tk.RIGHT, padx = 10)
        
        self.cimke = tk.Label(ablak, font=("Times", 24), textvariable=self.ertek)
        self.cimke.pack(pady=20)
        
    def novel(self):
        self.ertek.set(self.ertek.get() + 1)
        
    def csokkent(self):
        E = self.ertek.get()
        if E > 0:
            self.ertek.set(E - 1)
        
    def rgbtohex(r,g,b):
        return f'#{r:02x}{g:02x}{b:02x}'
    
    def rgbtext(self):
        E = self.ertek.get()
        if E <= 255:
            r += 1
        
# Főprogram

if __name__ == "__main__":
    Ablak = tk.Tk()
    alkalmazas = SzamlaloAlkalmazas(Ablak)
    Ablak.mainloop()
    
