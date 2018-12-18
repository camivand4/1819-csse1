Camille Van Damme
18/12/2018

Deel 1: Dataformaten

<!-- Maak een onderzoeksverslag omtrent de gebruikelijke dataformaten om data uit te wisselen.
En geef een antwoord op volgende vragen:
- Wat is een dataformaat?
- Welke dataformaten zijn er?
- Wat zijn de verschillen? -->


Een dataformaat of bestandsformaat:
    is de vorm waarin informatie gecodeerd is. De informatie is op zo'n manier gecodeerd dat een programma of toepassing de data kan herkennen, lezen en gebruiken.

Welke dataformaten:
    Tekstdocumenten
        .txt (Text) is een bestandsformaat voor platte tekst.

        .xml (Extensible Markup Language) is syntaxis van formele opmaaktalen waarmee men met behulp van tags en attributen gestructureerde gegevens kan weergeven in de vorm van platte tekst.

        .doc (Document) is een bestandsformaat voor opgemaakte tekst en wordt meestal gebruikt door Microsoft Office Word. In het verleden werd de bestandsextensie gebruikt voor platte tekst. Het bestandsformaat werd opgevolgd door .docx.  De toegevoegde ‘x’ betekent dat de aangemaakte documenten standaard in XML-indeling worden opgeslagen (en geen macro’s bevat).

        .odt (Open Document Text) is een open, op XML-gebaseerd bestandsformaat voor opgemaakte tekst.

        PDF/A is geschikt als archiveringformaat. 

        Het is moeilijk om van dit bestandsformaat verdere afgeleiden te maken. Bewaar daarom, wanneer je later nog aanpassingen wil maken aan het bestand, ook nog een .docx naast de PDF-versie.

        Voor XML en txt wordt er best gebruik gemaakt van een UTF-8 codering

    Afbeeldingen
        .tiff of .tif (Tagged Image File Format) is het meest aanbevolen formaat omwille van zijn robuustheid en brede ondersteuning. Het TIFF- formaat is zo flexibel opgezet dat het mogelijkheid biedt extensies te schrijven boven op het basisbestand. Deze extensies kunnen echter problematisch zijn voor langetermijnarchivering omdat de ondersteuning van sommige extensies gering is. Er wordt daarom in geval van archivering geadviseerd gebruik te maken van het zogenaamde TIFF-basisbestand, zonder interne compressie: TIFF baseline 6.0 uncompressed. Een extra voordeel van het TIFF-formaat is dat het erg goed bestand lijkt tegen datacorruptie.

        .gif (Graphics Interchange Format) is een beeldformaat dat beperkt is tot 256 kleuren (8 bits). Gebruik GIF enkel voor logo's, grafieken en animaties.

        .jpg of .jpeg is naast GIF het meest gebruikte formaat voor afbeeldingen op internet. Om de bestandsgrootte te reduceren maakt JPEG gebruik van lossy compressie (waarbij dus beeldinformatie verloren gaat). Gebruik JPEG enkel als er ook een (originele) analoge wordt bewaard en de digitale representatie louter gebruikt wordt voor raadpleging van de inhoud van de foto.

        .jp2 is een formaat met heel veel functionaliteiten voor online ontsluiting van grote complexe beeldbestanden, maar bijgevolg ook met een complexe structuur. JPEG2000 biedt mogelijkheden voor het gebruik van zowel lossless als lossy compressie. Gebruik JPEG2000 als je de omvang van het moederbestand wil beperken.Gebruik JPEG2000 met lossy compressie enkel als er ook een (originele) analoge wordt bewaard en de digitale representatie louter gebruikt wordt voor raadpleging van de inhoud van de foto.

        .png (Portable Network Graphics) is een open beeldformaat dat gebruik maakt van lossless compressie (waarbij dus geen beeldinformatie verloren gaat). Gebruik PNG enkel als er ook een (originele) analoge wordt bewaard en de digitale representatie louter gebruikt wordt voor raadpleging van de inhoud van de foto.


    Spreadsheets
        Wanneer je gegevens en formules wil bewaren, maak je best gebruik van XLS
        
        Bij een CVS en XML worden geen formules bewaard
        
        Wanneer je enkel je opmaak wil bewaren, je gegevens wil raadplegen of dit wil publiceren op je website, dan volstaat een PDF of PDF/A
        
        PDF of PDF/A: het is moeilijk om van dit bestandsformaat verdere afgeleiden te maken. Bewaar daarom best een .xsl/.xslx naast je PDF-versie. 

    E-mail
        XML, msg

    Audio
        .wav (Waveform Audio File Format) is een breed ondersteund audioformaat dat ongecomprimeerde audiobestanden kan bewaren en ontwikkeld werd door Microsoft en IBM.

        .aiff (Audio Interchange File Format) is een breed ondersteund audioformaat dat ongecomprimeerde audiobestanden kan bewaren en ontwikkeld werd door Apple.

        .flac (Free Lossless Audio Codec) is een open-source, lossless gecomprimeerd audioformaat.

        codering in: 
            LPCM (Linear Pulse Code Modulation) is de standaardopslagvorm van digitaal geluid in computers, in verschillende bestandsformaten en op CD.

    Video
        .mkv (Matroska) is een open standaard multimediacontainerformaat dat virtueel elke bitstream kan verpakken, maar er zijn nog maar weinig best practices uit de erfgoedsector bekend. De software voor het transcoderen en valideren van .mkv is vrij beschikbaar. Matroska gebruik je wanneer je een open containerformaat verkiest.

    .mxf (Material eXchange Format) is geen open standaard, maar wel een industriestandaard. Het formaat wordt breed ondersteund door professionele videosoftware en er zijn best practices beschikbaar voor integratie van H.262, H.264 en JPEG2000 videostreams. MXF is echter een complex containerformaat en de implementaties van het formaat zijn sterk productgebonden. Om het risico op problemen met de uitwisselbaarheid te beperken is het aanbevolen gebruik te maken van het OP1a-profiel, beschreven in de SMPTE ST 378:2004 standaard, bij voorkeur als onderdeel van het AS-03 profiel of de Digital Cinema System Specification. MXF gebruiken doe je vooral wanneer je het videomateriaal voornamelijk voor de omroep- en filmsector beschikbaar stelt.

    .avi (Audio Video Interleaved) is een gesloten formaat, maar de specificaties zijn vrij beschikbaar en ze worden door vrijwel alle mediaspelers voor respectievelijk Windows en Mac (Apple) ondersteund. AVI gebruik je wanneer je slechts over beperkte expertise en tools beschikt om videobestanden af te spelen en te transcoderen.

    .mov (QuickTime) is een gesloten formaat, maar de specificaties zijn vrij beschikbaar en ze worden door vrijwel alle mediaspelers voor respectievelijk Windows en Mac (Apple) ondersteund. MOV gebruik je wanneer je slechts over beperkte expertise en tools beschikt om videobestanden af te spelen en te transcoderen.

    codering in: 
        FFV1 is een lossless codering. De codecs en specificaties zijn beschikbaar via de FFmpeg-bibliotheek die door de meeste open source mediaspelers gebruikt wordt.
        JPEG2000
        De JPEG2000-codering kan zowel lossless als lossy worden gebruikt. Gebruik de lossless JPEG2000 codering, en bij voorkeur de OpenJPEG-bibliotheek voor het maken van JPEG2000-streams.


    Websites
        XML
        HTML (alle pagina’s)
        CMS bewaren
        PDF


    Bladmuziek
        PDF, PDF/A, TIFF, MusicXML

    Technische tekeningen
        3D-geometrieën zijn vectoriële afbeeldingen in 3D. De bestandsformaten die hier als duurzaam worden gepresenteerd zijn enkel geschikt als je de geometrische (vormelijke) informatie wilt bewaren. Ze zijn niet geschikt voor de bewaring van andere eigenschappen zoals kleur, tekst of lagen.

        PDF/E: Overweeg dit bestandsformaat wanneer je 3D-geometrieën enkel nog wil raadplegen of publiceren op het web.
        STEP: Overweeg dit bestandsformaat indien je de bestanden nog beschikbaar wil houden voor hergebruik in een productieomgeving.
        IGES: Overweeg dit bestandsformaat bij relatief eenvoudige 3D-geometrieën en wanneer je de bestanden nog beschikbaar wil houden voor hergebruik in een productieomgeving.

            2D CAD
            In tegenstelling tot enkel geometrische informatie, bevatten CAD-bestanden ook andere eigenschappen, zoals kleur, lagen, blocks, tekst enz. Dit maakt de preservatie van de bestanden wat complexer. Voor 2D CAD kunnen volgende bestandsformaten gelden:

            PDF/A-2, PDF/A-3 en PDF/E: Overweeg dit bestandsformaat wanneer je CAD-bestanden enkel nog wil raadplegen of publiceren op het web.
            DWG en DXF: Overweeg dit bestandsformaat wanneer je de bestanden nog beschikbaar wil houden voor hergebruik in een productieomgeving, zeker wanneer je werkt met AutoDesk-software. (DWG is geen open formaat!)
            SVG: Overweeg dit bestandsformaat bij relatief eenvoudige tweedimensionale objecten.


            3D CAD
            Voor CAD-bestanden in 3D is momenteel nog geen geschikt archiveringsformaat vastgesteld, zelfs niet voor raadpleging of documentatie. Wel kunnen enkele bestandsformaten genoemd worden, maar conversies naar deze formaten dienen steeds grondig te worden gecontroleerd op verlies van essentiële informatie:

            DWG en DXF 1: Overweeg dit bestandsformaat voor bewaring op lange termijn, zeker wanneer je werkt met AutoDesk-software. (DWG is geen open formaat!)
            COLLADA: Overweeg dit bestandsformaat voor bewaring op lange termijn, voor de bestanden van SketchUp.

