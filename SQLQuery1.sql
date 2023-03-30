SELECT * from GrupoUsuario
SELECT * from PermissaoGrupoUsuario WHERE IdGrupoUsuario = 4

begin tran

	DELETE FROM PermissaoGrupoUsuario = 1 AND IdGrupoUsuario = 4
	
	Delete from GrupoUsuario WHERE Id = 4
	COMMIT
	 
	 rollback