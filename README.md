![alt text](https://cdn.pixabay.com/photo/2017/05/31/16/39/windows-2360920_960_720.png)
# SEGUINDO EXEMPLO

## API COM VSCODE 
![alt text](https://code.visualstudio.com/favicon.ico)
### PRÉ-REQUISITOS 💼
* [vscode instalado](https://code.visualstudio.com/download)
* [Csharp versão atual](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
* [dotnet core sdk atual](https://dotnet.microsoft.com/download/dotnet-core/3.1)

### CRIANDO O PROJETO 🧗 
* Abra o terminal, e escolha diretório que preferir
* Comandos iniciais

		// Acesse o terminal que preferir :
			dotnet new webapi -o "aqui coloque o nome do seu projeto"

		// Entre no seu projeto criado :
		cd "aqui está o seu projeto"

		// Adicione esses pacotes, obs : caso queira usar banco de dados fisico ou em nuvem :
		dotnet add package Microsoft.EntityFrameworkCore.SqlServer

		// Alternativa é usar banco em memoria :
		dotnet add package Microsoft.EntityFrameworkCore.InMemory

		// Agora é só abrir o editor de texto que preferir, no meu caso uso [vscode](https://code.visualstudio.com/download)

		// Digite seguinte comando no terminal : 
		code -r ../"aqui está o seu projeto"
		
		OBS : 

### AGORA É SÓ TESTAR 🎮
	
	// Ação de comando :
	* Pressione CTRL+F5 para executar o aplicativo. Em um navegador, acesse a seguinte : 
	URL: https://localhost:5001/WeatherForecast

### ATÉ A PROXIMA 👋

