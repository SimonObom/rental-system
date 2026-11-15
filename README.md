# Rental System – US8

En konsolapplikation för att hitta en bokning och visa tillhörande utrustning och uthyrningsstatus.

## Kör programmet

Du behöver .NET 10 SDK.

1. Klona repositoryt och öppna en terminal i repositoryts rot.
2. Kör:

   ```powershell
   dotnet run --project RentalSystem.US8
   ```

3. Välj ett scenario i menyn:

   - **1:** Pågående uthyrning.
   - **2:** Återlämnad utrustning.
   - **3:** Bokning saknas.
   - **4:** Ogiltigt bokningsnummer.

Menyn använder förberedda bokningsnummer för att förenkla verifieringen. Data lagras i minnet.
