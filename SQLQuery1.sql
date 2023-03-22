

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

 SELECT * FROM GruppoUsuario;
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Gerente')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Vendedo')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Estoquista')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Fiscal de caixa')
 INSERT INTO GrupoUsuario(NomeGrupo) VALUES('Operador de caixa')

 SELECT * FROM GrupoUsuario
 
 SELECT * FROM permissaoGrupoUsuario
 SELECT * FROM UsuarioGrupoUsuario

INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,1)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,2)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,3)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,4)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,5)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,6)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,7)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,8)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,9)
INSERT INTO Permissao(IdGrupoUsuario , IdPermissao)VALUES(18,10)
					  

 INSERT INTO UsuarioGrupo(IdGrupoUsuario,Idusuario) VALUES(18,24)
 
 
SELECT * FROM Usuario
SELECT * FROM UsuarioGrupoUsuario

DECLARE @IdUsuario INT =14
DECLARE @IdPermissao INT = 10


 SELECT 1 FROM PermissaoGrupoUsuario
 INNER JOIN UsuarioGrupoUsuario ON PermissaoGrupoUsuario.IdGrupoUsuario = UsuarioGrupoUsuario.IdGrupoUsuario
 WHERE UsuarioGrupoUsuario.IdUsuario = @IdUsuario AND PermissaoGrupoUsuario.IdPermissao = @IdPermissao