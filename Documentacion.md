# ACA -- Programación Avanzada

# Sistema de Gestión de Biblioteca

------------------------------------------------------------------------

## PORTADA

**\[CUN - INGENIERIA DE SISTEMAS\]**

**\[PROGRAMACION AVANZADA / 54469\]**

### ACA -- Programación Avanzada

### Sistema de Gestión de Biblioteca

**Presentado por:**
Manuel Esteban Martinez Carmona

**Docente:**
Veronica Castro Munar

**Fecha:**
Bogota Octubre 2026

------------------------------------------------------------------------

# CONTRAPORTADA

**Sistema de Gestión de Biblioteca**

Proyecto desarrollado como evidencia del curso de **Programación
Avanzada**, aplicando Programación Orientada a Objetos, base de datos
relacional, arquitectura por capas, operaciones CRUD, validaciones,
manejo de excepciones y conexión con SQL Server.

**Estudiante(s):** Manuel Martinez Carmona
**Programa:** Programación Avanzada
**Docente:** Veronica Castro Munar
**Institución:** CUN
**Año:** 2026

------------------------------------------------------------------------

# TABLA DE CONTENIDO


1.  Introducción
2.  Objetivos
    -   2.1 Objetivo general
    -   2.2 Objetivos específicos
3.  Planteamiento del problema
4.  Análisis de requerimientos
5.  Casos de uso
6.  Diagrama de clases
7.  Modelo entidad-relación
8.  Diccionario de datos
9.  Arquitectura del sistema
10. Explicación de los módulos desarrollados
11. Capturas de pantalla del sistema
12. Pruebas de funcionamiento
13. Conclusiones
14. Recomendaciones

------------------------------------------------------------------------

# 1. INTRODUCCIÓN

En este apartado se debe presentar de manera general el proyecto
desarrollado.

**Texto guía:**

El presente documento describe el desarrollo del **Sistema de Gestión de
Biblioteca**, una aplicación de escritorio cuyo propósito es facilitar
la administración de registros de libros, usuarios, autores y prestamos 
asi como realizar consultas de historial

El sistema fue desarrollado utilizando C#, visual code, visual code studio, SQL managment, Github, aplicando principios de
Programación Orientada a Objetos y una arquitectura por capas.

La aplicación permite gestionar libros, autores, categorías, usuarios,
préstamo y devoluciones
------------------------------------------------------------------------

# 2. OBJETIVOS

## 2.1 Objetivo general

Desarrollar un Sistema de Gestión de Biblioteca que permita consultar,registrar libros, prestamos y autores, utilizando Programación Orientada a
Objetos, una base de datos relacional y una arquitectura por capas.



## 2.2 Objetivos específicos

-   Diseñar e implementar una aplicación de escritorio para la gestión
    de gestion de libros
-   Aplicar principios de Programación Orientada a Objetos.
-   Diseñar e implementar una base de datos relacional en SQL Server.
-   Implementar operaciones CRUD para las entidades principales.
-   Implementar validaciones de datos.
-   Implementar manejo de excepciones.
-   Aplicar una arquitectura por capas.
-   Implementar consultas que faciliten la administración de la
    biblioteca.
-   Utilizar Git y GitHub para el control de versiones.
-   Documentar técnica y funcionalmente el proyecto.


------------------------------------------------------------------------

# 3. PLANTEAMIENTO DEL PROBLEMA

## 3.1 Descripción del problema


En la actualidad, la biblioteca enfrenta problemas para llevar un control ordenado de sus libros, 
autores, usuarios y préstamos.
Al depender de procesos manuales, es común que se cometan equivocaciones, 
que se extravíen datos y que resulte complicado saber qué libros están disponibles en un momento dado.

Ante esta situación, se plantea crear una aplicación que reúna y gestione la información de 
la biblioteca de forma ordenada y eficaz.



## 3.2 Justificación

Desarrollar este sistema es importante porque permite a la biblioteca dejar atrás los procesos manuales, que son lentos y propensos a fallos.
Con una aplicación centralizada, la información de libros, autores, usuarios y préstamos queda en un solo lugar, accesible y actualizada, lo que 
reduce los errores y evita la pérdida de datos.

