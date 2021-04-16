SELECT *
FROM OPENDATASOURCE('MSOLEDBSQL'
	, 'Server=jsrevature001.database.windows.net
	;Database=jsrevature001;
	TrustServerCertificate=Yes;
	Trusted_Connection=Yes;').jsrevature001.dbo.Production