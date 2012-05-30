CREATE TABLE Calendario
(
	Cal_Codigo  int  IDENTITY (1,1) ,
	Cal_Descricao  nvarchar(255)  NULL ,
	Cal_DataInicio  datetime  NOT NULL ,
	Cal_DataFim  datetime  NOT NULL ,
	Cli_Codigo  int  NULL ,
	Pro_Numero  int  NULL ,
	CEs_Codigo  int  NULL ,
	Fun_Codigo  int  NULL ,
	Hon_Codigo  int  NULL ,
	Cus_Codigo  int  NULL 
);

ALTER TABLE Calendario
	ADD  PRIMARY KEY    (Cal_Codigo  );

CREATE TABLE Clientes
(
	Cli_Codigo  int  IDENTITY (1,1) ,
	Cli_Nome  nvarchar(100)  NOT NULL ,
	Cli_CPF  nvarchar(15)  NULL ,
	Cli_CNPJ  nvarchar(22)  NULL ,
	Cli_RG  nvarchar(15)  NULL ,
	Cli_Endereco  nvarchar(100)  NULL ,
	Cli_Numero  nvarchar(20)  NULL ,
	Cli_Bairro  nvarchar(50)  NULL ,
	Cli_CEP  nvarchar(12)  NULL ,
	Cli_Cidade  nvarchar(50)  NULL ,
	Cli_UF  nvarchar(2)  NULL ,
	Cli_Email  nvarchar(100)  NULL ,
	Cli_Telefone  nvarchar(15)  NULL ,
	Cli_TelefoneComercial  nvarchar(15)  NULL ,
	Cli_Celular  nvarchar(15)  NULL 
);

ALTER TABLE Clientes
	ADD  PRIMARY KEY    (Cli_Codigo  );

CREATE TABLE Clientes_Custos
(
	Cli_Codigo  int  NOT NULL ,
	Cus_Codigo  int  NOT NULL 
);

ALTER TABLE Clientes_Custos
	ADD  PRIMARY KEY    (Cli_Codigo  ,Cus_Codigo  );

CREATE TABLE Contas_Banco
(
	Con_Codigo  int  IDENTITY (1,1) ,
	Con_Numero  nvarchar(25)  NOT NULL ,
	Con_NomeBanco  nvarchar(50)  NOT NULL ,
	Con_CodigoBanco  int  NOT NULL ,
	Con_NumeroAgencia  int  NOT NULL 
);

ALTER TABLE Contas_Banco
	ADD  PRIMARY KEY    (Con_Codigo  );

CREATE TABLE Contas_Clientes
(
	Cli_Codigo  int  NOT NULL ,
	Con_Codigo  int  NOT NULL 
);

ALTER TABLE Contas_Clientes
	ADD  PRIMARY KEY    (Cli_Codigo  ,Con_Codigo  );

CREATE TABLE Contas_escritorio
(
	CEs_Codigo  int  IDENTITY (1,1) ,
	CEs_Nome  nvarchar(100)  NOT NULL ,
	CES_NivelAcesso  int  NOT NULL ,
	CES_Valor  decimal(10,3)  NOT NULL 
);

ALTER TABLE Contas_escritorio
	ADD  PRIMARY KEY    (CEs_Codigo  );

CREATE TABLE Contas_Funcionarios
(
	Fun_Codigo  int  NOT NULL ,
	Con_Codigo  int  NOT NULL 
);

ALTER TABLE Contas_Funcionarios
	ADD  PRIMARY KEY    (Fun_Codigo  ,Con_Codigo  );

CREATE TABLE Contas_Pagas
(
	Fun_Codigo  int  IDENTITY (1,1) ,
	CEs_Codigo  int  NULL ,
	COP_Data  datetime  NULL ,
	COP_venceu  nchar  NOT NULL ,
	COP_ValorPago  decimal(10,3)  NOT NULL ,
	COP_Juros  decimal(10,3)  NULL 
);

ALTER TABLE Contas_Pagas
	ADD  PRIMARY KEY    (Fun_Codigo  )
;

