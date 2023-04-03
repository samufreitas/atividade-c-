#Curso de Programação em C#
## Arquivos da aula sobre Windows Forms utilizando C# e aplicações utilizando consulta ao banco de dados

Módulo integrante do Curso de Engenharia de Software em parceria entre Ufac e Compal

Período: 15 a 27 de março de 2023

Laboratório de Estatística, Campus Ufac, Rio Branco/AC

## Banco de dados

Mysql Connector C# -> https://dev.mysql.com/downloads/connector/net/8.0.html
Mysql Server 8.0.32 -> https://dev.mysql.com/downloads/file/?id=516926

CREATE TABLE `vendas` (
  `Nome` varchar(60) NOT NULL,
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Quantidade` int(11) NOT NULL AUTO_INCREMENT,
  `Fornecedor` varchar(60) DEFAULT NULL,
  PRIMARY KEY (`Id`)
)

INSERT INTO `vendas` VALUES
('Nome 1', 00, 7, 'Pemaza');

