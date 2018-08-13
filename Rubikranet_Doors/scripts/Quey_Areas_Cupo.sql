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