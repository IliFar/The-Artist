**URSPRUNG**
applikationen �r tydligt byggd med MVC-designm�nster d�r jag har modeller som representerar produkterna som konstn�ren s�ljer och deras kategorier, plus modellerna f�r hemsidan och kontaktsidan. Sedan skapade jag kontrollerna f�r varje modell utom kategorimodellen eftersom den bara anv�nds f�r att se till att alla produkter tillh�r en kategori efter id:n.
F�r varje modell finns det ett Interface Repository (IArtRepository) med de metoder som beh�vs som anropas i ett repository (ArtRepository) som implementerar gr�nssnittet. Jag skapade �ven en modell f�r databasen (AppDbContext) som injiceras i produkt repository (ArtRepository).
Ut�ver detta finns det Mockrepositories f�r varje modell i syfte att testa.
I produktkontrollern (ArtController) har jag 2 metoder, f�rst en metod (Index) som returnerar en vy av alla produkter, och den andra metoden (Categori) som f�r produkterna efter deras kategori-id och returnerar en vy av de h�mtade produkterna.
Jag hade inget kategori repository i uppfinnaren 1, men jag uppdaterade programmet med ett kategori repository, samt skapade repository f�r hemvyn, kontaktvyn och kategorivyn. Applikationen var relativt enkel, men lite komplex, det handlade mer om att f�rst� strukturen och sambandet mellan de olika delarna av programmet.


**RESULTAT**
Eftersom vi i den h�r modulen lade till en EF i minnesdatabasen, uth�rdade kodstrukturen f�ljande f�r�ndringar:
[1] Lade till en dependency injection av databasen i ConfigureServices metoden.
[2] Tog bort Add-metoden fr�n produktens interfacet (IArtRepository) och fr�n dess implementeringar, anledningen till att jag tog bort den h�r metoden �r helt enkelt f�r att appen inte anv�nder den i nul�get.
[3] Lade �ven till en kategorie property av typen Category till produktklassen (Art).
[4] Anv�nde Linq f�r att inkludera kategoritypen i produkterna, och anv�nde Linq �ven f�r att h�mta produkter efter deras kategori-id.
[5] �ndrade get-metoden i IArtRespository fr�n att f� en produkt efter id till att f� produkter efter deras kategori-id.
[6] Lade till en kontrollmetod (Category(int id)) f�r att visa en vy av en vald kategori och produkterna i den.
[7] Lade till en vymodell(ArtListViewModel) f�r att anv�nda i vyerna(Category och Index f�r Art) och i kontrollern (ArtController).
N�r det g�ller vidare utveckling av programmet, f�r att implementera CRUD-operationer som ett exempel s� �r det bara att l�gga till de ansvarsfulla metoderna i interfacet och sedan koppla ihop dem med kontrollern och vyerna.

**TESTER**

TestModels
(1)[Test_Should_Retrun_ArtByCategoryId()] detta test s�kerst�ller att det returnerade v�rdet f�r metoden (GetArtByCategoryId(int id)) inte �r null.
(2)[Test_Should_Return_AllArt()] detta test s�kerst�ller att det returnerade v�rdet f�r metoden (List()) inte �r tomt.

TestControllers
(1)[Index_Test_Should_Return_ViewForIndex()] det h�r testet s�kerst�ller att det returnerade v�rdet f�r kontrollmetoden (Index) inte �r tomt samt att det returnerade objektet �r den givna typen och inte en h�rledd typ.
(2)[Category_Test_Should_Return_ViewForCategory()] det h�r testet s�kerst�ller att det returnerade v�rdet f�r kontrollmetoden (Category) inte �r tomt samt att det returnerade objektet �r den givna typen och inte en h�rledd typ.

jag �r inte s� bekv�m med att g�ra tester �n men jag tror att mina tester ser till att alla testade metoder inte kommer att returnera null eller ett tomt objekt, s� det kommer alltid att se till att metoderna returnerar n�got och s�d�r om testerna misslyckas d� vi vet att de testade metoderna returnerar ett tomt objekt eller inte returnerar n�got alls.


