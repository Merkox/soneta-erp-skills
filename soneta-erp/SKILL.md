---
name: soneta-erp
description: >
  Mapa i przewodnik po wyspecjalizowanych skillach platformy Soneta (enova365, Triva):
  soneta-programming (ORM), soneta-addon-planning, soneta-business-xml,
  soneta-form-xml, soneta-place-def-elementow, soneta-config (konfiguracja i funkcje
  domenowe — import/eksport XML, scan-folders), soneta-config-reg (rejestr konfiguracji
  ConfigReg — providery, *.reg.json, przenoszenie ustawień między bazami),
  soneta-tools (narzędzia CLI: dbmgr,
  buscall, SonetaFrame). Używaj gdy użytkownik: (1) rozpoczyna
  zadanie dla platformy Soneta i nie wiadomo, który skill wybrać; (2) pyta ogólnie
  o dodatki, moduły lub rozszerzenia Soneta ERP; (3) wspomina enova, Soneta Enterprise,
  Triva bez sprecyzowania warstwy (dane, UI, logika, płace); (4) chce poznać dostępne
  skille; (5) realizuje zadanie obejmujące wiele warstw platformy (np. moduł z bazą,
  formularzami i logiką).
---

# Mapa skills podczas pracy z platformą Soneta (enova365, Triva)

* `/soneta-programming` - Fundamentalne klasy ORM platformy Soneta. Obejmuje mapowanie 
obiektowo-relacyjne (Row, Table, Module), zarządzanie sesją (Session), logowanie (Login, Database, BusApplication), 
paczki danych (Datapack, GuidedRow) oraz kontekst (Context). Używaj gdy użytkownik pyta o podstawowe klasy logiki 
biznesowej, strukturę obiektów ORM, sesje i transakcje, hierarchię klas Row/Table/Module, mechanizm Datapack i 
synchronizację danych, lub kontekst aplikacji Soneta, Context 
* `/soneta-addon-planning` - Planowanie projektów dodatków dla platformy Soneta. Tworzy
  kompletną dokumentację projektową obejmującą: strukturę danych (tabele, relacje),
  elementy konfigurowalne, definicje list i menu, formularze, workery i raporty.
  Używaj gdy użytkownik prosi o zaplanowanie nowego modułu/dodatku Soneta,
  przygotowanie założeń projektu, stworzenie specyfikacji funkcjonalnej dodatku,
  lub zdefiniowanie struktury danych i interfejsu użytkownika dla nowego modułu.
*  `/soneta-business-xml` - Generator plików business.xml dla platformy Soneta.
   Tworzy definicje obiektów biznesowych (tabel, kolumn, relacji, indeksów) zgodne
   ze schematem XSD. Używaj gdy użytkownik prosi o stworzenie nowego modułu biznesowego,
   zdefiniowanie obiektów lub encji do przechowywania w bazie danych, utworzenie relacji
   między obiektami, lub generowanie plików business.xml dla platformy Soneta.
* `/soneta-config` - Narzędzia i mechanizmy związane z konfiguracją systemu i funkcjami
  domenowymi platformy (zawartość rozwijana). Obecnie: (A) **import/eksport danych i ustawień
  konfiguracyjnych przez pliki XML** — struktura pliku `<session>`, import według rekordów
  (pliki `*.dbinit.xml`, baza demo), import przez logikę biznesową (`business="true"`),
  eksport datapacku, identyfikacja po GUID, formaty wartości; (B) `scan-folders` —
  inwentaryzacja **folderów statycznych menu** (`[assembly: FolderView]`) z bibliotek DLL
  (drzewo pozycji menu, listy, formularze, powiązanie z tabelą/`ViewInfo`). Używaj gdy
  użytkownik buduje/analizuje XML importu danych Soneta, przenosi ustawienia między bazami,
  eksportuje rekordy do XML, albo mapuje strukturę menu dodatku. Warstwa kodu importu
  (`SessionReader`/`SessionWriter`) i ORM → `/soneta-programming`; operacje na bazie z CLI →
  `/soneta-tools`.
* `/soneta-config-reg` - **Rejestr konfiguracji (ConfigReg)** — silnik zrzucający całą
  konfigurację bazy do drzewa `ConfigReg`, serializowanego do plików `*.reg.json` i tabeli
  `ConfigRegistry`. Od strony kodu C#: providery `IConfigRegProvider` (Root/Module/Table/Row/
  SubTable/Storage/Addins), atrybut `[ConfigReg(Hide/Ignore/Include/ChildrenType)]` sterujący
  zakresem rejestru, potok Loader → Differ/Merger → SessionUpdater, format JSON (`$strict`,
  `$v`, `#klucz`, `@atrybut`). Używaj gdy użytkownik pyta o rejestr konfiguracji, chce wyłączyć
  tabelę lub kolumnę z rejestru, pisze/poprawia provider albo debuguje przenoszenie ustawień
  między bazami przez rejestr. Odróżnij od `/soneta-config`: XML (`<session>`, `dbinit.xml`)
  to inny, niezależny mechanizm.
* `/soneta-tools` - Narzędzia deweloperskie wiersza poleceń Soneta. `dbmgr` — zarządzanie
  bazami danych (tworzenie/rejestracja, konwersja, backup/restore, licencje, rozszerzenia,
  analiza, kompilacja); przygotowanie baz testowych/demo i automatyzacja w CI. `buscall` —
  testowanie na żywej aplikacji: zdalne sterowanie programem i zrzuty ekranu do analizy
  wizualnej. `SonetaFrame` / `SonetaFrameNew` (obie nazwy używane równolegle) — aplikacja ramki hostująca webową wersję
  programu: uruchamianie, parametry startowe, plik ustawień i źródła baz danych. Używaj gdy
  użytkownik zarządza bazą z CLI, tworzy bazę demo, robi backup/konwersję, uruchamia ramkę
  i konfiguruje połączenia do baz, albo weryfikuje zmiany na uruchomionej aplikacji.
* `/soneta-form-xml` - XML z nieistniejącymi elementami. ZAWSZE używaj tego skilla gdy użytkownik: (1) prosi o utworzenie lub modyfikację pliku pageform.xml, viewform.xml, form.xml, lookupform.xml lub gridform.xml dla platformy Soneta (enova365); (2) pyta o elementy DataForm, Page, Group, Grid, Field, Row, Stack, Flow, Command, Include, Appearance, GroupBy w Soneta; (3) pyta o składnię EditValue, DataContext, Visibility, RowCondition, Renderable, CaptionHtml, Footer, Class lub układ UI formularzy Soneta; (4) pokazuje istniejący plik form.xml/pageform.xml/viewform.xml i pyta o jego strukturę lub chce go rozszerzyć; (5) pyta o warunkową widoczność, formatowanie warunkowe (Appearance), bindowanie danych lub wzorce UI w Soneta.
