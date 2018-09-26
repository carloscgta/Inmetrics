#language: pt-BR
Funcionalidade: Comprar_Passagem

#Contexto: Logar no app


	Esquema do Cenario: Validar valor da Bagagem com tarifas
		Dado que esteja logado no app "<Login>" "<Senha>"
		Quando compra uma passagem com tarifa "<Tarifa>"
		Então visualizo que o valor da bagagem despachada é "<preco>"
			
	Exemplos: 
	 | Login                     | Senha     | Tarifa | preco |
	 | yamrodri@inmetrics.com.br | voegol123 | Light  | 50,00 |
	 #| kartsilva@voegol.com.br  | Voegol123 | Light  | 50,00 |
	
	

#	Esquema do Cenario: Validar cobrança de assento comum fora da janela de check-in
#		Dado compra uma passagem com tarifa "<Tarifa>"
#		Quando reservar fora da janela de check-in "<Assento>"
#		Então verifico que houve cobrança "<Valor>"
#
#	Exemplos: 
#	|Tarifa | Assento | Valor |
#	|Light  | Comum   | 10,00 |
#
#
#	Esquema do Cenario: Validar cobrança de assento comum dentro da janela de check-in
#		Dado compra uma passagem com tarifa "<Tarifa>"
#		Quando reservar dentro da janela de check-in "<Assento>"
#		Então verifico que houve cobrança "<Valor>"
#
#	Exemplos: 
#	|Tarifa | Assento | Valor |
#	|Light  | Comum   | 0,00 |



