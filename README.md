<h1 align="center">LojaChocolateApp</h1>
<h1 align="center">
<img alt="menu" title="menu" src="./GithubGif/LojaDeChocolateLogoCor.png"/>
</h1><br>
<p>Este projeto faz parte de um estudo prático da linguagem Csharp, com uso da .NET Framework,  WinForm e MS SQL Server.
A aplicação tem como função gerir necessidades básicas de uma pequena loja de chocolates, onde deseja-se um controle de funcionário, produtos e vendas.</p><br>

<p align="center">
<a href="#sobre"><b>Sobre</b></a> •
<a href="#features"><b>Features</b></a> •
<a href="#tecnologias"><b>Tecnologias</b></a> •
<a href="#pré-requisitos"><b>Pré-Requisitos</b></a> •
<a href="#autor"><b>Autor</b></a> 
</p><br>

# **Sobre**
<p>O formato de exibição deste aplicativo tem tamanho único não possibilitando sua redução ou aumento, o design é pensado para ser objetivo com suas informações apresentadas.</p>
<p>A App usa como repositório um banco de dados SQL que através das classes <b>FuncionarioRepository</b>, <b>ProdutoRepository</b> e <b>VendasRepository</b> são manipulados os dados que serão gravados, alterados ou removidos.</p>
<p>Todas as classes de repositório implementam a interface <b>IRepository</b> onde a base de métodos está atribuída.</p> 
<p>As classes que intermediam a manipulação dos objetos que serão produtos, vendas e funcionários gerem os seus atributos que serão gravados nos respectivos repositórios. </p>
<p>Em futuras versões serão adicionadas funcionalidades que possibilitem o cálculo de bonificação, controle de usuário através de login e implementação de banco de dados SQL</p><br>

# **Features**

<h2><b>Login</b></h2>
<p>Escolha a instancia SQL que devera utilizar o banco de dados, informe usuário e senha para acessar o sistema.</p>
<h1 align="center"> <br>
<img  alt="menu" title="menu" src="./GithubGif/login.gif"/>
</h1><br><br>
<h2><b>Menu</b></h2>
<p>O menu é interativo com dropDown para seus submenus, os submenus controlam qual tela vai aparecer para o usuário.</p>
<br>
<img alt="menu" title="menu" src="./GithubGif/MenuDropDown.gif"/>
<br><br>
<h2><b>TextBox</b></h2>
<p>Utiliza-se de textbox para inserção de dados onde os campos são configurados para recuperar as informações de forma correta.</p>
<p>Os campos Id, Estoque, contato, salário entre outros aceitam apenas valores numéricos os mesmos tem um limite de caracteres e são configurados quando necessário</p>
<br>
<img alt="textbox" title="textbox" src="./GithubGif/CamposTextBox.gif"/>
<br><br>
<h2><b>CSV no Cadastro</b></h2>
<p>Ao enviar um arquivo CSV a aplicação analisa os padrões do texto retornando um erro caso o mesmo esteja fora dos padrões. Para facilitar o usuário foi inserida um popup que informa quais padrões devem ser seguidos.</p>
<br>
<img alt="popupCSV" title="PopupCSV" src="./GithubGif/PopupCSV.gif"/>
<br><br>
<h2><b><b>Remover Produto ou Funcionário</b></b></h2>
<p>Ao tentar remover um produto ou funcionário será exibido um popup de aviso para que seja confirmada a decisão de remoção do mesmo.</p>
<br>
<img alt="popupCSV" title="PopupCSV" src="./GithubGif/PopupRemover.gif"/>
<br><br>
<h2><b>Exibição das informações cadastradas</b></h2>
<p>A exibição de produtos e funcionários e seus detalhes é feita através do uso de painéis criadas por control form.</p> 
<h1>
<img alt="Exibe Funcionários" title="Exibe Funcionários" src="./GithubGif/ExibeCadastroFuncionário.gif"/>
</h1><br>
<p>Já a exibição de vendas é feita através de DataGrid.</p>
<br>
<img alt="Exibe Vendas" title="Exibe Vendas" src="./GithubGif/ExibeCadastroVendas.gif"/>
<br><br>
<h2><b>Erros Esperados</b></h2>
<p>Alguns erros comuns são esperados e serão informados através de <b>MessageBox</b>. Alguns deles são:</p>
<h3><b>Dados faltantes e incorretos no TextBox:</b></h3>
<br>
<img alt="Erro nos dados" title="Erro nos dados" src="./GithubGif/DadosErrados.gif"/>
<br><br>
<p>Mais erros são esperados como: id incorreto em busca de detalhes; produto com pouco estoque; CSV incorreto, entre outros</p>
<br>
<h2><b>Cadastro de Novo Usuário</b></h2>
<p>Incluido a possibilidade de criar um novo acesso mediante a aprovação de um gerente.</p><br>
<img alt="Cadastro de novo Login" title="Cadastro de novo Login" src="./GithubGif/CadastroNovoLogin.gif"/>
<br>
<img alt="Autorização de novo Login" title="Autorização de novo Login" src="./GithubGif/AutorizacaoNovoLogin.gif"/>
<br><br>
<h2><b>Controle de Acesso de Usuários</b></h2>
<p>Habilitada a possibilidade de diferentes views para cada hierarquia de funcionário. O usuário <b>"Gerente"</b> terá acesso a todas as funções da aplicação inclusive a de aprovar novo login, já o vendedor não tera acesso ao menu de funcionários.</p><br>
<img alt="Controle de Acesso" title="Controle de Acesso" src="./GithubGif/ControleDeAcesso.gif"/>
<br><br>
<h2><b>DarkMode e viso de Estoque Baixo</b></h2>
<p>A funcionalidade de darkmode altera o fundo de painéis que são brancos, substituíndo a cor por um cinza próximo ao preto, além disso as fontes são alteradas para a cor branca. O aviso de estoque baixo informa o usuário se o estoque de um produto está abaixo do escolhido.</p><br>
<img alt="DarkMode e Limite de Estoque" title="DarkMode e Limite de Es" src="./GithubGif/DarkModeLimiteEstoque.gif"/>
<br><br>

