import tkinter as tk
from tkinter import *
from tkinter import ttk
admin_user = "admin"
admin_pass = "admin"

window1 = Tk()
window1.geometry("720x608")


def nyilvantartas_user():
    window2 = Tk()
    window1.destroy() #autómárka, széria, évjárat, teljesítmény, km óra állás
    window2.geometry("1440x810")
    cim = Label(window2, text="szia").grid(row=0, column=10)
    
def nyilvantartas_admin():
    class admin_feltoltes:
        def __init__(self, marka, szeria, evjarat, teljesitmeny, kmora):
            self.m = marka
            self.sz = szeria
            self.ev = evjarat
            self.t = teljesitmeny
            self.km = kmora
        
        def adatok(self):
            window2 = Tk()
            
        
        def ablak(self):
            window3 = Tk()
            window3.geometry("1440x900")
            set = ttk.Treeview(window3)
            set.pack(pady = 40)
            set['columns']=("a","b","c","d","e")
            set.column("#0", width=0, stretch=NO)
            set.heading("a", text="Márka", anchor=CENTER)
            set.heading("b", text="Széria", anchor=CENTER)
            set.heading("c", text="Évjárat", anchor=CENTER)
            set.heading("d", text="Teljesítmény", anchor=CENTER)
            set.heading("e", text="Km óra állás", anchor=CENTER)
            set.insert("", "end", values=(self.m, self.sz, self.ev, self.t, self.km))
            
    a = admin_feltoltes("a", "b", "c", "d", "e")
    a.ablak()
    
            
     
    
def reginput():
    u = uservar.get()
    p = passvar.get()
    print(u,p)
    with open("reg-login.txt","a", encoding="utf-8") as output:
        username_list = [i for i in u]
        password_list = [i for i in p]
        if len(u) >= 3 and u != admin_user:
            length_user = True
            user_label = Label(window1, text="a").grid(row=0, column=2)
        else:
            length_user = False
            user_label = Label(window1, text="b").grid(row=0, column=2)
        if len(p) >= 8 and p != admin_pass:
            length_pass = True
            pass_label = Label(window1, text="a").grid(row=1, column=2)
        else:
            length_pass = False
            pass_label = Label(window1, text="b").grid(row=1, column=2)  
        if u != admin_user and p != admin_pass and length_user and length_pass:
            register = f'{u} {p} \n'
            output.write(register)   
    return u, p


def loginput():
    u = uservar.get()
    p = passvar.get()
    login = [u,p]
    with open("reg-login.txt","r", encoding="utf-8") as input:
        lines = []
        for i in input:
            lines.append(i.strip().split())
        print(lines)
        if login in lines:
            print("Tög lyó")
            nyilvantartas_user()
        elif login == [admin_user, admin_pass]:
            print("Admin bejelentkezés")
            nyilvantartas_admin()
        else:
            print("Hát ez nem lyó")
    


userlabel = Label(window1, text="Felhasználónév (min. 3 karakter)").grid(row=0, column=0)
uservar = StringVar()
user = Entry(window1, textvariable=uservar).grid(row=0, column=1)


passlabel = Label(window1, text="Jelszó (min. 8 karakter)").grid(row=1, column=0)
passvar = StringVar()
password = Entry(window1, show="*", textvariable=passvar).grid(row=1, column=1)


log_btn = Button(window1, text="Bejelentkezés", command=loginput).grid(row=4, column=1)  # regisztrálás
reg_btn = Button(window1, text="Regisztrálás", command=reginput).grid(row=5, column=1)
    

    














# bejelentkezés gomb megnyomására beolvassa a reg-login txt fájlt """
























window1.mainloop()
