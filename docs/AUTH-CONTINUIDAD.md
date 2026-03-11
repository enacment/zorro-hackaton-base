# Autenticación — Continuidad (pendiente de definición final)

## Contexto confirmado
- Azure **sí** se usa hoy para hosting/repositorio de versiones.
- La autenticación **no está centralizada en Azure AD** para todos los aplicativos.
- Existen varios aplicativos con credenciales diferentes.
- Para conexión/autenticación actual se usa una **DLL**.

## Decisión para el template base (hackatón)
Implementar una autenticación **simple dentro del proyecto**, con arquitectura desacoplada:

1. `IAuthProvider` (interfaz común)
2. `MockAuthProvider` (default para desarrollo/demo)
3. `LegacyDllAuthProvider` (placeholder para integrar DLL real)
4. `AuthGuard` para rutas protegidas
5. `AuthState` mínimo (sesión actual, login/logout, expiración)

Objetivo: poder empezar a desarrollar sin sobrecomplicar y sin bloquear por credenciales finales.

## Qué sí incluye esta base
- Login básico (usuario/contraseña)
- Logout
- Ruta protegida
- Pantalla de Healthcheck (app + API ping)

## Qué NO incluye aún
- Integración real con la DLL (método exacto de login pendiente de confirmar)
- SSO corporativo
- MFA
- RBAC completo

## DLL recibidas (consideradas, no versionadas)
- `ZA98OUT.dll` (descifrado)
- `ZAIO2206.dll` (acceso/operaciones legacy)
- archivo de configuración asociado (con IP/credenciales cifradas)

Estas DLL **no se suben al repositorio**. Se deben colocar en entorno local seguro:
- `local-secrets/dll/ZA98OUT.dll`
- `local-secrets/dll/ZAIO2206.dll`
- `local-secrets/dll/ZAIO2206.ini`

## Pendientes para siguiente checkpoint
1. Confirmar con Fer:
   - tipo de DLL (framework/versión),
   - contrato de entrada/salida,
   - manejo de errores,
   - expiración/renovación de sesión.
2. Definir entorno de prueba para login real.
3. Sustituir `LegacyDllAuthProvider` placeholder por implementación real.

## Regla temporal de trabajo
Mientras no esté cerrada la integración DLL:
- usar `MockAuthProvider` por default en DEV,
- mantener todos los puntos de integración detrás de interfaz,
- no acoplar lógica de negocio a proveedor de autenticación.
