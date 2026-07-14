# 🅿️ Estacionamento

Sistema de console em **C# / .NET 8** para gerenciar um estacionamento simples: cadastro, remoção (com cálculo de valor) e listagem de veículos.

Projeto baseado no desafio "Fundamentos" (DIO), com correções e melhorias de robustez aplicadas sobre a versão original.

## ✨ Funcionalidades

- Definição do **preço inicial** e do **preço por hora** no início da execução.
- **Cadastrar veículo**: adiciona uma placa ao estacionamento (impede duplicidade).
- **Remover veículo**: informa quantas horas o veículo ficou estacionado e calcula o valor total a pagar.
- **Listar veículos**: mostra todas as placas atualmente estacionadas.
- **Encerrar**: finaliza o programa.

## 🛠️ Tecnologias

- [.NET 8](https://dotnet.microsoft.com/) (C#)
- Console App (`Microsoft.NET.Sdk`)

## 📂 Estrutura do projeto

```
Estacionamento-main/
├── Estacionamento.sln
└── Estacionamento/
    ├── Estacionamento.csproj
    ├── Program.cs              # Ponto de entrada e menu interativo
    └── Models/
        └── Estacionamento.cs   # Regras de negócio (cadastrar, remover, listar)
```

## ▶️ Como executar

Pré-requisito: [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado.

```bash
# Clone o repositório
git clone <url-do-repositorio>
cd Estacionamento-main/Estacionamento

# Rode o projeto
dotnet run
```

Ao iniciar, informe o preço inicial e o preço por hora. Em seguida, use o menu numérico para interagir com o sistema.

## ✅ Validações e melhorias já aplicadas

- Entradas numéricas inválidas (preço, horas) não derrubam mais o programa — o usuário é solicitado a digitar novamente.
- Placas vazias/nulas são tratadas com segurança (sem `NullReferenceException`).
- Placas duplicadas não podem ser cadastradas duas vezes.
- Placas são sempre normalizadas em maiúsculas, de forma consistente em toda a aplicação.
- Valor total exibido em formato monetário `pt-BR` (ex.: `R$ 15,00`).

## 💡 Possíveis evoluções futuras

- Registrar automaticamente o horário de entrada (`DateTime.Now`) e calcular as horas estacionadas na remoção, em vez de solicitar a digitação manual.
- Persistir os dados em arquivo ou banco de dados (atualmente os veículos existem apenas em memória, durante a execução).
- Cobrir a lógica de negócio com testes automatizados (xUnit/NUnit).

## 📄 Licença

Projeto de estudo, livre para uso e modificação.
