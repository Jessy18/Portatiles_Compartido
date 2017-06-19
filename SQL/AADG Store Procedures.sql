

--- PROCEDIMIENTOS ALMACENADOS AADG

--############################################          REMISIONES       #########################################

go
create procedure Remisiones_Agregar (
@NumRemision		as int,
@IdSucursalSalida	as nvarchar(10),
@IdSucursalEntrada	as nvarchar(10),
@IdUsuRemite		as nvarchar(10),
@IdUsuAutoriza		as nvarchar(10),
@IdUsuRecibe		as nvarchar(10),
@NumRemisionSuc		as int,
@Fecha				as date,
@Observaciones		as nvarchar(300),
@Total				as numeric(10,0)
)
as
begin	
	-- insertamos la remision
	INSERT INTO Remisiones (NumRemision,  IdSucursalSalida,  IdSucursalEntrada,  IdUsuRemite,  IdUsuAutoriza,  IdUsuRecibe,  NumRemisionSuc,  Fecha,  Observaciones,  Total,  Editar, Anulada) VALUES
	   					  (@NumRemision, @IdSucursalSalida, @IdSucursalEntrada, @IdUsuRemite, @IdUsuAutoriza, @IdUsuRecibe, @NumRemisionSuc, @Fecha, @Observaciones, @Total,       0,       0)
	
end 

go

create function Remisiones_ObtieneNum(@IdSucursalSalida nvarchar(10)) 
returns @t TABLE (NumRemision int, NumRemisionSuc int)
AS
Begin
	Declare @NumRemision as INT
	Declare @NumRemisionSuc as INT
	select @NumRemision = ISNULL(Remisiones, 1) FROM Empresa
	select @NumRemisionSuc = ISNULL(NumRemisionSuc, 1) FROM Sucursales Where IdSucursal = @IdSucursalSalida	

	INSERT @t Select @NumRemision, @NumRemisionSuc;
	return
end

go

Create procedure Remisiones_ActualizaNum(@IdSucursalSalida nvarchar(10)) 
AS
Begin
	-- Actualizamos la numeración de Remisiones de la Empresa
	UPDATE Empresa SET [Remisiones] = [Remisiones] + 1

	-- Actualizamos la numeración de Remisiones de la Sucursal
	UPDATE Sucursales SET [NumRemisionSuc] = [NumRemisionSuc] + 1 WHERE IdSucursal = @IdSucursalSalida
end


--select * From Remisiones_ObtieneNum('001')
--execute Remisiones_ActualizaNum '001'

go

create procedure Remisiones_Anular(
@NumRemision	int
)
as
	begin		
		--Eliminamos su detalle
		DELETE FROM DetalleRemision WHERE	NumRemision	= @NumRemision

		-- actualizamos la remision
		UPDATE Remisiones SET	Observaciones		= '*** ANULADA ***',
								Total				= 0,
								Editar				= 0,
								Anulada				= 1
		WHERE					NumRemision			= @NumRemision
	
	end 
go

--############################################      DETALLE REMISIONES     #########################################

create procedure Remisiones_Det_Agregar (
@NumRemision		as int,
@IdProducto			as nvarchar(10),
@Cantidad			as numeric(10, 0),
@Costo				as numeric(10, 4)
)
as
begin	
	-- insertamos la remision
	INSERT INTO DetalleRemision (NumRemision,  IdProducto,  Cantidad,  Costo) VALUES
	   						   (@NumRemision, @IdProducto, @Cantidad, @Costo)
	
end 


go

--############################################      SUCURSALES     #########################################
Create procedure Sucursales_GLUE(
@IdEmpresa	int
)
as
begin		
	Select IdSucursal, Sucursal From Sucursales	Where IdEmpresa = @IdEmpresa AND Activa=1
	order BY Sucursal ASC
end 
go

Create procedure Sucursales_Agregar(
@IdSucursal		nvarchar(10),
@IdEmpresa		int,
@Sucursal		nvarchar(100),
@DirSucursal	nvarchar(200),
@NumCompraSuc	int,
@NumRemisionSuc	int,
@NumFacturaSuc	int,
@NumAjusteSuc	int
)
as
begin		
	INSERT INTO Sucursales
    ( IdSucursal,  IdEmpresa,  Sucursal,  DirSucursal, Activa,  NumCompraSuc,  NumRemisionSuc,  NumFacturaSuc,  NumAjusteSuc) VALUES 
	(@IdSucursal, @IdEmpresa, @Sucursal, @DirSucursal,      1,   @NumCompraSuc, @NumRemisionSuc, @NumFacturaSuc, @NumAjusteSuc)
