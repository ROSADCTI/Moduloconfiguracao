

INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(2,'Usu�rio cadastrar')
INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permiss�o a um grupo de usu�rio')
INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usu�rio a um usu�rio')

SELECT * FROM Permissao;
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Gerente')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Vendedo')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Estoquista')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Fiscal de caixa')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Operador de caixa')

 SELECT * FROM GrupoUsuario
 SELECT * FROM |GrupoUsuario
 SELECT* FROM Usuario
 SELECT * FROM  PermissaoGrupoUsuario
 SELECT * from UsuarioGrupoUsuario
 
 
 
SELECT * FROM GrupoUsuario






 DECLARE @IdUsuario INT = 14
 DECLARE @IdPermissao INT = 10

 SELECT 1 FROM PermissaoGrupoUsuario
 INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
 WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao