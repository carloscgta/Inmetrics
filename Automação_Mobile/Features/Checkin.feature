#language: pt-BR
Funcionalidade: Checkin
	

@mytag
Esquema do Cenario: Realizar reserva com tarifa Promo- Check-in compra de uma bagagem
	Dado que estou logado no check-in "<Login>" "<Senha>"
	Quando selecionar o localizador
	E  preencher os dados "<CodigoVoo>" "<Sobrenome>"
	Entao realizo o check-in com sucesso

	Exemplos: 
   	 | Login                | Senha				 | CodigoVoo   | Sobrenome |
	 | carloscgta@gmail.com |  71992040812	     | UMW7JN      | TIRONE    |	