<!-- voor de grafische bestandsformaten -->

Grafische bestandsformaten
Er zijn veel soorten grafische bestandsformaten, ze verschillen vaak in grootte en kwaliteit. Ieder bestandsformaat heeft weer zijn eigen voor en nadelen. Hier staan omschrijvingen van de bekendste en de meest gebruikte grafische bestandsformaten en de voor en nadelen. 

    BMP
BMP staat voor Bitmap. Vaak wordt het Windows Bitmap genoemd, omdat het BMP formaat standaard is voor Windows. De extensie is .bmp, maar soms wordt ook .dib gebruikt. Het bestandsformaat is zeer veelzijdig in kleurengebruik:
Kleuren	Bits
2 kleuren	1
16 kleuren	4
256 kleuren	8
16,7 miljoen kleuren	24
Het bestandsformaat bevat standaard geen compressie, dus is een BMP bestand vaak heel groot. Bijvoorbeeld een foto van 1024 x 674 is als 24-bits BMP ongeveer 2MB groot. Er is wel een compressie voor BMP, dat wordt RLE genoemd. Dat staat voor Windows Run-Length Encoded. Met deze compressie kan het bestand 16 of 256 kleuren bevatten, het nadeel van deze compressie is dat veel programma’s het niet kunnen lezen. Daarom wordt RLE bijna niet gebruikt. Het voordeel van het BMP formaat is dat het veel kleuren kan bevatten en een zeer hoge kwaliteit heeft. Het nadeel van het formaat is dat het heel groot is.

    GIF
