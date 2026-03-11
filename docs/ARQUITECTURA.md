# Arquitectura base (Monorepo MAUI)

## Principio
Template base único para arrancar rápido: estructura homogénea, dominios separados y librerías compartidas.

## Separación por dominios
- `apps/Zorro.Planogramas.App`: experiencia y lógica específica de Planogramas.
- `apps/Zorro.Traspasos.App`: experiencia y lógica específica de Traspasos.
- `apps/Zorro.Precios.App`: experiencia y lógica específica de Precios.

## Compartido
- `shared/Domain.Common`: contratos, value objects, errores comunes.
- `shared/Application.Common`: casos de uso comunes, validaciones transversales.
- `shared/Infrastructure.Common`: clientes HTTP, storage abstractions, observabilidad.

## Contratos obligatorios por app/equipo
Cada equipo define:
1. `README` del equipo
2. `Contexto PRD` (qué sí/qué no)
3. `Integraciones` (fuente, formato, owner)
4. `Checklist readiness`
5. `DoD mínimo`

## Autenticación base del template
- `IAuthProvider` como contrato único.
- Provider por default en DEV: mock/local.
- Punto de extensión para integración real vía DLL (pendiente de datos técnicos finales).
- Documento de continuidad: `docs/AUTH-CONTINUIDAD.md`.
