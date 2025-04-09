CREATE PROCEDURE sp_GetClientesPaginados
    @PageNumber INT,
    @PageSize INT
AS
BEGIN
    SELECT * FROM Clientes
    ORDER BY Id
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;
END