Además, el sistema ofrece beneficios concretos: el personal puede consultar en segundos la disponibilidad de cualquier libro, se agilizan 
los procesos de préstamo y devolución, y es posible generar reportes que apoyan la toma de decisiones, como identificar los títulos más 
solicitados. En conjunto, esto mejora la calidad del servicio que recibe el usuario y optimiza el tiempo y los recursos de la biblioteca.

## 3.3 Alcance

El sistema permitirá:

-   Gestionar libros.
-   Gestionar autores.
-   Gestionar categorías.
-   Gestionar usuarios.
-   Registrar préstamos.
-   Registrar devoluciones.
-   Consultar disponibilidad.
-   Consultar historial de préstamos.


### Fuera del alcance


-   Recibir feedbacks de los clientes
-   Registrar de que seccion fueron tomados los libros, stand, pasillo

------------------------------------------------------------------------

# 4. ANÁLISIS DE REQUERIMIENTOS

## 4.1 Descripción general

El Sistema de Gestión de Biblioteca permitirá administrar la información 
relacionada con libros, autores y usuarios, y controlar los procesos de préstamos, 
devoluciones y consultas de disponibilidad.

## 4.2 Actores del sistema

  -----------------------------------------------------------------------
  Actor                               Descripción
  ----------------------------------- -----------------------------------
  Bibliotecario / Administrador       Puede ver, registrar y modificar
                                      libros, autores,editoriales y usuarios

 
  -----------------------------------------------------------------------


## 4.3 Requerimientos funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RF01                    Gestionar libros        Registrar, consultar,
                                                  actualizar, eliminar y
                                                  buscar libros.

  RF02                    Gestionar autores       Registrar, consultar,
                                                  actualizar y eliminar
                                                  autores.

  RF03                    Gestionar categorías    Registrar, consultar,
                                                  actualizar y eliminar
                                                  categorías.

  RF04                    Gestionar usuarios      Registrar, consultar,
                                                  actualizar y eliminar
                                                  usuarios.

  RF05                    Registrar préstamos     Registrar préstamos y
                                                  actualizar la
                                                  disponibilidad de los
                                                  libros.

  RF06                    Registrar devoluciones  Registrar devoluciones,
                                                  calcular retrasos y
                                                  multa cuando aplique.

  RF07                    Realizar consultas      Consultar libros
                                                  disponibles, libros
                                                  prestados, historial y
                                                  usuarios con préstamos
                                                  activos.

  
  -----------------------------------------------------------------------



## 4.4 Requerimientos no funcionales

  -----------------------------------------------------------------------
  Código                  Requerimiento           Descripción
  ----------------------- ----------------------- -----------------------
  RNF01                   Usabilidad              La interfaz debe ser
                                                  clara, sencilla y fácil
                                                  de utilizar.

  RNF02                   Validación              El sistema debe validar
                                                  la información
                                                  ingresada por el
                                                  usuario.

  RNF03                   Mantenibilidad          El código debe estar
                                                  organizado y
                                                  documentado.

  RNF04                   Arquitectura            El sistema debe
                                                  utilizar una
                                                  arquitectura por capas.

  RNF05                   Manejo de excepciones   Las operaciones deben
                                                  manejar errores de
                                                  forma controlada.

  RNF06                   Integridad de datos     La información debe
                                                  mantenerse consistente
                                                  en la base de datos.

  RNF07                   Consultas               Las consultas a la base
                          parametrizadas          de datos deben utilizar
                                                  parámetros.


  -----------------------------------------------------------------------

## 4.5 Reglas de negocio

### RN01 -- Código único del libro

No se permitirá registrar dos libros con el mismo código.

### RN02 -- Datos obligatorios

No se permitirá almacenar registros con campos obligatorios vacíos.

### RN03 -- Usuario existente

No se podrá registrar un préstamo para un usuario inexistente.

### RN04 -- Libro existente

No se podrá registrar un préstamo para un libro inexistente.

### RN05 -- Disponibilidad

No se podrá prestar un libro cuando no existan ejemplares disponibles.

### RN06 -- Actualización de disponibilidad

Al registrar un préstamo, la disponibilidad del libro deberá
actualizarse.

### RN07 -- Devolución

Al registrar una devolución, la disponibilidad deberá actualizarse
nuevamente.

### RN08 -- Multa

La multa se calculará únicamente cuando exista retraso en la devolución.



------------------------------------------------------------------------

# 5. CASOS DE USO

## 5.1 Descripción

