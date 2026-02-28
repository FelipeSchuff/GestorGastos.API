# 💸 Gestor de Gastos - Full Stack Application

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET 8](https://img.shields.io/badge/.NET_8-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![JWT](https://img.shields.io/badge/JWT-black?style=for-the-badge&logo=JSON%20web%20tokens)
![JavaScript](https://img.shields.io/badge/JavaScript-F7DF1E?style=for-the-badge&logo=javascript&logoColor=black)
![Bootstrap](https://img.shields.io/badge/Bootstrap-563D7C?style=for-the-badge&logo=bootstrap&logoColor=white)
![Chart.js](https://img.shields.io/badge/Chart.js-FF6384?style=for-the-badge&logo=chartdotjs&logoColor=white)

## 📌 Descripción del Proyecto
Aplicación Full Stack diseñada para el control y análisis de finanzas personales con un sistema de seguridad completo. Permite a los usuarios registrarse, iniciar sesión y gestionar sus movimientos financieros de forma privada, ofreciendo un panel analítico en tiempo real. 

Este proyecto demuestra la implementación de una arquitectura cliente-servidor segura, donde una RESTful API protegida por Tokens JWT se comunica de forma asíncrona con una interfaz de usuario dinámica y responsiva.

## 🚀 Características Principales (Features)
* **🔐 Autenticación y Seguridad:** Sistema de Login y Registro. Contraseñas encriptadas con BCrypt y protección de endpoints mediante JSON Web Tokens (JWT).
* **CRUD Completo:** Creación, lectura, actualización y eliminación de registros financieros.
* **Dashboard Analítico:** Visualización de gastos por categoría mediante gráficos dinámicos (Chart.js) actualizados en tiempo real.
* **Cálculo de Balance:** Motor de suma automática procesada del lado del servidor utilizando LINQ.
* **Experiencia de Usuario (UX):** Diseño responsivo con tema oscuro inteligente basado en el horario del sistema, animaciones suaves y gestión de sesiones con LocalStorage.
* **CORS Configurado:** Políticas de seguridad implementadas para permitir el consumo seguro de la API desde el cliente web.

## 🛠️ Stack Tecnológico

**Backend (API Rest):**
* Lenguaje: C#
* Framework: .NET 8 (ASP.NET Core Web API)
* ORM: Entity Framework Core
* Seguridad: JWT Bearer Authentication & BCrypt.Net
* Arquitectura: Inyección de Dependencias, Controladores y LINQ.

**Frontend (Cliente Web):**
* Estructura: HTML5
* Diseño y UI: CSS3, Bootstrap 5.3
* Lógica y Peticiones: Vanilla JavaScript (Fetch API) con inyección de Headers de Autorización.
* Visualización de Datos: Chart.js

**Base de Datos:**
* Motor: SQL Server (LocalDB)
* Enfoque: Code-First Migrations (Tablas relacionales para Usuarios y Gastos)

## 🎥 Demo del Proyecto
![demo-gestor](https://github.com/user-attachments/assets/30de9fb5-a5e3-4bbc-b4ba-91063b882da1)

## ⚙️ Instalación y Ejecución Local

Para correr este proyecto en tu entorno local:

**1. Clona este repositorio:**
Abre tu terminal o consola y ejecuta:
`git clone https://github.com/FelipeSchuff/GestorGastos.API.git`

**2. Abre la solución:**
Abre el proyecto clonado en Visual Studio.

**3. Crea la base de datos:**
Abre la Consola del Administrador de Paquetes (Package Manager Console) en Visual Studio y ejecuta el siguiente comando para generar las tablas de usuarios y gastos:
`Update-Database`

**4. Ejecuta el servidor (F5):** Inicia el proyecto para que la API quede encendida y escaneando credenciales.

**5. Abre la aplicación:**
Haz doble clic en tu archivo `index.html` en cualquier navegador web para interactuar con la interfaz gráfica Full Stack.

---
*Desarrollado por [Felipe Schuffeneger](https://github.com/FelipeSchuff)*
