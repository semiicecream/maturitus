# 7 segment displej
Program: ZDS II - Z8Encore! 4.11.0

Video na jecha produkty: [ZiLOG004_ZALOZENI_PROJEKTU.zip](http://jecha.name/produkty/dokumenty/ZiLOG004_ZALOZENI_PROJEKTU.zip)

<http://jecha.name/produkty/dokumenty/ZiLOG008_Doplneni_ZiLOG004.zip>

serial number musi byt stejny jako na pc, kde jsi poprvy Windows instaloval

(jinak ti to nebude fungovat na ostatnich pc a musis jit display delat tam, kdes instaloval OS na SSD) + mozna potrebujes driver pro zilog (usb smart cable)


**0)** Název

![zl1](https://user-images.githubusercontent.com/55453339/167260836-a974b57c-11c8-4ac7-9020-7e2a74ae0845.png)


**1)** CPU vyber F1622

![zl2](https://user-images.githubusercontent.com/55453339/167260849-8dcbf2d9-bb5d-450e-bf7a-d01f0b45556b.png)

**2)**

![zl3](https://user-images.githubusercontent.com/55453339/167260861-e9c6ceba-c975-4762-acfe-959643527253.png)

**3)** U tohohle se nic nemění

![zl4](https://user-images.githubusercontent.com/55453339/167260866-4aa6702d-f6eb-4bef-a751-395f1dea428e.png)

**4)** 
new file > save as (jmeno_asm.s) > project add file > vybrat to co sis ulozil (jmeno_asm.s) > build > rebuild all

**5)** Upravíš 8 hodnot (4 a 4) v kódu

![zl5](https://user-images.githubusercontent.com/55453339/167260876-ff0c2643-c0b9-4035-9659-f12d7ce3fa1a.png)

podle textu co máš zadanej, jako tady Arti, 6789 (čárka se nepíše)

![zl6](https://user-images.githubusercontent.com/55453339/167260888-92b8819b-8f43-4b67-a585-5c15c9cc0ae5.png)

binarni cisla se prepisujou zprava do leva > to pak převedeš do hexadecimálního:

<https://www.rapidtables.com/convert/number/binary-to-hex.html>

nebo použiješ jechuv nastroj, kterej to prevede za tebe:

<http://jecha.name/programy/7seg.html>

**5)** Project > settings (alt+F7) > Debugger > Setup

cislo 4.00, podle poctu carek na desce pod displejem v levo

![zl7](https://user-images.githubusercontent.com/55453339/167260895-65c5daeb-a365-4dc7-91e1-52b3073745ec.png)

![zl8](https://user-images.githubusercontent.com/55453339/167260902-baff5fb1-c08a-476e-ab5f-1011d61543b2.png)

**6)** Zapojis display s deskou, nejdriv dovnitr zapojis data connector s pinama a zobackem nahoru, potom az napajeni (kdyz vypojujes, tak nejdriv jde napajeni pryc)

**7)** (debug) connect to target > build/rebuild all > (debug) download code > (debug) go