GIF staat voor Graphic Interchange Format. Het is ontwikkeld door CompuServe Inc. De extensie is .gif. Het GIF formaat kan tussen de 2 en 256 kleuren bevatten. Er zijn twee versies van dit formaat, 87a en 89a. Het verschil is dat 89a ook interlacing, transplarantie en animatie ondersteunt. Compressie is ook mogelijk met het gif formaat. Namelijk LZW, dit is een lossless compressie waarmee het bestand tussen de 20 en 70 procent van de originele grootte wordt. Maar in verhouding met JPEG is de compressie niet hoog, een JPEG bestand is gemiddeld 3 keer zo klein als een GIF bestand.


    JPEG
JPEG staat voor Joint Photographic Experts Group. Joint Photographic Experts Group is de groep die het bestand heeft ontwikkeld. De extensie is standaard .jpeg, maar vaker wordt .jpg gebruikt. JPEG bestanden hebben 2 kleuren mogelijkheden:
Naam	kleuren / grijstinten	Bits
Truecolor	16,7 miljoen kleuren	24
Grayscale	256 grijstinten	8
Het bestand is dan ook zeer geschikt voor het opslaan van foto’s of andere afbeeldingen die veel kleuren bevatten. Het bestand heeft een ingebouwde compressie, die heet ook gewoon .jpeg. De compressie werkt door het weghalen van dingen die het oog niet kan zien. De afbeelding of de foto ziet er dan voor het oog nog steeds hetzelfde uit, maar eigenlijk mist er heel veel. Dit kan je zichtbaar maken door de afbeelding uit te vergroten. De compressietechniek is zeer effectief, 90 tot 95% zonder zichtbaar kwaliteitsverlies. Zelfs met een compressie van 98% is de afbeelding nog van aanvaardbare kwaliteit. Het voordeel van het JPEG formaat is dus dat het heel klein is en toch van goede kwaliteit is. Het is daarom ook het meest gebruikte formaat op het internet, thuis en in de grafische industrie.

    PCD
