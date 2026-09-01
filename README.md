# WindowsFormsShutdown

Utilidad de escritorio para Windows (WinForms, .NET 10) que programa el
**apagado**, **reinicio** o **hibernación** del equipo, ya sea por un tiempo
relativo (días/horas/minutos/segundos) o en una fecha y hora exactas.

## Características

- **Tres acciones**: Apagar, Reiniciar o Hibernar.
- **Dos formas de programar**: por tiempo relativo o por fecha/hora exacta
  (calendario + selector de hora).
- **Cuenta atrás en pantalla** (`Dd HH:MM:SS`), actualizada cada segundo, con
  botón **Cancelar** para abortar en cualquier momento.
- El contador se pone en **rojo** cuando quedan 30 segundos o menos.
- Mientras la cuenta atrás corre se bloquean los controles de configuración
  para evitar cambios accidentales.
- Los comandos `shutdown` se ejecutan sin abrir ventana de consola.

## Cómo funciona

La app usa el comando `shutdown` de Windows:

| Acción     | Comando            |
|------------|---------------------|
| Apagar     | `shutdown /s /f /t 0` |
| Reiniciar  | `shutdown /r /f /t 0` |
| Hibernar   | `shutdown /h`          |

Como `shutdown /h` no admite temporizador (`/t` solo funciona con `/s` y
`/r`), el conteo se gestiona **dentro de la aplicación** en los tres casos, y
el comando correspondiente se dispara recién al llegar a cero (o al pulsar
Ejecutar si no hay espera).

## Requisitos

- Windows
- [.NET 10 SDK/Runtime](https://dotnet.microsoft.com/) (`net10.0-windows`)

## Compilar y ejecutar

```
dotnet build WindowsFormsShutdown.sln
dotnet run --project WindowsFormsShutdown
```

O abrir `WindowsFormsShutdown.sln` en Visual Studio y ejecutar (F5).

## Historial

Ver [`CHANGELOG.md`](CHANGELOG.md).
