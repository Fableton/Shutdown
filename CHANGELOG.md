# Changelog

Todos los cambios notables de este proyecto se documentan en este archivo.

El formato está basado en [Keep a Changelog](https://keepachangelog.com/es-ES/1.1.0/)
y el proyecto sigue [Versionado Semántico](https://semver.org/lang/es/).

## [2.1.0] - 2026-05-31

### Añadido
- **Cuenta atrás interna** para todas las acciones (apagar, reiniciar e
  hibernar): un contador en tamaño grande muestra el tiempo restante
  (`Dd HH:MM:SS`) actualizado cada segundo.
- **Botón Cancelar** que detiene la cuenta atrás en cualquier momento y
  rehabilita los controles.
- El contador **cambia a rojo cuando quedan 30 segundos o menos**.

### Cambiado
- El temporizador ya **no se delega al parámetro `/t` de `shutdown`**; la
  aplicación gestiona el conteo internamente. Apagar y reiniciar se ejecutan
  con `/t 0` justo al llegar a cero.
- Mientras la cuenta atrás está activa se deshabilitan el selector de tipo de
  apagado y las pestañas de tiempo/fecha para evitar cambios accidentales.
- La ventana se amplió para alojar el contador y el botón de cancelar.

## [2.0.0] - 2026-05-31

### Añadido
- Opción **Hibernar**: nuevo radio button junto a *Apagar* y *Reiniciar*.
  Como `shutdown /h` de Windows no admite temporizador (`/t` solo funciona con
  `/s` y `/r`), la aplicación permanece abierta con un temporizador interno y
  dispara la hibernación (`shutdown /h`) al cumplirse el tiempo o la fecha
  configurada.
- `CHANGELOG.md` para registrar los cambios del proyecto.

### Cambiado
- **Migración de .NET Framework 4.0 a .NET 10** (`net10.0-windows`).
- `.csproj` reescrito al formato SDK moderno (inclusión implícita de archivos,
  metadatos del ensamblado en el propio proyecto).
- Los comandos `shutdown` ahora se ejecutan sin abrir una ventana de consola
  (`CreateNoWindow` / `UseShellExecute = false`).
- Las etiquetas de resultado y el cuadro de confirmación reflejan la acción
  correcta (Apagará / Reiniciará / Hibernará).

### Corregido
- Selección de tipo de apagado: se eliminó el alternado manual de los radio
  buttons (frágil con tres opciones); ahora la exclusividad la gestiona el
  `GroupBox`.

### Eliminado
- `Properties/AssemblyInfo.cs` (sus metadatos se definen ahora en el `.csproj`).
- `Properties/Settings.settings` y `Properties/Settings.Designer.cs` (no se
  usaban y arrastraban una dependencia de `System.Configuration`).

## [1.0.0] - 2013

### Añadido
- Versión inicial en .NET Framework 4.0: apagar o reiniciar el equipo por
  tiempo (días/horas/minutos/segundos) o en una fecha y hora exactas.
