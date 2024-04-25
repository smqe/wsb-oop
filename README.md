# Projekt z Programowania Obiektowego Grupa: I_Inf_NW_2

## Temat: System zarządzania produktami

## Autor: Dawid Stużyński, Błażej Szulik, Bartłomiej Szulik, Marcin Śmieszek

## Opis i Założenia Projektu

Projekt obejmuje system zarządzania produktami, który umożliwia tworzenie, odczytywanie, aktualizowanie i usuwanie
produktów za pomocą interfejsu API. System ten został zaprojektowany w oparciu o podejście obiektowe, wykorzystując
język C# oraz technologię ASP.NET Core.

### Funkcjonalności

- Tworzenie nowego produktu
- Pobieranie produktu na podstawie jego identyfikatora
- Pobieranie listy wszystkich produktów
- Aktualizowanie informacji o produkcie
- Usuwanie produktu

### Technologie

- Język programowania: C#
- Framework: ASP.NET Core
- Baza danych: SQLite

## Opis Techniczny Projektu

### Struktura Projektu

- **Kontroler ProductController:** Odpowiada za obsługę żądań związanych z produktami. Posiada metody do tworzenia,
  pobierania, aktualizowania i usuwania produktów.

- **Serwis ProductService:** Zapewnia logikę biznesową związaną z produktami. Odpowiada za manipulację danymi produktów
  w bazie danych.

- **Mapper ProductMapper:** Odpowiada za mapowanie obiektów DTO (Data Transfer Object) na obiekty encji i odwrotnie.

- **Modele:** Zawierają definicje obiektów używanych w projekcie, takie jak CreateProductDto, ProductDto, ProductEntity
  itp.

### Interfejsy

- **IProductService:** Interfejs definiujący operacje związane z produktami.

### Klasy Abstrakcyjne

**ControllerBase:** jest to klasa frameworka

### Klasa Finalna

**ProductMapper:** klasa finalna (sealed)

### Hermetyzacja, Dziedziczenie, Polimorfizm

- **Hermetyzacja:** W klasie ProductEntity pola Id, Name i Description są hermetyzowane poprzez ustawienie odpowiednich
  modyfikatorów dostępu.

- **Dziedziczenie:** Product controller rozszerza klasę **ControllerBase:** i uzyskuje dostęp do jej elementów

- **Polimorfizm:** Zastosowano polimorfizm poprzez implementację metod w interfejsie IProductService oraz ich
  implementację w klasie ProductService, gdzie zachowanie tych metod może się różnić w zależności od kontekstu oraz przy
  używaniu interfesju List

## Wnioski

Projekt został zaimplementowany zgodnie z założeniami i spełnia wszystkie wymagania funkcjonalne. Wykorzystanie
podejścia obiektowego, interfejsów oraz hermetyzacji przyczyniło się do czytelności, elastyczności i łatwości
rozszerzania kodu. Przetestowanie funkcjonalności umożliwia swagger dostępny po uruchomieniu aplikacji pod adresem `http://localhost:5202/swagger/index.html` 
