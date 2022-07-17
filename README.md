<h1 align="center">LojaChocolateApp</h1>
<h1 align="center">
<img alt="menu" title="menu" src="./GithubGif/LojaDeChocolateLogoCor.png"/>
</h1><br>
<p>Este projeto faz parte de um estudo prático da línguagem Csharp, com uso da .NET Framework e também de WinForm.
A aplicação tem como função gerir necessidades básicas de uma pequena loja de chocolates, onde deseja-se um controle de funcionário, produtos e vendas.</p><br>

<p align="center">
<a href="#sobre">Sobre</a> •
<a href="#features">Features</a> •
<a href="#tecnologias">Tecnologias</a> •
<a href="#pre-requisitos">Pré-Requisitos</a> •
<a href="#autor">Autor</a> 
</p><br>

# Sobre
<p>O formato de exibição deste aplicativo tem tamanho unico não possibilitando sua redução ou aumento, o design é pensado para ser objetivo com suas informações apresentadas.</p>
<p>A App usa como repositório arquivos CSV, atráves das classes <b>FuncionarioRepository</b>, <b>ProdutoRepository</b> e <b>VendasRepository</b> são manipulados os dados que serão gravados, alterados ou removidos.</p>
<p>Todas as classes de repositório implementam a interface <b>IRepository</b> onde a base de métodos está atribuída.</p> 
<p>As classes que intermediam a manipulação dos objetos que serão produtos, vendas e funcionários gerem os seus atributos que serão gravados nos respectivos repositórios. </p>
<p>Em futuras versões serão adicionadas funcionalidades que possibilitem o cálculo de bonificação, controle de usuário através de login e implementação de banco de dados SQL</p><br>

# Features

<h2>Menu</h2>
<p>O menu é interativo com dropDown para seus submenus, os submenus controlam qual tela vai aparecer para o usuário.</p>
<h1 align="center">
<img alt="menu" title="menu" src="./GithubGif/MenuDropDown.gif"/>
</h1><br>
<h2>TextBox</h2>
<p>Utiliza-se de textbox para inserção de dados onde os campos são pré configurados para recuperar as informações de forma correta.</p>
<p>Os campos Id, Estoque, contato, sálario entre outros aceitam apenas valores numéricos os mesmos tem um limite de caracteres e são pré configurados quando necessário</p>
<h1>
<img alt="textbox" title="textbox" src="./GithubGif/CamposTextBox.gif"/>
</h1><br>
<h2>CSV no Cadastro</h2>
<p>Ao enviar um arquivo CSV a aplicação analiza os padrões do texto retornando um erro caso o mesmo esteja fora dos padrões. Para facilitar o usuário foi inserida um popup que informa quais padrões devem ser seguidos.</p>
<h1>
<img alt="popupCSV" title="PopupCSV" src="./GithubGif/PopupCSV.gif"/>
</h1><br>
<h2>Remover Produto ou Funcionário</h2>
<p>Ao tentar remover um produto ou funcionário será exibido um popup de aviso para que seja confirmada a decisão de remoção do mesmo.</p>
<h1>
<img alt="popupCSV" title="PopupCSV" src="./GithubGif/PopupRemover.gif"/>
</h1><br>
<h2>Exibição das informações cadastradas</h2>
<p>A exibição de produtos e funcionários e seus detalhes é feita através do uso de paineis criadas por control form.</p> 
<h1>
<img alt="Exibe Funcionários" title="Exibe Funcionários" src="./GithubGif/ExibeCadastroFuncionário.gif"/>
</h1><br>
<p>Já a exibição de vendas é feita através de DataGrid.</p>
<h1>
<img alt="Exibe Vendas" title="Exibe Vendas" src="./GithubGif/ExibeCadastroVendas.gif"/>
</h1><br>
<h2>Erros Esperados</h2>
<p>Alguns erros comuns são esperados e serão informados através de <b>MessageBox</b>. Alguns deles são:</p>
<h3>Dados faltantes e incorretos no TextBox:</h3>
<h1>
<img alt="Erro nos dados" title="Erro nos dados" src="./GithubGif/DadosErrados.gif"/>
</h1><br>
<p>Mais erros são esperados como: id incorreto em busca de detalhes; produto com pouco estoque; CSV incorreto, entre outros</p><br>

# Tecnologias

- `CSharp`
- `.NET Framework 4.8`
<p>Através da linguagem CSharp, FrameWork .NET e o WinForms foram aplicadas tecnologias para captura de erro como try/Catch, verificação de padrões em textos com a classe Regex, implementação de diferentes formas de ordenar objetos com a interface ICompare.</p>
<p>Para o uso do repositorio em CSV foi necessária a utilização de diretivas using, FileStream, StreamReader e StreamWritter.</p>
<p>De forma a utilizar uma escrita de códigos com menos linhas e métodos o uso de Tuple para retornar mais de um valor em um método foi aplicado. O mesmo também foi utilizado em lista de correlação de valores com objetos.</p>
<p>Por fim, muitas funcões de click time event foram aplicadas para que o funcionamento correto e responsividade visual fossem obtidas na aplicação.</p><br>

# Pré-Requisitos

<p>Para utilizar a aplicação basta salva-la em seu compudador e utilizar seu atalho.</p>
<p>Caso ocorra algum problema ao acessar o atalho deve acessar o seguinte diretório:<br> LojaChocolateAppView / LojaChocolateApp / bin / Debug / LojaChocolateApp.exe</p>

# Autor

| [<img src="https://avatars.githubusercontent.com/u/107010683?v=4" width=115><br><sub>Felipe Rodrigues Santos</sub>](https://github.com/FelipeR-S) |  
| :---: |



