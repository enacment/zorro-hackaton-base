# Playbook Antigravity

## Cuándo usarlo
- Scaffolding
- Variantes de implementación
- Documentación técnica de apoyo
- Aceleración táctica en tareas bien delimitadas

## Regla de oro
Antigravity trabaja contra `context/PRD.md` como fuente de verdad.

## Checklist antes de usar
- [ ] PRD referenciado (`context/PRD.md`)
- [ ] Objetivo acotado y verificable
- [ ] Restricciones y no-alcance claros
- [ ] Plan de validación definido

## Reglas
- No cerrar decisiones de arquitectura solo con Antigravity.
- No definir reglas críticas de negocio fuera de PRD.
- Toda propuesta se valida con build y pruebas mínimas.
- Si contradice PRD, se reporta al usuario y se detiene ejecución.

## Uso recomendado
1. Pedir 2-3 alternativas con tradeoffs.
2. Elegir una con criterio técnico + PRD.
3. Implementar cambio pequeño.
4. Validar y documentar decisión.
