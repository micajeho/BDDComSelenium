Funcionalidade: Calcula Idade
	Como usuário do site
	Eu quero calcular a minha idade
	Para validar se sou maior de idade


Cenário: Calcular idade para menor de idade
	Dado que estou na página de calcular Idade
	E preencho o campo data de nascimento como valor '25/04/1981'
	E a data atual é '15/04/1999'
	Quando eu clicar no botão 'Calcular'
	Então a mensagem 'Usuario menor de idade'
	E a idade do usuário será exibida


Cenário: Calcular idade para maior de idade
	Dado que estou na página de calcular Idade
	E preencho o campo data de nascimento como valor '25/04/1981'
	E a data atual é '15/04/2000'
	Quando eu clicar no botão 'Calcular'
	Então a mensagem 'Usuario maior de idade'
	E a idade do usuário será exibida
	
