

CREATE TABLE TB_Alimento
(
	Id int primary key identity(1,1) not null,
	NomeAlimento VARCHAR(150) NULL,
	CaloriaPorGrama DECIMAL (8,2) NULL,
	ProteinaPorGrama DECIMAL (8,2) NULL,
	DataInclusao DATETIME2 DEFAULT GETDATE()
)
GO
CREATE TABLE TB_DietaDoDia
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	AlimentoId INT NOT NULL,
	GramasAlimento DECIMAL (8,2) NOT NULL,
	CaloriasTotais DECIMAL (8,2) DEFAULT 0,
	ProteinasTotais DECIMAL (8,2) DEFAULT 0,
	DataInclusao DATETIME2 DEFAULT GETDATE()
	CONSTRAINT FK_AlimentoId FOREIGN KEY (AlimentoId)
	REFERENCES TB_Alimento
)
