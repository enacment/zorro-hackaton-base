# GEMINI.md — Reglas embebidas para Antigravity/Gemini

Este archivo guía el uso de Antigravity/Gemini dentro del repo.

## Fuente primordial
Consultar siempre primero:
- `context/PRD.md`
- `context/memory.md`

## Uso recomendado
- Scaffolding
- Alternativas de implementación con tradeoffs
- Documentación técnica
- Aceleración táctica en bloques pequeños

## Límites
- No decidir arquitectura final solo con Gemini.
- No definir reglas críticas fuera de PRD.
- No aprobar cambios sin build/test y revisión humana.

## Manejo de discrepancias
Si el prompt nuevo contradice `context/PRD.md`:
- detener implementación,
- reportar discrepancia al usuario en lenguaje claro,
- pedir confirmación de cuál fuente prevalece.

## Prompt mínimo obligatorio
- Contexto: sección de `context/PRD.md`
- Objetivo: resultado funcional verificable
- Restricciones: stack, seguridad, no alcance
- Entrega: archivos/comandos/pruebas/riesgos
- Aceptación: criterio PRD a cumplir

## Ciclo
Brief → Build → Verify → Commit