Describir cómo interactúan los actores con las funcionalidades
principales del sistema.

## 5.2 Diagrama de casos de uso

Insertar aquí el diagrama de casos de uso.

**Archivo sugerido:**

`![Diagrama de casos de uso](ruta/al/diagrama-casos-uso.png)`

## 5.3 Descripción de casos de uso

### CU01 -- Gestionar libros

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar, consultar, actualizar, eliminar y
buscar libros.

**Precondiciones:** - El usuario debe tener acceso al sistema. - debe tener
la informacion de los libros

**Flujo principal:** 1. El actor ingresa al módulo de libros. 2. El
sistema muestra los libros registrados. 3. El actor selecciona la
operación que desea realizar. 4. El sistema procesa la solicitud. 5. El
sistema muestra el resultado.

**Flujos alternativos:** - El actor ingresa al modulo de autores, busca el libro
de su autor favorito, registra el prestamos en la seccion de prestamos y el sistema
procesala solucitud

**Postcondiciones:** - El sistema registrara el prestamo sin importar el flujo tomado previamente

------------------------------------------------------------------------

### CU02 -- Registrar préstamo

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar el préstamo de uno o varios libros a
un usuario.

**Precondiciones:** - El usuario debe existir. - El libro debe
existir. - Debe existir disponibilidad.

**Flujo principal:** 1. Seleccionar usuario. 2. Seleccionar libro. 3.
Verificar disponibilidad. 4. Registrar préstamo. 5. Actualizar
disponibilidad. 6. Mostrar confirmación.

**Flujos alternativos:** - Usuario inexistente. - Libro inexistente. -
Libro sin disponibilidad. - Autor no existente

**Postcondiciones:** - El préstamo queda registrado. - La disponibilidad
del libro queda actualizada.

------------------------------------------------------------------------

### CU03 -- Registrar devolución

**Actor principal:** Bibliotecario / Administrador

**Descripción:** Permite registrar la devolución de un libro prestado.

**Precondiciones:** - Debe existir un préstamo activo.

**Flujo principal:** 1. Seleccionar el préstamo. 2. Registrar la
devolución. 3. Calcular días de retraso. 4. Calcular multa cuando
corresponda. 5. Actualizar disponibilidad. 6. Actualizar el estado del
préstamo. 7. Mostrar confirmación.

**Flujos alternativos:** - El prestamo no fue registrado correctamente, el
flujo no reconocio el prestamo y no es posible realizar la devolucion correspondiente

**Postcondiciones:** - La devolución queda registrada. - El libro vuelve
a estar disponible según corresponda.

------------------------------------------------------------------------

# 6. DIAGRAMA DE CLASES

## 6.1 Descripción

Describir las principales clases utilizadas en el sistema y su
responsabilidad.

## 6.2 Diagrama de clases

Insertar aquí el diagrama de clases.

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/DIAGRAMA 6.2.png>)

## 6.3 Principales clases

  Clase             Responsabilidad
  ----------------- --------------------------------------------------------
  Libro             Representar y gestionar la información de los libros.
  Autor             Representar y gestionar los autores.
  Categoria         Representar las categorías de los libros.
  Usuario           Representar los usuarios de la biblioteca.
  Prestamo          Gestionar la información de los préstamos.
  DetallePrestamo   Relacionar los libros incluidos en un préstamo.
  Devolucion        Gestionar las devoluciones y calcular retrasos/multas.


## 6.4 Aplicación de POO

Explicar cómo se aplicaron:

-   Clases.
-   Objetos.
-   Constructores.
-   Métodos.
-   Propiedades.
-   Encapsulamiento.
-   Colecciones.
-   Herencia, si aplica.
-   Polimorfismo, si aplica.
-   Sobrecarga, si aplica.

------------------------------------------------------------------------

# 7. MODELO ENTIDAD-RELACIÓN

## 7.1 Descripción

Explicar el modelo de datos diseñado para almacenar la información del
sistema.

## 7.2 Diagrama entidad-relación

Insertar aquí el modelo entidad-relación.

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/DIAGRAMA 7.2.png>)

## 7.3 Relaciones principales

En el sistema, las entidades se conectan entre sí mediante relaciones que reflejan cómo funciona una biblioteca en la práctica.

