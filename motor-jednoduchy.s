INCLUDE "ez8.inc"

VECTOR Reset=zacatek

org        %100

zacatek:
SRP #%00
LDX SPL,#%FF
LDX SPH,#%00

LDX PAADDR,#%01
LDX PACTL,#%00

LDX R11,#%11

toc:
LDX PAOUT,R11
RR   R11
CALL cekej
JR toc

cekej:
LDX R0,#%04
CLR R1
CLR R2
hopsem:
DEC R2
JR nz,hopsem

DEC R1
JR nz,hopsem

DEC R0
JR nz,hopsem

RET
