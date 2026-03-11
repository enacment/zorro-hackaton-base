# Zorro.Template.App

Plantilla base para arrancar cualquier app del hackatón sin sobrecomplicar.

## Incluye
- Autenticación simple embebida en proyecto (login/logout + guard).
- Punto de extensión para autenticación real vía DLL.
- Navegación base (Shell + rutas mínimas).
- Healthcheck de app y backend.

## Estructura
```txt
src/
  Auth/
    IAuthProvider.cs
    MockAuthProvider.cs
    LegacyDllAuthProvider.cs
    AuthModels.cs
  Health/
    IHealthCheckService.cs
    HealthCheckService.cs
    HealthModels.cs
  Navigation/
    AppShell.routes.md
  Config/
    appsettings.template.json
```

## Modo de arranque rápido
1. Usar `MockAuthProvider` en DEV.
2. Configurar endpoint de healthcheck en `appsettings.template.json`.
3. Implementar primera pantalla protegida.
4. Validar login + healthcheck + logout.

## Continuidad
Para integrar autenticación real revisar: `docs/AUTH-CONTINUIDAD.md`.
