GO  
CREATE TABLE [dbo].[Employee](  
[ID] [bigint] IDENTITY(1,1) NOT NULL,  
[FullName] [nvarchar](150) NULL,  
[Designation] [nvarchar](50) NULL,  
[Phone] [nvarchar](20) NULL,  
[Email] [nvarchar](50) NULL,  
CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED  
(  
[ID] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]  
) ON [PRIMARY]  
GO  


GO  
SET IDENTITY_INSERT [dbo].[Employee] ON  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (1, N'Gnanavel', N'Software Engineer', N'9876543210', N'Testmail@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (2, N'Robert ', N'Software Engineer', N'9632884100', N'Testmail1@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (3, N'Muthu ', N'Software Engineer', N'7894563210', N'Testmail2@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (4, N'Ramar ', N'Sr. Software Engineer', N'4561230789', N'Testmail3@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (5, N'Gokul', N'Sr. Software Engineer', N'7412589630', N'Testmail4@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (6, N'Karthick', N'Application Developer', N'8523697410', N'Testmail5@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (7, N'Sharma', N'Application Developer', N'9845632107', N'Testmail6@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (8, N'Sheriff', N'Application Developer', N'7563241890', N'Testmail7@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (9, N'Anand', N'Application Developer', N'9875163240', N'Testmail8@gmail.com')  
GO  
INSERT [dbo].[Employee] ([ID], [FullName], [Designation], [Phone], [Email]) VALUES (10, N'Mubarak', N'Application Developer', N'7123456890', N'Testmail9@gmail.com')  
GO  
SET IDENTITY_INSERT [dbo].[Employee] OFF  
GO  