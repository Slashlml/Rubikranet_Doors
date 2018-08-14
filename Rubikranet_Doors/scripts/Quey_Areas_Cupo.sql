CREATE PROCEDURE AREAS_PROCEDURE
@_RFID varchar(30),
@_AREA int
AS
SELECT cli.id_membresia,cli.nombre,cat_memb.id_categoria,ar.id_area,ar.cupo_actual,ar.cupo_maximo
FROM clientes as cli,membresias as memb,categorias_membresias as cat_memb,areas as ar, accesibilidad_areas as acc_ar
WHERE cli.id_membresia = @_RFID AND memb.id_membresia = cli.id_membresia AND memb.id_categoria = cat_memb.id_categoria
AND ar.id_area = @_AREA AND acc_ar.id_categoria = cat_memb.id_categoria AND acc_ar.id_area = ar.id_area
GO

EXEC AREAS_PROCEDURE '04D195323C4D80','1' 
SELECT * FROM clientes WHERE id_membresia = '046ADF323C4D80'


CREATE PROCEDURE ADD_CUPO
@_AREA INT,
@_CUPO INT
AS
UPDATE areas SET cupo_actual = @_CUPO WHERE id_area = @_AREA

EXEC ADD_CUPO '1','119'

select * from areas where id_area = '1'



-----------NUEVOS----------
create procedure verificaCliente
	@_RFID varchar(30),
	@_AREA int
	as
	SELECT
	cli.id_cliente,
	cli.nombre,
	ar.cupo_actual,
	ar.cupo_maximo
	FROM clientes as cli,
	membresias as memb,
	categorias_membresias as cat,
	areas as ar, 
	accesibilidad_areas as acc_ar
	WHERE 
	cli.estatus <> 1 and
	memb.estatus <> 1 and
	cli.id_membresia = @_RFID AND 
	memb.id_membresia = @_RFID AND 
	memb.id_categoria = cat.id_categoria AND 
	ar.id_area = @_AREA AND 
	acc_ar.id_categoria = memb.id_categoria AND 
	acc_ar.id_area = @_AREA and
	cast(GETDATE() as date) between memb.vigencia_inicio and memb.vigencia_fin
	GO


	create procedure verificaMiembro
	@_RFID varchar(30),
	@_AREA int
	as
	select
		cli.id_cliente,
		mfm.id_membresia,
		mfm.id_membresia_familiar, 
		mfm.nombre,
		ar.cupo_maximo, 
		ar.cupo_actual,
		ppm.tipo_edad

		from membresia_familiar_miembros mfm, 
		precio_por_miembro ppm,
		areas ar, 
		clientes cli, 
		accesibilidad_areas acc,
		membresias memb

		where mfm.id_membresia_familiar = @_RFID and
		mfm.id_membresia = cli.id_membresia and
		mfm.id_membresia = memb.id_membresia and
		mfm.id_precio_miembro = ppm.id_precio_miembro and
		memb.estatus <> 1 and
		mfm.estatus <> 1 and
		ar.id_area = @_AREA and
		acc.id_categoria = memb.id_categoria and 
		acc.id_area = @_AREA and
		cast(GETDATE() as date) between memb.vigencia_inicio and memb.vigencia_fin
	go



	CREATE PROCEDURE actualiza_Areas_VisitadasAndCupo
	@check int,--1 = entrará, 0 = salirá
	@_AREA int,
	@id_cliente varchar(30),
	@id_miembro varchar(30)
	AS
	begin
	if @check = 1
		begin
		insert into areas_visitadas(id_cliente, id_membresia_familiar, id_area, hora_entrada, fecha)
		values(@id_cliente, @id_miembro, @_AREA, (SELECT CONVERT(VARCHAR(8), GETDATE(), 108) 'hh:mi:ss'), GETDATE())

		UPDATE areas SET cupo_actual = cupo_actual + 1 WHERE id_area = @_AREA
		end
	else
		begin
		update areas_visitadas
		set hora_salida = (SELECT CONVERT(VARCHAR(8), GETDATE(), 108) 'hh:mi:ss')
		where id_cliente = @id_cliente and fecha = CAST(GETDATE() as date) and id_membresia_familiar = @id_miembro or id_cliente = @id_cliente and fecha = CAST(GETDATE() as date) and 
		  isnull(id_membresia_familiar, 'no') = 'no'

		UPDATE areas SET cupo_actual = cupo_actual - 1 WHERE id_area = @_AREA
		end
	end
	go