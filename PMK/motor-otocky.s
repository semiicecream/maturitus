; NETESTOVANO - nemam tuseni jestli to funguje lol
INCLUDE "ez8.inc"

VECTOR Reset=init

org   %100

init:
SRP   #%00
LDX   SPL,#%FF
LDX   SPH,#%00

LDX   PAADDR,#%01
LDX   PACTL,#%00

start:
LDX   R11,#%11
LDX   R12,#%20    ; pocet otacek prvniho otaceni - 0x20 = 1 otacka (hexadecimalne cili 0x40 jsou dve apod.)

toc:
LDX   PAOUT,R11
RR    R11         ; RR = otaceni doprava
CALL  cekej
DEC   R12
JR    nz,toc

CALL  cekej       ; 4x cekej = zhruba 1 sekunda
CALL  cekej
CALL  cekej
CALL  cekej

LDX   R12,#%20    ; pocet otacek druheho otaceni

toc2:
LDX   PAOUT,R11
RL    R11         ; RL = otaceni doleva
CALL  cekej
DEC   R12
JR    nz,toc2

CALL  cekej
CALL  cekej
CALL  cekej
CALL  cekej

JR    start

cekej:
LDX   R0,#%04       ; zde lze zmenit rychlost rotace (bude potreba prizpusobit pocet cekej mezi toc a toc2) vyssi hodnota = delsi doba cekani
CLR   R1
CLR   R2

hopsem:
DEC   R2
JR    nz,hopsem

DEC   R1
JR    nz,hopsem

DEC   R0
JR    nz,hopsem

RET
