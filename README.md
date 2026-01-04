🍔 Burger Express – Eskaera Kudeaketa Sistema

📌 Proiektuaren azalpena

Proiektu hau Burger Express jatetxerako eskaeren kudeaketa sistema da, C# lengoaian egina eta kontsola bidez funtzionatzen duena.

Programaren helburua da erabiltzaileari aukera ematea:

Eskaera berriak sortzeko

Aurreko eskaerak ikusteko

Eskaerak izenaren arabera bilatu eta ezabatzeko

Estatistikak ikusteko

Eguneko menua aldatzeko

Programa modularra da, klase desberdinetan banatuta, kodea argiagoa eta antolatuagoa izateko.

🛠 Erabilitako teknologiak

Lengoaia: C#

Ingurunea: .NET Console Application

IDE gomendatua: Visual Studio / Visual Studio Code

▶️ Nola exekutatu

Klonatu repositorioa:

git clone https://github.com/erabiltzailea/burger-express.git


Sartu proiektuaren karpetan:

cd Proiektua


Exekutatu programa:

dotnet run

📂 Proiektuaren egitura
Proiektua/
│
├── Program.cs
├── SProiektua.cs
├── Eskaera.cs
├── Besteak.cs
├── EskariaKontroladorea.cs
├── MenuKontroladorea.cs
├── Estatistikak.cs
└── README.md

📄 Fitxategien azalpena
🔹 Program.cs

Programaren abiapuntua da (Main metodoa).

SProiektua klasea sortzen du eta Run() metodoa exekutatzen du.

🔹 SProiektua.cs

Programaren kontrol nagusia.

Menu nagusia erakusten du eta erabiltzailearen aukerak kudeatzen ditu.

Eskaerak gordetzeko List<Eskaera> erabiltzen du.

Beste klaseetara deitzen du funtzionalitatea banatzeko.

Menu nagusiko aukerak:

Eskaera berria sortu

Aurreko eskaerak ikusi

Eskaerak bilatu

Eskaera ezabatu

Estatistikak ikusi

Eguneko menua aldatu

Irten

🔹 Eskaera.cs

Eskaera baten eredua da.

Datu hauek gordetzen ditu:

Bezeroaren izena

Hamburguesaren tamaina

Haragi mota

Osagai osagarriak

Edaria

Osagarria

🔹 Besteak.cs

Laguntza klasea da.

Erabiltzailearekin interakzioa errazteko metodoak ditu:

Ongietorri mezua

Pausak (ENTER sakatzeko)

Aukeren menua (tamaina, haragia, osagaiak)

Eskaeraren laburpena erakustea

Irteerako mezua

Klase hau static da, ez da objekturik sortu behar erabiltzeko.

🔹 EskariaKontroladorea.cs

Eskaeren kudeaketa egiten du:

Eskaera berriak sortu

Eskaerak erakutsi

Eskaerak bilatu

Eskaerak ezabatu

Metodo guztiek List<Eskaera> jasotzen dute parametro gisa.

🔹 MenuKontroladorea.cs

Eguneko menua aldatzeko erabiltzen da.

Uneko menua erakutsi eta berri bat sartzeko aukera ematen du.

🔹 Estatistikak.cs

Eskaeren estatistikak kalkulatzen ditu:

Tamainaren arabera

Haragi motaren arabera

Osagai osagarrien erabilera

🔄 Programaren funtzionamendua

Programa abiarazten da.

Menu nagusia agertzen da.

Erabiltzaileak aukera bat hautatzen du.

Aukeraren arabera, dagokion klasea eta metodoa exekutatzen da.

“Irten” aukeratzean, programa modu naturalean amaitzen da (return erabiliz).

⚠️ Oharrak

Eskaerak memorian gordetzen dira; programa ixtean galdu egiten dira.

Ez da datu-base edo fitxategi kanpokorik erabiltzen.

Programa ikasketa helburuetarako egina dago.

👤 Egilea

Izena: Ádrian Corroza

Proiektua: Burger Express

Ikasgaia: Programazioa (C#)

📜 Lizentzia

Proiektu hau hezkuntza-helburuetarako sortu da.
