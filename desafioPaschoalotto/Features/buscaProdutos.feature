#language: pt-br

Funcionalidade: Busca de produtos
	Para visualizar os produtos desejado
	Eu sendo um usuário com acesso ao site
	Quero pesquisar os produtos

Esquema do Cenário: Buscar Produtos
	Dado que acesse o site da loja
	Quando pesquisar pelo '<produto>'
	Então o produto pesquisado deve estar visível

	Exemplos:
	| produto                        |
	| Smartphone Samsung Galaxy A70  |
	| Smartphone Motorola One Vision |
	| Smartphone Xiaomi Redmi Note 7 |