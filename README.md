<div align="center">

# 🔧 Gestor de Taller de Vehículos

**Sistema de escritorio para la gestión de vehículos y órdenes de servicio en un taller mecánico**

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET_Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows_Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)

</div>

---

## 📋 Descripción

**Gestor de Taller de Vehículos** es una aplicación de escritorio desarrollada en **C# con Windows Forms** que permite administrar el registro de vehículos y sus respectivas órdenes de servicio dentro de un taller mecánico.

El sistema aplica el patrón de diseño **MVC (Modelo - Vista - Controladora)** separando claramente la lógica de negocio de la interfaz de usuario, con manejo de colecciones en memoria usando `List<T>` y LINQ.

---

## ✨ Funcionalidades

| Módulo | Descripción |
|---|---|
| 🚗 **Registro de Vehículos** | Alta de vehículos con placa, modelo, color, número de motor y tarjeta de propiedad |
| 📄 **Órdenes de Servicio** | Asociación de órdenes de servicio a un vehículo registrado |
| 📊 **Reportes** | Consultas y listados con criterios de filtrado y ordenamiento |

### 📊 Reportes disponibles

- 🔤 Listar vehículos en forma **ascendente según placa**
- 💰 Listar vehículos con el **mayor monto total cancelado según tipo de servicio**
- 📅 Listar vehículos con el **mayor número de órdenes en los dos últimos años**
- 🔧 Listar vehículos con el **menor número de mantenimientos realizados**

---

## 🏗️ Arquitectura del Proyecto

```
gestor-taller-vehiculos/
├── COrdenServicio.cs          → Modelo: Orden de Servicio
├── CVehiculo.cs               → Modelo: Vehículo (contiene lista de órdenes)
├── CControladora.cs           → Controladora: toda la lógica de negocio
├── Program.cs                 → Punto de entrada de la aplicación
│
└── Vistas (Windows Forms)
    ├── frmMain                → Menú principal con navegación
    ├── frmVehiculo            → Registro y visualización de vehículos
    ├── frmOrdenServicio       → Registro de órdenes de servicio
    └── frmListar...           → Formularios de reportes (×4)
```

---

## 🚀 Cómo ejecutar el proyecto

### Pre-requisitos

- Windows 10 o superior
- [Visual Studio 2019+](https://visualstudio.microsoft.com/) con carga de trabajo **Desarrollo de escritorio .NET**
- .NET Framework 4.7.2 o superior

### Pasos

1. Clona el repositorio:
   ```bash
   git clone https://github.com/LuisUmina/gestor-taller-vehiculos.git
   ```

2. Abre el archivo de solución en Visual Studio:
   ```
   gestor-taller-vehiculos.sln
   ```

3. Compila y ejecuta con `F5` o el botón ▶️ **Iniciar**

> **Nota:** Los datos son en memoria — se reinician al cerrar la aplicación.

---

## 📄 Enunciado del ejercicio

El enunciado completo con los requerimientos del sistema está disponible en:
📎 [`docs/enunciado.pdf`](docs/enunciado.pdf)

---

## 🎬 Desarrollo paso a paso en YouTube

> Serie de 4 videos que documenta el desarrollo completo del sistema: desde la definición de modelos y la controladora hasta los formularios de registro y los reportes con LINQ.

<table>
  <tr>
    <td align="center" width="50%">
      <a href="https://www.youtube.com/watch?v=fyQDMle56Ho">
        <img src="https://img.youtube.com/vi/fyQDMle56Ho/hqdefault.jpg" width="100%" alt="Parte 1 - Introducción y estructura"/>
      </a>
      <br/>
      <a href="https://www.youtube.com/watch?v=fyQDMle56Ho">
        <strong>Parte 1 · Introducción, modelos y estructura</strong>
      </a>
      <br/>
      <sub>⏱ 1:57</sub>
    </td>
    <td align="center" width="50%">
      <a href="https://www.youtube.com/watch?v=sRKym-IYqsE">
        <img src="https://img.youtube.com/vi/sRKym-IYqsE/hqdefault.jpg" width="100%" alt="Parte 2 - Controladora y vehículos"/>
      </a>
      <br/>
      <a href="https://www.youtube.com/watch?v=sRKym-IYqsE">
        <strong>Parte 2 · Controladora, vehículos y ListView</strong>
      </a>
      <br/>
      <sub>⏱ 25:09</sub>
    </td>
  </tr>
  <tr>
    <td align="center" width="50%">
      <a href="https://www.youtube.com/watch?v=Mr0qFMEyocM">
        <img src="https://img.youtube.com/vi/Mr0qFMEyocM/hqdefault.jpg" width="100%" alt="Parte 3 - Órdenes de servicio y LINQ"/>
      </a>
      <br/>
      <a href="https://www.youtube.com/watch?v=Mr0qFMEyocM">
        <strong>Parte 3 · Órdenes de servicio y consultas LINQ</strong>
      </a>
      <br/>
      <sub>⏱ 53:50</sub>
    </td>
    <td align="center" width="50%">
      <a href="https://www.youtube.com/watch?v=-RlQD4occ4w">
        <img src="https://img.youtube.com/vi/-RlQD4occ4w/hqdefault.jpg" width="100%" alt="Parte 4 - Reportes y cierre"/>
      </a>
      <br/>
      <a href="https://www.youtube.com/watch?v=-RlQD4occ4w">
        <strong>Parte 4 · Reportes avanzados y cierre del sistema</strong>
      </a>
      <br/>
      <sub>⏱ 45:08</sub>
    </td>
  </tr>
</table>

---

## 🧩 Conceptos aplicados

- ✅ Programación Orientada a Objetos (POO)
- ✅ Patrón MVC (Modelo - Vista - Controladora)
- ✅ Colecciones genéricas `List<T>` y multilistas
- ✅ LINQ (`.OrderBy()`, `.Exists()`, `.Count()`, `.Find()`)
- ✅ Windows Forms (ListView, MenuStrip, ComboBox)
- ✅ Validación de datos en formularios

---

## 👤 Autor

**Luis Umina**

[![GitHub](https://img.shields.io/badge/GitHub-181717?style=flat&logo=github&logoColor=white)](https://github.com/LuisUmina)

---

<div align="center">
<sub>Desarrollado con ❤️ en C# · Windows Forms · Visual Studio</sub>
</div>
