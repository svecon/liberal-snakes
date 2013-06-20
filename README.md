# Snakes v1.0 #
Zápoctový program ke druhému semestru Programování na MFF-UK, obecná informatika.

## Zadání
Had
   - 2D s plynulým zatácením
   - sbírání predmetu
   - bonusy
   - multiplayer (až 4 hráci)

## Zvolený algoritmus 
Spojitá simulace, had se postupne vykresluje do bitmapy a zároven ukládá pozici do stavového pole, které slouží k zjištení nárazu.

## Diskuse výberu algoritmu
Program využívá celkem tri bitmapy - jednu jako plátno, druhou pro hady samotné a tretí pro bonusy a peníze.
Pri každém ticku casovace se všechny dve zmínené bitmapy slejí na plátno.

## Program 
Program má pouze dva základní stavy - výber hrácu a samotná hra.
Základní trídou je Game, která má na starosti všechny významné události (rízení klávesami) a objekty (had, hrác, bonus, ...).

## Alternativní programová rešení 
Zkoušel jsem mít pro každého hada samostatnou bitmapu, abych prípadne mohl pomocí bonusu treba umazat jenom jednoho hada,
ale slévání už bylo príliš nárocné a bránilo plynulému chodu programu.
Algoritmus by šel ješte více zefektivnit tak, že bychom si pamatovali, kde nastaly zmeny a sléli bychom pouze takto oznacené oblasti.

## Reprezentace vstupních dat a jejich príprava 
Program se ovládá myší a ovládání hadu klávesami (znázornenými pri výberu hrácu).

## Reprezentace výstupních dat a jejich interpretace
Bitmapa.

## Co nebylo dodeláno
- více druhu bonusu
- premistování mincí (po urcitém timeoutu)
- sofistikovanejší umístení bonusu/mincí
- rychlejší vykreslování (pouze zmeny na plátne)
- zmena ovládání hadu
- víc jak 4 hráci (generováním)
                                                                                                            
## Jak preložit
Vyzkoušeno:
- Microsoft Visual Studio 2012