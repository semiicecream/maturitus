INCLUDE "ez8.inc"

VECTOR Reset=init

org        %100

init:
SRP   #%00
LDX   SPL,#%FF
LDX   SPH,#%00

LDX   PAADDR,#%01
LDX   PACTL,#%00

LDX   PBADDR,#%01
LDX   PBCTL,#%00



skokhlavni:
; v registru R5-R8 jsou obsazeny hodnoty zobrazovane na displeji (http://jecha.name/programy/7seg.html) toto je pro zadani "rAdE"
LDX   R5,#%50 ;r
LDX   R6,#%77 ;A
LDX   R7,#%5E ;d
LDX   R8,#%79 ;E

LDX   R12,#%40 ; registrem R12 se nastavuje delka zobrazeni jedne casti
skok11:
LDX   PAOUT,R5
LDX   PBOUT,#%01
CALL  male_cekej

LDX   PAOUT,R6
LDX   PBOUT,#%02
CALL  male_cekej

LDX   PAOUT,R7
LDX   PBOUT,#%04
CALL  male_cekej

LDX   PAOUT,R8
LDX   PBOUT,#%08
CALL  male_cekej

DEC   R12
JP	  nz,skok11

; v registru R5-R8 jsou obsazeny hodnoty zobrazovane na displeji (http://jecha.name/programy/7seg.html) toto je pro zadani "6921"
LDX	  R5,#%7D ;6
LDX   R6,#%67 ;9
LDX   R7,#%5B ;2
LDX   R8,#%6  ;1

LDX	  R12,#%40 ; registrem R12 se nastavuje delka zobrazeni jedne casti

skok12:
LDX   PAOUT, R5	
LDX	  PBOUT, #%01
CALL  male_cekej

LDX   PAOUT,R6
LDX   PBOUT,#%02
CALL  male_cekej

LDX   PAOUT,R7
LDX   PBOUT,#%04
CALL  male_cekej

LDX   PAOUT,R8
LDX   PBOUT,#%08
CALL  male_cekej

DEC	  R12
JP	  nz,skok12

JP	  skokhlavni


male_cekej:
LDX   R0,#%08	
CLR   R1

hopsem:
DEC   R1
JR	  nz,hopsem

DEC   R0
JR    nz,hopsem

RET
