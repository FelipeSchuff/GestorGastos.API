# 💸 Gestor de Gastos - Full Stack Application

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)
![Chart.js](https://img.shields.io/badge/Chart.js-FF6384?style=for-the-badge&logo=chartdotjs&logoColor=white)

## 📌 Descripción del Proyecto
Aplicación Full Stack diseñada para el control y análisis de finanzas personales. Permite a los usuarios registrar, editar, categorizar y eliminar movimientos financieros de forma intuitiva, ofreciendo un panel analítico en tiempo real. 

Este proyecto demuestra la implementación de una arquitectura cliente-servidor, donde una RESTful API robusta se comunica de forma asíncrona con una interfaz de usuario dinámica y responsiva.

## 🚀 Características Principales (Features)
* **CRUD Completo:** Creación, lectura, actualización y eliminación de registros financieros.
* **Dashboard Analítico:** Visualización de gastos por categoría mediante gráficos dinámicos (Chart.js) actualizados en tiempo real.
* **Cálculo de Balance:** Motor de suma automática procesada del lado del servidor utilizando LINQ.
* **Validaciones de Seguridad:** Uso de Data Annotations en el Backend para asegurar la integridad de los datos (prevención de montos negativos y campos nulos).
* **Experiencia de Usuario (UX):** Diseño responsivo con tema oscuro inteligente basado en el horario del sistema, transiciones suaves y notificaciones interactivas.
* **CORS Configurado:** Políticas de seguridad implementadas para permitir el consumo seguro de la API.

## 🛠️ Stack Tecnológico

**Backend (API Rest):**
* Lenguaje: C#
* Framework: .NET 8 (ASP.NET Core Web API)
* ORM: Entity Framework Core
* Arquitectura: Inyección de Dependencias, Controladores y LINQ.

**Frontend (Cliente Web):**
* Estructura: HTML5
* Diseño y UI: CSS3, Bootstrap 5.3
* Lógica y Peticiones: Vanilla JavaScript (Fetch API)
* Visualización de Datos: Chart.js

**Base de Datos:**
* Motor: SQL Server (LocalDB)
* Enfoque: Code-First Migrations

## 📸 Capturas de Pantalla

* **Dashboard Analítico:**
  <img width="1879" height="575" alt="imagen" src="https://github.com/user-attachments/assets/d584d7c2-3cb3-495d-8075-7934b4ebb237" />

* **Modo Edición:**
  <img width="1872" height="615" alt="imagen" src="https://github.com/user-attachments/assets/024bcea9-5df5-43f2-bb24-84c4a757196d" />

## ⚙️ Instalación y Ejecución Local

Para correr este proyecto en tu entorno local:

1. Clona este repositorio:
git clone https://github.com/FelipeSchuff/GestorGastos.API.git

2. Abre la solución en Visual Studio.

3. Abre la Consola del Administrador de Paquetes (Package Manager Console) y ejecuta la migración para crear la base de datos:
Update-Database

4. Ejecuta el proyecto (F5) para iniciar el servidor local.

5. Abre el archivo index.html en cualquier navegador web para interactuar con la interfaz gráfica.

---
*Desarrollado por [Felipe Schuffeneger](https://github.com/FelipeSchuff)*
