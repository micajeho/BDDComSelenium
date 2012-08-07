Funcionalidade: Cálculo do valor do IR
	Para saber quanto vou pagar de imposto
	Enquanto contribuinte
	Eu gostaria de calcular o IR

Cenário: Salário de 100 reais fica isento
	Dado que estou na página IR
	E preencho o campo 'salario' com o valor 100.00
	Quando clico em Calcular
	Então vejo 'O resultado é 0.00'

Cenário: Salário de 5000 paga 300
	Dado que estou na página IR
	E preencho o campo 'salario' com o valor 5000.00
	Quando clico em Calcular
	Então vejo 'O resultado é 300.00'

Cenário: Salário de 5000 com 1 dependente paga 200
	Dado que estou na página IR

	E preencho o campo 'salario' com o valor 5000.00
	E preencho o campo 'dependentes' com o valor 1
	Quando clico em Calcular
	Então vejo 'O resultado é 200.00'

Cenário: Salário de 5000 com 2 dependente paga 200
	Dado que estou na página IR
	E preencho o campo 'salario' com o valor 5000.00
	E preencho o campo 'dependentes'com o valor 2
	Quando clico em Calcular
	Então vejo 'O resultado é 100.00'

Cenário: Salário de 6000  paga 200
	Dado que estou na página IR
	E preencho o campo 'salario' com o valor 6000.00
	E preencho o campo 'dependentes' com o valor 2
	Quando clico em Calcular
	Então vejo 'O resultado é 150.00'


Cenário: Salário de 6000 para 150
	Dado que estou na página IR
	E preencho o campo 'salario' com o valor 6000.00
	E preencho o campo 'dependentes' com o valor 2
	Quando clico em Calcular
	Então vejo 'O resultado é 150.00'

