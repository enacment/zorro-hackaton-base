# Guardrails de desarrollo con IA (Codex + Antigravity)

## Regla principal
El **PRD de cada equipo es la única fuente de verdad** para alcance y criterios de aceptación.

Si una propuesta no está en PRD:
- no se implementa,
- se registra como idea aparte,
- se decide después con owner.

## Ubicación obligatoria de PRDs
- `prd/planogramas/PRD.md`
- `prd/traspasos/PRD.md`
- `prd/precios/PRD.md`

## Mejores prácticas aplicadas (resumen)
Basado en guías de OpenAI (Codex/Prompting) y Google Vertex AI Prompting:

1. **Instrucciones claras y específicas**
2. **Contexto + restricciones + salida esperada** en cada prompt
3. **Iteración corta y medible** (objetivos verificables)
4. **Validación obligatoria** (build/test/evidencia)
5. **Versionado estable** (no cambiar modelo/estrategia sin registrar)

## Reglas para Codex
Usar Codex para:
- debugging complejo,
- integración crítica,
- refactor sensible.

Cada solicitud a Codex debe incluir:
- referencia exacta a PRD (`sección`, `criterio`, `no-alcance`),
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
1. Seleccionar micro-objetivo desde PRD
2. Redactar prompt estructurado
3. Implementar cambio mínimo
4. Verificar build + pruebas
5. Commit pequeño trazable

## Plantilla mínima de prompt
```txt
Contexto de negocio: [equipo] + [sección PRD]
Objetivo: [resultado funcional verificable]
Restricciones: [fuera de alcance, stack, seguridad]
Archivos objetivo: [rutas]
Entrega obligatoria: [archivos modificados, comandos, pruebas, riesgos]
Criterio de aceptación: [cómo validamos]
```
