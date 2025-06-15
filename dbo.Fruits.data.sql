SET IDENTITY_INSERT [dbo].[Fruits] ON
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (2, N'Портокал', N'Сочен цитрусов плод, богат на витамин C', CAST(2.50 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (3, N'Лимон', N'Кисел плод, използван често за напитки и готвене', CAST(2.00 AS Decimal(18, 2)), 1)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (4, N'Праскова', N'Сочен и ароматен плод с пухкава кожа, подходящ за десерти', CAST(3.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (6, N'Череша', N'Малки, сладки или кисели плодове, използвани за компоти', CAST(5.00 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (7, N'	Кайсия', N'	Малък оранжев плод с мек вкус, подходящ за сладкиши', CAST(3.50 AS Decimal(18, 2)), 2)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (9, N'Ягода', N'	Малък, червен и ароматен плод, много сладък', CAST(6.00 AS Decimal(18, 2)), 3)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (10, N'Малина', N'Мек плод с наситен вкус, предпочитан за сладкиши.', CAST(5.50 AS Decimal(18, 2)), 3)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (11, N'Банан', N'Мек и сладък плод, много популярен за закуска', CAST(1.80 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (12, N'Ананас', N'Твърда кора и сладка, кисела сърцевина', CAST(3.50 AS Decimal(18, 2)), 4)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (14, N'Ябълка', N'Сладък и хрупкав плод, подходящ за ядене суров или в сладкиши', CAST(2.50 AS Decimal(18, 2)), 5)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (15, N'Круша', N'Мек плод с леко сладък вкус, добър за консумация суров', CAST(2.00 AS Decimal(18, 2)), 5)
INSERT INTO [dbo].[Fruits] ([NumberId], [Name], [Description], [Price], [TypeNumberId]) VALUES (16, N'Диня', N'Голям плод с твърда кора и сладка, сочна червена сърцевина', CAST(0.80 AS Decimal(18, 2)), 6)
SET IDENTITY_INSERT [dbo].[Fruits] OFF
