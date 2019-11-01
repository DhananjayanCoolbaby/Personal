USE [TESTDB]
GO
/****** Object:  FullTextCatalog [FullTextCatalog]    Script Date: 9/18/2019 16:53:31 ******/
CREATE FULLTEXT CATALOG [FullTextCatalog]AS DEFAULT

GO
/****** Object:  UserDefinedTableType [dbo].[TS_HoursWorkedType]    Script Date: 9/18/2019 16:53:31 ******/
CREATE TYPE [dbo].[TS_HoursWorkedType] AS TABLE(
	[ProjectHoursWorked] [varchar](50) NULL,
	[DateWorked] [datetime] NULL,
	[TimesheetPeriodid] [int] NOT NULL,
	[Comments] [varchar](max) NULL
)
GO
/****** Object:  Table [dbo].[ContractorPersonalInfo]    Script Date: 9/18/2019 16:53:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractorPersonalInfo](
	[contractor_Id] [int] IDENTITY(1,1) NOT NULL,
	[CWRID] [varchar](100) NULL,
	[ReportingID] [varchar](200) NULL,
	[imageFilecontentId] [varchar](500) NULL,
	[firstName] [varchar](200) NOT NULL,
	[lastName] [varchar](200) NULL,
	[DOB] [datetime] NULL,
	[JoiningDate] [datetime] NULL,
	[accessCardId] [varchar](150) NULL,
	[communicationAddressLine] [varchar](500) NULL,
	[commState] [int] NULL,
	[commCity] [nvarchar](50) NULL,
	[commPincode] [int] NULL,
	[permanentAddressLine] [varchar](500) NULL,
	[perState] [int] NULL,
	[perCity] [nvarchar](50) NULL,
	[perPincode] [int] NULL,
	[officialEmailID] [varchar](200) NULL,
	[personalEmailID] [varchar](200) NULL,
	[primaryContactNo] [varchar](50) NULL,
	[secondaryContactNo] [varchar](50) NULL,
	[emergencyContactName] [varchar](100) NULL,
	[relationshipId] [int] NULL,
	[emergencyContactNo] [varchar](50) NULL,
	[isActive] [int] NULL,
	[createdBy] [varchar](10) NULL,
	[createdDate] [datetime] NULL,
	[modifiedBy] [varchar](10) NULL,
	[modifiedDate] [datetime] NULL,
	[lastUpdatedDateTime] [datetime] NULL,
	[Gender] [varchar](50) NULL,
	[VendorID] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[FatherName] [nvarchar](50) NULL,
	[Remarks] [nvarchar](max) NULL,
	[VendorEmpID] [nvarchar](50) NULL,
	[Reportingdate] [datetime] NULL,
	[VendorEmailID] [nvarchar](50) NULL,
 CONSTRAINT [PK__Contract__3213E83F4CD93F48] PRIMARY KEY CLUSTERED 
(
	[contractor_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Documents]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Documents](
	[No] [int] NOT NULL,
	[Employee] [char](9) NOT NULL,
	[DocumentDateNew] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExceptionLog]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExceptionLog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ErrorNumber] [int] NULL,
	[ErrorMessage] [nvarchar](max) NULL,
	[DateErrorRaised] [datetime] NULL,
	[ErrorSPName] [nvarchar](50) NULL,
 CONSTRAINT [PK_ExceptionLog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TempDays]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempDays](
	[dateofcurrent] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TempTableDelete]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempTableDelete](
	[cwrid] [nvarchar](50) NULL,
	[dayof] [int] NULL,
	[attdate] [date] NULL,
	[totalhrs] [nvarchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIO_ErrorLog]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIO_ErrorLog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](5000) NULL,
	[DateTime] [datetime] NOT NULL,
	[Action] [varchar](100) NULL,
 CONSTRAINT [PK_Opp_ErrorLog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TIO_StatusMaster]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIO_StatusMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StatusID] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TIO_StatusMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_Comments]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_Comments](
	[DocID] [int] IDENTITY(1,1) NOT NULL,
	[CWRID] [nvarchar](50) NOT NULL,
	[TimesheetPeriodid] [int] NOT NULL,
	[RequestId] [nvarchar](50) NULL,
	[Comments] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_TS_Comments] PRIMARY KEY CLUSTERED 
(
	[DocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_Credential]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_Credential](
	[DocID] [int] IDENTITY(1,1) NOT NULL,
	[contractor_Id] [int] NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Userlevel] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NOT NULL,
	[ReporterID] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedBy] [nvarchar](50) NULL,
	[modifiedDate] [datetime] NULL,
 CONSTRAINT [PK__TS_Crede__3EF1888D47DBAE45] PRIMARY KEY CLUSTERED 
(
	[DocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_HoursWorked]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_HoursWorked](
	[TimeSheetHourID] [int] IDENTITY(1,1) NOT NULL,
	[CWRID] [varchar](100) NULL,
	[TimesheetPeriodid] [int] NOT NULL,
	[RequestId] [varchar](50) NULL,
	[DateWorked] [datetime] NULL,
	[ProjectHoursWorked] [varchar](50) NULL,
	[ExtraHoursWorked] [decimal](18, 2) NULL,
	[HasSavedForLater] [bit] NULL,
	[IsCHApprovalRequired] [bit] NULL,
	[Status] [varchar](15) NULL,
	[CreatedBy] [varchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[RequestStatus] [varchar](200) NULL,
	[LegendStatus] [int] NULL,
 CONSTRAINT [PK__TS_Hours__5E00D051330789FE] PRIMARY KEY CLUSTERED 
(
	[TimeSheetHourID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_LeaveApplied]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_LeaveApplied](
	[TimeSheetLeaveID] [int] IDENTITY(1,1) NOT NULL,
	[TimeSheetHourID] [int] NULL,
	[CWRID] [varchar](100) NULL,
	[LeaveDate] [datetime] NULL,
	[LeaveType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[TimeSheetLeaveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_LeaveTypeMaster]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_LeaveTypeMaster](
	[LegendId] [int] IDENTITY(1,1) NOT NULL,
	[LegendName] [varchar](1000) NULL,
	[LegendShortName] [varchar](15) NULL,
 CONSTRAINT [PK_TS_LeaveTypeMaster] PRIMARY KEY CLUSTERED 
(
	[LegendId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_Position]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_Position](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[ID] [int] NOT NULL,
	[Position] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TS_Position] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_Reporting]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_Reporting](
	[ReporterID] [int] IDENTITY(1,1) NOT NULL,
	[ReporterName] [nvarchar](50) NOT NULL,
	[ReporterContactNO] [nvarchar](50) NULL,
	[ReporterEmail] [nvarchar](50) NULL,
	[costcentername] [nvarchar](50) NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_TS_Reporting] PRIMARY KEY CLUSTERED 
(
	[ReporterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_State]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_State](
	[DocID] [int] IDENTITY(1,1) NOT NULL,
	[StateID] [int] NOT NULL,
	[StateName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TS_State] PRIMARY KEY CLUSTERED 
(
	[DocID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_TimesheetPeriod]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_TimesheetPeriod](
	[TimesheetPeriodid] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_TS_TimesheetPeriod] PRIMARY KEY CLUSTERED 
(
	[TimesheetPeriodid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_UniqueIdCreation]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_UniqueIdCreation](
	[TS_Request_Id_Identity] [int] IDENTITY(1,1) NOT NULL,
	[TS_Request_Id]  AS ('RQ'+right('0000000'+CONVERT([varchar](7),[TS_Request_Id_Identity],(0)),(7))) PERSISTED,
	[Contractor_Id] [varchar](7000) NULL,
	[TimesheetPeriodid] [int] NULL,
	[CreatedDate] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TS_Vendor]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TS_Vendor](
	[VendorID] [int] IDENTITY(1,1) NOT NULL,
	[VendorName] [nvarchar](50) NOT NULL,
	[VendorContactNO] [nvarchar](50) NULL,
	[VendorEmail] [nvarchar](50) NULL,
	[Active] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_TS_Vendor] PRIMARY KEY CLUSTERED 
(
	[VendorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[TS_Credential]  WITH CHECK ADD  CONSTRAINT [FK__TS_Creden__contr__49C3F6B7] FOREIGN KEY([contractor_Id])
REFERENCES [dbo].[ContractorPersonalInfo] ([contractor_Id])
GO
ALTER TABLE [dbo].[TS_Credential] CHECK CONSTRAINT [FK__TS_Creden__contr__49C3F6B7]
GO
/****** Object:  StoredProcedure [dbo].[C_spGetErrorInfo]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[C_spGetErrorInfo]
@ErrorNumber int ,
@ErrorMessage nvarchar(max),
@ErrorSPName nvarchar(50)
as
begin
insert into ExceptionLog(ErrorNumber, ErrorMessage,DateErrorRaised,ErrorSPName)
	    values(@ErrorNumber,@ErrorMessage,GETDATE(),@ErrorSPName)
end  

GO
/****** Object:  StoredProcedure [dbo].[GetPosition]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetPosition]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
	SELECT [ID] as ID ,[Position]as Name FROM [TESTDB].[dbo].[TS_Position]
	END

 


GO
/****** Object:  StoredProcedure [dbo].[Getreporting]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[Getreporting]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  declare @month int;
set @month=11; --- input month given by user
declare @days int;
set @days= datediff(dd,getdate(),dateadd(mm,1,getdate()))
DECLARE @frmdate date,@end_date date
SET @frmdate = convert(date,(CAST( DATEPART(YEAR,GETDATE()+1)AS varchar(5)) +'-'+CAST(@month as varchar)+'-'+cast(1 as varchar)))
SET @end_date = convert(date,(CAST( DATEPART(YEAR,GETDATE()+1)AS varchar(5)) +'-'+CAST(@month as varchar)+'-'+cast(@days as varchar)))

WHILE @frmdate <= @end_date
BEGIN
 ------------------------------------------------- ------------------------------------------------- ------------------------------------------------- --------------------
DECLARE @TempProcessTable as Table(cwrid varchar(100) , wrkdate date)
			   
	Insert into @TempProcessTable(cwrid,wrkdate)             
	  select distinct cwrid,@frmdate from TS_HoursWorked

    
 SET @frmdate = DATEADD(d, 1, @frmdate)
END
--select * from @TempProcessTable
select a.cwrid as CWRID,a.wrkdate as DateWorked, case  when b.ProjectHoursWorked  is null
then 'NA' else cast(b.ProjectHoursWorked as varchar)end as 'Project Hours Worked' 
from @TempProcessTable a left join TS_HoursWorked b on a.wrkdate = b.DateWorked and a.cwrid=b.cwrid
order by cwrid, a.wrkdate asc

--Select * from TS_HoursWorked
	END

 


GO
/****** Object:  StoredProcedure [dbo].[GetState]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetState]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
	SELECT [StateID] as id ,[StateName]as Name FROM [TESTDB].[dbo].[TS_State]
END

 


GO
/****** Object:  StoredProcedure [dbo].[SP_TVRegisterAttendanceReportExcel]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec SP_TVRegisterAttendanceReportExcel 0,0,0,0,0,0,'01/01/2014','01/01/2014',1,1
create PROCEDURE [dbo].[SP_TVRegisterAttendanceReportExcel]
	@emp_id [nvarchar](max) = null,
	@department_id [nvarchar](max) = null,
	@position_id [nvarchar](max) = null,
	@nationality_id [nvarchar](max) = null,
	@group_id [nvarchar](max) = null,
	@company_id [nvarchar](max) = null,
	@Date_From datetime = NULL,
	@Date_To datetime = NULL,
	@roleid int,
	@usrid int
AS

BEGIN
-----------------------------@emp_id-------------------------------------------
DECLARE @SlNo INT,@Tno int
DECLARE @tempEmpId as Table (EmpId INT)
SELECT @SlNo=LEN(@emp_Id),@Tno=1
While @SlNo >0 Begin
	IF Right(LEFT(@emp_id,@Tno),1)=',' BEGIN
	INSERT INTO @tempEmpId	VALUES(LEFT(@emp_id, @Tno-1))	
	SELECT @emp_id=Right(@emp_id,LEN(@emp_id)-@TNo),@Tno=0
	END		
SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
END

IF EXISTS (SELECT*FROM @tempEmpId WHERE EmpId<>0 OR EmpId IS NULL) BEGIN SELECT @emp_id=1 END 
-----------------------------@department_id---------------------------------------
DECLARE @tempDepId as Table (DepId INT)
SELECT @SlNo=LEN(@department_id),@Tno=1
While @SlNo >0 Begin
	IF Right(LEFT(@department_id,@Tno),1)=',' BEGIN
	INSERT INTO @tempDepId	VALUES(LEFT(@department_id, @Tno-1))	
	SELECT @department_id=Right(@department_id,LEN(@department_id)-@TNo),@Tno=0
	END		
SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
END
IF EXISTS (SELECT*FROM @tempDepId WHERE DepId<>0) BEGIN SELECT @department_id=1 END 
-----------------------------@position_id-------------------------------------------
DECLARE @tempPosId as Table (PosId INT)
SELECT @SlNo=LEN(@position_id),@Tno=1
While @SlNo >0 Begin
	IF Right(LEFT(@position_id,@Tno),1)=',' BEGIN
	INSERT INTO @tempPosId	VALUES(LEFT(@position_id, @Tno-1))	
	SELECT @position_id=Right(@position_id,LEN(@position_id)-@TNo),@Tno=0
	END		
SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
END
IF EXISTS (SELECT*FROM @tempPosId WHERE PosId<>0) BEGIN SELECT @position_id=1 END 
------------------------------@nationality_id--------------------------------------- 
DECLARE @tempNatId as Table (NatId INT)
SELECT @SlNo=LEN(@nationality_id),@Tno=1
While @SlNo >0 Begin
	IF Right(LEFT(@nationality_id,@Tno),1)=',' BEGIN
	INSERT INTO @tempNatId	VALUES(LEFT(@nationality_id, @Tno-1))	
	SELECT @nationality_id=Right(@nationality_id,LEN(@nationality_id)-@TNo),@Tno=0
	END		
SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
END
IF EXISTS (SELECT*FROM @tempNatId WHERE NatId<>0) BEGIN SELECT @nationality_id=1 END 
------------------------------@group_id--------------------------------------- 
DECLARE @tempgroId as Table (groId INT)
SELECT @SlNo=LEN(@group_id),@Tno=1
While @SlNo >0 Begin
	IF Right(LEFT(@group_id,@Tno),1)=',' BEGIN
	INSERT INTO @tempgroId	VALUES(LEFT(@group_id, @Tno-1))	
	SELECT @group_id=Right(@group_id,LEN(@group_id)-@TNo),@Tno=0
	END		
SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
END
IF EXISTS (SELECT*FROM @tempgroId WHERE groId<>0) BEGIN SELECT @group_id=1 END 
--------------------------------@company_id--------------------------------------
DECLARE @tempcomId as Table (comId INT)
SELECT @SlNo=LEN(@company_id),@Tno=1
While @SlNo >0 Begin
	IF Right(LEFT(@company_id,@Tno),1)=',' BEGIN
	INSERT INTO @tempcomId	VALUES(LEFT(@company_id, @Tno-1))	
	SELECT @company_id=Right(@company_id,LEN(@company_id)-@TNo),@Tno=0
	END		
SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
END
IF EXISTS (SELECT*FROM @tempcomId WHERE comId<>0) BEGIN SELECT @company_id=1 END 
----------------------------------@emp_status---------------------------------------
--DECLARE @tempstatus as Table (statusk nvarchar(100))
--SELECT @SlNo=LEN(@emp_status),@Tno=1
--While @SlNo >0 Begin
--	IF Right(LEFT(@emp_status,@Tno),1)=',' BEGIN
--	INSERT INTO @tempstatus	VALUES(LEFT(@emp_status, @Tno-1))	
--	SELECT @emp_status=Right(@emp_status,LEN(@emp_status)-@TNo),@Tno=0
--	END		
--SELECT @SlNo=@SlNo-1,@Tno=@Tno+1
--end
------------------------chella----------------------
 DECLARE @PSlNo INT,@PTno int,@Peremp_id [nvarchar](max)
DECLARE @Pertempemp_id as Table (Peremp_id INT)
set @Peremp_id= (select companyids from role_menu_access where role_id=@roleid and menu_id=86)+','
SELECT @PSlNo=LEN(@Peremp_id),@PTno=1
While @PSlNo >0 Begin
	IF Right(LEFT(@Peremp_id,@PTno),1)=','
	 BEGIN
	INSERT INTO @Pertempemp_id	VALUES(LEFT(@Peremp_id, @PTno-1))	
	SELECT @Peremp_id=Right(@Peremp_id,LEN(@Peremp_id)-@PTno),@PTno=0
	END		
SELECT @PSlNo=@PSlNo-1,@PTno=@PTno+1
end
--------------------------------------------------
--IF EXISTS (SELECT*FROM @tempstatus WHERE statusk<>'0') BEGIN SELECT @emp_status=1 END 
----------------------------------------------------------------------------------



truncate table TempTableDelete
insert into TempTableDelete (empcode,empname,attdate,totalhrs,othrs,deptname,dayof)
select e.emp_reader_id,e.emp_name,att_date,cast(case when leavecode is null then cast(isnull(DATEDIFF(second, 0,
 convert(time, TotalHrs, 8)),0) as nvarchar) else leavecode end as varchar(50)),
 (select  cast(cast(datediff(hour, 0, 
    dateadd(s, sum(datediff(second, 0,
	
	case when (isnull(TotalHrs,'00:00:00')>'09:00:00') then
  convert(time,dateadd(ms,datediff(ss,'09:00:00',isnull(TotalHrs,'00:00:00'))*1000,0),114)
    else '00:00:00.000' end)), 0)) as varchar(5))*3600
  + left(right(convert(char(19),dateadd(s, sum(datediff(second, 0, 
  
  case when  (isnull(TotalHrs,'00:00:00')>'09:00:00') then
  convert(time,dateadd(ms,datediff(ss,'09:00:00',isnull(TotalHrs,'00:00:00'))*1000,0),114)
     else '00:00:00.000' end)),0), 126), 5),2)*60 as bigint)
 from Daily_attendance_data b 
 join employee s on s.emp_reader_id=a.emp_reader_id where b.emp_reader_id=a.emp_reader_id
 and (CONVERT(VARCHAR(26), b.att_date, 23) >=CONVERT(VARCHAR(26), @Date_From, 23) and CONVERT(VARCHAR(26), b.att_date, 23) <=CONVERT(VARCHAR(26), @Date_To, 23))
 )  as ottotal, d.dept_name,cast(datepart(dd,att_date) as int) 
 from Daily_attendance_data a left outer join employee e 
 on e.emp_id=a.emp_id left outer join departments d on d.dept_id= e.dept_id 
 --where a.TotalHrs is not null
 

 --select * from TempTableDelete


 WHERE --a.emp_reader_id=5024 and 
      (@emp_id=0 OR @emp_id is null  OR e.emp_id  in (select EmpId from @tempEmpId))AND 
      --(@department_id=0 OR @department_id is null  OR B.dept_id  in (select DepId from @tempDepId)) AND
      --(@position_id=0 OR @position_id is null  OR B.desn_id  in (select PosId from @tempPosId)) AND
      --(@nationality_id=0 OR @nationality_id is null  OR B.country_id  in (select NatId from @tempNatId)) AND
      --(@group_id=0 OR @group_id is null  OR B.group_id  in (select groId from @tempgroId)) AND
     (CONVERT(VARCHAR(26), A.att_date, 23) >=CONVERT(VARCHAR(26), @Date_From, 23) and CONVERT(VARCHAR(26), A.att_date, 23) <=CONVERT(VARCHAR(26), @Date_To, 23))
     -- and B.status=1  
order by a.emp_reader_id,a.att_date asc

 
DECLARE @cols AS NVARCHAR(MAX),
    @query  AS NVARCHAR(MAX)
 select @cols = STUFF((SELECT  ',' + QUOTENAME(dayof) 

  --select @cols = STUFF((SELECT  ',' + QUOTENAME(cast(left(datename(dw,attdate),3) as varchar)
 --+' '+cast(datepart(dd,attdate) as varchar)) 

                    from TempTableDelete
                    group by dayof
                    order by dayof
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')


--SELECT @cols = ISNULL(@cols+',','')+QUOTENAME(att_date)
--FROM (SELECT DISTINCT  dayof  as att_date FROM TempTableDelete ) AS att_date
 
 
--select @cols

set @query = 'SELECT empcode as Code, empname as Name,deptname as Department,' + @cols + ',0 as "Total Hours" ,othrs as "OT Hours" from 
             (
                select a.empcode, a.empname,a.deptname,a.othrs,TotalHrs,dayof
				
                from TempTableDelete a 
				
	
            ) x
            pivot 
            (
                max(totalhrs)
                for dayof in (' + @cols + ')
            ) p '

 
--set @query = 'SELECT empname as TGNo,' + @cols + ',othrs from
--             (
--                select a.empname,othrs,  cast (left(datename(dw,attdate),3) as varchar)+space(1)+
--                           cast(datepart(dd,attdate) as varchar) as attdate, totalhrs 
                          
--                from regtable1 a
                          
      
--            ) x
--            pivot
--            (
--                max(totalhrs)
--                for attdate in (' + @cols + ')
--            ) p '
 
execute(@query)

--DECLARE @cols AS NVARCHAR(MAX),
--    @query  AS NVARCHAR(MAX)
--SELECT @cols = ISNULL(@cols+',','')+QUOTENAME(att_date)
--FROM (SELECT DISTINCT  cast(datepart(dd,att_date) as int)  as att_date FROM Daily_attendance_data) AS att_date


----select @cols

--set @query = 'SELECT emp_reader_id as TGNo, emp_name as Name,dept_name as Contract,' + @cols + ' from 
--             (
--                select a.emp_reader_id, c.emp_name,b.dept_name,cast(datepart(dd,att_date) as varchar) as att_date,DATEDIFF(second, 0, convert(time, TotalHrs, 8)) as TotalHrs
				
--                from Daily_attendance_data a left outer join departments b on b.dept_id=a.dept_id
--				left outer join dbo.employee c ON (a.emp_id = c.emp_id)
				
	
--            ) x
--            pivot 
--            (
--                max(totalhrs)
--                for att_date in (' + @cols + ')
--            ) p '

--execute(@query)
END









GO
/****** Object:  StoredProcedure [dbo].[test]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[test] 
-- Add the parameters for the stored procedure here

AS
BEGIN
-- SET NOCOUNT ON added to prevent extra result sets from
SET NOCOUNT ON;
    SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;
DECLARE @TransactionName   nvarchar(max) = REPLACE(NEWID(),'-','')

   DECLARE     
   @ErrorMessage VARCHAR(4000),  
   @Source VARCHAR(100), 
   @ErrorNumber VARCHAR(100),
   @ErrorSeverity INT,
   @ErrorState INT,
   @ErrorLine VARCHAR(100)

BEGIN TRY

  BEGIN TRANSACTION @TransactionName


delete from [TS_Vendor] where [VendorName]='2' and VendorID=28
        -- continue.
		INSERT INTO [dbo].[TS_Vendor]
           ([VendorName]
           ,[VendorContactNO]
           ,[VendorEmail]
           ,[Active]
           ,[CreatedDate])
     VALUES
           ( null
           ,'asd141'
           ,'kone@com'
           ,1,getdate())
		-- 
 
 COMMIT TRANSACTION @TransactionName
END TRY

BEGIN CATCH 
  IF (@@TRANCOUNT > 0)
   BEGIN
   -- Return 0 to the calling program to indicate failure.
       SET @ErrorMessage = ERROR_MESSAGE()
	   SET @ErrorNumber = ERROR_LINE()
      ROLLBACK TRANSACTION  @TransactionName
	  exec C_spGetErrorInfo @ErrorNumber, @ErrorMessage
      Select 0 as ReturnState;
   END 
ELSE
    BEGIN
        -- Return 1 to the calling program to indicate success.
        Select 1 as ReturnState;
    END
END CATCH
END 

GO
/****** Object:  StoredProcedure [dbo].[TS_Checkcredential]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_Checkcredential]
	-- Add the parameters for the stored procedure here
	@Username varchar(50), 
	@password varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	 Select Count([UserName]) as UserName ,Userlevel From TS_Credential where [UserName]=@Username and [Password]=@password group by Userlevel
END


GO
/****** Object:  StoredProcedure [dbo].[TS_CheckUsernamesAvailability]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create  PROCEDURE [dbo].[TS_CheckUsernamesAvailability]
@UserName varchar (50)
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Select  Count ([CWRID]) From [TESTDB].[dbo].[ContractorPersonalInfo] A Where A.[CWRID]=@UserName
END

GO
/****** Object:  StoredProcedure [dbo].[TS_CreateTimeSheet]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[TS_CreateTimeSheet]

As

begin

begin try  begin tran

SET NOCOUNT ON





Declare @day int=day(getdate())

Declare @startdate date=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(getdate())-1),getdate()),101) 
--Convert(date, (getdate())-((

--					case when (@day)between 1 and 15  then (@day)

--						 when (@day) between 15 and 31 then (@day-15)end)-1))



Declare @enddate  date= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,getdate()))),
DATEADD(mm,1,getdate())),101)
--Convert(date, (getdate())+((

--							case when (@day)between 1 and 15  then(15-datepart(dd,(GETDATE())))

--								 when (@day) between 15 and 31 then (datepart(dd,DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,getdate())+1,0)))-datepart(dd,(GETDATE())))end)))  







Declare @TimesheetPeriodid int 



if not exists (select TimesheetPeriodid from [TS_TimesheetPeriod] with(nolock) where [StartDate] = @startdate and [EndDate]=@enddate)

		begin

				Insert into [TS_TimesheetPeriod] ([StartDate],[EndDate],[CreatedDate])

				values(@startdate,@enddate,getdate())

				SELECT @TimesheetPeriodid = SCOPE_IDENTITY()

		end

else 

		begin 

			SELECT @TimesheetPeriodid = TimesheetPeriodid from [TS_TimesheetPeriod] where [StartDate] = @startdate and [EndDate]=@enddate

		end 



		Select @startDate =StartDate , @endDate= EndDate 

		FROM [TS_TimesheetPeriod] with(nolock) where TimesheetPeriodid=@TimesheetPeriodid



;with dateRange as

(

	select perioddate = dateadd(dd, 0, @startDate),@startDate as startDate ,@endDate as endDate

	where dateadd(dd, 1, @startDate) <= @endDate
	
	union all

	select dateadd(dd, 1, perioddate),@startDate as startDate ,@endDate as endDate

	from dateRange

	where dateadd(dd, 1, perioddate) <= @endDate

)


merge into TS_HoursWorked [target]

using

( Select distinct ([CWRID]),@TimesheetPeriodid as TimesheetPeriodid ,

		
		perioddate from dateRange ,[ContractorPersonalInfo] a with(nolock)
		INNER JOIN  TS_Credential b on a.[CWRID]= b.UserName and Userlevel NOT IN ('l1')

)as [source] 

on Convert(date,[target].DateWorked) = [source].perioddate


 and [target].CWRID=[source].[CWRID] 



When NOT MATCHED THEN 

Insert (CWRID,TimesheetPeriodid,DateWorked,LegendStatus)

values ( source.[CWRID], source.TimesheetPeriodid, source.perioddate,0 );

if @@error=0 Commit tran else Rollback Tran END try

BEGIN CATCH

	declare @msg varchar(5000),

	@sp_name varchar(100)

	set @msg = ERROR_MESSAGE()

	--set @sp_name = concat('sp : ',ERROR_PROCEDURE())

	--EXEC InsertErrorLog @action=@sp_name, @Description=@msg

	

	IF @@TRANCOUNT > 0

	BEGIN

		--SET @msg = concat('Rolling back transaction ',ERROR_MESSAGE())

		--set @sp_name = concat('sp : ',ERROR_PROCEDURE())

		--EXEC InsertErrorLog @action=@sp_name, @Description=@msg

		ROLLBACK TRAN

	END

END CATCH

End


GO
/****** Object:  StoredProcedure [dbo].[TS_CreateTimeSheet1]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create procedure [dbo].[TS_CreateTimeSheet1]

As

begin

begin try  begin tran

SET NOCOUNT ON





Declare @day int=day(getdate())

Declare @startdate date=Convert(date, (getdate())-((

					case when (@day)between 1 and 15  then (@day)

						 when (@day) between 15 and 31 then (@day-15)end)-1))



Declare @enddate  date= Convert(date, (getdate())+((

							case when (@day)between 1 and 15  then(15-datepart(dd,(GETDATE())))

								 when (@day) between 15 and 31 then (datepart(dd,DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,getdate())+1,0)))-datepart(dd,(GETDATE())))end)))  







Declare @TimesheetPeriodid int 



if not exists (select TimesheetPeriodid from [TS_TimesheetPeriod] with(nolock) where [StartDate] = @startdate and [EndDate]=@enddate)

		begin

				Insert into [TS_TimesheetPeriod] ([StartDate],[EndDate],[CreatedDate])

				values(@startdate,@enddate,getdate())

				SELECT @TimesheetPeriodid = SCOPE_IDENTITY()

		end

else 

		begin 

			SELECT @TimesheetPeriodid = TimesheetPeriodid from [TS_TimesheetPeriod] where [StartDate] = @startdate and [EndDate]=@enddate

		end 



		Select @startDate =StartDate , @endDate= EndDate 

		FROM [TS_TimesheetPeriod] with(nolock) where TimesheetPeriodid=@TimesheetPeriodid



;with dateRange as

(

	select perioddate = dateadd(dd, 0, @startDate),@startDate as startDate ,@endDate as endDate

	where dateadd(dd, 1, @startDate) <= @endDate
	
	union all

	select dateadd(dd, 1, perioddate),@startDate as startDate ,@endDate as endDate

	from dateRange

	where dateadd(dd, 1, perioddate) <= @endDate

)


merge into TS_HoursWorked [target]

using

( 
Select distinct (a.[CWRID]),@TimesheetPeriodid as TimesheetPeriodid ,

		perioddate from dateRange ,[ContractorPersonalInfo] a with(nolock) inner join TS_Credential b on  b.UserName=a.CWRID where b.Userlevel  not in ('l1','l2')

)as [source] 

on Convert(date,[target].DateWorked) = [source].perioddate


 and [target].CWRID=[source].[CWRID] 



When NOT MATCHED THEN 

Insert (CWRID,TimesheetPeriodid,DateWorked,LegendStatus)

values ( source.[CWRID], source.TimesheetPeriodid, source.perioddate,0 );

if @@error=0 Commit tran else Rollback Tran END try

BEGIN CATCH

	declare @msg varchar(5000),

	@sp_name varchar(100)

	set @msg = ERROR_MESSAGE()

	--set @sp_name = concat('sp : ',ERROR_PROCEDURE())

	--EXEC InsertErrorLog @action=@sp_name, @Description=@msg

	

	IF @@TRANCOUNT > 0

	BEGIN

		--SET @msg = concat('Rolling back transaction ',ERROR_MESSAGE())

		--set @sp_name = concat('sp : ',ERROR_PROCEDURE())

		--EXEC InsertErrorLog @action=@sp_name, @Description=@msg

		ROLLBACK TRAN

	END

END CATCH

End


GO
/****** Object:  StoredProcedure [dbo].[TS_FetchDataBasedOnMonth]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_FetchDataBasedOnMonth]
	@UserName Varchar(50),
	@DateandTime Varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
		SELECT left((DATENAME(dw,DateWorked)),3) as 'Days',DATEPART(day,DateWorked) 'Date' ,DateWorked,[TimesheetPeriodid] , RequestId,ProjectHoursWorked
		From [TESTDB].[dbo].[TS_HoursWorked]
		where  CWRID=@UserName and MONTH(DateWorked) = MONTH(@DateandTime) AND YEAR(DateWorked) = YEAR(@DateandTime)
		
END




GO
/****** Object:  StoredProcedure [dbo].[TS_FetchDataBasedOnReporterID]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[TS_FetchDataBasedOnReporterID]
	@ReporterID Varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT  [ReporterID] as ReporterID ,[ReporterName] as Reportername,[ReporterContactNO] as ReporterContactNO,
		[ReporterEmail] as ReporterEmail
		FROM [TESTDB].[dbo].[TS_Reporting] where Active=1 and [ReporterID]=@ReporterID
	
		
END




GO
/****** Object:  StoredProcedure [dbo].[TS_FetchDataBasedOnRequestId]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_FetchDataBasedOnRequestId]
	@UserName Varchar(50),
	@RequestId Varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
		SELECT left((DATENAME(dw,DateWorked)),3) as 'Days',DATEPART(day,DateWorked) 'Date' ,
		DateWorked,[TimesheetPeriodid] , RequestId,ProjectHoursWorked,Status
		From [TESTDB].[dbo].[TS_HoursWorked]
		where  CWRID=@UserName and RequestId=@RequestId
		
END




GO
/****** Object:  StoredProcedure [dbo].[TS_FetchDataBasedOnVendorID]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[TS_FetchDataBasedOnVendorID]
	@VendorID Varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		SELECT  [VendorID] ,[VendorName],[VendorContactNO],[VendorEmail] FROM [TESTDB].[dbo].[TS_Vendor] where Active=1 and [VendorID]=@VendorID
	
		
END




GO
/****** Object:  StoredProcedure [dbo].[TS_FetchLegendDetails]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
create PROCEDURE [dbo].[TS_FetchLegendDetails]
	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT [LegendName],[LegendShortName] FROM [TESTDB].[dbo].[TS_LeaveTypeMaster]
END

GO
/****** Object:  StoredProcedure [dbo].[TS_FillMyTimeSheetDetails]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_FillMyTimeSheetDetails]
	@UserName Varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		DECLARE @MaxPeriodId int
		SET @MaxPeriodId=(SELECT Max(TimesheetPeriodid) FROM TS_TimesheetPeriod with(nolock)) 
		declare @SDate date = (select StartDate from TS_TimesheetPeriod where TimesheetPeriodid = @MaxPeriodId)
		declare @Edate date = (select EndDate from TS_TimesheetPeriod where TimesheetPeriodid = @MaxPeriodId)
		SELECT left((DATENAME(dw,DateWorked)),3) as 'Days',DATEPART(day,DateWorked) 'Date' ,
		DateWorked,[TimesheetPeriodid] , RequestId,ProjectHoursWorked,Status
		From [TESTDB].[dbo].[TS_HoursWorked]
		where  [TimesheetPeriodid]=@MaxPeriodId
		and [DateWorked]  between @SDate and @Edate and CWRID=@UserName 
		--and MONTH(DateWorked) = MONTH(GETDATE()) AND YEAR(DateWorked) = YEAR(GETDATE())
		
END



GO
/****** Object:  StoredProcedure [dbo].[TS_GetAllCWREmpRegisterDetails]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================

--exec   [TS_GetAllCWREmpRegisterDetails]
CREATE PROCEDURE [dbo].[TS_GetAllCWREmpRegisterDetails]  
  
AS  
BEGIN  
 -- SET NOCOUNT ON added to prevent extra result sets from  
 -- interfering with SELECT statements.  
 SET NOCOUNT ON;  
  
    -- Insert statements for procedure here  
   --select distinct Convert(date,dateadd(dd, 0, DateWorked) )as Date,left((DATENAME(dw,DateWorked)),3) as 'Days',DATEPART(day,DateWorked) 'DatePart'   
   --From [TESTDB].[dbo].[TS_HoursWorked]  WHERE Year(DateWorked) = Year(CURRENT_TIMESTAMP)   
   --              AND Month(DateWorked) = Month(CURRENT_TIMESTAMP)-- order by CWRID  

   declare @Date_From datetime = '2018-03-01 00:00:00.000',
	@Date_To datetime = '2018-03-31 00:00:00.000'


	truncate table tempdays
Declare @startdate date=CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(getdate())-1),getdate()),101) 
Declare @enddate  date= CONVERT(VARCHAR(25),DATEADD(dd,-(DAY(DATEADD(mm,1,getdate()))),DATEADD(mm,1,getdate())),101)
insert into tempdays(dateofcurrent) 
sELECT [Date] = datepart(dd,DATEADD(Day,Number,@startDate))
FROM  master..spt_values 
WHERE Type='P'
AND DATEADD(day,Number,@startDate) <= @endDate

	--select a.cwrid,CONVERT(VARCHAR(26),a.[DateWorked], 23),cast(datepart(dd,a.[DateWorked]) as int) ,ProjectHoursWorked
 --from [TS_HoursWorked] a where (CONVERT(VARCHAR(26), A.[DateWorked], 23) >=CONVERT(VARCHAR(26), [DateWorked], 23) 
 --and CONVERT(VARCHAR(26), A.[DateWorked], 23) <=CONVERT(VARCHAR(26), @Date_To, 23))

truncate table TempTableDelete
insert into TempTableDelete (cwrid,attdate,dayof,totalhrs)
select  a.cwrid,CONVERT(VARCHAR(26),a.[DateWorked], 23),cast(datepart(dd,a.[DateWorked]) as int) ,ProjectHoursWorked
 from [TS_HoursWorked] a where ((a.Status  IS  NULL) or (a.Status not in (2))) and --a.cwrid='con_dpachaik' and 
 (CONVERT(VARCHAR(26), A.[DateWorked], 23) >=CONVERT(VARCHAR(26), [DateWorked], 23) 
 and CONVERT(VARCHAR(26), A.[DateWorked], 23) <=CONVERT(VARCHAR(26), @Date_To, 23))

 
DECLARE @cols AS NVARCHAR(MAX),
    @query  AS NVARCHAR(MAX)
 select @cols = STUFF((SELECT  ',' + QUOTENAME(dateofcurrent) 

  --select @cols = STUFF((SELECT  ',' + QUOTENAME(cast(left(datename(dw,attdate),3) as varchar)
 --+' '+cast(datepart(dd,attdate) as varchar)) 

                    from tempdays
                    group by dateofcurrent
                    order by dateofcurrent
            FOR XML PATH(''), TYPE
            ).value('.', 'NVARCHAR(MAX)') 
        ,1,1,'')

		--select @cols

--SELECT @cols = ISNULL(@cols+',','')+QUOTENAME(att_date)
--FROM (SELECT DISTINCT  dayof  as att_date FROM TempTableDelete ) AS att_date
 
 
--select @cols

set @query = 'SELECT cwrid as Date,' + @cols + ' from 
             (
                select a.cwrid,dayof,totalhrs
				
                from TempTableDelete a join tempdays b on b.dateofcurrent=dayof
				
	
            ) x
            pivot 
            (
                max(totalhrs)
                for dayof in (' + @cols + ')
            ) p '



execute(@query)

END  
  
GO
/****** Object:  StoredProcedure [dbo].[TS_GetReporting]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_GetReporting]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
      [ReporterID] as ID,
      [ReporterName] as Name
      
  FROM [TESTDB].[dbo].[TS_Reporting]
	END

 


GO
/****** Object:  StoredProcedure [dbo].[TS_GetReportingID]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_GetReportingID]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT isnull(max([ReporterID])+1,1) as [ReporterID] FROM [TESTDB].[dbo].TS_Reporting 
END

 


GO
/****** Object:  StoredProcedure [dbo].[TS_GetSavedCWRData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[TS_GetSavedCWRData] 

	
AS

BEGIN

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [CWRID] as UserName     ,[firstName] as Name    , isnull(replace(convert(NVARCHAR, JoiningDate, 106), ' ', '-'),'-')  as JoiningDate
 FROM [TESTDB].[dbo].[ContractorPersonalInfo] where [isActive]=1 order by [CWRID] desc
		
END

GO
/****** Object:  StoredProcedure [dbo].[TS_GetSavedCWRDataDetails]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE  PROCEDURE [dbo].[TS_GetSavedCWRDataDetails]
	@UserName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
		
	  SELECT  A.[CWRID] as Username,[ReportingID] as Reporting,C.UserLevel,C.Password as Password ,[firstName] as Name, isnull(replace(convert(NVARCHAR, [DOB], 106), ' ', '-'),'-')  as DOB , isnull(replace(convert(NVARCHAR, [JoiningDate], 106), ' ', '-'),'-')  as JoiningDate,1 as Position,'Pachiakkannu 'as FatherName,
	  [permanentAddressLine] as Address,a.perState as State ,[perPincode] as Postcode,[personalEmailID] as Email,[primaryContactNo] as MobileNo,[Gender] as Gender
		FROM [TESTDB].[dbo].[ContractorPersonalInfo] A 
		 inner join TS_State B on a.perState=B.StateID  
		 inner join TS_Credential C on C.[UserName]=A.CWRID
		where isActive=1 and A.[CWRID]=@UserName
	
END

 


GO
/****** Object:  StoredProcedure [dbo].[TS_GetSavedReporterData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[TS_GetSavedReporterData] 

	
AS

BEGIN

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT [ReporterName] as Reportername     ,[ReporterContactNO] as ReporterContactNO , ReporterEmail,ReporterID 
FROM [TESTDB].[dbo].TS_Reporting 
where [Active]=1 order by Reportername desc
		
END

GO
/****** Object:  StoredProcedure [dbo].[TS_GetSavedTimeSheetDetailes]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[TS_GetSavedTimeSheetDetailes] 
@UserName varchar(50)

	
AS

BEGIN

Select distinct [RequestId], CWRID,[EndDate],
Case  Status
WHEN  1  THEN  'Submit'
WHEN  0 THEN  'Pending'
WHEN  2 THEN  'Rejected'
ELSE 'Name not Found'
END  as Status ,A.[CreatedDate]FROM [TESTDB].[dbo].[TS_HoursWorked] A inner join
             [TESTDB].[dbo].[TS_TimesheetPeriod] B On A.[TimesheetPeriodid]=B.[TimesheetPeriodid] 
			 where   CWRID=@UserName and [RequestId] IS NOT NULL
		
END
GO
/****** Object:  StoredProcedure [dbo].[TS_GetSavedVendorData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[TS_GetSavedVendorData] 

	
AS

BEGIN

/****** Script for SelectTopNRows command from SSMS  ******/
SELECT VendorName as Vendorname     ,vendorContactNo as VendorContactNO , VendorEmail,VendorID FROM [TESTDB].[dbo].TS_Vendor 
where [Active]=1 order by VendorName desc
		
