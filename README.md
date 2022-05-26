# MvcMovie
- Creazione Progetto con `dotnet new mvc`
- Caso in cui non si abbia attivo il certificato HTTPS si può usare `dotnet dev-certs https --trust`
- I pachetti che mi serviranno per questa app sono:
  ```
  dotnet tool uninstall --global dotnet-aspnet-codegenerator
  dotnet tool install --global dotnet-aspnet-codegenerator
  dotnet tool uninstall --global dotnet-ef
  dotnet tool install --global dotnet-ef
  dotnet add package Microsoft.EntityFrameworkCore.Design
  dotnet add package Microsoft.EntityFrameworkCore.SQLite
  dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
  dotnet add package Microsoft.EntityFrameworkCore.SqlServer
  ```
- Per creare le pagine in un colpo solo posso usare lo scaffolding con il seguente comando CLI
  ```
  dotnet-aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite
  ```
  i parametri usati rapprsentano:
  - `controller -name MoviesController` aggiungere un controller con questo nome
  - `-m Movie` classe di modelli da usare
  - `-dc MvcMovieContext` nome della classe DbContext da usare
  - `--relativeFolderPath Controllers` specifica dove deve essere generato il file
  - `--useDefaultLayout` setta il layout default per le viste
  - `--referenceScriptLibraries` librerie di script di riferimento nelle viste generate. Aggiunge _ValidationScriptsPartial per modificare e creare pagine.
  - `-sqlite` Flag per specificare se DbContext deve usare SQLite anziché SQL Server.

  ![img](https://i.ibb.co/wdkzhcs/Cattura.png)
  quando va a buon fine, questo è quello che si ottiene.
