USE [personal];
CREATE SCHEMA IF NOT EXIST [practical-project];
GO

/****** Object:  Table [practical-project].[travelq]    Script Date: 11/17/2023 12:22:44 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [practical-project].[travelq](
	[id] [varchar](100) NOT NULL,
	[ref_number] [varchar](100) NOT NULL,
	[disclosure_group] [varchar](50) NULL,
	[title_en] [varchar](100) NULL,
	[title_fr] [nvarchar](100) NULL,
	[name] [nvarchar](100) NULL,
	[purpose_en] [varchar](150) NULL,
	[purpose_fr] [nvarchar](150) NULL,
	[start_date] [datetime2](7) NULL,
	[end_date] [datetime2](7) NULL,
	[destination_en] [varchar](100) NULL,
	[destination_fr] [nvarchar](100) NULL,
	[airfare] [money] NULL,
	[other_transport] [money] NULL,
	[lodging] [money] NULL,
	[meals] [money] NULL,
	[other_expenses] [money] NULL,
	[total] [money] NULL,
	[additional_comments_en] [varchar](250) NULL,
	[additional_comments_fr] [nvarchar](250) NULL,
	[owner_org] [nvarchar](50) NULL,
	[owner_org_title] [nvarchar](150) NULL,
 CONSTRAINT [PK_travelq] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