PCD staat voor Photo CD. Het is ontworpen door Eastmam Kodak als een standaard formaat om foto’s op cd’s op te slaan. De standaard extensie is .pcd. Standaard wordt het Truecolor (24 bits) gebruikt voor dit formaat. Op de cd wordt dan een thumbnail opgeslagen, dit is een bestand qua afmetingen kleiner dan het oorspronkelijke bestand, dat gebruik gebruikt wordt voor het vooraf bekijken van een foto. Een hele serie van thumbnail vormt maakt dan een index. Compressie gaat volgens de Kodac PAC of YCC methode. De PAC methode is een zeer goede compressie methode en een concurrent van het JPEG formaat. 

    PCX
PCX staat voor (MEER). Het werd gebruikt door een oud tekenprogramma, PC Paintbrush. De standaard extensie is .pcx. Het programma had keus uit verschillende kleurdiepten, namelijk:
Naam	kleuren
CGA	4
EGA	16
VGA	256
16,7 miljoen
Het formaat kan gebruik maken van RLE-compresssie, maar die compressie is niet erg effectief. Zeker niet in verhouding tot het JPEG formaat. Het formaat werd ook ondersteund door Macintosh, maar wordt tegenwoordig nog maar weinig gebruikt.

    TIFF
TIFF staat voor Tagged Image File Format. Het is ontworpen door Microsoft en Aldust Corporations. De standaard extensies zijn .tiff en .tif. Het bestand kan in veel verschillende kleuren worden opgeslagen, namelijk:
Kleuren / grijstinten
2 kleuren
16 kleuren
256 kleuren
16,7 miljoen kleuren
16 grijstinten
256 grijstinten
Het formaat komt zowel gecomprimeerd als ongecomprimeerd voor. De compressietechniek is volgens een lossless compressiemethode, die LZW wordt genoemd. Die is helaas niet erg effectief, de besparing licht maar tussen de 20 – 30%. Daardoor is het bestand zeer groot en neemt het open van het bestand ook veel tijd in beslag. Jaren later is de omschrijving van TIFF aangepast om het mogelijk te maken een TIFF op te slaan met JPEG compressie.Voordelen heeft TIFF niet te opzichte van JPEG, want ook al hebben tegenwoordig de bestanden dezelfde compressiemethode, TIFF is veel complexer en daardoor langzamer.

    PNG
PNG staat voor Portable Network Graphics. De standaard extensie is .png. Het bestandsformaat is gemaakt als vervanging voor GIF en TIFF bestanden. Deze vervanging werd nodig, omdat de eigenaren van de LZH-compressie, die wordt gebruikt bij o.a. Gif compressie geld wil gaan vragen voor het commerciële gebruik ervan. De compressie is bij het PNG formaat beter dan het GIF formaat. Een GIF bestand is ongeveer 30% groter dan het PNG bestand met dezelfde afmetingen. Het PNG formaat heeft dezelfde kleurenmogelijkheden als GIF, maar ondersteund ook nog 32 bits kleuren en grijstinten. PNG werkt net als GIF met een lossless compressiemethode, bij PNG genaamd CRC-32. Dit maakt het PNG formaat uiterst geschikt voor het internet, maar ook voor de grafische industrie.
Het GIF formaat is nog niet helemaal verdwenen, omdat de geanimeerde GIF’s heel populair zijn geworden. Er is (nog geen) geanimeerd PNG formaat. Als dat er wel komt dan wordt verwacht dat PNG het GIF formaat geheel zal vervangen.

