Dmitro Shtempelyuk

shtempelyuk.2018@skola.ssps.cz

16.05.2021

- Úvod
  - Účel dokumentu
 	 - účelem tohoto sowftwaru je vytvořit časovač ve WPF
  - Kontakty
    - Dmitro Shtempelyuk soundcloud: nmbht44
  - Odkazy na ostatní dokumenty 
 	 - nejsou
- Celkový popis
  - Funkce
    - Tento program má sloužit k použiží časovače, rychle a jednoduše. 
    - Taky tento program by mohl být určený ke škole a to tak, že by ten program začal vydávat zvuky, když začne online hodina.
  - Uživatelské skupiny 
    - Studenti SŠ a žáci ZŠ
  - Omezení návrhu a implementace
    - absence databáze školního programu každého uživatele zvlášť 
- Požadavky na rozhraní
  - Uživatelská rozhraní
    - Windows
  - Softwarová rozhraní
    - Windows Presentation Foundation
- Vlastnosti systému
  - i: volba času, kdy výuka začíná, informace o délce hodin a přestavkách dohromady
  - akce: program zjistí kdy začínájí hodiny tento den  
  - výstup: informace a zvukový signál o tom, že hodina začala nebo začne s předstihem v pár minut 
  - vstup: zmačknutí tlačítka, které vypne zvukový signal 
- Nefunkční požadavky
  - Odezva
    - 1s, než se spustí zvukový signál
  - Spolehlivost
    - Jako švýcarské hodinky  	
  - Bezpečnost
    - Není nutné zadávat svoje osobní údaje
    - Všechno potřebné už budete mít v programu, a program bude fingovat bez připojení k internetu(pokud se samozremě nevyvine a nezpřístupni se k udajům o rozvrhů škol)
   
