# Integración de DLL de autenticación/conexión (sin subir binarios al repo)

## Objetivo
Arrancar autenticación con DLL legacy sin comprometer seguridad del repositorio.

## 1) Ubicación local obligatoria
Crear carpeta local (no versionada):

```bash
mkdir -p local-secrets/dll
```

Copiar archivos:
- `local-secrets/dll/ZA98OUT.dll`
- `local-secrets/dll/ZAIO2206.dll`
- `local-secrets/dll/ZAIO2206.ini`

## 2) Verificar setup

```bash
bash scripts/verify-dll-setup.sh
```

Si todo está OK, continúa.

## 3) Activar provider legacy
Editar `apps/Zorro.Template.App/src/Config/appsettings.template.json`:
- `Auth.Provider`: `"LegacyDll"`
- `Auth.UseLegacyDll`: `true`
- confirmar rutas `LegacyDll.*Path`

## 4) Arranque de autenticación
`LegacyDllAuthProvider.cs` ya:
- valida presencia de DLL/INI,
- carga DLL dinámicamente,
- deja el punto de integración para método real de login.

## 5) Qué falta para cierre completo
- mapear método real de autenticación (clase/método/parámetros/salida),
- reemplazar token temporal por resultado real de DLL,
- agregar prueba de login real con entorno controlado.

## Regla de seguridad
- Nunca subir DLL, INI, credenciales ni secretos al repositorio.