CREATE TABLE Custo
(
	Cus_Codigo  int  IDENTITY (1,1) ,
	Cus_Nome  nvarchar(100)  NOT NULL ,
	Cus_Pago  nchar  NULL ,
	Cus_Valor  decimal(10,3)  NOT NULL 
);

ALTER TABLE Custo
	ADD  PRIMARY KEY    (Cus_Codigo  );

CREATE TABLE Documento_digital
(
	Dod_codigo  int  IDENTITY (1,1) ,
	Dod_localizacao  nvarchar(512)  NOT NULL ,
	Pro_Numero  int  NULL 
);

ALTER TABLE Documento_digital
	ADD  PRIMARY KEY    (Dod_codigo  );

CREATE TABLE Empresa
(
	Emp_cod  int  IDENTITY (1,1) ,
	Emp_nome  nvarchar(50)  NOT NULL ,
	Emp_CNPJ  nvarchar(20)  NOT NULL ,
	Emp_descricao  nvarchar(100)  NULL ,
	Emp_telefone  nvarchar(15)  NOT NULL ,
	Emp_CEP  nvarchar(10)  NULL ,
	Emp_endereco  nvarchar(50)  NOT NULL ,
	Emp_logo  image  NULL ,
	Emp_email  nvarchar(100)  NULL ,
	Emp_numero  nvarchar(10)  NULL ,
	Emp_celular1  nvarchar(15)  NULL ,
	Emp_celular2  nvarchar(15)  NULL ,
	Emp_UF  nvarchar(2)  NULL ,
	Emp_Bairro  nvarchar(30)  NULL 
);

ALTER TABLE Empresa
	ADD  PRIMARY KEY    (Emp_cod  );

CREATE TABLE Funcionarios
(
	Fun_Codigo  int  IDENTITY (1,1) ,
	Fun_Nome  nvarchar(100)  NOT NULL ,
	Fun_RG  nvarchar(15)  NULL ,
	Fun_CPF  nvarchar(15)  NULL ,
	Fun_Tipo  nchar  NULL ,
	Fun_Telefone  nvarchar(15)  NULL ,
	Fun_Celular  nvarchar(15)  NULL ,
	Fun_Email  nvarchar(100)  NULL ,
	Fun_Endereco  nvarchar(100)  NULL ,
	Fun_Numero  nvarchar(20)  NULL ,
	Fun_Cidade  nvarchar(50)  NULL ,
	Fun_Bairro  nvarchar(50)  NULL 
);

ALTER TABLE Funcionarios
	ADD  PRIMARY KEY    (Fun_Codigo  );

CREATE TABLE Honorarios
(
	Hon_Codigo  int  IDENTITY (1,1) ,
	Pro_Numero  int  NULL ,
	Hon_DataInicial  datetime  NULL ,
	Hon_ValorTotal  decimal(10,3)  NULL ,
	Hon_Parcelado  nchar  NULL ,
	Hon_QuantidadeParcelas  int  NULL ,
	Hon_Descricao  nvarchar(255)  NULL ,
	Hon_NivelAcesso  int  NOT NULL 
);

ALTER TABLE Honorarios
	ADD  PRIMARY KEY    (Hon_Codigo  );

CREATE TABLE Movimentacao
(
	Mov_Cod  int  IDENTITY (1,1) ,
	Mov_Descricao  nvarchar(255)  NULL 
);

ALTER TABLE Movimentacao
	ADD  PRIMARY KEY    (Mov_Cod  );

CREATE TABLE Movimentacoes_Contas
(
	Mov_Cod  int  NOT NULL ,
	Con_Codigo  int  NOT NULL ,
	Mvc_Data  datetime  NULL ,
	Mvc_Valor  decimal(10,3)  NOT NULL 
);

ALTER TABLE Movimentacoes_Contas
	ADD  PRIMARY KEY    (Mov_Cod  ,Con_Codigo  );

CREATE TABLE Pastas
(
	Pas_Codigo  int  IDENTITY (1,1) ,
	Pro_Numero  int  NOT NULL ,
	Pas_LocPasta  nvarchar(30)  NOT NULL 
);

