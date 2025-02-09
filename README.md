# Sistema de Finanzas - Gestión de Préstamos y Clientes

[![Build Status](https://img.shields.io/travis/usuario/sistema-finanzas.svg)](https://travis-ci.org/usuario/sistema-finanzas)
[![Versión](https://img.shields.io/github/release/usuario/sistema-finanzas.svg)](https://github.com/usuario/sistema-finanzas/releases)

## Descripción

El **Sistema de Finanzas** es una aplicación diseñada para gestionar préstamos, amortizaciones y clientes de manera eficiente. Permite realizar simulaciones de préstamos, visualizar los pagos periódicos, calcular amortizaciones y gestionar la información de los clientes de manera intuitiva.

Este sistema está desarrollado en **C#** utilizando **WinForms** para una interfaz gráfica amigable y fácil de usar.

## Características

- **Gestión de Préstamos**: Permite registrar préstamos, calcular intereses y ver el estado de los pagos.
- **Amortización**: Calcula las tablas de amortización de los préstamos y muestra los pagos mensuales.
- **Gestión de Clientes**: Añade, edita y elimina información de clientes.
- **Interfaz Amigable**: Interfaz gráfica construida con WinForms que facilita la interacción.
- **Reportes**: Generación de reportes detallados sobre préstamos y pagos.

## Tabla de Contenidos
- [Instalación](#instalación)
- [Uso](#uso)
- [Contribución](#contribución)
- [Reconocimientos](#reconocimientos)

## Instalación

Para instalar y configurar el sistema en tu entorno local, sigue estos pasos:

### Requisitos

- **.NET Framework 4.8 o superior**
- **Visual Studio 2019 o superior**

### Pasos de instalación

1. Clona este repositorio:
   ```bash
   git clone https://github.com/usuario/sistema-finanzas.git
2. Abre el proyecto en Visual Studio.

3. Restaura las dependencias NuGet si es necesario.

4. Compila y ejecuta la aplicación desde Visual Studio:

-    En el menú de Visual Studio, selecciona Compilar -> Compilar solución.
-    Luego ejecuta el proyecto con F5 o Ctrl + F5.
-    La aplicación debería abrirse en una ventana de WinForms, lista para usar.
  
5. La aplicación debería abrirse en una ventana de WinForms, lista para usar.

### Uso
Una vez que hayas instalado el sistema, sigue los siguientes pasos para utilizarlo:

**1. Gestión de Clientes:**
- En la sección "Clientes", puedes agregar nuevos clientes con su nombre, dirección y contacto.
- Puedes editar o eliminar registros existentes.

**2. Registrar un Préstamo:**
- Dirígete a la sección "Préstamos" y agrega un nuevo préstamo para un cliente.
- La aplicacion por si sola Calculara todas la condiciones como(monto, interes, etc...) en base a su cliente.

**3. Amortización:**
- En la sección "Amortización", puedes ver la tabla de amortización completa del préstamo, incluyendo el deposito y los pagos realizados.

**4. Generar Reportes:**
- Genera reportes detallados sobre préstamos y clientes para obtener una visión clara de las finanzas.

### Contribución
¡Las contribuciones son bienvenidas! Si deseas mejorar el sistema o agregar nuevas funcionalidades, sigue estos pasos:

- Haz un fork de este repositorio.
- Crea una rama para tu nueva característica (```git checkout -b feature-nueva-caracteristica```).
- Realiza los cambios y haz un commit (```git commit -m 'Agregar nueva característica'```).
- Sube los cambios (```git push origin feature-nueva-caracteristica```).
- Crea un pull request describiendo los cambios realizados.

### Reconocimientos:
- Gracias a los desarrolladores de ```WinForms``` por la plataforma que hace posible esta aplicación.
