	USE HEAccounting
	DELETE FROM	AccountDetails 
	DELETE FROM	Accounts 
	DELETE FROM Cheques
	DELETE FROM CompanyInfo
	DELETE FROM Currency
	DELETE FROM CurrencyRate
	DELETE FROM Customers
	DELETE FROM [dbo].[DbLog]
	DELETE  FROM [dbo].Groups 
	DELETE FROM Items
	DELETE FROM Inventory
	DELETE  FROM dbo.itemsSellingHistory
	DELETE  FROM dbo.ItemsPurchasingHistory
	DELETE FROM NotesPayable
	DELETE FROM NotesReceive
	DELETE FROM PurchaseOrderDetails 
	DELETE FROM PurchaseOrderHeader  
	DELETE FROM SalesOrdersDetails
	DELETE FROM SalesOrdersHeader
	DELETE FROM TempID WHERE [TempTbl] <> 'Users'
    DELETE FROM	[Transaction]
	DELETE FROM Vendors

		DBCC CHECKIDENT ('[AccountDetails]', RESEED, 0)  
		DBCC CHECKIDENT ('[Accounts]', RESEED, 0)    
		DBCC CHECKIDENT ('[Cheques]', RESEED, 0)  
		DBCC CHECKIDENT ('[CompanyInfo]', RESEED, 0) 
		DBCC CHECKIDENT ('[Currency]', RESEED, 0)   
		DBCC CHECKIDENT ('[CurrencyRate]', RESEED, 0) 
		DBCC CHECKIDENT ('[Customers]', RESEED, 0)  
		DBCC CHECKIDENT ('[DbLog]', RESEED, 0)  
		DBCC CHECKIDENT ('[Groups]', RESEED, 0) 
		DBCC CHECKIDENT ('[Items]', RESEED, 0) 
		DBCC CHECKIDENT ('[Inventory]', RESEED, 0) 
		DBCC CHECKIDENT ('[itemsSellingHistory]', RESEED, 0)  
		DBCC CHECKIDENT ('[ItemsPurchasingHistory]', RESEED, 0) 
		DBCC CHECKIDENT ('[NotesPayable]', RESEED, 0)  
		DBCC CHECKIDENT ('[NotesReceive]', RESEED, 0)  
		DBCC CHECKIDENT ('[PurchaseOrderHeader]', RESEED, 0)  
		DBCC CHECKIDENT ('[PurchaseOrderDetails]', RESEED, 0) 
		DBCC CHECKIDENT ('[SalesOrdersHeader]', RESEED, 0)  
		DBCC CHECKIDENT ('[SalesOrdersDetails]', RESEED,0) 
		DBCC CHECKIDENT ('[Transaction]', RESEED, 0) 
		DBCC CHECKIDENT ('[Vendors]', RESEED, 0) 
		
		SET IDENTITY_INSERT [dbo].[Currency] ON 
			INSERT [dbo].[Currency] ([ID], [CurrencyID], [CurrName], [Symb], [PartName], [PartPrecision], [LatinName], [LatinPartName], [Date], [LatinSymb], [CurrFloat], [InitialState]) VALUES (1, 1, N'ليرة لبنانية', N'ل.ل', N'قرش', 100, N'Lebanease Pound', N'Kersh', CAST(N'2022-09-10' AS Date), N'L.L', -1, N'E')
			INSERT [dbo].[Currency] ([ID], [CurrencyID], [CurrName], [Symb], [PartName], [PartPrecision], [LatinName], [LatinPartName], [Date], [LatinSymb], [CurrFloat], [InitialState]) VALUES (2, 2, N'دولار أمريكي', N'$', N'سنت', 100, N'Dollars', N'Cent', CAST(N'2022-09-10' AS Date), N'$', 3, N'L')
		SET IDENTITY_INSERT [dbo].[Currency] OFF
		SET IDENTITY_INSERT [dbo].[CurrencyRate] ON 
			INSERT [dbo].[CurrencyRate] ([CurrencyRateID], [CurrencyID], [CurrencyVal], [CreatedDate], [CreatedDateTime]) VALUES (1, 1, 1, CAST(N'2022-09-10' AS Date), CAST(N'2022-09-10T12:25:45.590' AS DateTime))
			INSERT [dbo].[CurrencyRate] ([CurrencyRateID], [CurrencyID], [CurrencyVal], [CreatedDate], [CreatedDateTime]) VALUES (2, 2, 37500, CAST(N'2022-09-10' AS Date), CAST(N'2022-09-10T12:26:21.337' AS DateTime))
		SET IDENTITY_INSERT [dbo].[CurrencyRate] OFF 