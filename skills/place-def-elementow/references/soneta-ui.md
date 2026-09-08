# Konfiguracja elementu przez MCP soneta_ui lub buscall

Czytaj przy automatyzacji [definicji elementu wynagrodzenia](../SKILL.md) przez
połączenie MCP `soneta_ui` lub `buscall`. Poniższe nazwy to metody integracji Soneta, nie narzędzia
wbudowane w konkretne środowisko agenta. Przed wywołaniem sprawdź udostępnione narzędzia,
ich schematy argumentów i aktualne identyfikatory formularza; prefiks MCP może się różnić.
Jeśli korzystasz z `buscall`, składnię wywołania sprawdź w
[referencji buscall](../../tools/references/buscall.md).

Mapowanie kroków z głównego skilla (zapis poglądowy, nie gotowy skrypt):

```text
1. navigate_to_folder("Ustawienia/Kadry i płace/Płace/Elementy wynagrodzenia")
2. add_subobject(gridID="_New_CfgDefElementowExtender_DefElementow")
3. update_field_value — wypełnij zakładkę Ogólne (nazwa, skrót, naliczanie, lista płac)
4. switch_form_page("DefinicjaElementuAlgorytmPage") — skonfiguruj algorytm
5. [opcjonalnie] switch_form_page("DefinicjaElementuEdytorPage") — wpisz kod C#
6. switch_form_page("DefinicjaElementuDeklaracjePage") — skonfiguruj PIT/ZUS
7. switch_form_page("DefinicjaElementuNieobecnosciProPage") — skonfiguruj wliczanie do podstaw
8. accept_subform() — zatwierdź podformularz
9. save_form() — zapisz do bazy
```

### Formatowanie kodu w edytorze (przez MCP)

Znaki nowej linii w kodzie C# przez MCP wstawiamy jako `\\n`:

```
update_field_value(["_Tekst=public void Nazwa_Param(...) {\\n    ...\\n}\\n\\npublic Currency Nazwa_Wylicz(...) {\\n    return ...;\\n}"])
```
