Dmitro Shtempelyuk

shtempelyuk.2018@skola.ssps.cz

16.05.2021
# Specifikace požadavků
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
  - i: funkce zadávání rozvrhu, kterou si každý uživatel může nastavit sám
  - i: funkce použítí programu i na obyčejný timer
  - i: program využívá aktuální čas na počítačí k zprovoznění svých funkcí
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
  
  # Funkční specifikace
-	Úvod
    - Účel dokumentu
        -	účelem tohoto softwaru je vytvořit časovač ve WPF
    -	Kontakty
        -	Dmitro Shtempelyuk soundcloud: nmbht44
    -	Odkazy na ostatní dokumenty 
        -	nejsou
-	Scénáře  
    -	Všechny reálné způsoby použití
        -	Použití pro žáky, kteří se chtějí vzdělávat, ale chybí jim disciplína na to, aby to zvládali sami, hlídání si hodíš a času.
    -	Typy uživatelských rolí, „personas“
        -	Student - chce si hlídat online výuku, a nemít potíže s tím, v kolik mu začíná hodina, a jestli jí vůbec má.
        -	Běžný uživatel - potřebuje si nastavit časovač z osobních důvodů (např. Ví, že potřebuje vyrazit do práce za hodinu, a chce si nastavit časovač tak, aby si nemusel každých 5 minut kontolovat hodinky, nebo mobil).  
    -	Detaily, motivace, „živé“ příklady
        -	Během karantény a uvěznění doma jsem se setkal s tím, že mi chybí „zvonění“, které vždycky oznámí začátek a konec hodiny, a tak se mohlo stát, že jsem dorazil na hodinu později, až když jsem si na ni vzpomněl, nebo jsem nedorazil vůbec, protože jsem si šel dát snídaní o přestávce, zastavil jsem se nad videem na YouTube a mam neomluvenou hodinu, právě pro takové lidi jako jsem já, lidi, které zajímá škola, ale nedokážou si vždycky hlídat čas, tento program byl vynalezen.
    -	Vymezení rozsahu – co v sw Nebude
        -	Sw nebude určen pro mobilní zařízení, a nebude se spouštět, při zapnutí počítače, program bude počítat s tím, že ho student spustí svýma rukama, program nebude určen k hlídání domácích úkolů, a nepočítá s odpadlými hodinami, mít přístup k němu budete mít totiž jenom vy.
    -	Na co se NEbude klást důraz (výkonnost)
        -	Bezpečnost se nebude brát v potaz, neplánuji klást důraz na designovou stránku aplikace, jednoduchost a funkčnost jsou našimi hlavními principy.
-	Celková hrubá architektura
    -	Pracovní tok
        - Uživatl spustí aplikaci
        - Rozhodne se, jestli chce použivat aplikaci jenom na	timer nebo i na školu
        - Pokud chce používat aplikaci na rozvrh hodin do školy, bude muset jednou při prvním spuštění zadat svůj rozvrh hodin.
        - Rozvrh hodin se bude zadávat srozumitelně pro běžného studenta, bude mu ten interface jasný.
        - poté, co to zadá, otevře se ten program, který už začne pracovat s údají, co tam zadal.
        - 5 minut před začátkem vyučovací hodiny, se změní barva interfaců, a když bude muset začít hodina, spustí se zvukový signál.
        - také bude existovat tlačítko, kterým se uživatel, snadno přepne na timer a bude schopný si nastavit časovač na čas, který potřebuje.
        - Timer a Školní modul, budou vydávat různé zvuky, aby to nematlo uživatele.
    -	Hlavní moduly
        -	Modul „Online School“ 
        -	Modul "Timer" 
    -	Všechny detaily: obrazovky, okna, tisky, chybové zprávy, logování
        - 	 
    -	Všechny dohodnuté principy
        -	Timer
        -	Funkce pro hlídání školních online hodin