-   Un autor puede escribir varios libros, mientras que cada libro pertenece a un único autor principal.
-   Una categoría puede agrupar muchos libros, y un libro puede asociarse a una categoría.
-   Un usuario puede solicitar muchos préstamos a lo largo del tiempo.
-   Un préstamo puede incluir uno o más libros, según lo que el usuario se lleve en esa operación.
-   Cada detalle de préstamo corresponde a un solo libro.
-   Un detalle de préstamo puede dar lugar a una devolución que registre el momento en que el libro regresa a la biblioteca.


------------------------------------------------------------------------

# 8. DICCIONARIO DE DATOS

## 8.1 Convenciones

  Abreviatura   Significado
  ------------- -----------------------------
  PK            Clave primaria
  FK            Clave foránea
  UQ            Campo con valor único
  NULL          Campo que puede estar vacío
  NOT NULL      Campo obligatorio

## 8.2 Tabla: Autor

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ --------------------------------
  idAutor           INT            PK      No     Identificador único del autor.
  nombre            VARCHAR(100)   \-      No     Nombre del autor.
  apellidos         VARCHAR(100)   \-      No     Apellidos del autor.
  nacionalidad      VARCHAR(50)    \-      Sí     Nacionalidad del autor.
  fechaNacimiento   DATE           \-      Sí     Fecha de nacimiento.

## 8.3 Tabla: Categoria

  Campo         Tipo de dato   Clave   Nulo   Descripción
  ------------- -------------- ------- ------ --------------------------------------
  idCategoria   INT            PK      No     Identificador único de la categoría.
  nombre        VARCHAR(50)    UQ      No     Nombre de la categoría.
  descripcion   VARCHAR(200)   \-      Sí     Descripción de la categoría.

## 8.4 Tabla: Libro

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ -----------------------------------
  idLibro           INT            PK      No     Identificador único del libro.
  codigo            VARCHAR(20)    UQ      No     Código único del libro.
  titulo            VARCHAR(200)   \-      No     Título del libro.
  anioPublicacion   INT            \-      Sí     Año de publicación.
  idAutor           INT            FK      No     Autor asociado al libro.
  idCategoria       INT            FK      No     Categoría del libro.
  cantidad          INT            \-      No     Cantidad de ejemplares.
  estado            VARCHAR(20)    \-      No     Estado del libro.
  sinopsis          VARCHAR(500)   \-      Sí     Descripción o sinopsis del libro.

## 8.5 Tabla: Usuario

  Campo             Tipo de dato   Clave   Nulo   Descripción
  ----------------- -------------- ------- ------ ----------------------------------
  idUsuario         INT            PK      No     Identificador único del usuario.
  documento         VARCHAR(20)    UQ      No     Número de documento.
  tipoDocumento     VARCHAR(20)    \-      No     Tipo de documento.
  nombre            VARCHAR(100)   \-      No     Nombre del usuario.
  apellidos         VARCHAR(100)   \-      No     Apellidos del usuario.
  direccion         VARCHAR(150)   \-      Sí     Dirección del usuario.
  telefono          VARCHAR(20)    \-      Sí     Teléfono de contacto.
  correo            VARCHAR(100)   \-      Sí     Correo electrónico.
  fechaNacimiento   DATE           \-      Sí     Fecha de nacimiento.
  estado            VARCHAR(20)    \-      No     Estado del usuario.

## 8.6 Tabla: Prestamo

  Campo           Tipo de dato   Clave   Nulo   Descripción
  --------------- -------------- ------- ------ -----------------------------------
  idPrestamo      INT            PK      No     Identificador único del préstamo.
  idUsuario       INT            FK      No     Usuario que realiza el préstamo.
  fechaPrestamo   DATETIME       \-      No     Fecha del préstamo.
  estado          VARCHAR(20)    \-      No     Estado del préstamo.

## 8.7 Tabla: DetallePrestamo

  ---------------------------------------------------------------------------------------
  Campo                     Tipo de dato    Clave          Nulo           Descripción
  ------------------------- --------------- -------------- -------------- ---------------
  idDetalle                 INT             PK             No             Identificador
                                                                          único del
                                                                          detalle.

  idPrestamo                INT             FK             No             Préstamo al que
                                                                          pertenece.

  idLibro                   INT             FK             No             Libro prestado.

  fechaDevolucionEstimada   DATE            \-             No             Fecha estimada
                                                                          de devolución.

  fechaDevolucionReal       DATE            \-             Sí             Fecha real de
                                                                          devolución.

  valor                     DECIMAL(10,2)   \-             No             Valor asociado
                                                                          al préstamo, si
                                                                          aplica.

  multa                     DECIMAL(10,2)   \-             Sí             Valor de la
                                                                          multa generada.

  estado                    VARCHAR(20)     \-             No             Estado del
                                                                          detalle.
  ---------------------------------------------------------------------------------------

