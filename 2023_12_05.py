class maganhangzok:
    def __init__(self, szoveg):
        self.szoveg = szoveg

    def statistics_mgh(self):
        mgh_l = ['a','á','e','é','i','í','o','ó','ö','ő','u','ú','ü','ű']

mgh = maganhangzok("Szia")
print(mgh.statistics_mgh())