END

GO
/****** Object:  StoredProcedure [dbo].[TS_GetVendorDetiles]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_GetVendorDetiles]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
      [VendorID] as ID
      ,[VendorName] as Name
      
  FROM [TESTDB].[dbo].[TS_Vendor]
	END

 


GO
/****** Object:  StoredProcedure [dbo].[TS_GetVendorID]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_GetVendorID]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT isnull(max([VendorID])+1,1) as VendorID FROM [TESTDB].[dbo].[TS_Vendor] 
END

 


GO
/****** Object:  StoredProcedure [dbo].[TS_rejactedCWRIDData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[TS_rejactedCWRIDData] 
@CWRID Varchar(50),
@Month Varchar(50)
	
AS

BEGIN

  update [TESTDB].[dbo].[TS_HoursWorked] Set Status=2 where [CWRID]=@CWRID
  and month(dateWorked)=month(@Month) and Year(dateWorked)=year(@Month)
		
END

GO
/****** Object:  StoredProcedure [dbo].[TS_SaveCWRData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_SaveCWRData]
	-- Add the parameters for the stored procedure here
	@Username varchar(50),
	@Password varchar(50),
	@koneEmail varchar(50),
	@Reporting varchar(50),
	@Vendor varchar(50),
	@Position varchar(50),
	@FName	varchar(50),
	@LName varchar(50),
	@DOB datetime,
	@FatherName varchar(50),
	@MobileNo varchar(50),
	@Gender varchar(50),
	@Address varchar(50),
	@CityorTown varchar(50),
	@State  varchar(50),
	@Remarks varchar(max),
	@PersonalEmail varchar(50),
	@EmergencycontactNo varchar(50),
	@Employeeid varchar(50),
	@JoiningDate datetime,
	@Reportingdate datetime,
	@EmployeerEmailAddress varchar(50),
	@emergencyContactName varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	/****** Script for SelectTopNRows command from SSMS  ******/

	DECLARE @ScopeID INT
	IF EXISTS ( Select * from [TESTDB].[dbo].[ContractorPersonalInfo] where CWRID= @Username )
	BEGIN
        UPDATE [TESTDB].[dbo].[ContractorPersonalInfo] set [officialEmailID]=@koneEmail,ReportingID=@Reporting,VendorID=@Vendor,
		Position=@Position,firstName=@FName,lastName=@LName,DOB=convert(Datetime, @DOB),FatherName=@FatherName,primaryContactNo=@MobileNo,
		Gender=@Gender,permanentAddressLine=@Address,perCity=@CityorTown,perState=@State,Remarks=@Remarks,
		personalEmailID=@PersonalEmail,emergencyContactNo=@EmergencycontactNo,emergencyContactName=@emergencyContactName,
		VendorEmpID=@Employeeid,JoiningDate=convert(Datetime, @JoiningDate),Reportingdate=convert(Datetime, @Reportingdate),VendorEmailID=@EmployeerEmailAddress

		update  [TESTDB].[dbo].[TS_Credential] set [Password]=@Password

    END
	ELSE
    BEGIN
	insert into [TESTDB].[dbo].[ContractorPersonalInfo] ([CWRID],[officialEmailID],ReportingID,VendorID,
	Position,firstName,lastName,DOB,FatherName,primaryContactNo,Gender,permanentAddressLine,perCity,perState,Remarks,
	personalEmailID,emergencyContactNo,emergencyContactName,JoiningDate,Reportingdate,VendorEmailID,isActive) 
	values (@Username,@koneEmail,@Reporting,@Vendor,@Position,@FName,@LName,convert(Datetime, @DOB),@FatherName,@MobileNo,@Gender,
	@Address,@CityorTown,@State,@Remarks,@PersonalEmail,@EmergencycontactNo,@emergencyContactName,convert(Datetime, @JoiningDate),
	convert(Datetime, @Reportingdate),@EmployeerEmailAddress,1)

	Set  @ScopeID = SCOPE_IDENTITY()
	 
	 Insert into [TESTDB].[dbo].[TS_Credential]([contractor_Id],
	   [UserName] ,Userlevel     
      ,[Password]) values (@ScopeID,@Username,'l3',@password)
 END
