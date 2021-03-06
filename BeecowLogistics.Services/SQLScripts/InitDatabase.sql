USE [BeecowLogistic]
GO
/****** Object:  Table [dbo].[ChildRoute]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChildRoute](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](255) NULL,
	[Name] [nvarchar](255) NULL,
	[TimeStart] [datetime] NULL,
	[TimeEnd] [datetime] NULL,
	[Length] [int] NULL,
	[Status] [int] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NULL,
 CONSTRAINT [PK_ChildRoute] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Delivery]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Delivery] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[UserID] [uniqueidentifier] NULL,
	[SenderName] [nvarchar](255) NOT NULL,
	[SenderPhone] [varchar](50) NOT NULL,
	[SenderAddress] [nvarchar](max) NULL,
	[SenderCity] [nvarchar](255) NULL,
	[SenderDistrict] [nvarchar](255) NULL,
	[SenderWard] [nvarchar](255) NULL,
	[SenderStreet] [nvarchar](255) NULL,
	[ReceiverName] [nvarchar](255) NOT NULL,
	[ReceiverPhone] [varchar](50) NOT NULL,
	[ReceiverAddress] [nvarchar](max) NULL,
	[ReceiverCity] [nvarchar](255) NULL,
	[ReceiverDistrict] [nvarchar](255) NULL,
	[ReceiverWard] [nvarchar](255) NULL,
	[ReceiverStreet] [nvarchar](255) NULL,
	[PackageTypeID] [uniqueidentifier] NOT NULL,
	[SpecialOptionID] [uniqueidentifier] NULL,
	[PackageLength] [float] NULL,
	[PackageWidth] [float] NULL,
	[PackageHeight] [float] NULL,
	[PackageWeight] [float] NULL,
	[Descriptions] [nvarchar](max) NULL,
	[DeliveryID] [uniqueidentifier] NOT NULL,
	[IsForRent] [bit] NOT NULL,
	[StationForRentID] [uniqueidentifier] NULL,
	[RouteID] [uniqueidentifier] NOT NULL,
	[PayBy] [nvarchar](255) NULL,
	[PaymentTypeID] [uniqueidentifier] NOT NULL,
	[IsCOD] [bit] NOT NULL,
	[CODAmount] [decimal](18, 0) NOT NULL,
	[CODFee] [decimal](18, 0) NOT NULL,
	[ShippingFee] [decimal](18, 0) NOT NULL,
	[Tax] [decimal](18, 0) NOT NULL,
	[TotalFee] [decimal](18, 0) NOT NULL,
	[StationID] [uniqueidentifier] NOT NULL,
	[CurrentPosition] [nvarchar](255) NULL,
	[Status] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackageType]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackageType](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PackageType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentType]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentType](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Route]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Route](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[RouteName] [nvarchar](255) NOT NULL,
	[Routing] [nvarchar](max) NOT NULL,
	[ChildRoutes] [nvarchar](max) NULL,
	[ShippingFeeID] [uniqueidentifier] NULL,
	[TimeStart] [datetime] NULL,
	[TimeEnd] [datetime] NULL,
	[Status] [int] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingFee]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingFee](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
	[Status] [int] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ShippingFee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShippingFeeDetail]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShippingFeeDetail](
	[ID] [uniqueidentifier] NOT NULL,
	[ShippingFeeID] [uniqueidentifier] NOT NULL,
	[Length] [float] NOT NULL,
	[Width] [float] NOT NULL,
	[Height] [float] NOT NULL,
	[Weight] [float] NOT NULL,
	[Additional] [nvarchar](max) NULL,
	[UnitPrice] [varchar](50) NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Status] [int] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ShippingFeeDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpecialOption]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpecialOption](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_SpecialOption] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Station]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Station](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Phone] [varchar](50) NULL,
	[City] [nvarchar](255) NULL,
	[District] [nvarchar](255) NULL,
	[Ward] [nvarchar](255) NULL,
	[Address] [nvarchar](max) NULL,
	[StationTypeID] [uniqueidentifier] NOT NULL,
	[IsForRent] [bit] NULL,
	[Status] [int] NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StationType]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StationType](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_StationType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[FullName] [nvarchar](255) NOT NULL,
	[Phone] [varchar](15) NOT NULL,
	[PhoneConfirmed] [bit] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NULL,
	[Gender] [bit] NOT NULL,
	[DoB] [datetime2](7) NOT NULL,
	[Status] [int] NULL,
	[IsActive] [bit] NOT NULL,
	[UserTypeID] [uniqueidentifier] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK__Users__3214EC07D6A50C52] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Users__5C7E359E8161FDC9] UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserType]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserType](
	[ID] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Code] [varchar](50) NOT NULL,
	[Status] [int] NULL,
	[IsActive] [bit] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_UserType] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicle]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicle](
	[ID] [uniqueidentifier] NOT NULL,
	[Code] [nvarchar](255) NOT NULL,
	[Type] [nvarchar](255) NULL,
	[WorkingDays] [nvarchar](50) NULL,
	[StationID] [uniqueidentifier] NULL,
	[Status] [int] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Vehicle] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleRoute]    Script Date: 6/7/2021 11:37:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleRoute](
	[ID] [uniqueidentifier] NOT NULL,
	[VehicleID] [uniqueidentifier] NOT NULL,
	[RouteID] [uniqueidentifier] NOT NULL,
	[Status] [int] NULL,
	[LastSavedUser] [nvarchar](max) NULL,
	[LastSavedTime] [datetime2](7) NOT NULL,
	[CreatedUser] [nvarchar](max) NULL,
	[CreatedTime] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_VehicleRoute] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF__Users__Id__2C3393D0]  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Delivery] FOREIGN KEY([DeliveryID])
REFERENCES [dbo].[Delivery] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Delivery]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PackageType] FOREIGN KEY([PackageTypeID])
REFERENCES [dbo].[PackageType] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_PackageType]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_PaymentType] FOREIGN KEY([PaymentTypeID])
REFERENCES [dbo].[PaymentType] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_PaymentType]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Route] FOREIGN KEY([RouteID])
REFERENCES [dbo].[Route] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Route]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_SpecialOption] FOREIGN KEY([SpecialOptionID])
REFERENCES [dbo].[SpecialOption] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_SpecialOption]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Station] FOREIGN KEY([StationID])
REFERENCES [dbo].[Station] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Station]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Station1] FOREIGN KEY([StationForRentID])
REFERENCES [dbo].[Station] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Station1]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([ID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[Route]  WITH CHECK ADD  CONSTRAINT [FK_Route_ShippingFee] FOREIGN KEY([ShippingFeeID])
REFERENCES [dbo].[ShippingFee] ([ID])
GO
ALTER TABLE [dbo].[Route] CHECK CONSTRAINT [FK_Route_ShippingFee]
GO
ALTER TABLE [dbo].[ShippingFeeDetail]  WITH CHECK ADD  CONSTRAINT [FK_ShippingFeeDetail_ShippingFee] FOREIGN KEY([ShippingFeeID])
REFERENCES [dbo].[ShippingFee] ([ID])
GO
ALTER TABLE [dbo].[ShippingFeeDetail] CHECK CONSTRAINT [FK_ShippingFeeDetail_ShippingFee]
GO
ALTER TABLE [dbo].[Station]  WITH CHECK ADD  CONSTRAINT [FK_Station_StationType] FOREIGN KEY([StationTypeID])
REFERENCES [dbo].[StationType] ([ID])
GO
ALTER TABLE [dbo].[Station] CHECK CONSTRAINT [FK_Station_StationType]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_UserType] FOREIGN KEY([UserTypeID])
REFERENCES [dbo].[UserType] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_UserType]
GO
ALTER TABLE [dbo].[Vehicle]  WITH CHECK ADD  CONSTRAINT [FK_Vehicle_Station] FOREIGN KEY([StationID])
REFERENCES [dbo].[Station] ([ID])
GO
ALTER TABLE [dbo].[Vehicle] CHECK CONSTRAINT [FK_Vehicle_Station]
GO
ALTER TABLE [dbo].[VehicleRoute]  WITH CHECK ADD  CONSTRAINT [FK_VehicleRoute_Route] FOREIGN KEY([RouteID])
REFERENCES [dbo].[Route] ([ID])
GO
ALTER TABLE [dbo].[VehicleRoute] CHECK CONSTRAINT [FK_VehicleRoute_Route]
GO
ALTER TABLE [dbo].[VehicleRoute]  WITH CHECK ADD  CONSTRAINT [FK_VehicleRoute_Vehicle] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicle] ([ID])
GO
ALTER TABLE [dbo].[VehicleRoute] CHECK CONSTRAINT [FK_VehicleRoute_Vehicle]
GO
