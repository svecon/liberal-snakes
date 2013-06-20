# Snakes v1.0 #
Z�poctov� program ke druh�mu semestru Programov�n� na MFF-UK, obecn� informatika.

## Zad�n�
Had
   - 2D s plynul�m zat�cen�m
   - sb�r�n� predmetu
   - bonusy
   - multiplayer (a� 4 hr�ci)

## Zvolen� algoritmus 
Spojit� simulace, had se postupne vykresluje do bitmapy a z�roven ukl�d� pozici do stavov�ho pole, kter� slou�� k zji�ten� n�razu.

## Diskuse v�beru algoritmu
Program vyu��v� celkem tri bitmapy - jednu jako pl�tno, druhou pro hady samotn� a tret� pro bonusy a pen�ze.
Pri ka�d�m ticku casovace se v�echny dve zm�nen� bitmapy slej� na pl�tno.

## Program 
Program m� pouze dva z�kladn� stavy - v�ber hr�cu a samotn� hra.
Z�kladn� tr�dou je Game, kter� m� na starosti v�echny v�znamn� ud�losti (r�zen� kl�vesami) a objekty (had, hr�c, bonus, ...).

## Alternativn� programov� re�en� 
Zkou�el jsem m�t pro ka�d�ho hada samostatnou bitmapu, abych pr�padne mohl pomoc� bonusu treba umazat jenom jednoho hada,
ale sl�v�n� u� bylo pr�li� n�rocn� a br�nilo plynul�mu chodu programu.
Algoritmus by �el je�te v�ce zefektivnit tak, �e bychom si pamatovali, kde nastaly zmeny a sl�li bychom pouze takto oznacen� oblasti.

## Reprezentace vstupn�ch dat a jejich pr�prava 
Program se ovl�d� my�� a ovl�d�n� hadu kl�vesami (zn�zornen�mi pri v�beru hr�cu).

## Reprezentace v�stupn�ch dat a jejich interpretace
Bitmapa.

## Co nebylo dodel�no
- v�ce druhu bonusu
- premistov�n� minc� (po urcit�m timeoutu)
- sofistikovanej�� um�sten� bonusu/minc�
- rychlej�� vykreslov�n� (pouze zmeny na pl�tne)
- zmena ovl�d�n� hadu
- v�c jak 4 hr�ci (generov�n�m)
                                                                                                            
## Jak prelo�it
Vyzkou�eno:
- Microsoft Visual Studio 2012