## 8.8 Tabla: Devolucion

  Campo             Tipo de dato    Clave   Nulo   Descripción
  ----------------- --------------- ------- ------ ---------------------------------------
  idDevolucion      INT             PK      No     Identificador único de la devolución.
  idDetalle         INT             FK      No     Detalle del préstamo devuelto.
  fechaDevolucion   DATETIME        \-      No     Fecha de devolución.
  diasRetraso       INT             \-      No     Número de días de retraso.
  multa             DECIMAL(10,2)   \-      Sí     Valor de la multa, si aplica.



------------------------------------------------------------------------

# 9. ARQUITECTURA DEL SISTEMA

## 9.1 Descripción general

El Sistema de Gestión de Biblioteca se desarrolla utilizando una
**arquitectura por capas**, con el propósito de separar las
responsabilidades del sistema y facilitar su mantenimiento, organización
y evolución.

La arquitectura está compuesta por:

1.  Capa de Presentación.
2.  Capa de Lógica de Negocio.
3.  Capa de Acceso a Datos.
4.  Capa de Base de Datos.

## 9.2 Diagrama de arquitectura

Insertar aquí el diagrama de arquitectura.

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/DIAGRAMA 9.2.png>)

## 9.3 Capa de Presentación

**Responsabilidad:**

Es la capa mediante la cual el usuario interactúa con el sistema.

**Componentes:**

-   FrmPrincipal
-   FrmLibros
-   FrmAutores
-   FrmCategorias
-   FrmUsuarios
-   FrmPrestamos
-   FrmDevoluciones

**Tecnología utilizada:**

-   C#
-   Windows Forms
-   NET 8.0

## 9.4 Capa de Lógica de Negocio

**Responsabilidad:**

Procesa las solicitudes provenientes de la interfaz, aplica las reglas
de negocio y coordina las operaciones.

**Componentes:**

-   \[LibroController\]
-   \[AutorController\]
-   \[CategoriaController\]
-   \[UsuarioController\]
-   \[PrestamoController\]
-   \[DevolucionController\]

**Ejemplos de reglas:**

-   Validar disponibilidad.
-   Validar existencia del usuario.
-   Validar existencia del libro.
-   Calcular días de retraso.
-   Calcular multa.
-   Actualizar estados.

## 9.5 Capa de Acceso a Datos

**Responsabilidad:**

Gestiona la comunicación entre la aplicación y SQL Server.

**Componentes:**

-   \[Conexion\]
-   \[LibroDAO\]
-   \[AutorDAO\]
-   \[CategoriaDAO\]
-   \[UsuarioDAO\]
-   \[PrestamoDAO\]
-   \[DevolucionDAO\]

**Tecnologías utilizadas:**

-   SQL Server.
-   ADO.NET 
-   Consultas parametrizadas.

## 9.6 Capa de Base de Datos

La información del sistema se almacena en:

**Base de datos:** SwBiblioteca

**Tablas principales:**

-   Autor
-   Categoria
-   Libro
-   Usuario
-   Prestamo
-   DetallePrestamo
-   Devolucion

## 9.7 Flujo de información

``` text
Usuario
   ↓
Presentación
   ↓
Lógica de Negocio
   ↓
Acceso a Datos
   ↓
SQL Server
```

Las respuestas de la base de datos realizan el recorrido inverso hasta
llegar nuevamente a la interfaz.

------------------------------------------------------------------------

# 10. EXPLICACIÓN DE CADA MÓDULO DESARROLLADO

## 10.1 Módulo de libros

**Objetivo:** Mantener el catálogo de libros de la biblioteca, con sus datos principales y su estado de disponibilidad.

**Funcionalidades:**

-   Registrar nuevos libros en el catálogo.
-   Consultar la información de un libro.
-   Actualizar los datos de un libro.
-   Eliminar libros que ya no forman parte del acervo.
-   Buscar libros por título, autor o categoría.

**Validaciones:**

