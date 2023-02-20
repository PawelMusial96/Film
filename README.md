README.md

-------KRÓTKI OPIS --------

Aplikacja dla kinomaniaka to projekt ASP.NET, który umożliwia zarządzanie listą filmów/seriali do oglądnięcia. Dzięki aplikacji, można dodawać nowe filmy do listy, przypisywać je do odpowiednich gatunków, usuwać lub modyfikować dane filmu na podstawie ID.

--------URUCHAMIANIE-------

Aby móc skorzystać z projektu Film, potrzebujemy środowiska z zainstalowanym .NET i Microsoft SQL Server. W projekcie zostały użyte różne biblioteki, w tym EntityFrameworkCore, Web.
Aby skompilować i uruchomić aplikację, należy najpierw pobrać i zainstalować wymagane biblioteki przy użyciu menedżera pakietów NuGet. Następnie należy skonfigurować połączenie z bazą danych w pliku konfiguracyjnym, aby umożliwić aplikacji dostęp do bazy.
Projekt należy sklonować z Githuba: https://github.com/PawelMusial96/Film
Aby skonfigurować projekt Film, należy najpierw ustawić połączenie z bazą danych w pliku appsettings.json. W celu połączenia z bazą danych Microsoft SQL Server, należy zmodyfikować na podstawie swoich potrzeb. Przykładowa konfiguracja wygląda następująco:
"data source=PAWEŁ; initial catalog=Film; integrated security=true"
data source =; initial catalog =;Trusted_Connection=True; Integrated Security=true; Należy zastąpić odpowiednim adresem serwera bazy danych, a - nazwą bazy danych, którą chcemy utworzyć lub wykorzystać.
Aby uruchomić projekt, należy zainstalować menedżer pakietów NuGet i dodać migracje, które umożliwią utworzenie bazy danych. Można to zrobić za pomocą konsoli menedżera pakietów NuGet, wpisując następujące polecenia:
Add-Migration Update-Database Po wykonaniu tych kroków, baza danych zostanie utworzona, a aplikacja będzie gotowa do użycia.

---------UŻYTKOWNICY I ROLE--------

W projekcie aplikacji dla kinomaniaka dostępne jest konto użytkownika służące do testowania funkcjonalności systemu logowania. Poniżej przedstawione są informacje o tych użytkownikach:
Użytkownik (rola "User") • Name:  Jan • Email: user@example.com • UserName: JanKowal • Password: password123!  • PasswordConfirm: password123!
Powyższe dane, są jedynie danymi testowymi.

-------- USER EXPERIENCE & DZIAŁANIE APLIKACJI--------

Po uruchomieniu projektu, zostaniesz przeniesiony na stronę główną. Na stronie głównej znajdziesz filmy wcześniej dodane przez użytkownika .Klikając przycisk logowania, zostaniesz przekierowany na stronę rejestracji, gdzie możesz wpisać swój email oraz hasło. Hasło jest zaszyfrowane, dzięki czemu Twoje dane są bezpieczne. Po pomyślnym zalogowaniu zostaniesz przeniesiony do strony z menu, gdzie możesz zarządzać obszarami: Movie oraz Genre. W każdym z tych obszarów możesz wyświetlić listę wszystkich danych, dodać nowe dane, edytować istniejące dane lub je usunąć.
Wszystkie listy wyświetlane są w postaci tabeli, a dodawanie, edytowanie i usuwanie danych odbywa się za pomocą formularza.

