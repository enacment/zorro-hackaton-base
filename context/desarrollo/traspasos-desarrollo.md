# Traspasos — Guía de preparación y construcción

Equipo,

La meta en Traspasos es lograr un flujo reproducible y trazable del cálculo.

## 1) Checklist de preparación para taller

### Accesos y cuentas
- [ ] Repo clonado y acceso Git funcionando
- [ ] Entorno de ejecución listo
- [ ] Usuario de prueba definido

### Integraciones
- [ ] Fuentes operativas identificadas (Merksyst/Web HL/Top50)
- [ ] Formato de entrada acordado (CSV/API)
- [ ] Lugar de persistencia para corridas

### API keys / secretos
- [ ] Credenciales de fuente disponibles
- [ ] Variables cargadas localmente
- [ ] Conexión de prueba validada

### Datos para demo
- [ ] Dataset de muestra con inventario/ventas
- [ ] Reglas de prorrateo base documentadas
- [ ] 1 caso feliz y 1 caso borde definidos

## 2) Secuencia lógica de construcción (por fases)

### Fase A — Navegabilidad
Objetivo: flujo visible (carga datos → configurar regla → simular → resultado).

### Fase B — Modelo + reglas mock
Objetivo: modelo de corridas y algoritmo de prorrateo mock.

### Fase C — Persistencia
Objetivo: guardar corridas y permitir reproducibilidad.

### Fase D — Conexiones reales
Objetivo: conectar fuentes operativas y validar consistencia.

### Fase E — Cierre MVP
Objetivo: estabilidad, validación de reglas y demo ejecutiva.

## 3) Prompts copy/paste por fase

### Prompt base (usar siempre)
```txt
Lee primero:
- context/PRD.md
- context/memory.md
- context/traspasos/README.md
- context/CHANGELOG.md

Trabaja SOLO con el alcance PRD. Si hay discrepancia, avísame antes de implementar.
Entrégame plan corto, archivos, validación y riesgos.
```

### Fase A — Navegabilidad
```txt
Construye flujo navegable para Traspasos:
1) carga de insumos,
2) configuración de regla,
3) ejecución de simulación,
4) pantalla de resultado.
Sin integración real todavía.
```

### Fase B — Reglas mock
```txt
Diseña modelo de datos de corrida de traspaso e implementa algoritmo mock de prorrateo con salida explicable.
Incluye ejemplo de entrada/salida.
```

### Fase C — Persistencia
```txt
Implementa persistencia de corridas y consulta histórica.
Cada corrida debe guardar parámetros, timestamp y resultado.
```

### Fase D — Integraciones
```txt
Conecta fuentes operativas al flujo existente.
Mantén compatibilidad con modo mock para demo segura.
Documenta variables/credenciales requeridas.
```

### Fase E — Hardening MVP
```txt
Cierra MVP de Traspasos con:
- validación caso feliz y borde
- trazabilidad completa de corrida
- checklist de demo
- actualización de context/CHANGELOG.md
```

## 4) Nota de trabajo
Con una secuencia ordenada, cada iteración suma y llegamos a una solución confiable y demostrable.
