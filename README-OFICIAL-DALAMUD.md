# EST Clock — arquivos para submissão oficial no Dalamud

## O que já deixei pronto
- Removi do `ESTClock.csproj` a referência a `..\Data\goat.png`, porque esse arquivo não existe no projeto enviado e isso pode atrapalhar um build limpo em outra máquina.
- Criei o arquivo de submissão oficial em:
  - `submission/testing/live/ESTClock/manifest.toml`
- Criei a pasta de imagem exigida pelo repositório oficial em:
  - `submission/testing/live/ESTClock/images/icon.png`

## Antes de abrir o PR no DalamudPluginsD17
1. Suba para o seu GitHub a versão final do plugin.
2. Faça commit de qualquer mudança pendente no seu repositório.
3. Atualize a linha `commit = "..."` do `manifest.toml` para o hash final que estiver no GitHub.
   - No arquivo que eu gerei, usei este commit encontrado no zip:
     - `bb82a4fceb3f2b2178dab2e6c44fbe5072c2397d`
4. Forke o repositório `goatcorp/DalamudPluginsD17`.
5. Copie a pasta `submission/testing/live/ESTClock/` para dentro do fork, preservando a estrutura:
   - `testing/live/ESTClock/manifest.toml`
   - `testing/live/ESTClock/images/icon.png`
6. Abra o Pull Request.

## Observações
- Plugin novo deve ir primeiro em `testing/live`, não em `stable`.
- Seu ícone está em tamanho válido para a submissão oficial.
- O plugin já usa a Windowing API do Dalamud.
- O repositório oficial pede que o projeto esteja em um Git público e que o build em Release funcione com `.csproj` + `packages.lock.json` commitados.

## O que eu ainda recomendo você conferir
- Se o projeto realmente faz build limpo em outra máquina sem depender de arquivos locais.
- Se a versão final no GitHub é a mesma apontada pelo `commit` do `manifest.toml`.
- Se o PR descreve claramente que é a primeira submissão do plugin.