# **Tecnologias**

- **`CSharp`**
- **`.NET Framework 4.8`**
- **`SQL Server Microsoft`**
<p>Através da linguagem CSharp, FrameWork .NET e o WinForms foram aplicadas tecnologias para captura de erro como try/Catch, verificação de padrões em textos com a classe Regex, implementação de diferentes formas de ordenar objetos com a interface ICompare.</p>
<p>Para o uso do repositório foi aplicado o banco de dados MS SQL SERVER 2019 com tabelas para Funcionário, Produtos e Vendas e scripts utilizados para busca e escrita. Através do SQL também foi implementado um sistema de login que usa como user o próprio usuário cadastrado na criação do SQL Server.</p>
<p>De forma a utilizar uma escrita de códigos com menos linhas e métodos o uso de Tuple para retornar mais de um valor em um método foi aplicado. O mesmo também foi utilizado em lista de correlação de valores com objetos.</p>
<p>Por fim, muitas funções de click time event foram aplicadas para que o funcionamento correto e responsividade visual fossem obtidas na aplicação.</p><br>

# **Pré-Requisitos**

<p>Para garantir o funcionamento da aplicação deve-se extrair o arquivo na raiz do disco C: ou em outro disco.</p>
<p>Será necessária a instalação do MS SQL Server 2019, seguindo o passo a passo abaixo. O download está no link a seguir: https://www.microsoft.com/pt-br/sql-server/sql-server-downloads</p>
<p>Obs.: A versão utilizada no projeto foi a "Developer".</p>
<h3><b>Processo de Instalação MS SQL SERVER 2019</b></h3>
<p>Primeiramente inicie a instalação de modo personalizado e após isso em instalação selecione a primeira opção "Criar nova instalação autônoma do SQL".</p>
<p>Avance até a opção de "Seleção de Recursos" e marque a primeira box. Após isso siga até a opção de "Configuração de Mecanismo de Banco de Dados", selecione o modo misto, coloque a senha de sua preferência e adicione seu usuário de windows como um dos administradores."</p>
<p>Agora basta apenas finalizar a instalação.</p><br>
<h3><b>Permissão de Usuário</b></h3>
<p>Para que o banco de dados da aplicação fique funcional é necessário dar permissão de usuário no arquivo conforme segue:</p>
<p>Acesse o caminho "LojaChocolateApp\LojaChocolateAppView\LojaChocolateApp\Database" e para ambos os arquivos da pasta clique com o botão direito e vá em propriedades.</p>
<p>Em propriedades acesse a aba segurança e clique em editar, para editar permissões do "SISTEMA" e conceda "Controle Total".</p>
<p>Após isso basta apenas finalizar a instalação e utilizar a aplicação.</p>
<p>Para utilizar a aplicação basta salva-la em seu computador e utilizar seu atalho.</p>
<p>Caso ocorra algum problema ao acessar o atalho deve acessar o seguinte diretório:<br> LojaChocolateAppView/LojaChocolateApp/bin/Debug/LojaChocolateApp.exe</p><br>

# Autor

| [<img src="https://avatars.githubusercontent.com/u/107010683?v=4" width=115><br><sub>Felipe Rodrigues Santos</sub>](https://github.com/FelipeR-S) |  
| :---: |