# AGENTS.md — Reglas embebidas para Codex (obligatorias)

Este archivo define cómo debe trabajar cualquier agente tipo Codex en este repo.

## 1) Fuente de verdad
La fuente primordial está en `context/`:
- `context/PRD.md` (obligatorio)
- `context/memory.md` (memoria local de decisiones)
- `context/` archivos de apoyo (diagramas, reglas, anexos)

Si una solicitud nueva contradice `context/PRD.md`, **no se implementa directo**:
1. avisar explícitamente la discrepancia al usuario,
2. proponer opciones (ajustar prompt o actualizar PRD),
3. ejecutar solo cuando quede resuelto.

## 2) Flujo obligatorio por tarea
1. Leer `context/PRD.md` y `context/memory.md`.
2. Identificar criterio exacto de aceptación.
3. Definir micro-objetivo verificable (20-50 min).
4. Implementar cambio mínimo.
5. Validar (build + caso feliz + caso borde).
6. Commit pequeño y trazable.

## 3) Restricciones no negociables
- No subir secretos, DLLs ni archivos sensibles.
- No hacer cambios masivos sin justificación en PRD.
- No modificar arquitectura sin registrar decisión.
- No cerrar tarea sin evidencia de validación.

## 4) Formato de salida esperado del agente
- Archivos modificados
- Comandos ejecutados
- Resultado de validación
- Riesgos/supuestos
- Relación con criterio PRD
- Nota de discrepancia (si aplica)

## 5) Modo de trabajo recomendado
- Plan first, code second.
- Preferir iteraciones cortas a reescrituras grandes.
- Si hay bloqueo >15 min: registrar, escalar y proponer workaround.
