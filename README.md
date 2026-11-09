# SwBiblioteca

Sistema de Gestión de Biblioteca de escritorio, desarrollado como evidencia del curso **Programación Avanzada** (CUN, 2026).

## Descripción

Aplicación de escritorio para administrar libros, autores, categorías, usuarios, préstamos y devoluciones de una biblioteca. Permite consultar la disponibilidad de los libros, calcular retrasos y multas, y revisar el historial de préstamos.

## Tecnologías

- C# con .NET 8.0
- Windows Forms
- SQL Server (base de datos `SwBiblioteca`)
- ADO.NET con consultas parametrizadas
- Arquitectura por capas: Presentación, Lógica de Negocio, Acceso a Datos y Base de Datos
- Git y GitHub para control de versiones

## Estructura del repositorio

| Carpeta / archivo | Contenido |
|---|---|
| `SwBiblioteca/` | Código fuente de la aplicación |
| `sql file/` | Script SQL para crear la base de datos |
| `IMAGENES/` | Capturas de pantalla del sistema |
| `Documentacion.md` | Documentación técnica y funcional del proyecto |

## Requisitos

- Windows 10 u 11
- .NET 8.0 SDK
- SQL Server (Express o Developer)
- Visual Studio 2022 o superior

## Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/manuelmartinez-byte/SwBiblioteca.git
   ```
2. Abre SQL Server Management Studio y ejecuta el script de la carpeta `sql file/` [nombre del archivo .sql]. Esto crea la base de datos `SwBiblioteca` con sus tablas.
3. Abre la solución `SwBiblioteca.sln` dentro de la carpeta `SwBiblioteca/` en Visual Studio.
4. Revisa la cadena de conexión en [App.config / appsettings.json] y ajústala a tu servidor (por ejemplo, `DESKTOP-XXXX\SQLEXPRESS`).
5. Ejecuta el proyecto con **F5**.

## Funcionalidades

- Gestión de libros: registrar, consultar, actualizar, eliminar y buscar.
- Gestión de autores y categorías.
- Gestión de usuarios.
- Registro de préstamos y actualización de disponibilidad.
- Registro de devoluciones con cálculo de días de retraso y multa.
- Consultas: libros disponibles, libros prestados, usuarios con préstamos activos e historial.

## Validaciones

- Código de libro único.
- Campos obligatorios no vacíos.
- No se presta un libro sin ejemplares disponibles.
- No se presta a usuarios ni libros inexistentes.

## Documentación

La documentación completa (casos de

