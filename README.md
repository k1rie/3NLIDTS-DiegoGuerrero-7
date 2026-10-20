# Actividad 07 - Encendiendo LED (Arduino) · C# Windows Forms

Programación Avanzada · 3° "N" · LIDTS · UNACH

Formulario con dos botones que mandan un carácter por el puerto serie a un Arduino UNO:
**Encender LED** envía `a` y **Apagar LED** envía `b` (pin 13).

## Requisitos
- .NET SDK 10 (Windows)
- VS Code con la extensión C# (`ms-dotnettools.csharp`)
- Arduino UNO con el sketch de `arduino/led_serial/led_serial.ino`

## Ejecutar
1. Sube el sketch al Arduino y revisa su puerto en el IDE de Arduino (en `Form1.cs` está `COM7`; cámbialo si es otro).
2. Abre esta carpeta en VS Code y pulsa **F5**, o en la terminal:

```
dotnet run
```