END

GO
/****** Object:  StoredProcedure [dbo].[TS_SaveProjectHours]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_SaveProjectHours]
	-- Add the parameters for the stored procedure here
	@CWRID varchar(50),
	@TimesheetPeriodid int,
	@ProjectHoursWorked varchar(50),
	@Status varchar(50),
	@DateWorked varchar(50)
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	update [TS_HoursWorked] set [ProjectHoursWorked]= @ProjectHoursWorked,[Status]=@Status  
    where [CWRID]=@CWRID and [TimesheetPeriodid]=@TimesheetPeriodid AND  DateWorked =@DateWorked 
END

GO
/****** Object:  StoredProcedure [dbo].[TS_SaveReporterData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_SaveReporterData]
	-- Add the parameters for the stored procedure here
	@Reportername varchar(50),
	@ReporterID int,
	@ReporterContactNO varchar(50),
	@ReporterEmail varchar(50),
	@ReporterUsername varchar(50),
	@ReporterPassword varchar(50),
	@costcentername varchar(50)
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	/****** Script for SelectTopNRows command from SSMS  ******/

	DECLARE @ScopeID INT
	IF EXISTS ( Select * from [TESTDB].[dbo].TS_Reporting where ReporterID=  @ReporterID )
	BEGIN
        UPDATE [TESTDB].[dbo].TS_Reporting set 
		ReporterName =@Reportername, 
		ReporterContactNO=@ReporterContactNO,
		ReporterEmail=@ReporterEmail ,
		costcentername=@costcentername 
		where ReporterID= @ReporterID
		
		UPDATE [TS_Credential] set 
		[Password]= @ReporterPassword,
		UserName=@ReporterUsername 
		where ReporterID=@ReporterID

    END
	ELSE
    BEGIN
	insert into [TESTDB].[dbo].TS_Reporting (ReporterName,ReporterContactNO,ReporterEmail,Active,costcentername) 
									 values (@Reportername,@ReporterContactNO,@ReporterEmail,1,@costcentername)
	set @ScopeID= SCOPE_IDENTITY() 
	insert into [TS_Credential] (UserName,Userlevel,Password,ReporterID) 
						 values (@ReporterUsername,'l2',@ReporterPassword,@ScopeID)

	
 END
