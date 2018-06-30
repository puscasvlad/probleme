Presupunem ca primim ora folosind valori numerice si dorim sa afisam in cuvinte. De exemplu:

5:00 -> ora cinci fix
5:01 -> un minut dupa ora 5
5:10 -> zece minute dupa ora 5
5:15 -> cinci si un sfert
5:30 -> cinci si jumatate
5:40 -> sase fara douazeci de minute
5:45 -> sase fara un sfert
5:47 -> sase fara treisprezece minute
5:28 -> douazeci de minute dupa cinci

Cand este minutele sunt zero folositi `fix`. Pentru minutele intre 1 si 30 folositi `dupa` iar pentru cele mai mari de 30 folositi `fara`. Scrieti un program care tipareste timpul in cuvinte folsind formatul descris.

### Formatul de intrare

Prima line va contine orele care pot avea valori intre 1 si 12.
A doua linie va reprezenta orele cu valori intre 0 si 60.

``7
``25