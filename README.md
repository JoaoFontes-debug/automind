# Cadastro de Usuários

Este é um aplicativo de console simples para gerenciar o cadastro de usuários. Ele permite adicionar, listar e buscar usuários por nome.

## Estrutura do Projeto

- **`Program.cs`**: Contém o ponto de entrada da aplicação e a lógica de interação com o usuário.
- **`models/Usuario.cs`**: Define a classe `Usuario`, que representa os dados de um usuário.
- **`repository/UsuarioRepository.cs`**: Implementa a lógica de armazenamento e recuperação de usuários.
- **`service/UsuarioService.cs`**: Contém a lógica de negócios, incluindo validações e manipulação de usuários.

## Funcionalidades

1. **Adicionar Usuário**: Permite adicionar um novo usuário com nome, email e idade.
2. **Listar Usuários**: Exibe todos os usuários cadastrados.
3. **Buscar Usuário por Nome**: Permite buscar um usuário pelo nome.

## Como Executar

1. Certifique-se de ter o [.NET 8.0 SDK](https://dotnet.microsoft.com/) instalado.
2. Clone este repositório.
3. Navegue até o diretório do projeto.
4. Execute o comando abaixo para compilar e executar o programa:

   ```bash
   dotnet run

## Validações
- O nome e o email são obrigatórios. 
- A idade deve estar entre 1 e 120 anos.
- O email deve estar em um formato válido.
- **Ex:**
  - Nome: João
  - Email: joao@example.com
  - Idade: 25

