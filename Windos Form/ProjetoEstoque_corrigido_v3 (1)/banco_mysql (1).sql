-- Banco do sistema ProjetoEstoque - versão MySQL (MySQL Workbench)
CREATE DATABASE IF NOT EXISTS banco;
USE banco;

CREATE TABLE tb_cliente (
    cd_cliente   INT AUTO_INCREMENT PRIMARY KEY,
    nm_cliente   VARCHAR(50),
    ds_endereco  VARCHAR(50),
    nm_bairro    VARCHAR(50),
    nm_cidade    VARCHAR(30),
    sg_estado    CHAR(2),
    cd_cep       VARCHAR(8),
    cd_cpf       VARCHAR(14),
    cd_rg        VARCHAR(15)
);

CREATE TABLE tb_fornecedor (
    cd_fornecedor INT AUTO_INCREMENT PRIMARY KEY,
    nm_fornecedor VARCHAR(50),
    ds_endereco   VARCHAR(50),
    nm_bairro     VARCHAR(30),
    nm_cidade     VARCHAR(30),
    sg_estado     CHAR(2),
    cd_cep        VARCHAR(9),
    cd_cnpj       VARCHAR(18),
    cd_ie         VARCHAR(15)
);

CREATE TABLE tb_usuario (
    cd_usuario INT AUTO_INCREMENT PRIMARY KEY,
    nm_usuario VARCHAR(100),
    sg_nivel   CHAR(1),
    nm_login   VARCHAR(15),
    cd_senha   VARCHAR(15)
);

CREATE TABLE tb_produtos (
    cd_produto               INT AUTO_INCREMENT PRIMARY KEY,
    nm_produto               VARCHAR(50),
    sg_unidade_venda_produto CHAR(2),
    vl_custo                 DECIMAL(10,2),
    vl_venda                 DECIMAL(10,2),
    qt_estoque               INT
);
