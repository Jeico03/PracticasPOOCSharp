# Prácticas de Programación Orientada a Objetos en C#

Repositorio de ejercicios prácticos desarrollados en C# como parte de una ruta de aprendizaje de Programación Orientada a Objetos (POO).

Cada ejercicio está organizado en un proyecto de consola independiente, mientras que todos los proyectos de práctica se agrupan en una única solución de Visual Studio.

## 🎯 Objetivo

Reforzar los fundamentos de la programación orientada a objetos mediante ejercicios progresivos que permitan comprender cómo diseñar clases, crear objetos, reutilizar código y organizar aplicaciones en C#.

## 📚 Contenido

| Proyecto | Tema principal |
|---|---|
| `Practica01_Persona` | Clases, objetos, atributos y métodos |
| `Practica02_Empleado` | Propiedades, métodos y manejo de fechas |
| `Practica03_HerenciaVehiculos` | Herencia y sobrescritura de métodos |
| `Practica04_EncapsulacionAutomovil` | Encapsulación y modificadores de acceso |
| `Practica05_InterfacesVehiculos` | Interfaces y comportamientos comunes |
| `Practica06_SobrecargaConstructoresYMetodos` | Sobrecarga de constructores y métodos |
| `Practica07_ClasesAbstractasEInterfaces` | Clases abstractas e interfaces |
| `Practica08_TiposGenericosLista` | Tipos y clases genéricas |
| `Practica09_ManejoExcepciones` | Excepciones y bloques `try-catch` |
| `Practica10_PatronSingleton` | Introducción al patrón Singleton |
| `Practica11_PrincipiosSOLID` | Principios SOLID y refactorización |

## 🧠 Conceptos que se practican

- Clases, objetos, campos, propiedades y métodos.
- Constructores y sobrecarga.
- Encapsulación y modificadores de acceso.
- Herencia y polimorfismo.
- Interfaces y clases abstractas.
- Tipos genéricos y colecciones.
- Manejo de excepciones.
- Patrones de diseño.
- Principios SOLID, DRY y KISS.

## 🗂️ Organización del repositorio

```text
PracticasPOOCSharp/
│
├── PracticasPOOCSharp.sln
├── README.md
├── .gitignore
│
├── docs/
│   ├── Notas-Introduccion-POO.md
│   └── Notas-SOLID-DRY-KISS.md
│
└── src/
    │
    ├── Practica01_Persona/
    │   ├── Practica01_Persona.csproj
    │   ├── Program.cs
    │   └── Persona.cs
    │
    ├── Practica02_Empleado/
    │   ├── Practica02_Empleado.csproj
    │   ├── Program.cs
    │   └── Empleado.cs
    │
    ├── Practica03_HerenciaVehiculos/
    │   ├── Practica03_HerenciaVehiculos.csproj
    │   ├── Program.cs
    │   ├── Vehiculo.cs
    │   ├── Automovil.cs
    │   ├── Motocicleta.cs
    │   └── Camioneta.cs
    │
    ├── Practica04_EncapsulacionAutomovil/
    │   ├── Practica04_EncapsulacionAutomovil.csproj
    │   ├── Program.cs
    │   ├── Automovil.cs
    │   └── AutomovilDeportivo.cs
    │
    ├── Practica05_InterfacesVehiculos/
    │   ├── Practica05_InterfacesVehiculos.csproj
    │   ├── Program.cs
    │   ├── IVehiculo.cs
    │   ├── Automovil.cs
    │   └── Motocicleta.cs
    │
    ├── Practica06_SobrecargaConstructoresYMetodos/
    │   ├── Practica06_SobrecargaConstructoresYMetodos.csproj
    │   ├── Program.cs
    │   └── Persona.cs
    │
    ├── Practica07_ClasesAbstractasEInterfaces/
    │   ├── Practica07_ClasesAbstractasEInterfaces.csproj
    │   ├── Program.cs
    │   ├── FiguraGeometrica.cs
    │   ├── IDibujable.cs
    │   ├── Cuadrado.cs
    │   └── Circulo.cs
    │
    ├── Practica08_TiposGenericosLista/
    │   ├── Practica08_TiposGenericosLista.csproj
    │   ├── Program.cs
    │   └── Lista.cs
    │
    ├── Practica09_ManejoExcepciones/
    │   ├── Practica09_ManejoExcepciones.csproj
    │   ├── Program.cs
    │   └── Calculadora.cs
    │
    ├── Practica10_PatronSingleton/
    │   ├── Practica10_PatronSingleton.csproj
    │   ├── Program.cs
    │   └── ConfiguracionAplicacion.cs
    │
    └── Practica11_PrincipiosSOLID/
        ├── Practica11_PrincipiosSOLID.csproj
        ├── Program.cs
        ├── Empleado.cs
        ├── IRepositorioEmpleados.cs
        ├── RepositorioEmpleadosMemoria.cs
        └── ServicioEmpleados.cs
```

Cada carpeta dentro de `src/` contiene un proyecto de consola independiente, con su propio archivo `.csproj`, su archivo `Program.cs` y las clases necesarias para realizar la práctica.

La solución permite abrir y administrar todos los ejercicios desde Visual Studio sin mezclar sus implementaciones.

## 🛠️ Tecnologías utilizadas

- C#
- .NET
- Visual Studio
- Git
- GitHub

## ⚙️ Requisitos

- SDK de .NET instalado.
- Visual Studio o un entorno compatible con proyectos C#.
- Git para clonar y administrar el repositorio.

## ▶️ Cómo ejecutar una práctica

1. Clona el repositorio:

   ```bash
   git clone URL_DE_TU_REPOSITORIO
   ```

2. Abre `PracticasPOOCSharp.sln` en Visual Studio.
3. Selecciona el proyecto que deseas ejecutar.
4. Establece ese proyecto como proyecto de inicio.
5. Ejecuta la aplicación.

También puedes ejecutar un proyecto desde una terminal, entrando en su carpeta y ejecutando:

```bash
dotnet run
```

Por ejemplo, para ejecutar una práctica desde su carpeta correspondiente, utiliza el comando anterior dentro del directorio que contiene el archivo `.csproj` de esa práctica.

## 📖 Documentación

La carpeta `docs/` contiene apuntes y notas de estudio sobre los conceptos teóricos de la ruta de aprendizaje.

## 📌 Alcance del repositorio

Este repositorio está dedicado exclusivamente a las prácticas individuales de Programación Orientada a Objetos.

El proyecto integrador **Sistema de Gestión de Empleados** se desarrollará por separado, en su propio repositorio y solución de Visual Studio.

## 👨‍💻 Propósito

Proyecto personal de aprendizaje orientado a reforzar los fundamentos de C# y desarrollar buenas prácticas de programación.

---

**Lenguaje:** C#  
**Tipo de aplicación:** Consola  
**Estado:** Completado