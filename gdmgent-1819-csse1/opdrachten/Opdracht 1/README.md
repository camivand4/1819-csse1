1. Eigenlijke systeemstart

Voeding -> interne componenten
(harde schijven, DVD drives...)
Van stroom voorzien

CHipset een reset signaal tot power
Goed signaal 	-> voeding spanning omzetten van elk component
Reset signaal 	-> nog niet starten
		-> (chipset)

Alles ok, chipset geeft het power good signaal
Stroom OK

Processor -> BIOS startprogramma via BIOS-ROM onder de geheugenplaats FFFF0h
-> startprogramma opvragen
-> Inladen in de processor

Power on Self Test

Controle van BIOS -> BEEP

Grafische kaart -> videoBIOS

Zoektocht naar andere BIOS
-> scherm te zien

2. Systeemstart onder BIOS

hardware configurenen
- systeembronnen toewijzen
- BIOS systeeminventaris
- Plug & play apparaten

Informatie BIOS structureren

3. Schrijfeeneid inladen
Opstartbaar apparaat vinden in CMOS boot sequence opgeslagen
BIOS zoekt  MDR om te booten

Inladen besturingssysteem

-> opstart