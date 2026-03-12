# AGENTS.md — Reglas embebidas para Codex (obligatorias)

Este archivo define cómo debe trabajar cualquier agente tipo Codex en este repo.

## 1) Fuente de verdad
- El PRD del equipo es la única fuente de verdad:
  - `prd/planogramas/PRD.md`
  - `prd/traspasos/PRD.md`
  - `prd/precios/PRD.md`
- Si no está en PRD, **no se implementa**.

## 2) Flujo obligatorio por tarea
1. Identificar sección exacta de PRD.
2. Definir micro-objetivo verificable (20-50 min).
3. Implementar cambio mínimo.
4. Validar (build + caso feliz + caso borde).
5. Commit pequeño y trazable.

## 3) Restricciones no negociables
- No subir secretos, DLLs ni archivos sensibles.
- No hacer cambios masivos cross-módulo sin justificación PRD.
- No modificar arquitectura sin registrar decisión en docs.
- No cerrar tarea sin evidencia de validación.

## 4) Formato de salida esperado del agente
- Archivos modificados
- Comandos ejecutados
- Resultado de validación
- Riesgos/supuestos
- Relación con criterio PRD

## 5) Modo de trabajo recomendado
- Plan first, code second.
- Preferir iteraciones cortas a reescrituras grandes.
- Si hay bloqueo >15 min: registrar, escalar y proponer workaround.
