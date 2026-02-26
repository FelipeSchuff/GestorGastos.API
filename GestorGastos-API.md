# 🌐 Gestor de Gastos - RESTful API

Una API RESTful construida con **ASP.NET Core 8** y **C#**, diseñada para gestionar operaciones financieras. Este proyecto representa la evolución de un sistema de consola tradicional hacia una arquitectura web escalable, separando completamente la lógica del servidor (Backend) de la interfaz de usuario.

## 🚀 Características Técnicas

* **Arquitectura REST:** Implementación de controladores de API utilizando los verbos HTTP estándar (`GET`, `POST`, `PUT`, `DELETE`) para el manejo de recursos.
* **CRUD Completo vía Web:** Capacidad para crear, leer, actualizar y eliminar registros de gastos interactuando mediante peticiones web en formato **JSON**.
* **Persistencia de Datos:** Integración con **SQL Server** LocalDB mediante **Entity Framework Core** (ORM).
* **Documentación Interactiva:** Uso de **Swagger (OpenAPI)** integrado de forma nativa para testear y visualizar los *endpoints* sin necesidad de herramientas externas como Postman.
* **Auto-generación de IDs y Fechas:** Lógica de negocio encapsulada en el controlador para calcular timestamps dinámicos y delegar la creación de llaves primarias a la base de datos.

## 🛠️ Tecnologías Utilizadas

* **Framework:** .NET 8 (ASP.NET Core Web API)
* **Lenguaje:** C#
* **Base de Datos:** SQL Server (LocalDB)
* **ORM:** Entity Framework Core 8.0.x
* **Documentación de API:** Swagger / Swashbuckle

## 🎮 Cómo ejecutar el proyecto localmente

1. Clona el repositorio en tu máquina.
2. Abre la solución `.sln` en Visual Studio 2022.
3. Asegúrate de tener aplicadas las migraciones de Entity Framework (`Update-Database` en la consola del administrador de paquetes).
4. Ejecuta el proyecto (F5).
5. Tu navegador abrirá automáticamente la interfaz de **Swagger** (en `https://localhost:<puerto>/swagger`), desde donde podrás interactuar visualmente con todos los *endpoints* de la API.