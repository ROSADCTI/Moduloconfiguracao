

INSERT INTO Permissao(Id, Descricao)VALUES(1,'Visualizar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(2,'Usuário cadastrar')
INSERT INTO Permissao(Id, Descricao)VALUES(3,'Alterar usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(4,'Excluir usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(5,'Visualizar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(6,'Cadastrar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(7,'Alterar grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(8,'Excluir grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(9,'Adicionar permissão a um grupo de usuário')
INSERT INTO Permissao(Id, Descricao)VALUES(10,'Adicionar grupo de usuário a um usuário')

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