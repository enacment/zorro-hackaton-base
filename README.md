# Zorro Hackatón Base (Monorepo MAUI)

Repositorio base provisto por **Enacment** como **template de arranque** para los equipos del hackatón.

## Objetivo
Dar un punto de partida común, escalable y simple para construir MVPs alineados a PRD usando un stack homogéneo.

> Nota de alcance: este repo es plantilla base. Las apps finales por equipo pueden vivir en sus propios repos una vez iniciado el desarrollo.

## Stack objetivo
- Frontend/App: **.NET MAUI** (Android y opción Web mediante estrategia por equipo)
- Infraestructura: **Azure**
- AI copiloto: **Codex** y **Google Antigravity**

## Estructura
```txt
apps/
  Zorro.Template.App/
shared/
  Domain.Common/
  Application.Common/
  Infrastructure.Common/
context/
  PRD.md
  memory.md
  attachments/
playbooks/
  codex/
  antigravity/
teams/
  planogramas/
  traspasos/
  precios/
```

## Flujo de trabajo
1. Crear fork y rama de trabajo.
2. Cargar/actualizar `context/PRD.md`.
3. Registrar decisiones en `context/memory.md`.
4. Ejecutar tareas solo dentro del alcance PRD.
5. Si hay discrepancia con nuevo prompt, avisar y resolver antes de implementar.
6. Ejecutar checklist de readiness.
7. Empezar iteraciones de Vibe Coding.

## Reglas no negociables
- No subir secretos al repositorio.
- No ampliar alcance del PRD sin acuerdo explícito.
- `context/PRD.md` es la única fuente de verdad funcional.
- Cada cambio debe compilar o dejar evidencia de bloqueo con owner.
- Commits pequeños, trazables y con objetivo único.

## Guías de IA
- Guardrails: `docs/AI-DEVELOPMENT-GUARDRAILS.md`
- Reglas de construcción: `docs/REGLAS-CONSTRUCCION.md`
- Codex (embebido): `AGENTS.md`
- Antigravity/Gemini (embebido): `GEMINI.md`
- Playbook Codex: `playbooks/codex/README.md`
- Playbook Antigravity: `playbooks/antigravity/README.md`

## Estado de autenticación (actual)
- Autenticación base del template: simple y embebida en proyecto (login/logout + guard).
- Integración real de autenticación empresarial: preparada vía adapter DLL externo.
- Guías:
  - `docs/AUTH-CONTINUIDAD.md`
  - `docs/DLL-INTEGRATION.md`
  - `docs/CONTINUACION-DLL.md`
  - `scripts/verify-dll-setup.sh`

## Branching sugerido
- `main` protegida
- `team/<equipo>/...`
- `feat/<equipo>/<ticket-corto>`

## Plantilla de commit
- `feat(planogramas): agrega validador de frentes`
- `fix(traspasos): corrige regla de redondeo factor 0.8`
- `chore(precios): agrega loader de ISCAM`