-   El ISBN debe ser único y tener un formato válido.
-   El título y el autor son campos obligatorios.

## 10.2 Módulo de autores

**Objetivo:** Gestionar la información de los autores asociados a los libros del catálogo.

**Funcionalidades:**

-   Registrar autores.
-   Consultar los datos de un autor y sus libros.
-   Actualizar la información de un autor.
-   Eliminar autores que no tengan libros asociados.

## 10.3 Módulo de categorías

**Objetivo:** Organizar los libros por temas o géneros para facilitar su clasificación y búsqueda.

**Funcionalidades:**

-   Registrar categorías.
-   Consultar las categorías existentes y los libros que contienen.
-   Actualizar el nombre o la descripción de una categoría.
-   Eliminar categorías que no tengan libros asociados.

## 10.4 Módulo de usuarios

**Objetivo:** Gestionar la información de las personas registradas como usuarios de la biblioteca, que son quienes pueden solicitar préstamos.

**Funcionalidades:**

-   Registrar nuevos usuarios con sus datos personales y de contacto.
-   Consultar la información de un usuario y su estado actual.
-   Actualizar los datos de contacto o de identificación de un usuario.
-   Eliminar usuarios que no tengan préstamos activos asociados.
-   Buscar usuarios por documento o nombre.

**Validaciones:**

-   El número de documento debe ser único en el sistema.
-   El tipo de documento, el nombre, los apellidos y el estado son campos obligatorios.
-   El correo electrónico, si se registra, debe tener un formato válido.

## 10.7 Módulo de consultas

**Consultas implementadas:**

-   Total de libros registrados.
-   Total de usuarios registrados.
-   Libros disponibles.
-   Libros prestados.
-   Usuarios con préstamos activos.
-   Historial de préstamos.



------------------------------------------------------------------------

# 11. CAPTURAS DE PANTALLA DEL SISTEMA

En esta sección se deben incluir evidencias de las principales
funcionalidades.

## 11.1 Menú principal

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA_MENU_PRINCIPAL.png>)

**Descripción:** \[MENU PRINCIPAL.\]

## 11.2 Gestión de libros

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA GESTIOR DE LIBROS.png>)

**Descripción:** \[PODEMOS AÑADIR,EDITAR O ELIMINAR UN LIBRO.\]

## 11.3 Gestión de autores

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA_GESTION_DE_AUTORES.png>)

**Descripción:** \[PODEMOS REVISAR LOS MULTIPLES AUTORES REGISTRADOS.\]


## 11.5 Gestión de usuarios

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA_GESTION_DE_USUARIOS.png>)
![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA_GESTION_DE_USUARIOS2.png>)

**Descripción:** \[PODREMOS AÑADIR, CONSULTAR O ELIMINAR USUARIOS, TAL CUAL LO MUESTRAN LAS CAPTURAS REALIZADAS.\]

## 11.6 Registro de préstamos

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA_REGISTRO_PRESTAMOS.png>)

**Descripción:** \[AQUI PODREMOS CONSULTAR O REGISTRAR PRESTAMOS.\]

## 11.7 Registro de devoluciones

![C:\Users\manub\Documents\GitHub\SwBiblioteca\IMAGENES](<IMAGENES/CAPTURA_REGISTRO_DE_DEVOLUCIONES.png>)

**Descripción:** \[PODEMOS REVISAR LOS REGISTROS DE DEVOLUCIONES.\]




------------------------------------------------------------------------

# 12. PRUEBAS DE FUNCIONAMIENTO

## 12.1 Estrategia de pruebas

Se realizo paso por paso solicitidado y las pruebas fueron adjuntadas en el archivo 12.3 y 11.

