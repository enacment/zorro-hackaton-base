# Rutas base recomendadas

- `/login` — pantalla de autenticación
- `/home` — pantalla principal protegida
- `/health` — estado de app y backend

## Regla
- Si no hay sesión válida: redirigir a `/login`.
- Si hay sesión válida: permitir `/home` y `/health`.
