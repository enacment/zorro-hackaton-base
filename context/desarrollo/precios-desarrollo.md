# Precios — Guía de preparación y construcción

Equipo,

La meta en Precios es consolidar datos y producir reportes accionables de forma clara.

## 1) Checklist de preparación para taller

### Accesos y cuentas
- [ ] Repo clonado y acceso Git funcionando
- [ ] Entorno de ejecución listo
- [ ] Usuario de prueba definido

### Integraciones
- [ ] Fuentes identificadas (BI/ISCAM/mercado)
- [ ] Mapeo inicial de campos entre fuentes
- [ ] Destino de salida para reportes

### API keys / secretos
- [ ] Credenciales de fuentes disponibles
- [ ] Variables cargadas localmente
- [ ] Prueba de conectividad realizada

### Datos para demo
- [ ] Dataset pequeño de muestra por fuente
- [ ] Reglas mínimas de normalización definidas
- [ ] 1 caso feliz y 1 caso borde definidos

## 2) Secuencia lógica de construcción (por fases)

### Fase A — Navegabilidad
Objetivo: flujo visible (selección fuentes → consolidación → reporte).

### Fase B — Modelo y normalización mock
Objetivo: diseñar modelo de precios y reglas mock de homologación.

### Fase C — Persistencia
Objetivo: guardar snapshots, corridas y versiones de reporte.

### Fase D — Integraciones reales
Objetivo: conectar BI/ISCAM/mercado en forma incremental.

### Fase E — Cierre MVP
Objetivo: reportes consistentes, validación y demo final.

## 3) Prompts copy/paste por fase

### Prompt base (usar siempre)
```txt
Lee primero:
- context/PRD.md
- context/memory.md
- context/precios/README.md
- context/CHANGELOG.md

Trabaja solo dentro del PRD. Si ves discrepancia con mi prompt, avísame antes de implementar.
Devuélveme plan, archivos, validación y riesgos.
```

### Fase A — Navegabilidad
```txt
Construye flujo navegable de Precios:
1) selección de fuente,
2) vista de consolidación,
3) reporte final.
Sin conexión real en esta fase.
```

### Fase B — Modelo y reglas mock
```txt
Define modelo de datos de precios y reglas de homologación mock entre fuentes.
Incluye payload de ejemplo y resultado esperado.
```

### Fase C — Persistencia
```txt
Implementa persistencia de snapshots y corridas de reporte con timestamp y versión.
Agrega vista de historial simple.
```

### Fase D — Integraciones
```txt
Conecta fuentes reales de forma incremental (primero una, luego las demás).
Mantén modo mock como fallback para demo.
Documenta variables necesarias.
```

### Fase E — Hardening MVP
```txt
Cierra MVP con:
- validación de consistencia de reporte
- caso feliz y caso borde
- checklist de demo
- actualización de context/CHANGELOG.md
```

## 4) Nota de trabajo
Vamos a construir con foco y claridad. Si mantenemos el ritmo por fases, el resultado llega completo y listo para enseñar.
