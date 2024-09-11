# GestorDeEstudantesT7
#### **Concluído em: 02/09/2024**
#### 🎥 **Demonstração em Vídeo:** [Assista aqui](<https://youtu.be/BF5N0Ol5o2I>)

### 📘 **Descrição do Projeto**
**GestorDeEstudantesT7** é uma plataforma desenvolvida para gerenciar estudantes de forma simples e eficiente. O sistema permite que administradores façam login e tenham acesso a uma série de funcionalidades, como o registro, edição e visualização de informações dos alunos.

### 🚀 **Principais Funcionalidades**
- **Cadastro de Estudantes:** Adicione novos alunos com informações como nome, data de nascimento, foto, gênero e mais. Todos os dados são armazenados em um banco de dados para acesso e gerenciamento.
- **Listagem e Estatísticas:** Veja a lista completa de alunos registrados e acompanhe a porcentagem de alunos por gênero.
- **Edição de Informações:** Edite, remova ou atualize os dados de alunos já cadastrados a qualquer momento.
- **Exportação de Dados:** Gere um arquivo .txt com todos os detalhes dos estudantes registrados no sistema, disponível diretamente na sua área de trabalho ao clicar em "Imprimir".


## 🧑‍🎓Aba Alunos
### 👨‍🎓 Novo Estudante:
**Na aba de alunos é onde você preenche as informações sobre o novo aluno. Essas informações serão armazenadas em um banco de dados MySQL. Você deverá preencher informações como:**
 
- Nome: Nome do aluno
- Sobrenome: Sobrenome do aluno
- Nascimento: Data de nascimento do aluno (existe uma restrição para alunos menores de 10 anos e maiores de 100)
- Gênero: Gênero do aluno, sendo possível escolher entre masculino e feminino (considerando apenas o gênero biológico da pessoa)
- Telefone: Número de telefone do aluno (A formatação do texto está adequada para um número de telefone
- Endereço: Endereço residencial do aluno
- Foto: Foto do aluno
<hr>

### 👨‍🎓 **Listar Alunos**
**Clicando em listar alunos, você consegue visualizar todos os alunos cadastrados no seu sistema. Todas essas informações vem do banco de dados. Nessa aba, é possível perceber que cada dado de cada aluno é atribuído a eles de forma intuitiva, separando-os por ID, tornando mais fácil a identificação de cada aluno.**

<hr>

### 👨‍🎓Estatísticas
**Em Estatísticas, é apresentado a quantidade de alunos cadastrado no sistema separados por gêneros, ou seja, são divididos entre homens e mulheres. A apresentação dos dados são feitos em porcentagem e não em número bruto, visando melhorar a visibilidade dos dados e torna-los mais estatísticos.**

<hr>

### 👨‍🎓Editar/Remover
**Acessando Editar/Remover, o usuário consegue fazer manipulações encima dos alunos cadastrados em "novo aluno". O usuário pode editar todas as informações (nome, sobrenome, nascimento, gênero, telefone, endereço e foto). Para puxar os dados do aluno desejado, você pode inserir o ID do aluno cadastrado e clicar em "Buscar". O ID do usuário é possível ser visualizado em "Listar Alunos". Além de poder fazer qualquer tipo de manipulação dos dados do aluno, também é possível remover um aluno já cadastrado no sistema, para isso, basta puxar os dados do aluno desejado através do ID e, posteriormente, clicar em "Apagar". Para salvar as alterações de dados modificados, basta clicar em "Salvar"**


<hr>

### 👨‍🎓Gerenciar Alunos
**Já no tópico "Gerenciar Alunos", você vai se deparar com uma tela de grade, sendo possível visualizar todas as informações de todos os alunos separadas de forma intuitiva. Ainda nessa tela de grade, o usuário pode clicar em algum aluno, e, automaticamente, os dados daquele aluno selecionado serão impressos na aba da esquerda, onde será possível fazer qualquer tipo de manipulação daquele aluno assim como é possível ser feito em "Editar/Remover". Ainda sobre o gerenciador de alunos, caso o usuário queira, ele pode baixar a imagem do aluno, tal como também pode redefinir as informações e cadastrar um novo aluno.**

<hr>

### 👨‍🎓Imprimir
**Para finalizar, é importante ressaltar que, caso o usuário queira, ele pode imprimir todas as informações de todos os alunos cadastrados no banco de dados do sistema escolar, basta acessar "Imprimir" e usar os filtros desejados e posteriormente, clicar em "Salvar arquivo de texto". Caso queira, você pode filtrar os alunos separando-os por características específicas, como, separar por gênero e/ou utilizar um intervalo de datas, colocando as datas desejadas. Após isso, basta clicar em "filtrar" que todos os alunos impressos no grid serão filtrados de acordo com o filtro aplicado. Feito isso, você notará que será criado um bloco de notas na sua área de trabalho, nesse arquivo.txt, o usuário poderá visualizar os dados dos alunos desejados, tais como (nome, sobrenome, nascimento, gênero, telefone e endereço)**

<hr>

### 📝 **Observação**
Este projeto foi desenvolvido como parte do curso *Harvard Computer Science 50 (CS50)*.
