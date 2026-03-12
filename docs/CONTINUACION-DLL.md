# Continuación rápida — DLL auth

## Checklist
- [ ] Archivos en `local-secrets/dll/`
- [ ] `scripts/verify-dll-setup.sh` en verde
- [ ] Provider cambiado a `LegacyDll`
- [ ] Validación de carga dinámica OK
- [ ] Definir contrato real de método login

## Si falla
1. revisar nombres exactos de archivos,
2. revisar rutas en appsettings,
3. validar arquitectura de runtime compatible con DLL.