Wat is het beste grafische bestandsformaat?
Welke is nou het beste? Ik heb al verteld dat dat veel uitmaakt voor welk doel je de bestanden wil gebruiken. Maar voor thuisgebruik is JPEG het beste, een hoge kwaliteit en weinig ruimte. Voor het maken van een website zijn JPEG bestanden ook aan te raden als er veel plaatjes op de site komen.

    Video formaten
Video op de computer, vroeger was het ondenkbaar dat computers krachtig genoeg zouden worden om filmpjes of zelfs hele films mee af te kunnen spelen. Terwijl tegenwoordig als je een nieuwe computer koopt er vaak een standaard dvd-speler in zit. Het grote nadeel van video op de computer is, het is groot. Een videofragment bestaat uit meerdere beelden per seconde en ook nog geluid. De enige mogelijke oplossing is compressie. Veel videoformaten maken ook gebruik van compressie. Zou dit niet het geval zijn, dan zouden zelfs kleine filmpjes onhandig worden door hun grote formaat. Er zijn veel verschillende videoformaten en er kan vaak ook nog gebruik worden gemaakt van verschillende compressiemethoden bij elk videoformaat. Dit zijn de populairste en meest gebruikte.

    AVI
AVI staat voor Audio Video Interleave. Het is ontworpen door Microsoft en is vooral bedoeld voor kleine, lage kwaliteitsfilmpjes, met een hoge compressie. De standaard extensie is .avi. Het bestand bestuit uit kleine fragmenten van video en audio, die het patroon volgen van video – audio – video. De eerste versies van het formaat waren gelimiteerd tot een maximaal formaat van 320x240 en een snelheid van 30 frames per seconde (fps). Vroeger gebruikte men twee compressie technieken: AVI en RLU. Het formaat wordt veel gebruikt, omdat het op vrijwel elk platform afspeelbaar was en men geen speciale hardware nodig heeft. Tegenwoordig wordt AVI nog steeds gebruikt, maar meestal met andere compressietechnieken. Divx is tegenwoordig een veelgebruikte compressietechniek bij AVI.

    MOV
MOV staat voor Quicktime Movie. Het is ontworpen door Apple. De standaard extensie is .mov, maar .gt wordt ook vaak gebruikt. Het was ontworpen voor de Macintosh computer, maar werd later ondersteunde het formaat ook het Windows platform. Het werkte wel veel minder goed op een Windows platform. Het eerste formaat werd hardwarematig versneld op een Macintosh computer, maar vanwege de hoge snelheden tegenwoordig is dat nu amper merkbaar. Er bestaan voor dit formaat meerdere compressiemethoden. Cinepak is één van die compressiemethoden. Het was gemaakt voor een lage datatoevoer. Het werd gemaakt voor een film die een maximale datatoevoer van 300kb/s nodig had. Dit is een langzame datatoevoer en het formaat werd ook nutteloos toen de snellere computers uitkwamen die een veel snellere datatoevoer aankonden. Een andere compressiemethode is MPEG. De MPEG compressie werd gewoon toegepast in het MPEG formaat. Quicktime maakte ook een nieuw MPEG formaat, omdat MPEG-2 alleen geschikt was voor video en MPEG-3 alleen voor audio, maakten zij MPEG-4 die zowel audio als video aankon en dus alle verschillende typen media kon opslaan in een redelijk klein formaat. 

    MPEG
