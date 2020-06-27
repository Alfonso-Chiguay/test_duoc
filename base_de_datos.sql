CREATE TABLE [persona] (
	rut integer NOT NULL,
	dv varchar(1) NOT NULL,
	nombre varchar(100) NOT NULL,
	id_sexo varchar(20) NOT NULL,
  CONSTRAINT [PK_PERSONA] PRIMARY KEY CLUSTERED
  (
  [rut] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [sexo] (
	id_sexo integer NOT NULL,
	descripcion varchar(20) NOT NULL,
  CONSTRAINT [PK_SEXO] PRIMARY KEY CLUSTERED
  (
  [id_sexo] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
ALTER TABLE [persona] WITH CHECK ADD CONSTRAINT [persona_fk0] FOREIGN KEY ([id_sexo]) REFERENCES [sexo]([id_sexo])
ON UPDATE CASCADE
GO
ALTER TABLE [persona] CHECK CONSTRAINT [persona_fk0]
GO