ALTER TABLE Pastas
	ADD  PRIMARY KEY    (Pas_Codigo  );

CREATE TABLE Processos
(
	Pro_Numero  int  IDENTITY (1,1) ,
	Pro_Forum  nvarchar(100)  NULL ,
	Pro_Vara  nvarchar(100)  NULL ,
	Pro_Tipo  nvarchar(50)  NULL ,
	Pro_DataDistribuicao  datetime  NULL ,
	Pro_Area  nvarchar(100)  NULL ,
	Pro_Local  nvarchar(50)  NULL ,
	Pro_NivelAcesso  int  NOT NULL ,
	Pro_Situacao  nchar  NULL ,
	Fun_AdvResp  int  NULL 
);

ALTER TABLE Processos
	ADD  PRIMARY KEY    (Pro_Numero  );

CREATE TABLE Processos_Clientes
(
	Pro_Numero  int  NOT NULL ,
	Cli_Codigo  int  NOT NULL 
);

ALTER TABLE Processos_Clientes
	ADD  PRIMARY KEY    (Pro_Numero  ,Cli_Codigo  );

CREATE TABLE Processos_Custos
(
	Pro_Numero  int  NOT NULL ,
	Cus_Codigo  int  NOT NULL 
);

ALTER TABLE Processos_Custos
	ADD  PRIMARY KEY    (Pro_Numero  ,Cus_Codigo  );

CREATE TABLE Processos_Funcionarios
(
	Fun_Codigo  int  NOT NULL ,
	Pro_Numero  int  NOT NULL 
);

ALTER TABLE Processos_Funcionarios
	ADD  PRIMARY KEY    (Fun_Codigo  ,Pro_Numero  );

CREATE TABLE Recebimentos
(
	Rec_Codigo  int  IDENTITY (1,1) ,
	Cli_Codigo  int  NOT NULL ,
	Pro_Numero  int  NOT NULL ,
	Hon_Codigo  int  NOT NULL ,
	Rece_Data  datetime  NOT NULL ,
	Rece_Descricao  nvarchar(100)  NULL ,
	Rece_Valor  decimal(10,3)  NOT NULL 
);

ALTER TABLE Recebimentos
	ADD  PRIMARY KEY    (Rec_Codigo  );

CREATE TABLE Usuarios
(
	usu_login  nvarchar(30)  NOT NULL ,
	usu_nivelacesso  int  NOT NULL ,
	Fun_Codigo  int  NULL ,
	usu_senha  nvarchar(20)  NOT NULL 
);

ALTER TABLE Usuarios
	ADD CONSTRAINT  PK_Usuarios PRIMARY KEY (usu_login);

ALTER TABLE Calendario
	ADD CONSTRAINT  FK_CalendarioCliente FOREIGN KEY (Cli_Codigo) REFERENCES Clientes(Cli_Codigo);

ALTER TABLE Calendario
	ADD CONSTRAINT  FK_CalendarioProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Calendario
	ADD CONSTRAINT  FK_CalendarioContas_Escritorio FOREIGN KEY (CEs_Codigo) REFERENCES Contas_escritorio(CEs_Codigo);

ALTER TABLE Calendario
	ADD CONSTRAINT  FK_CalendarioFuncionarios FOREIGN KEY (Fun_Codigo) REFERENCES Funcionarios(Fun_Codigo);

ALTER TABLE Calendario
	ADD CONSTRAINT  FK_CalendarioHonorarios FOREIGN KEY (Hon_Codigo) REFERENCES Honorarios(Hon_Codigo);

ALTER TABLE Calendario
	ADD CONSTRAINT  FK_CalendarioCusto FOREIGN KEY (Cus_Codigo) REFERENCES Custo(Cus_Codigo);

ALTER TABLE Clientes_Custos
	ADD CONSTRAINT  FK_Clientes_CustosClientes FOREIGN KEY (Cli_Codigo) REFERENCES Clientes(Cli_Codigo);

ALTER TABLE Clientes_Custos
	ADD CONSTRAINT  FK_Clientes_CustosCusto FOREIGN KEY (Cus_Codigo) REFERENCES Custo(Cus_Codigo);

