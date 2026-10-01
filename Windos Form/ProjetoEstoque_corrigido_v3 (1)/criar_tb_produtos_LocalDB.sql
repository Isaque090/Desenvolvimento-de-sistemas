-- Rode no Visual Studio: Gerenciador de Servidores > dbEstoque.mdf > botão direito > Nova Consulta
IF OBJECT_ID('dbo.tb_produtos') IS NULL
CREATE TABLE dbo.tb_produtos (
    cd_produto               INT IDENTITY(1,1) PRIMARY KEY,
    nm_produto               VARCHAR(50),
    sg_unidade_venda_produto CHAR(2),
    vl_custo                 DECIMAL(10,2),
    vl_venda                 DECIMAL(10,2),
    qt_estoque               INT
);
