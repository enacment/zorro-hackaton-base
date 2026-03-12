# Continuación del template base (siguientes pasos)

## Estado actual
- Starter base listo con auth simple + healthcheck.
- Adapter para DLL legacy preparado (sin binarios en repo).
- Guardrails Codex/Antigravity activos.
- PRD como fuente de verdad por equipo.

## Cómo continuar autenticación legacy
1. Colocar archivos localmente (no versionar):
   - `local-secrets/dll/ZA98OUT.dll`
   - `local-secrets/dll/ZAIO2206.dll`
   - `local-secrets/dll/ZAIO2206.ini`
2. Configurar rutas en `apps/Zorro.Template.App/src/Config/appsettings.template.json`.
3. Cambiar `Auth.Provider` a `LegacyDll` cuando exista contrato de método real.
4. Completar implementación en `LegacyDllAuthProvider.cs` con clase/método oficial.

## Checklist técnico rápido para equipos
- [ ] PRD cargado en `prd/<equipo>/PRD.md`
- [ ] Build baseline
- [ ] Login mock funcionando
- [ ] Healthcheck funcional
- [ ] Primer caso PRD implementado en iteración corta

## Regla operativa
No desarrollar fuera de PRD. Si algo falta, primero se actualiza PRD.
