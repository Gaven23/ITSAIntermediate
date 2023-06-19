IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Address')
BEGIN
CREATE TABLE [dbo].[Address](
	[AddressId] [uniqueidentifier] NOT NULL,
    [UserId] [uniqueidentifier] NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
    [Province] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Suburb] [nvarchar](50) NOT NULL,
    [PostalCode] [nvarchar](50) NOT NULL,
	[UnitNumber] [nvarchar](50) NOT NULL,
    [ComplexName] [nvarchar](50) NOT NULL,
	[CreatedOn] [datetime] NULL,
	[Deleted] [bit] NOT NULL,
	[DeletedBy] [nvarchar](max) NULL,
	[DeletedOn] [datetime] NULL,
 CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED 
(
	[AddressId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
