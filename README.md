# Zorro Hackatón Base (Monorepo MAUI)

Repositorio base provisto por **Enacment** para los 3 equipos del hackatón:
- Planogramas
- Traspasos
- Precios

## Objetivo
Dar un punto de partida común, escalable y con buenas prácticas enterprise para construir MVPs alineados a PRD usando un stack homogéneo.

## Stack objetivo
- Frontend/App: **.NET MAUI** (Android y opción Web mediante estrategia por equipo)
- Infraestructura: **Azure**
- AI copiloto: **Codex** y **Google Antigravity**

> Nota: este repo inicia como base estructural. Cada equipo completa su contexto técnico y ejecuta bootstrap en su README.

## Estructura
```txt
apps/
  Zorro.Planogramas.App/
  Zorro.Traspasos.App/
  Zorro.Precios.App/
shared/
  Domain.Common/
  Application.Common/
  Infrastructure.Common/
context/
  planogramas/
  traspasos/
  precios/
playbooks/
  codex/
  antigravity/
teams/
  planogramas/
  traspasos/
  precios/
```

## Flujo de trabajo por equipo
1. Crear fork y rama de trabajo.
2. Ir a `teams/<equipo>/README.md`.
3. Completar sección **Contexto del equipo** con su PRD (sin inventar alcance).
4. Completar sección **Infra y accesos** (deploy, keys, storage, DB, integraciones).
5. Ejecutar checklist de readiness.
6. Empezar iteraciones de Vibe Coding.

## Reglas no negociables
- No subir secretos al repositorio.
- No ampliar alcance del PRD sin acuerdo explícito.
- Cada cambio debe compilar o dejar evidencia de bloqueo con owner.
- Commits pequeños, trazables y con objetivo único.

## Branching sugerido
- `main` protegida
- `team/<equipo>/...`
- `feat/<equipo>/<ticket-corto>`

## Plantilla de commit
- `feat(planogramas): agrega validador de frentes`
- `fix(traspasos): corrige regla de redondeo factor 0.8`
- `chore(precios): agrega loader de ISCAM`
