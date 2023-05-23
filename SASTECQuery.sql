CREATE DATABASE SASTECteste;
USE SASTECteste;

CREATE TABLE TBcliente(
	IdCli INT PRIMARY KEY IDENTITY(1,1),
	NomeCli VARCHAR(50) NOT NULL,
	EmailCli VARCHAR(120) NOT NULL
);

INSERT INTO TBcliente (NomeCli, EmailCli) VALUES ('Fernanda','fernanda@gmail.com');