

--- PROCEDIMIENTOS ALMACENADOS AADG

--############################################          REMISIONES       #########################################
go
Create procedure Remisiones_Agregar (
@IdSucursalSalida	as nvarchar(10),
@IdSucursalEntrada	as nvarchar(10),
@IdUsuRemite		as nvarchar(10),
@IdUsuAutoriza		as nvarchar(10),
@IdUsuRecibe		as nvarchar(10),
@Fecha				as date,
@Observaciones		as nvarchar(300),
@Total				as numeric(10,0), 
@resultado			int output
)
as
begin transaction
begin try
	declare @NumRemision int
	declare @NumRemisionSuc int
	select @NumRemision = ISNULL(Remisiones, 1) FROM Empresa
	select @NumRemisionSuc = ISNULL(NumRemisionSuc, 1) FROM Sucursales Where IdSucursal = @IdSucursalSalida	

	if not exists (select * From Remisiones Where NumRemision=@NumRemision)
	begin
		if not exists (select * From Remisiones Where NumRemisionSuc=@NumRemisionSuc)
		begin
			-- insertamos la remision
			INSERT INTO Remisiones (NumRemision,  IdSucursalSalida,  IdSucursalEntrada,  IdUsuRemite,  IdUsuAutoriza,  IdUsuRecibe,  NumRemisionSuc,  Fecha,  Observaciones,  Total,  Editar, Anulada) VALUES
									(@NumRemision, @IdSucursalSalida, @IdSucursalEntrada, @IdUsuRemite, @IdUsuAutoriza, @IdUsuRecibe, @NumRemisionSuc, @Fecha, @Observaciones, @Total,       0,       0)

			-- Actualizamos la numeración de Remisiones de la Empresa
			UPDATE Empresa SET [Remisiones] = @NumRemision + 1

			-- Actualizamos la numeración de Remisiones de la Sucursal
			UPDATE Sucursales SET [NumRemisionSuc] = @NumRemisionSuc + 1 WHERE IdSucursal = @IdSucursalSalida
			set @resultado = 1
		end
		else
			set @resultado = 2
	end 
	else	
		set @resultado = 2

	commit transaction
	return @resultado
end try
begin catch
	rollback transaction
	set @resultado = 3
	return @resultado
end catch

go

Create procedure Remisiones_Actualizar (
@NumRemision		as int,
@IdSucursalSalida	as nvarchar(10),
@IdSucursalEntrada	as nvarchar(10),
@IdUsuRemite		as nvarchar(10),
@IdUsuAutoriza		as nvarchar(10),
@IdUsuRecibe		as nvarchar(10),
@NumRemisionSuc		nvarchar(10),
@Fecha				as date,
@Observaciones		as nvarchar(300),
@Total				as numeric(10,0),
@Editar				as bit,
@Anulada			as bit,
@resultado			int output
)
as
begin transaction
begin try

	if exists (select * From Remisiones Where NumRemision=@NumRemision)
	begin		
		-- actualizamos la remision
		UPDATE Remisiones SET	IdSucursalSalida	= @IdSucursalSalida,
								IdSucursalEntrada	= @IdSucursalEntrada,
								IdUsuRemite			= @IdUsuRemite,
								IdUsuAutoriza		= @IdUsuAutoriza,
								IdUsuRecibe			= @IdUsuRecibe,
								NumRemisionSuc		= @NumRemisionSuc,
								Fecha				= @Fecha,
								Observaciones		= @Observaciones,
								Total				= @Total,
								Editar				= @Editar,
								Anulada				= @Anulada
		WHERE					NumRemision			= @NumRemision

		set @resultado = 1		
	end 
	else	
		set @resultado = 2

	commit transaction
	return @resultado
end try
begin catch
	rollback transaction
	set @resultado = 3
	return @resultado
end catch

go

create procedure Remisiones_Anular(
@NumRemision	int,
@resultado		int output
)
as
begin transaction
begin try
	if exists (select * From Remisiones Where NumRemision=@NumRemision)
	begin		
		--Eliminamos su detalle
		DELETE FROM DetalleRemision WHERE	NumRemision	= @NumRemision

		-- actualizamos la remision
		UPDATE Remisiones SET	Observaciones		= 'A N U L A D A',
								Total				= 0,
								Editar				= 0,
								Anulada				= 1
		WHERE					NumRemision			= @NumRemision

		set @resultado = 1		
	end 
	else	
		set @resultado = 2

	commit transaction
	return @resultado
end try
begin catch
	rollback transaction
	set @resultado = 3
	return @resultado
end catch