MPEG staat voor Motion Picture Expert Group. MPEG is door de zelfde groep gemaakt als JPEG. De standaard extensies zijn .mpeg en .mpg. Het is het standaard formaat voor de meeste digitale films. Er zijn veel soorten MPEG formaten, zoals MPEG-1, MPEG-2, MPEG-3 en MPEG-4. MPEG-3 is alleen geschikt voor audio en wordt niet gebruikt voor video, MPEG-1, MPEG-2, en MPEG-4 zijn dat wel. MPEG-1 is gelimiteerd tot een formaat van 352 x 240 en een snelheid van 30 frames per second (fps). Dit is een redelijk goede kwaliteit, maar nog niet goed genoeg om optimaal een film te bekijken. MPEG-2 gaat door tot een formaat van 1,280 x 720 en een snelheid van 60 frames per second (fps), en een geluidskwaliteit is gelijk aan dat van een CD. Dit maakt het MPEG-2 en MPEG-4 formaat uitermate geschikt voor zeer hoge kwaliteit films, daarom is het ook gebruikt voor DVD’s.
De MPEG compressie werkt bijna hetzelfde als de JPEG compressie. Wat het oog niet kan zien wordt weggehaald. Het MPEG formaat is opgebouwd met een header (begin), maar zonder footer (einde). Dit betekent dat het formaat realtime kan worden afgespeeld (streaming) en het bestand niet eerst geheel in het geheugen hoeft te worden geladen. Hierdoor is het formaat zeer geschikt voor het internet, want je kan de film of het filmpje bekijken terwijl je het download. 

    RAM
RAM staat voor Real Media. Het formaat is gemaakt door het bedrijf Real. De standaard extensies zijn .ram, .rm en .ra. Het formaat is speciaal gemaakt voor live streaming over het internet. Het formaat heeft een enorme compressie. Dat maakt het zeer geschikt voor live streaming, helaas is de kwaliteit daardoor ook minder goed. Maar voor filmpjes met een klein formaat is het zeer geschikt. Alleen geluid kan ook worden gestreamd, deze functie wordt ook veel gebruikt door radiostations om mensen de mogelijk te geven via internet overal ter wereld de uitzendingen te kunnen beluisteren.

Wat is het beste videoformaat?
Voor lange video bestanden van hoge kwaliteit zijn MPEG en AVI met divx compressie het beste. Vooral als het bedoelt is om te draaien op full screen(het hele beeld). Maar voor kleinere videobestanden, met een klein formaat is RAM heel goed, de compressie is heel sterk en daardoor zijn de bestanden heel klein en uitermate geschikt voor kleine filmpjes die niet zo’n hoge kwaliteit vereisen. Het grote nadeel van RAM is dat men de Realpayer nodig heeft om het formaat te kunnen bekijken en niet compatible is met de andere mediaspelers, waaronder Windows Media Player, die standaard bij Windows wordt geleverd.

    Geluidsformaten
Op de computer wordt gebruik gemaakt van veel verschillende soorten geluidsformaten. Ik leg hier de drie meeste gebruikte formaten uit. Ieder heeft zijn voordelen en zijn nadelen.

    MIDI
MIDI staat voor Musical Instrument Digital Interface. De standaard extensie van het bestand is .mid. Het MIDI formaat is heel anders dan andere geluidsformaten, omdat MIDI op zichzelf geen muziek is. Het bestand bestaat alleen maar uit opdrachten die door een ‘wavetable’ in muziek wordt omgezet. Tegenwoordig bevat elke geluidskaart standaard een wavetable. Het bestand bestaat uit commando’s die vertellen welke noten er moeten worden gespeeld, hoe hard en met welk instrument. Het grote voordeel van dit bestand is dat het heel weinig ruimte inneemt. De gemiddelde grootte van een MIDI bestand is zo’n 50kb. Ter vergelijking, het zelfde liedje als WAV bestand is vaak 20 MB of groter. Hierdoor is het formaat uitermate geschikt voor gebruik op het internet. Veel websites maken ook gebruik van MIDI bestanden. Helaas heet MIDI ook nadelen, namelijk: 
•	De liedjes klinken op iedere computer niet hetzelfde, want omdat verschillende geluidskaarten ander wavetables hebben.
•	De meeste wavetables produceren maar 128 klanken.
•	MIDI liedjes hebben vaak een plastic bijklank.
De kwaliteit houdt dus nog wel wat te wensen over, maar het formaat is daarin tegen wel zeer klein. MIDI bestanden zijn met veel afspeelsoftware compatible en kunnen gewoon afgespeeld worden door veelgebruikte programma’s, zoals: Winamp, Windows Media Player en Quicktime player.

    MP3
