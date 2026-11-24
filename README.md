# Calculadora de Escritorio en C# (.NET Windows Forms)

## 1. Descripción general
Aplicación de escritorio desarrollada en C# utilizando Windows Forms (.NET) que simula el funcionamiento de una calculadora básica convencional, permitiendo realizar operaciones aritméticas fundamentales mediante una interfaz gráfica intuitiva y segura.

## 2. Objetivos
* Aplicar los fundamentos de la programación orientada a eventos en C# y .NET Windows Forms.
* Diseñar una interfaz gráfica organizada, uniforme y de solo lectura en su pantalla de resultados.
* Validar entradas del usuario y gestionar excepciones matemáticas como la división para cero.
* Documentar y gestionar el código fuente mediante control de versiones en GitHub.

## 3. Características principales
* Ingreso de valores numéricos del `0` al `9` mediante botones en pantalla.
* Ejecución de las cuatro operaciones aritméticas básicas: suma (`+`), resta (`-`), multiplicación (`×`) y división (`÷`).
* Pantalla digital (`TextBox`) configurada en modo solo lectura (`ReadOnly = true`) para evitar edición manual errónea.
* Botón de reinicio (`C`) para limpiar la pantalla y restablecer las variables de estado.
* Soporte para operaciones consecutivas sin necesidad de cerrar la aplicación.
* Control de errores mediante validaciones con `double.TryParse()` y alertas claras (`MessageBox`) ante divisiones para cero u operaciones incompletas.

## 4. Tecnologías utilizadas
* **Lenguaje de programación:** C#
* **Framework / Plataforma:** .NET (Windows Forms App)
* **Entorno de desarrollo:** Visual Studio Community 2026
* **Control de versiones:** Git y GitHub

## 5. Requisitos de instalación
* Sistema operativo Windows 10 o Windows 11.
* SDK de .NET 8.0 o superior instalado.
* Visual Studio 2022 o 2026 con la carga de trabajo **Desarrollo de escritorio de .NET**.

## 6. Instrucciones de ejecución
1. Clonar este repositorio en su equipo local:
   ```bash
   git clone [https://github.com/xjefflx/PPE03_Limones_Jeff_Calculadora.git](https://github.com/xjefflx/PPE03_Limones_Jeff_Calculadora.git)
