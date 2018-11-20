# GK_P2
Polygon filler
Klawiszologia:

Poza oczywistymi guzikami typu "Zmień", oraz radioButtonami istnieje też opcja przesuwania wierzchołków.

W tym celu w należy kliknąć lewym przyciskiem myszy(LPM) w okolicy miejsca przecięć dwóch krawędzi(obu z tego samego trójkąta). 
Następnie wcisnąć prawy przycisk myszy(PPM) aby zmienić położenie wybranego wierzchołka. 
Aby upuścić wierzchołek należy ponownie wcisnąć lewy przycisk myszy (LPM).

Przyjęte założenia:
Bitmapa osadzona w głównym pictureBox'ie jest odrysowywana przy każdym poruszeniu wierzchołkiem, ticku Timera(przy włączonym trybie animacji), zmianie w dowolnym radioButtonie - w efekcie program działa zauważalnie wolno. 

Rozwiązaniem mogłoby być rysowanie całej bitmapy w tle (przy przełączaniu radiobuttonów), gdyż jesteśmy w stanie to zrobić z niewielkim opóźnieniem, ale odbywałoby się to kosztem animacji (przerwa między tickami wzrosłaby zauważalnie).
