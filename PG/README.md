# Praktická - PG

### 1. Generátor náhodných čísel
Vytvořte formulářovou aplikaci v jazyku C#, která vygeneruje, setřídí a statisticky zpracuje množinu náhodných čísel. Program může sloužit jako návod pro tipování čísel do výherní loterie. Zdrojový kód programu zkopírujte do textového souboru a stručně ho popište např. formou komentářů. Program bude splňovat následující povinné upřesňující požadavky. Vše ostatní (grafické uživatelské rozhraní, další funkce programu atd.) je libovolné.
V aplikaci bude možné:
- vygenerovat zadaný počet náhodných čísel ze zadaného rozsahu do prvku TEXTBOX
- vzestupně setřídit obsah prvku TEXTBOX 
- vypočítat z náhodných čísel následující statistické veličiny: aritmetický průměr, modus, medián, minimální a maximální hodnotu, variační rozpětí, průměrnou absolutní odchylku  
- uložit obsah prvku TEXTBOX do textového souboru a zpětně ho načíst pomocí dialogů
- mazat prvek TEXTBOX

### 2. Grafický editor
Vytvořte formulářovou aplikaci v jazyku C#, pomocí které se budou vykreslovat základní geometrické tvary. Program může sloužit jako jednoduchý grafický editor. Zdrojový kód programu zkopírujte do textového souboru a stručně ho popište např. formou komentářů. Program bude splňovat následující povinné upřesňující požadavky. Vše ostatní (grafické uživatelské rozhraní, další funkce programu atd.) je libovolné. 
V aplikaci bude možné:
- vybrat tvar pomocí prvku COMBOBOX
- vybrat obrys nebo plochu pomocí prvku RADIOBUTTON
- vybrat barvu pomocí prvku COLORDIALOG
- vykreslit na prvek PICTUREBOX tvar (elipsa, obdélník, přímka) pomocí zadaných souřadnic
- uložit obrázek do souboru a zpětně ho načíst pomocí dialogů
- mazat prvek PICTUREBOX

### 3. Příklady z aritmetiky
> Vytvořte formulářovou aplikaci v jazyku C#, která bude generovat příklady na 4 základní aritmetické operace a vyhodnocovat odpovědi (výsledky) uživatele. Program může sloužit jako podpůrný výukový prostředek předmětu matematika pro žáky základní školy. Zdrojový kód programu zkopírujte do textového souboru a stručně ho popište např. formou komentářů. Program bude splňovat následující povinné upřesňující požadavky. Vše ostatní (grafické uživatelské rozhraní, další funkce programu atd.) je libovolné.
V aplikaci bude možné:
- zadat celočíselný interval pro generování náhodných čísel pro příklad
- vybrat aritmetickou operaci (součet, rozdíl, součin, podíl) pomocí prvku COMBOBOX
- zobrazit příklad skládající se ze dvou náhodných čísel a zadaného operátoru
- vyhodnotit uživatelovu odpověď (správně / špatně); v případě podílu se bude vyhodnocovat pouze celočíselné dělení, kdy dělenec bude větší než dělitel
- průběžně zobrazovat uživatelovu úspěšnost (celkový počet příkladů, počet správných a špatných odpovědí, procentuální úspěšnost odpovědí)
- zaznamenávat do prvku TEXTBOX chybně zodpovězené příklady včetně odpovědí (chybných výsledků)
- uložit obsah prvku TEXTBOX do textového souboru a zpětně ho načíst pomocí dialogů
- mazat prvek TEXTBOX

### 4. Stopky
> Vytvořte formulářovou aplikaci v jazyku C#, která bude zobrazovat čas po desetinách sekundy od stanoveného počátku. Program může sloužit jako stopky pro časové vyhodnocování sportovních nebo jiných soutěží. Zdrojový kód programu zkopírujte do textového souboru a stručně ho popište např. formou komentářů. Program bude splňovat následující povinné upřesňující požadavky. Vše ostatní (grafické uživatelské rozhraní, další funkce programu atd.) je libovolné.
V aplikaci bude možné:
- spustit, zastavit a vynulovat zobrazený čas ve formátu minuty, sekundy, desetiny sekund
- zaznamenávat do prvku TEXTBOX zvolené časové údaje převedené na desítkové číslo
- vypočítat z časových údajů následující statistické veličiny: aritmetický průměr, modus, medián, minimální a maximální hodnotu, variační rozpětí, průměrnou absolutní odchylku 
- uložit obsah prvku TEXTBOX do textového souboru a zpětně ho načíst pomocí dialogů
- mazat prvek TEXTBOX

### 5. Průsečík dvou přímek
> Vytvořte formulářovou aplikaci v jazyku C#, která bude početně a graficky řešit průsečík dvou přímek. Program může sloužit jako podpůrný výukový prostředek předmětu matematika pro žáky střední školy. Zdrojový kód programu zkopírujte do textového souboru a stručně ho popište např. formou komentářů. Program bude splňovat následující povinné upřesňující požadavky. Vše ostatní (grafické uživatelské rozhraní, další funkce programu atd.) je libovolné.
V aplikaci bude možné:
- zadat pro 2 lineární funkce stejný definiční obor a diferenci hodnot definičního oboru
- zadat pro každou funkci zvlášť koeficienty A, B
- načíst pro obě funkce hodnoty X a vypočítané hodnoty Y do prvku DATAGRIDVIEW
- vykreslit grafy obou funkcí do prvku CHART
- vypočítat souřadnice průsečíku obou funkcí řešením soustavy 2 lineárních rovnic
- uložit obsah prvku CHART do obrazového souboru pomocí SAVEDIALOGU
- mazat prvek CHART