MP3 staat voor MPEG Layer 3. De makers van de techniek horen bij het Fraunhofer-Gesellschaft uit Duitsland. De MP3 compressie techniek heeft in principe iets weg van de JPEG compressie, al het overbodige wordt verwijderd. Bij MP3 bestaat de compressie uit 3 belangrijke dingen:
1.	Wanneer er veel energie op een frequentie is gericht kan het oor de dichtbijgelegen frequenties met een mindere mate van energie niet waarnemen. Deze niet hoorbare frequenties worden gemaskeerd genoemd. Bij MP3 wordt de gemaskeerde signaalinformatie weggegooid.
2.	Het menselijk oor kan sommige frequenties niet horen, bij MP3 worden deze voor de mens onhoorbare frequenties weggelaten.
3.	Bij MP3 wordt een methode gebruikt van stereo-effect in plaats van echt stereo geluid dat zeer veel data kost.
Dus als de compressie goed wordt gedaan is er geen hoorbaar kwaliteitsverlies. De compressie ten opzichte van de cd is enorm. Bijvoorbeeld: 1 Minuut geluid op een cd wordt een bestand van ongeveer 10 MB. Als hetzelfde bestand dan gecomprimeerd wordt met MP3, dan zal het bestand nog maar 800 kb groot zijn, dat is 12 keer zo klein. In vergelijking is de grootte van MIDI bestanden veel kleiner, maar de kwaliteit van een MIDI bestand is ook veel slechter ten opzichte van MP3. De kwaliteit van de bestanden hangt natuurlijk ook veel af van de gebruikte bitrate, bij mp3 wordt meestal een bitrate van 128kbps. Een nadeel van dit formaat is dat het heeft geleid tot veel illegale verspreiding via het internet. Binnenkort komt MP4 uit die nog betere compressie zal hebben.

    WAV
WAV staat voor Windows WAVetable sound. De standaard extensie voor het bestand is .wav. Het bestand heeft de beste geluidskwaliteit die tot nu toe voor de computer ontwikkeld is, maar het WAV formaat heeft zeer veel nadelen:
1.	Het bestand is zeer groot, een WAV bestand van 1 minuut is ongeveer 10 MB
2.	Het bestand kan niet worden streaming worden afgespeeld
Het WAV formaat is wat er standaard wordt gebruikt op audio cd’s en als je het op de goede manier op een cd brand is het ook gewoon met een cd-speler af te spelen. Een WAV bestand heeft een hele hoge bitrate, dit maakt het bestand ook zo groot. Een WAV bestand heeft normaal een bitrate van 1400kbs. 

Wat is het beste geluidsformaat?
Als het puur om kwaliteit gaat is WAV het beste geluidsformaat, maar als je kwaliteit en grootte gaat afwegen, dan is MP3 ruim de beste. Een zeer hoge kwaliteit en goede compressie. De kwaliteit van het MIDI is te laag om als beste geluidsformaat mee te dingen. Maar het formaat is op internet wel enorm handig omdat het zo super klein is. 

    Compressie Bestanden
Er zijn heel veel soorten compressie bestanden. Ze werken meestal op een zelfde manier, maar lang niet altijd. Compressie is vaak handig bij het besparen van hardeschijfruimte en helpt om sneller data te versturen naar iemand anders, op bijvoorbeeld een floppy of via e-mail. Het comprimeren van bestanden wordt vaak inpakken genoemd, omdat de bestanden in één bestand inpakt.

    ACE
ACE is een vrij nieuw compressiebestand, maar dat al redelijk populair is. De standaard extensie is .ace. Maar wordt het is meerdere bestanden opgedeeld, dan heb je .ace als hoofdbestand en voor de rest .c01 .c02 enz. Dit is ook één van de grote voordelen van het ACE formaat, het kan heel makkelijk opgedeeld worden in meerdere delen. Je stelt in hoe groot elk bestand moet zijn en de bestanden die zijn geselecteerd in het programma worden ingepakt en meerdere bestanden van de opgegeven grootte worden gemaakt. Vanwege deze makkelijke optie is het ACE formaat zeer populair geworden op het internet, op deze manier kunnen toch grote bestanden door mensen met een lage download snelheid worden gedownload, omdat het niet allemaal is één keer hoeft. Het standaard programma is Winace. Het heeft zeer veel opties, waaronder self-extracting is. Dan heeft het als extensie .exe en kan men gewoon door het bestand te open, de bestanden uit pakken, zonder een uitpakprogramma nodig te hebben. Er is ook een optie voor solid archiving, dan wordt er een sterkere compressie toegepast, maar het inpakken en uitpakken van de bestanden duur dan ook langer. Het is in principe voor Windows ontworpen en is niet voor gebruik in dos bedoeld. In dos wordt aangeraden met ARJ te werken als men iets wil opdelen in meerdere bestanden.


    ARJ
