USE [XSCJDB]
GO
/****** Object:  Table [dbo].[XSB]    Script Date: 04/21/2019 20:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[XSB](
	[XH] [char](6) NOT NULL,
	[XM] [char](8) NOT NULL,
	[XB] [char](2) NOT NULL,
	[CSRQ] [datetime] NULL,
	[ZY] [char](8) NOT NULL,
	[ZXF] [int] NULL,
	[BZ] [varchar](500) NULL,
 CONSTRAINT [PK_XSB] PRIMARY KEY CLUSTERED 
(
	[XH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051101', N'王林    ', N'男', CAST(0x000081FD00000000 AS DateTime), N'计算机  ', 50, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051102', N'程明    ', N'男', CAST(0x0000836200000000 AS DateTime), N'计算机  ', 50, N'')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051103', N'王燕    ', N'女', CAST(0x0000817E00000000 AS DateTime), N'计算机  ', 50, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051104', N'韦严平  ', N'男', CAST(0x000082C200000000 AS DateTime), N'计算机  ', 50, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051106', N'李方方  ', N'男', CAST(0x0000831800000000 AS DateTime), N'计算机  ', 50, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051107', N'李明    ', N'男', CAST(0x0000824D00000000 AS DateTime), N'计算机  ', 54, N'提前修完数据结构，并获得学分')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051108', N'林一帆  ', N'男', CAST(0x0000814000000000 AS DateTime), N'计算机  ', 52, N'已提前修完一门课')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051109', N'张强民  ', N'男', CAST(0x00007FD900000000 AS DateTime), N'计算机  ', 50, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051110', N'张蔚    ', N'女', CAST(0x0000840D00000000 AS DateTime), N'计算机  ', 50, N'三好生')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051111', N'赵琳    ', N'女', CAST(0x0000822100000000 AS DateTime), N'计算机  ', 50, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051113', N'严红    ', N'女', CAST(0x0000814600000000 AS DateTime), N'计算机  ', 48, N'有一门课不及格，待补考')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051201', N'王敏    ', N'男', CAST(0x00007F9B00000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051202', N'王林    ', N'男', CAST(0x0000808400000000 AS DateTime), N'通信工程', 40, N'有一门课不及格，待补考')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051203', N'王玉民  ', N'男', CAST(0x0000822900000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051204', N'马琳琳  ', N'女', CAST(0x00007F2300000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051206', N'李计    ', N'男', CAST(0x0000816E00000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051210', N'李红庆  ', N'男', CAST(0x000080E000000000 AS DateTime), N'通信工程', 44, N'已提前修完一门课，并获得学分')
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051216', N'孙祥欣  ', N'男', CAST(0x00007F3E00000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051218', N'孙研    ', N'男', CAST(0x000082EE00000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051220', N'吴薇华  ', N'女', CAST(0x0000822100000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051221', N'刘燕敏  ', N'女', CAST(0x000081A300000000 AS DateTime), N'通信工程', 42, NULL)
INSERT [dbo].[XSB] ([XH], [XM], [XB], [CSRQ], [ZY], [ZXF], [BZ]) VALUES (N'051241', N'罗林琳  ', N'女', CAST(0x000081F200000000 AS DateTime), N'通信工程', 50, N'转专业学习')
/****** Object:  Table [dbo].[KCB]    Script Date: 04/21/2019 20:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KCB](
	[KCH] [char](3) NOT NULL,
	[KCM] [char](12) NULL,
	[XQ] [smallint] NULL,
	[XS] [int] NULL,
	[XF] [int] NULL,
 CONSTRAINT [PK_KCB] PRIMARY KEY CLUSTERED 
(
	[KCH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'101', N'计算机基础  ', 1, 64, 3)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'102', N'C++程序设计 ', 2, 68, 4)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'103', N'数据结构    ', 3, 68, 5)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'104', N'计算机组成  ', 3, 96, 4)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'105', N'操作系统    ', 4, 80, 5)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'106', N'数据库原理  ', 7, 112, 5)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'107', N'计算机网络  ', 5, 96, 4)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'108', N'计算机新技术', 1, 32, 2)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'201', N'高等数学    ', 1, 80, 5)
INSERT [dbo].[KCB] ([KCH], [KCM], [XQ], [XS], [XF]) VALUES (N'202', N'离散数学    ', 3, 68, 4)
/****** Object:  Table [dbo].[CJB]    Script Date: 04/21/2019 20:52:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CJB](
	[XH] [char](6) NOT NULL,
	[KCH] [char](3) NOT NULL,
	[CJ] [int] NULL,
 CONSTRAINT [PK_CJB] PRIMARY KEY CLUSTERED 
(
	[XH] ASC,
	[KCH] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051101', N'101', 80)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051101', N'102', 78)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051102', N'101', 66)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051102', N'102', 62)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051103', N'101', 70)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051103', N'102', 81)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051104', N'101', 90)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051104', N'102', 84)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051106', N'101', 65)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051106', N'102', 78)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051107', N'101', 78)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051107', N'102', 65)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051108', N'101', 71)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051108', N'102', 80)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051109', N'101', 78)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051109', N'102', 80)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051110', N'101', 68)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051110', N'102', 85)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051111', N'101', 64)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051111', N'102', 87)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051113', N'101', 66)
INSERT [dbo].[CJB] ([XH], [KCH], [CJ]) VALUES (N'051113', N'102', 83)
