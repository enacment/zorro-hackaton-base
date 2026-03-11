# Playbook Codex

## Cuándo usarlo
- Integraciones críticas
- Debugging complejo
- Refactors sensibles

## Regla de oro
Codex trabaja **siempre** contra un bloque específico del PRD.

## Checklist antes de pedir código
- [ ] PRD referenciado (`prd/<equipo>/PRD.md`, sección exacta)
- [ ] Alcance y fuera de alcance explícitos
- [ ] Inputs/salidas definidos
- [ ] Restricciones técnicas explícitas
- [ ] Criterio de aceptación verificable

## Formato mínimo del prompt
```txt
Contexto: [equipo + sección PRD]
Objetivo: [resultado funcional]
Restricciones: [stack, seguridad, no-alcance]
Archivos objetivo: [rutas]
Entrega: [archivos, comandos, pruebas, riesgos]
Validación: [build + caso feliz + borde]
```

## Salida esperada de Codex
- Archivos modificados
- Comandos para correr
- Validación mínima
- Riesgos/supuestos

## Calidad obligatoria
No se acepta resultado sin:
- build verde,
- prueba mínima,
- revisión humana de diff,
- commit pequeño y trazable.
