# Principios de desarrollo asistido por IA

## Fuente de verdad
El PRD de cada equipo es la única fuente de verdad de alcance y aceptación:
- `prd/planogramas/PRD.md`
- `prd/traspasos/PRD.md`
- `prd/precios/PRD.md`

## Roles esperados
- Codex: complejidad técnica alta (debug/integración/refactor sensible).
- Antigravity: aceleración táctica (scaffolding, alternativas, documentación).

## Ciclo recomendado
1. Definir micro-objetivo desde PRD
2. Prompt estructurado (contexto + restricciones + salida)
3. Implementación mínima
4. Build/test
5. Commit

## Criterio de calidad
- Nada entra sin validación técnica y funcional.
- Prompt sin criterio de aceptación = trabajo incompleto.
- Cambios fuera de PRD se bloquean.

## Prompt base
```txt
Contexto: [equipo] + [sección PRD].
Objetivo: [qué debe quedar funcionando].
Restricciones: [stack, seguridad, no alcance].
Entrega: [archivos, comandos, pruebas mínimas, riesgos].
Criterio de aceptación: [cómo validamos].
```
