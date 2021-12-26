**URSPRUNG**
applikationen är tydligt byggd med MVC-designmönster där jag har modeller som representerar produkterna som konstnären säljer och deras kategorier, plus modellerna för hemsidan och kontaktsidan. Sedan skapade jag kontrollerna för varje modell utom kategorimodellen eftersom den bara används för att se till att alla produkter tillhör en kategori efter id:n.
För varje modell finns det ett Interface Repository (IArtRepository) med de metoder som behövs som anropas i ett repository (ArtRepository) som implementerar gränssnittet. Jag skapade även en modell för databasen (AppDbContext) som injiceras i produkt repository (ArtRepository).
Utöver detta finns det Mockrepositories för varje modell i syfte att testa.
I produktkontrollern (ArtController) har jag 2 metoder, först en metod (Index) som returnerar en vy av alla produkter, och den andra metoden (Categori) som får produkterna efter deras kategori-id och returnerar en vy av de hämtade produkterna.
Jag hade inget kategori repository i uppfinnaren 1, men jag uppdaterade programmet med ett kategori repository, samt skapade repository för hemvyn, kontaktvyn och kategorivyn. Applikationen var relativt enkel, men lite komplex, det handlade mer om att förstå strukturen och sambandet mellan de olika delarna av programmet.


**RESULTAT**
Eftersom vi i den här modulen lade till en EF i minnesdatabasen, uthärdade kodstrukturen följande förändringar:
[1] Lade till en dependency injection av databasen i ConfigureServices metoden.
[2] Tog bort Add-metoden från produktens interfacet (IArtRepository) och från dess implementeringar, anledningen till att jag tog bort den här metoden är helt enkelt för att appen inte använder den i nuläget.
[3] Lade även till en kategorie property av typen Category till produktklassen (Art).
[4] Använde Linq för att inkludera kategoritypen i produkterna, och använde Linq även för att hämta produkter efter deras kategori-id.
[5] Ändrade get-metoden i IArtRespository från att få en produkt efter id till att få produkter efter deras kategori-id.
[6] Lade till en kontrollmetod (Category(int id)) för att visa en vy av en vald kategori och produkterna i den.
[7] Lade till en vymodell(ArtListViewModel) för att använda i vyerna(Category och Index för Art) och i kontrollern (ArtController).
När det gäller vidare utveckling av programmet, för att implementera CRUD-operationer som ett exempel så är det bara att lägga till de ansvarsfulla metoderna i interfacet och sedan koppla ihop dem med kontrollern och vyerna.

**TESTER**

TestModels
(1)[Test_Should_Retrun_ArtByCategoryId()] detta test säkerställer att det returnerade värdet för metoden (GetArtByCategoryId(int id)) inte är null.
(2)[Test_Should_Return_AllArt()] detta test säkerställer att det returnerade värdet för metoden (List()) inte är tomt.

TestControllers
(1)[Index_Test_Should_Return_ViewForIndex()] det här testet säkerställer att det returnerade värdet för kontrollmetoden (Index) inte är tomt samt att det returnerade objektet är den givna typen och inte en härledd typ.
(2)[Category_Test_Should_Return_ViewForCategory()] det här testet säkerställer att det returnerade värdet för kontrollmetoden (Category) inte är tomt samt att det returnerade objektet är den givna typen och inte en härledd typ.

jag är inte så bekväm med att göra tester än men jag tror att mina tester ser till att alla testade metoder inte kommer att returnera null eller ett tomt objekt, så det kommer alltid att se till att metoderna returnerar något och sådär om testerna misslyckas då vi vet att de testade metoderna returnerar ett tomt objekt eller inte returnerar något alls.