end 
go

Create procedure Sucursales_Actualizar(
@IdSucursal		nvarchar(10),
@IdEmpresa		int,
@Sucursal		nvarchar(100),
@DirSucursal	nvarchar(200),
@Activa			bit,
@NumCompraSuc	int,
@NumRemisionSuc	int,
@NumFacturaSuc	int,
@NumAjusteSuc	int
)
as
begin		
	UPDATE Sucursales SET		
		IdEmpresa		= @IdEmpresa,
		Sucursal		= @Sucursal,
		DirSucursal		= @DirSucursal,
		Activa			= @Activa,
		NumCompraSuc	= @NumCompraSuc,
		NumRemisionSuc	= @NumRemisionSuc,
		NumFacturaSuc	= @NumFacturaSuc,
		NumAjusteSuc	= @NumAjusteSuc
	WHERE IdSucursal	= @IdSucursal
end 
go

--############################################      USUARIOS       #########################################
go
Create procedure Usuarios_GLUE(
@IdSucursal	nvarchar(10) = ''
)
as
begin		
	if @IdSucursal = ''
	begin
		Select IdUsuario, Nombre AS Usuario From Usuarios	Where  Activo=1
		order BY Nombre	ASC
	end
	else
	begin
		Select IdUsuario, Nombre AS Usuario From Usuarios	Where  Activo=1 AND IdSucursal = @IdSucursal
		order BY Nombre	ASC
	end	
end 
go

create procedure Usuarios_Agregar (
@IdUsuario			as nvarchar(10),
@IdSucursal			as nvarchar(10),
@Nombre				as nvarchar(10),
@Clave				as nvarchar(15),
@Administrador		as bit
)
as
	if not exists (select * From Usuarios Where IDUsuario=@IdUsuario AND Nombre=@Nombre)
	begin		
		-- insertamos
		INSERT INTO Usuarios Values (@IdUsuario, @IdSucursal, @Nombre, @Clave, 1, @Administrador)	
	end 
go 

--############################################      MARCAS       #########################################

go
create procedure Marcas_Agregar (
@IdMarca	as nvarchar(10),
@Marca		as nvarchar(20)
)
as
-- insertamos la Marca
INSERT INTO Marcas(IdMarca,  Marca,  Activo) VALUES
					  (@IdMarca, @Marca,  1)


go
alter procedure Marcas_Actualizar (
@IdMarca	as nvarchar(10),
@Marca		as nvarchar(10),
@Activo		AS bit
)
as
-- insertamos la Marca
UPDATE Marcas SET	Marca	=	@Marca,
					Activo	=	@Activo
			  WHERE IdMarca =	@IdMarca
go					  

