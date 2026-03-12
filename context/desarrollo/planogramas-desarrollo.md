# Planogramas — Guía de preparación y construcción

Equipo,

La meta en Planogramas es construir un MVP útil y demostrable por etapas, sin fricción.

## 1) Checklist de preparación para taller

### Accesos y cuentas
- [ ] Repo clonado y acceso Git funcionando
- [ ] Acceso al entorno de demo (web o móvil)
- [ ] Usuario de prueba definido

### Integraciones
- [ ] Fuente de inventario identificada (aunque sea CSV inicial)
- [ ] Endpoint/servicio de Vision definido (Gemini o Azure Vision)
- [ ] Ruta de storage para evidencias (imágenes/resultados)

### API keys / secretos
- [ ] API key de Vision disponible
- [ ] Variables en entorno local (nunca en repo)
- [ ] Prueba simple de conexión realizada

### Datos para demo
- [ ] 10-20 ejemplos de imágenes de anaquel
- [ ] 1 planograma de referencia
- [ ] 1 caso feliz y 1 caso borde definidos

## 2) Secuencia lógica de construcción (por fases)

### Fase A — Navegabilidad
Objetivo: flujo completo visible (login → captura → resultado).

### Fase B — Modelo de datos + reglas mock
Objetivo: definir entidades y cálculo de cumplimiento con datos simulados.

### Fase C — Persistencia y trazabilidad
Objetivo: guardar corridas, evidencias y resultados.

### Fase D — Integraciones reales
Objetivo: conectar Vision + inventario y reemplazar mocks.

### Fase E — Cierre MVP
Objetivo: estabilizar demo, validar casos y dejar checklist de salida.

## 3) Prompts copy/paste por fase

### Prompt base (usar siempre)
```txt
Lee primero:
- context/PRD.md
- context/memory.md
- context/planogramas/README.md
- context/CHANGELOG.md

Trabajaremos SOLO dentro de PRD. Si detectas discrepancia con mi prompt, avísame antes de implementar.
Devuélveme:
1) Plan corto
2) Archivos a modificar
3) Validación (caso feliz + borde)
4) Riesgos
```

### Fase A — Navegabilidad
```txt
Con base en context/PRD.md y context/planogramas/README.md, crea la primera versión navegable del flujo:
login -> captura -> revisión -> resultado.
Sin lógica de negocio compleja todavía.
Incluye rutas, componentes y estado mínimo.
```

### Fase B — Modelo y reglas mock
```txt
Con base en PRD, diseña el modelo de datos de Planogramas (captura, referencia, comparación, resultado) e implementa reglas mock de cumplimiento.
No conectes APIs reales aún.
Entrega ejemplos de payload y validación con datos simulados.
```

### Fase C — Persistencia
```txt
Implementa persistencia para corridas de planograma con trazabilidad:
- fecha
- usuario
- evidencias
- resultado
Agrega consulta de historial básico.
```

### Fase D — Integraciones
```txt
Conecta el módulo de Vision y la fuente de inventario al flujo actual sin romper navegabilidad.
Mantén un fallback mock si falla integración.
Documenta variables de entorno necesarias.
```

### Fase E — Hardening MVP
```txt
Prepara cierre de MVP:
- validar caso feliz y borde
- mejorar mensajes de error
- checklist de demo
- actualización de context/CHANGELOG.md
```

## 4) Nota de trabajo
Vamos paso a paso y siempre con evidencia visible. Si cada fase queda cerrada, el MVP llega sólido al final del taller.
