import tkinter as tk
from tkinter import ttk

'''
user
bejelentkezés + regisztráció
adatok feltöltése (autómárka - legördülő, évjárat - legördülő, széria - textbox, km óra állás - textbox, lóerő - textbox, ár - textbox)

admin
bejelentkezés
adatok törlése/hozzáadása
adatbázishoz való hozzáférés
'''
def convert():
    label = ttk
window = tk.Tk()
window.geometry('900x540')
title = ttk.Label(master = window, text = 'szia')
title.pack()
input = ttk.Frame(master=window)
entry = ttk.Entry(master=input)
button = ttk.Button(master=input, text='C' command = convert)
entry.pack()
button.pack()
input.pack()
window.mainloop()