--############################################      PRODUCTOS       #########################################
go
create procedure Productos_ActualizarExist (@idProducto nvarchar(10), @idSucursal nvarchar(10) = '')
AS
begin 
	--verificamos que no sea un producto de servicio
	declare @Servicio bit
	Select @Servicio = servicio from Productos
	if @servicio = 1
	begin		
		UPDATE Productos SET [Existencia] = 0 WHERE IdProducto = @idProducto
		return
	end

	DECLARE @Total int, @Ventas int, @Compras int, @AjustesSuma int, @AjustesResta int
	DECLARE @RemisionesResta int, @RemisionesSuma int

	--Verificamos las Compras
	if @idSucursal = ''
	begin
		Select @Compras = ISNULL(SUM(dc.Cantidad), 0) From Compras AS c
		INNER JOIN  DetalleCompra AS dc ON c.NumCompra = dc.NumCompra 
		Where dc.IdProducto = @idProducto AND c.Anulada = 0	AND C.Aplicada = 1
	end
	else
	begin
		Select @Compras = ISNULL(SUM(dc.Cantidad), 0) From Compras AS c
		INNER JOIN  DetalleCompra AS dc ON c.NumCompra = dc.NumCompra 
		Where dc.IdProducto = @idProducto AND c.IdSucursal = @idSucursal AND c.Anulada = 0 AND C.Aplicada = 1
	end

	--Verificamos las Ventas
	if @idSucursal = ''
	begin
		Select @Ventas = ISNULL(SUM(dv.Cantidad), 0) From Ventas AS v
		INNER JOIN  DetalleVenta AS dv ON v.NumVenta = dv.NumVenta 
		Where dv.IdProducto = @idProducto AND v.Anulada = 0	
	end
	else
	begin
		Select @Ventas = ISNULL(SUM(dv.Cantidad), 0) From Ventas AS v
		INNER JOIN  DetalleVenta AS dv ON v.NumVenta = dv.NumVenta 
		Where dv.IdProducto = @idProducto AND v.IdSucursal = @idSucursal AND v.Anulada = 0	
	end

	--Verificamos los Ajustes de Aumento
	if @idSucursal = ''
	begin
		Select @AjustesSuma = ISNULL(SUM(da.Cantidad), 0) From Ajustes AS a
		INNER JOIN  DetalleAjuste AS da ON a.NumAjuste = da.NumAjuste
		INNER JOIN  TipoAjuste as ta ON ta.IdTipo = a.IdTipo
		Where da.IdProducto = @idProducto AND a.Anulado = 0	AND ta.Valor = 1
	end
	else
	begin
		Select @AjustesSuma = ISNULL(SUM(da.Cantidad), 0) From Ajustes AS a
		INNER JOIN  DetalleAjuste AS da ON a.NumAjuste = da.NumAjuste
		INNER JOIN  TipoAjuste as ta ON ta.IdTipo = a.IdTipo
		Where da.IdProducto = @idProducto AND a.IdSucursal = @idSucursal AND a.Anulado = 0	AND ta.Valor = 1
	end

	--Verificamos los Ajustes de Disminucion
	if @idSucursal = ''
	begin
		Select @AjustesResta = ISNULL(SUM(da.Cantidad), 0) From Ajustes AS a
		INNER JOIN  DetalleAjuste AS da ON a.NumAjuste = da.NumAjuste
		INNER JOIN  TipoAjuste as ta ON ta.IdTipo = a.IdTipo
		Where da.IdProducto = @idProducto AND a.Anulado = 0	AND ta.Valor = -1
	end
	else
	begin
		Select @AjustesResta = ISNULL(SUM(da.Cantidad), 0) From Ajustes AS a
		INNER JOIN  DetalleAjuste AS da ON a.NumAjuste = da.NumAjuste
		INNER JOIN  TipoAjuste as ta ON ta.IdTipo = a.IdTipo
		Where da.IdProducto = @idProducto AND a.IdSucursal = @idSucursal AND a.Anulado = 0	AND ta.Valor = -1
	end

	--Verificamos las RemisionesEntrada
	if @idSucursal = ''
		set @RemisionesSuma = 0
	else
	begin
		Select @RemisionesSuma = ISNULL(SUM(dr.Cantidad), 0) From Remisiones AS r
		INNER JOIN  DetalleRemision AS dr ON r.NumRemision = dr.NumRemision
		Where dr.IdProducto = @idProducto AND r.IdSucursalEntrada = @idSucursal AND r.Anulada = 0
	end

	--Verificamos las Remisiones de Salida
	if @idSucursal = ''
		set @RemisionesResta = 0
	else
	begin
		Select @RemisionesResta = ISNULL(SUM(dr.Cantidad), 0) From Remisiones AS r
		INNER JOIN  DetalleRemision AS dr ON r.NumRemision = dr.NumRemision
		Where dr.IdProducto = @idProducto AND r.IdSucursalSalida = @idSucursal AND r.Anulada = 0
	end

	SET @total = @Compras + @AjustesSuma + @RemisionesSuma - @Ventas - @AjustesResta - @RemisionesResta

	if @idSucursal = ''
		UPDATE Productos SET [Existencia] = @Total WHERE IdProducto = @idProducto
	else
		UPDATE Prod_Suc SET [Existencia] = @Total WHERE IdProducto = @idProducto AND IdSucursal = @idSucursal

end


--############################################      HISTORIAL ACCIONES       #########################################
go
create procedure HistorialAcciones_GRID
(
	@Fechaini	datetime,
	@Fechafin	datetime,
	@idUsuario	nvarchar(10) = ''
)
AS
begin
		
	Select * From HistorialAcciones
	--UPDATE HistorialAcciones SET Usuario = u.Nombre
	--From HistorialAcciones as ha
	--cross join Usuarios as u
	--Where u.IDUsuario = '001'

	Select Fecha, IdUsuario, Usuario, Modulo, Accion, NumDoc, IdSucursal, DatosOLD, DatosNEW from HistorialAcciones
	 WHERE IdEmpresa = '" & IdEmpresa.ToString & "' AND Convert(Date, Fecha) 
	 BETWEEN @Fechaini AND @Fechafin
	 AND IdUsuario = @IdUsuario
	 AND IdSucursal = @IdSucursal

	
end