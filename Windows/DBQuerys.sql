ALTER PROCEDURE ObtenerContrato --ObtenerContrato '1'
	-- Add the parameters for the stored procedure here
	@ContratoId INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT
		C.Id,
		CL.NombreCompleto,
		CL.Documento,
		CL.Direccion,
		CL.Celular,

		C.Contenido,
		C.DireccionObra,
		C.Referencia,
		C.Observaciones,
		C.ConceptoAdicional,
		C.MontoAdicional,

		E.Codigo,
		E.Descripcion,
		E.Serie,
		E.Marca,
		E.Modelo,

		D.FechaInicio,
		D.FechaFin,
		D.Monto

	FROM ContratoEntities C
		INNER JOIN DetalleContratoEntities D ON C.Id = D.ContratoId
		INNER JOIN ClienteEntities CL ON C.ClienteId = CL.Id
		INNER JOIN EquipoEntities E ON D.EquipoId = E.Id
	WHERE C.Id = @ContratoId
END
GO
