# Decision Log (ADR lite)

Usar este archivo para decisiones técnicas relevantes.

## Plantilla
### DEC-XXXX — Título
- Fecha:
- Estado: proposed | accepted | superseded
- Contexto:
- Decisión:
- Alternativas consideradas:
- Consecuencias:
- Referencias: PR/commit/docs

---

### DEC-0001 — Fuente de verdad en carpeta context
- Fecha: 2026-03-11
- Estado: accepted
- Contexto: El modelo por proyecto generaba fricción y dispersión.
- Decisión: usar `context/PRD.md` y `context/memory.md` como base única.
- Alternativas consideradas: PRD por equipo en `prd/*`.
- Consecuencias: menor curva de aprendizaje y trazabilidad centralizada.
- Referencias: commit 31170b6