END




GO
/****** Object:  StoredProcedure [dbo].[TS_SaveVendorData]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[TS_SaveVendorData]
	-- Add the parameters for the stored procedure here
	@VendorName varchar(50),
	@VendorID	int,
	@VendorContactNO varchar(50),
	@VendorEmail varchar(50)
	
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	/****** Script for SelectTopNRows command from SSMS  ******/

	DECLARE @ScopeID INT
	IF EXISTS ( Select * from [TESTDB].[dbo].TS_Vendor where VendorID=  @VendorID )
	BEGIN
        UPDATE [TESTDB].[dbo].TS_Vendor set VendorName= @VendorName,VendorContactNO=@VendorContactNO,VendorEmail=@VendorEmail where VendorID= @VendorID
		

    END
	ELSE
    BEGIN
	insert into [TESTDB].[dbo].TS_Vendor (VendorName,VendorContactNO,VendorEmail,Active) 
	values (@VendorName,@VendorContactNO,@VendorEmail,1)

	
 END
END

GO
/****** Object:  StoredProcedure [dbo].[TS_SubmitTimesheet]    Script Date: 9/18/2019 16:53:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================

-- Author:	

-- Alter date: 

-- Description:	

--ModifiedBy: <Dhananjayan>

--Description <added TS_Transactions table ProjectHoursWorked,ExtraHoursWorked,DateWorked>

-- =============================================

CREATE procedure [dbo].[TS_SubmitTimesheet] 


	@dtHoursworked [TS_HoursWorkedType] READONLY,
	@createdBy varchar(200)

AS

BEGIN

DECLARE @Random NVARCHAR(10);--To store 4 digit random number
DECLARE @RequestId NVARCHAR(MAX)--Final unique random number
DECLARE @Upper INT;
DECLARE @Lower INT
---- This will create a random number between 1 and 9999
SET @Lower = 1 ---- The lowest random number
SET @Upper = 9999 ---- The highest random number
SELECT @Random = ROUND(((@Upper - @Lower -1) * RAND() + @Lower), 0)

SET @RequestId = 'RQ' + Right(Year(getDate()),2) + RIGHT('0' + RTRIM(MONTH(GETDATE())), 2) + @Random

UPDATE H

	SET H.ProjectHoursworked=dt.[ProjectHoursWorked],

		H.[RequestId]=@RequestId,
		H.[Status]=0
		FROM [dbo].[TS_HoursWorked] H

		INNER JOIN @dtHoursworked dt ON( H.TimesheetPeriodid=dt.TimesheetPeriodid

		AND DATEPART(day, H.DateWorked)= DATEPART(day, dt.DateWorked) 

		AND H.CWRID=@createdBy)

if not	exists (Select * from  TS_Comments A INNER JOIN @dtHoursworked dt ON( A.TimesheetPeriodid=dt.TimesheetPeriodid )
				where A.CWRID=@createdBy and A.RequestId=@RequestId)
		BEGIN
		Insert into TS_Comments (CWRID,TimesheetPeriodid,RequestId,Comments,CreatedDate)
						Select top 1 @createdBy,T.TimesheetPeriodid,@RequestId,T.Comments,getdate() From  @dtHoursworked T
		END						
		else
		begin
		Update TS_Comm Set TS_Comm.Comments=D.Comments From  TS_Comments  TS_Comm 
		INNER JOIN @dtHoursworked D ON( TS_Comm.TimesheetPeriodid=D.TimesheetPeriodid)
		where TS_Comm.CWRID=@createdBy  and  TS_Comm.RequestId=@RequestId
						
		END
END

GO
