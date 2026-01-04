# 3.LU-Proiektua
1️⃣ Programaren deskribapena
Programa hau Burger Express jatetxe baten eskaeren sistema simulatzen du. Honako funtzio hauek ditu:
Eskaera berriak sortzea.


Aurreko eskaerak ikustea.


Eskaerak izenaren arabera bilatzea eta ezabatzea.


Eskaeren estatistikak erakustea.


Eguneko menuaren konfigurazioa aldatzea.


Erabiltzaileak programarekin kontsola bidezko menu baten bitartez interakzio egiten du.

2️⃣ Fitxategi eta klase nagusiak
a) Program.cs
Programaren hasiera puntua (Main) dauka.


SProiektua klasearen instantzia sortzen du eta Run() metodoa exekutatzen du.


SProiektua p = new SProiektua();
p.Run();


b) SProiektua.cs
Programa kontrolatzen duen klase nagusia da.


Menu nagusia (MenuNagusia) dauka, honako aukerak dituena:


Eskaera berria sortu


Aurreko eskaerak ikusi


Eskaerak bilatu izenaren arabera


Eskaera ezabatu


Estatistikak erakutsi


Eguneko menuaren konfigurazioa


Irten


List<Eskaera> listaEskaerak erabiltzen du eskaerak gordetzeko.


menuEguneko aldagaiak eguneroko menuaren izena gordetzen du.


Menu aukerak beste klase batzuei deitzen die (EskariaKontroladorea, MenuKontroladorea, Estatistikak, Besteak).



c) Eskaera.cs
Eskaera klasea eskaera bat ordezkatzen du.


Propietateak:


BezeroarenIzena → bezeroaren izena


Tamaina → hamburguesaren tamaina


HaragiaMota → haragi mota


Osagaiak → osagai osagarriak


Edaria → edaria


Osagarria → laguntzaile (patatak, tipulak…)


Eskaria sortzeko kontstruktore bat erabiltzen da, propietate guztiak emanez.



d) Besteak.cs
Erabiltzailearekin interakzioa errazten duten metodoak ditu.


Nagusiak:


LehenMezua() → ongietorria erakusten du


Pausa() → exekuzioa gelditzen du ENTER sakatu arte


EskareraTamaina(), EskareraHaragiaMota(), EskareraOsagaiak() → erabiltzaileari eskaeraren informazioa eskatzen dio


ErakutsiEskaeraLaburpena(Eskaera p) → eskaeraren laburpena erakusten du


Irten() → agur mezua erakusten du



e) EskariaKontroladorea.cs
Eskaerak sortu, ikusi, bilatu eta ezabatzeko metodoak ditu:


SortuEskaeraBerria(List<Eskaera>) → eskaera berri bat sortzen du eta zerrendara gehitzen du


IkusiAurrekoEskaerak(List<Eskaera>) → aurreko eskaerak erakusten ditu


BilatuEskaeraIzenarenArabera(List<Eskaera>) → eskaerak bezeroen izenaren arabera bilatzen ditu


EzabatuEskaera(List<Eskaera>) → eskaera bat ezabatzen du


Besteak-en metodoak erabiltzen ditu erabiltzailearekin komunikatzeko eta emaitzak erakusteko.



f) MenuKontroladorea.cs
Eguneko menuaren konfigurazioa egiten du.


EgunekoMenuarenKonfigurazioa(string menuActual) metodoak:


Menua erakusten du


Erabiltzaileak menu berria idatz dezake


Menu berria itzultzen du



g) Estatistikak.cs
Eskaeren estatistikak kalkulatzen eta erakusten ditu:


Eskaerak tamainaren arabera


Eskaerak haragi motaren arabera


Osagai osagarrien maiztasuna


Metodo nagusia: ErakutsiEstatistikak(List<Eskaera>).



3️⃣ Programaren fluxua
Program.cs exekutatzen da → SProiektua instantzia sortzen da → Run() deitzen da.


Menu nagusia erakusten da.


Erabiltzaileak aukera bat aukeratzen du:


Sortu eskaera → EskariaKontroladorea.SortuEskaeraBerria()


Ikusi eskaerak → EskariaKontroladorea.IkusiAurrekoEskaerak()


Bilatu → EskariaKontroladorea.BilatuEskaeraIzenarenArabera()


Ezabatu → EskariaKontroladorea.EzabatuEskaera()


Estatistikak → Estatistikak.ErakutsiEstatistikak()


Menuaren konfigurazioa → MenuKontroladorea.EgunekoMenuarenKonfigurazioa()


Irten → Besteak.Irten() + programa bukatzea