ARJ is een zeer oud compressiebestand dat vroeger veel in dos werd gebruikt. De standaard extensie is .arj. Het maakt gebruik van een lossless compressietechniek, dat wil zeggen dat er bij het comprimeren geen data verloren gaat. Dus als je een bestand inpakt in een arj bestand en daarna weer uitpakt heb je weer precies het originele bestand. Het bestand wordt tegenwoordig nog maar weinig gebruikt, maar veel compressie programma kunnen het formaat wel gewoon uitpakken. Het bestand werd zeer populair onder dos, omdat het in tegenstelling van de toen nog wat onhandige ZIP programma’s voor dos het heel gemakkelijk iets kan inpakken en daarna over meerdere bestanden te verdelen. Dit is was vroeger natuurlijk ideaal, omdat men veel de floppydrive gebruiken en veel bestanden had die te groot waren om op één floppy te zetten. ARJ biedt geen optie voor self-extracting, wat het dus tegenwoordig een wat onhandig formaat maakt. Maar omdat veel compressieprogramma’s het gewoon kunnen uitpakken wordt het nog wel gebruikt. Binnenkort komt er een opvolger voor ARJ, JAR. JAR bevat veel nieuwere compressietechnieken en werkt ook beter onder Windows, dan het voor dos ontworpen ARJ.

    RAR
RAR heeft veel weg het ACE formaat. De standaard extensie is .rar. Maar net als ACE kan het opgedeeld worden in meerdere bestanden, dan worden die extra bestanden: .r01 .02 enz. De ACE en RAR bestanden hebben dezelfde doelen, namelijk goede compressie en de mogelijkheid tot het makkelijk opdelen van de bestanden. De bestanden zijn ook allebei zeer populair. Maar beide programma’s die bij de formaten horen: Winace en Winrar zijn meer gericht op multifunctionaliteit, dan op concurrentie. De programma’s kunnen veel compressiebestanden uitpakken, ook die van elkaar. Winace kan gewoon rar bestanden uitpakken en Winrar heeft ook geen moeite met winace.

    ZIP
Zip is tegenwoordig het bekendste compressiebestand en wordt heel veel gebruikt. De standaard extensie is .zip. Zip werkt met een lossless compressietechniek. Het comprimeren met zip wordt vaak zippen genoemd. De compressie die wordt behaald hangt heel veel af van het soort bestand dat je wilt comprimeren. Een JPG-plaatje heeft zelf al een zeer sterke compressie, dus als je dat plaatje zipt dan wordt er geen hoge compressie gehaald, maar bij een GIF-plaatje of een tekstdocument kan wel sterk worden gecomprimeerd. Het ZIP formaat is zeer populair en wordt ook veel gebruikt op het internet. Het wordt vaak gebruikt met het programma winzip. ZIP bevat in tegenstelling tot ACE en RAR geen solid archiving. ZIP heeft ook een optie tot self-extracting. Dit is zeer handig als men het zipbestand naar iemand anders stuurt (via bijvoorbeeld e-mail), die niet het uitpakprogramma heeft. Dit kan alleen wel soms nadelen geven als je bijvoorbeeld onder Windows een self-extracting zipbestand maakt en het bestand onder dos weer wil uitpakken. Maar via het dos unzipprogramma (meestal wordt hiervoor PKUNZIP gebruikt) kan men het bestand aanpassen, zodat het wel te unzippen is onder dos.



<!-- Bronnen:
https://datasupport.researchdata.nl/start-de-cursus/iii-onderzoeksfase/dataformaten/
http://www.projecttracks.be/nl/tools/detail/bestandsformaten-en-codecs
https://www.scholieren.com/praktische-opdracht/8085 -->