## 12.2 Casos de prueba

  ------------------------------------------------------------------------------------------
  ID          Funcionalidad   Entrada / Acción Resultado        Resultado       Estado
                                               esperado         obtenido        
  ----------- --------------- ---------------- ---------------- --------------- ------------
  CP01        Registrar libro Datos válidos    Libro registrado Comprobado      Aprobado
                                               correctamente                    

  CP02        Registrar libro Código repetido  Mostrar mensaje  Comprobado      Aprobado
                                               de validación                    

  CP03        Registrar       Datos válidos    Usuario          Comprobado      Aprobado
              usuario                          registrado                       

  CP04        Registrar       Libro disponible Préstamo         Comprobado      Aprobado
              préstamo                         registrado y                     
                                               disponibilidad                   
                                               actualizada                      

  CP05        Registrar       Libro sin        No permitir el   Comprobado      Aprobado
              préstamo        disponibilidad   préstamo                         

  CP06        Registrar       Préstamo activo  Registrar        Comprobado      Aprobado
              devolución                       devolución y                     
                                               actualizar                       
                                               disponibilidad                   

  CP07        Devolución con  Fecha posterior  Calcular retraso  Comprobado     Aprobado
              retraso         a la estimada    y multa                          

  CP08        Consulta        Consultar libros Mostrar libros   Comprobado      Aprobado
                              disponibles      disponibles                      


                     
  ------------------------------------------------------------------------------------------

## 12.3 Evidencias de pruebas

Insertar capturas que demuestren los resultados de las pruebas.

### Prueba CP01

![Evidencia CP01](ruta/prueba01.png)

**Resultado:** \[Descripción.\]

### Prueba CP02

![Evidencia CP02](ruta/prueba02.png)

**Resultado:** \[Descripción.\]

------------------------------------------------------------------------

# 13. CONCLUSIONES

## Conclusión 1

Aprendi bastante durante este proyecto, fue mi primer aplicativo creado y me entretuve bastante aunque no fue para nada sencillo

## Conclusión 2

Programacion Orienta a Objetos me ayudo bastante a entender a mayor profundidad como funcionan este tipo de programas y conceptos como la heriencia POO me ayudaron a que fuera mas facil de ejecutar

## Conclusión 3

Bases de datos fue el mayor reto durante todo el aplicativo, no habia tenido nunca un acercamiento con SQL y aun asi gracias a los tips de la docente pude entender su funcionalidad y pude aplicarlo sin problema

## Conclusión 4

Uno de los mayores retos fue intentar aplicar guias recomendadas por el copilot integrado de visual studio, lo cual llevo a que mi codigo se corrompiera y tuviera que iniciar desde 0, por suerte fue en las primeras semanas, esto hizo que para la segunda vez me motivara a trabajar sin ayuda de IA y pudiera sacarlo adelante, adicional fue muy entrenido trabajar por primera vez con C# dado que solo estaba acostumbrado a usar Python

------------------------------------------------------------------------

# 14. RECOMENDACIONES

-   Una recomendacion clave enfrentanda durante la creacion del proyecto seria buscar compañeros para futuras entregas y asi reducir la carga de trabajo acumulado
-   Evitaria el uso de cualquier herramienta 3era con el proposito de proteger mi codigo aun mas y evitar que lo puedan robar
-   Me gustaria añadir a futuros proyectos una pagina de soporte para que el usuario final pueda dejar feedbacks o reportar errores que puedan enfrentar con el programa


------------------------------------------------------------------------


# ANEXOS

## Anexo A. Repositorio GitHub

**Repositorio:** \[Enlace al repositorio\]

## Anexo B. Script de base de datos

**Archivo:** `[Nombre del archivo .sql]`

## Anexo C. Evidencia de Git y GitHub

Insertar capturas que evidencien:

-   Creación del repositorio.

-   Commits realizados.

-   Organización del proyecto.

-   Publicación del código.

-   README.md.



------------------------------------------------------------------------

# LISTA DE VERIFICACIÓN ANTES DE ENTREGAR

-   [ ] Portada.
-   [ ] Contraportada.
-   [ ] Introducción.
-   [ ] Objetivos.
-   [ ] Tabla de contenido.
-   [ ] Numeración de páginas.
-   [ ] Planteamiento del problema.
-   [ ] Análisis de requerimientos.
-   [ ] Casos de uso.
-   [ ] Diagrama de casos de uso.
-   [ ] Diagrama de clases.
-   [ ] Modelo entidad-relación.
-   [ ] Diccionario de datos.
-   [ ] Arquitectura del sistema.
-   [ ] Explicación de cada módulo.
-   [ ] Capturas de pantalla.
-   [ ] Pruebas de funcionamiento.
-   [ ] Conclusiones.
-   [ ] Recomendaciones.
-   [ ] Código fuente completo.
-   [ ] Script SQL.
-   [ ] Datos de prueba.
-   [ ] Repositorio GitHub.
-   [ ] README.md.
-   [ ] Evidencia de commits.

------------------------------------------------------------------------
