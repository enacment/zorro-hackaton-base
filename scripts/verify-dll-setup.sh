#!/usr/bin/env bash
set -euo pipefail

ROOT_DIR="$(cd "$(dirname "$0")/.." && pwd)"
DLL_DIR="$ROOT_DIR/local-secrets/dll"

required=(
  "$DLL_DIR/ZA98OUT.dll"
  "$DLL_DIR/ZAIO2206.dll"
  "$DLL_DIR/ZAIO2206.ini"
)

missing=0
for f in "${required[@]}"; do
  if [[ ! -f "$f" ]]; then
    echo "MISSING: $f"
    missing=1
  else
    echo "OK: $f"
  fi
done

if [[ $missing -eq 1 ]]; then
  echo "\n❌ DLL setup incompleto."
  exit 1
fi

echo "\n✅ DLL setup completo. Puedes activar LegacyDll en appsettings.template.json"
