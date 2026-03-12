# Guardrails de desarrollo con IA (Codex + Antigravity)

## Regla principal
La fuente de verdad funcional está en `context/`:
- `context/PRD.md` (principal)
- `context/memory.md` (decisiones y notas locales)

Si una propuesta no está en PRD:
- no se implementa,
- se registra como idea aparte,
- se decide después con owner.

Si el prompt nuevo contradice PRD:
- se avisa al usuario,
- se describe el conflicto,
- se pide confirmación antes de ejecutar.

## Mejores prácticas aplicadas (resumen)
1. Instrucciones claras y específicas
2. Contexto + restricciones + salida esperada
3. Iteración corta y medible
4. Validación obligatoria (build/test/evidencia)
5. Versionado estable

## Reglas para Codex
Usar Codex para:
- debugging complejo,
- integración crítica,
- refactor sensible.

Cada solicitud a Codex debe incluir:
- referencia a sección de `context/PRD.md`,
- archivos objetivo,
- restricciones técnicas,
- contrato de salida: `archivos + comandos + pruebas + riesgos`.

No aceptar salida de Codex sin:
- build verde,
- prueba mínima (caso feliz + borde),
- diff revisado por humano.

## Reglas para Antigravity
Usar Antigravity para:
- scaffolding,
- propuestas alternativas,
- documentación técnica,
- aceleración táctica.

No usar Antigravity para cerrar solo:
- decisiones de arquitectura,
- reglas críticas de negocio,
- cambios de alcance del PRD.

Toda propuesta de Antigravity se valida igual que Codex: build/test/revisión humana.

## Ciclo estándar (obligatorio)
1. Leer `context/PRD.md` y `context/memory.md`
2. Seleccionar micro-objetivo
3. Redactar prompt estructurado
4. Implementar cambio mínimo
5. Verificar build + pruebas
6. Commit pequeño trazable

## Plantilla mínima de prompt
```txt
Contexto de negocio: [sección de context/PRD.md]
Objetivo: [resultado funcional verificable]
Restricciones: [fuera de alcance, stack, seguridad]
Archivos objetivo: [rutas]
Entrega obligatoria: [archivos modificados, comandos, pruebas, riesgos]
Criterio de aceptación: [cómo validamos]
```
