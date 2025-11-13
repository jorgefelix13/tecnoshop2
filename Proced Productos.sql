
USE BDTecnoShop


CREATE PROC Productos_All
AS
BEGIN
	SELECT 
		p.pro_id AS ID,
		p.pro_nombre AS Nombre,
		p.pro_descripcion AS Descripcion,
		p.pro_especificaciones AS Especificaciones,
		p.pro_precioVenta AS PrecioVenta,
		p.pro_precioCompra AS PrecioCompra,
		p.pro_stock AS Stock,
		Cat.cat_nombre AS Categoria,
		p.pro_activo AS Activo,
		m.mar_nombre AS Marca,
		m.mar_logoUrl AS LogoUrl,
		pimg.pimg_url AS ImgUrl
	FROM productos p
	INNER JOIN productoImagenes pimg ON p.pro_id = pimg.pimg_proId
	INNER JOIN categorias Cat ON p.pro_catId = Cat.cat_id
	INNER JOIN marcas m ON p.pro_marId = m.mar_id
	ORDER BY p.pro_id ASC;
END;

------------------------------------------------------------------------------------------


CREATE PROC Productos_ADD
	@Nombre NVARCHAR(100),
	@Descripcion NVARCHAR(255),
	@Especificaciones NVARCHAR(MAX),
	@PrecioVenta DECIMAL(10,2),
	@PrecioCompra DECIMAL(10,2),
	@Stock INT,
	@CategoriaId INT,
	@MarcaId INT
AS
BEGIN
	-- Insertar producto
	INSERT INTO productos (
		pro_nombre, pro_descripcion, pro_especificaciones,
		pro_precioVenta, pro_precioCompra, pro_stock,
		pro_catId, pro_marId, pro_activo
	)
	VALUES (
		@Nombre, @Descripcion, @Especificaciones,
		@PrecioVenta, @PrecioCompra, @Stock,
		@CategoriaId, @MarcaId, 1
	);
END;

--------------------------------------------------------------------------------------


CREATE PROC Productos_Update
	@ProductoId INT,
	@Nombre NVARCHAR(100),
	@Descripcion NVARCHAR(255),
	@Especificaciones NVARCHAR(MAX),
	@PrecioVenta DECIMAL(10,2),
	@PrecioCompra DECIMAL(10,2),
	@Stock INT,
	@CategoriaId INT,
	@MarcaId INT
AS
BEGIN
	UPDATE productos
	SET 
		pro_nombre = @Nombre,
		pro_descripcion = @Descripcion,
		pro_especificaciones = @Especificaciones,
		pro_precioVenta = @PrecioVenta,
		pro_precioCompra = @PrecioCompra,
		pro_stock = @Stock,
		pro_catId = @CategoriaId,
		pro_marId = @MarcaId
	WHERE pro_id = @ProductoId;
END;

--------------------------------------------------------------------------------------


CREATE PROC Productos_Delete
	@ProductoId INT,
	@Activo BIT
AS
BEGIN
	UPDATE productos
	SET pro_activo = @Activo
	WHERE pro_id = @ProductoId;
END;