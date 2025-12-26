# CalculatorApp 🧮

Jednoduchá konzolová kalkulačka demonstrující princip **Single Responsibility Principle (SRP)** rozdělením zodpovědností do samostatných tříd.

## 📝 Popis

CalculatorApp je konzolová aplikace napsaná v C# (.NET 10.0), která umožňuje provádět základní aritmetické operace. Projekt slouží jako ukázka správného návrhu softwarové architektury s důrazem na princip jediné zodpovědnosti (SRP) z SOLID principů.

Každá třída v projektu má jasně definovanou zodpovědnost:
- **Výpočty** - třída Calculator
- **Vstup** - třída InputReader
- **Výstup** - třída OutputWriter
- **Řízení toku** - třída Program

## ✨ Funkce

- ➕ Sčítání
- ➖ Odčítání
- ✖️ Násobení
- ➗ Dělení (s ošetřením dělení nulou)
- 🎨 Barevný výstup v konzoli
- 🔄 Opakované použití až do ukončení uživatelem
- ✅ Validace vstupů

## 🏗️ Architektura projektu

Projekt je rozdělen do čtyř hlavních tříd, každá s vlastní zodpovědností:

### 1. Calculator
**Zodpovědnost:** Provádění aritmetických operací

```csharp
public double Add(double a, double b)
public double Subtract(double a, double b)
public double Multiply(double a, double b)
public double Divide(double a, double b)
```

### 2. InputReader
**Zodpovědnost:** Čtení a validace vstupu z konzole

```csharp
public double ReadDouble()  // Čte a validuje číselný vstup
public string ReadString()  // Čte textový vstup
```

### 3. OutputWriter
**Zodpovědnost:** Formátování a výpis informací na konzoli

```csharp
public void Write(string text, ConsoleColor? color = null)
public void WriteLine(string text, ConsoleColor? color = null)
public void WriteError(string text)      // Červený výpis
public void WriteSuccess(string text)    // Zelený výpis
public void WriteWarning(string text)    // Žlutý výpis
public void WriteDivider(ConsoleColor? color = null)
```

### 4. Program
**Zodpovědnost:** Řízení hlavního toku aplikace a koordinace mezi třídami

## 🚀 Spuštění aplikace

### Požadavky
- .NET 10.0 SDK nebo novější

### Spuštění
```bash
# Klonování repozitáře
git clone https://github.com/jardaczk/CalculatorApp.git
cd CalculatorApp/CalculatorApp

# Spuštění aplikace
dotnet run
```

### Kompilace
```bash
# Build projektu
dotnet build

# Spuštění zkompilované aplikace
dotnet run --no-build
```

## 💡 Použití

Po spuštění aplikace se zobrazí menu s možnostmi:

```
**************************************************
Vyberte operaci:
1. Sčítání
2. Odčítání
3. Násobení
4. Dělení
5. Konec
**************************************************
```

1. Vyberte operaci zadáním čísla (1-5)
2. Zadejte první číslo
3. Zadejte druhé číslo
4. Aplikace zobrazí výsledek
5. Proces se opakuje až do výběru možnosti "5. Konec"

### Příklad použití
```
Vyberte operaci:
1
Zadejte první číslo:
15
Zadejte druhé číslo:
5
Výsledek: 20
```

## 🎯 Single Responsibility Principle (SRP)

Tento projekt demonstruje SRP následujícím způsobem:

| Třída | Jediná zodpovědnost |
|-------|---------------------|
| **Calculator** | Provádění matematických výpočtů |
| **InputReader** | Čtení a parsování vstupu z konzole |
| **OutputWriter** | Formátování a zobrazení výstupu |
| **Program** | Orchestrace toku aplikace |

### Výhody tohoto přístupu:
- ✅ **Snadná údržba** - změny v jedné oblasti neovlivňují ostatní
- ✅ **Testovatelnost** - každá třída lze testovat samostatně
- ✅ **Rozšiřitelnost** - snadné přidání nových operací nebo vstupně-výstupních metod
- ✅ **Čitelnost** - jasná struktura a zodpovědnosti

## 🔮 Možnosti dalšího rozvoje

Projekt je navržen tak, aby bylo možné jej snadno rozšiřovat:

- ➕ Přidání pokročilých matematických operací (mocniny, odmocniny, logaritmy)
- 📊 Implementace historie výpočtů
- 💾 Ukládání výsledků do souboru
- 🧪 Přidání unit testů pro každou třídu
- 🌐 Lokalizace do více jazyků
- 🎨 Vylepšení uživatelského rozhraní
- 📱 Vytvoření GUI verze aplikace
- 🔧 Přidání podpory pro složitější výrazy

## 📚 Technologie

- **Jazyk:** C# 10
- **Framework:** .NET 10.0
- **Typ aplikace:** Console Application

## 👤 Autor

jardaczk

## 📄 Licence

Tento projekt je vytvořen pro vzdělávací účely a demonstraci SRP principu.