# Reglas de construcción (definidas)

## Contrato operativo
1. `context/PRD.md` primero.
2. `context/memory.md` como memoria local.
3. `context/DECISIONS.md` + `context/CHANGELOG.md` como trazabilidad viva.
4. Cambios pequeños.
5. Validación técnica mínima.
6. Evidencia de aceptación.
7. Trazabilidad en commit/PR.
8. Cada PR debe actualizar `context/CHANGELOG.md`.

## Manejo de discrepancias
Si el prompt del usuario contradice `context/PRD.md`:
- se reporta explícitamente la discrepancia,
- se proponen opciones de resolución,
- no se implementa hasta aclaración.

## Gate de calidad mínimo
- Build exitoso
- Caso feliz validado
- Caso borde validado
- Sin secretos
- Referencia a `context/PRD.md` en PR

## Herramientas IA
- Codex: implementación compleja (con AGENTS.md)
- Antigravity: apoyo táctico (con GEMINI.md)

## Resultado esperado por iteración
- Algo funcional, medible y demostrable
- Sin deuda oculta crítica
- Con rollback simple