ALTER TABLE Contas_Clientes
	ADD CONSTRAINT  FK_Contas_ClientesClientes FOREIGN KEY (Cli_Codigo) REFERENCES Clientes(Cli_Codigo);

ALTER TABLE Contas_Clientes
	ADD CONSTRAINT  FK_Contas_ClientesContas_Banco FOREIGN KEY (Con_Codigo) REFERENCES Contas_Banco(Con_Codigo);

ALTER TABLE Contas_Funcionarios
	ADD CONSTRAINT  FK_Contas_FuncionariosFuncionarios FOREIGN KEY (Fun_Codigo) REFERENCES Funcionarios(Fun_Codigo);

ALTER TABLE Contas_Funcionarios
	ADD CONSTRAINT  FK_Contas_FuncionariosContas_Banco FOREIGN KEY (Con_Codigo) REFERENCES Contas_Banco(Con_Codigo);

ALTER TABLE Contas_Pagas
	ADD CONSTRAINT  FK_Contas_PagasFuncionarios FOREIGN KEY (Fun_Codigo) REFERENCES Funcionarios(Fun_Codigo);

ALTER TABLE Contas_Pagas
	ADD CONSTRAINT  FK_Contas_PagasContas_escritorio FOREIGN KEY (CEs_Codigo) REFERENCES Contas_escritorio(CEs_Codigo);

ALTER TABLE Documento_digital
	ADD CONSTRAINT  FK_Documento_digitalProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Honorarios
	ADD CONSTRAINT  FK_HorariosProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Movimentacoes_Contas
	ADD CONSTRAINT  FK_Movimentacoes_ContasMovimentacao FOREIGN KEY (Mov_Cod) REFERENCES Movimentacao(Mov_Cod);

ALTER TABLE Movimentacoes_Contas
	ADD CONSTRAINT  FK_Movimentacoes_ContasContas_Banco FOREIGN KEY (Con_Codigo) REFERENCES Contas_Banco(Con_Codigo);

ALTER TABLE Pastas
	ADD CONSTRAINT  FK_PastasProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Processos
	ADD CONSTRAINT  FK_ProcessosFuncionarios FOREIGN KEY (Fun_AdvResp) REFERENCES Funcionarios(Fun_Codigo);

ALTER TABLE Processos_Clientes
	ADD CONSTRAINT  FK_Processos_ClientesProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Processos_Clientes
	ADD CONSTRAINT  FK_Processos_ClientesClientes FOREIGN KEY (Cli_Codigo) REFERENCES Clientes(Cli_Codigo);

ALTER TABLE Processos_Custos
	ADD CONSTRAINT  FK_Processos_CustosProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Processos_Custos
	ADD CONSTRAINT  FK_Processos_CustosCusto FOREIGN KEY (Cus_Codigo) REFERENCES Custo(Cus_Codigo);

ALTER TABLE Processos_Funcionarios
	ADD CONSTRAINT  FK_Processos_FuncionariosFuncionarios FOREIGN KEY (Fun_Codigo) REFERENCES Funcionarios(Fun_Codigo);

ALTER TABLE Processos_Funcionarios
	ADD CONSTRAINT  FK_Processos_FuncionariosProcessos FOREIGN KEY (Pro_Numero) REFERENCES Processos(Pro_Numero);

ALTER TABLE Recebimentos
	ADD CONSTRAINT  FK_RecimentosHonorarios FOREIGN KEY (Hon_Codigo) REFERENCES Honorarios(Hon_Codigo);

ALTER TABLE Recebimentos
	ADD CONSTRAINT  FK_RecimentosProcessos_Clientes FOREIGN KEY (Pro_Numero,Cli_Codigo) REFERENCES Processos_Clientes(Pro_Numero,Cli_Codigo);

ALTER TABLE Usuarios
	ADD CONSTRAINT  FK_UsuariosFuncionarios FOREIGN KEY (Fun_Codigo) REFERENCES Funcionarios(Fun_Codigo);