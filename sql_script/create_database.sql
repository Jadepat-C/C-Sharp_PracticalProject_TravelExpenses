USE [master]
GO

/****** Object:  Database [personal]    Script Date: 11/17/2023 12:23:31 AM ******/
CREATE DATABASE [personal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'personal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\personal.mdf' , SIZE = 270336KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'personal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\personal_log.ldf' , SIZE = 401408KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [personal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [personal] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [personal] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [personal] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [personal] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [personal] SET ARITHABORT OFF 
GO

ALTER DATABASE [personal] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [personal] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [personal] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [personal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [personal] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [personal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [personal] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [personal] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [personal] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [personal] SET  DISABLE_BROKER 
GO

ALTER DATABASE [personal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [personal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [personal] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [personal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [personal] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [personal] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [personal] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [personal] SET RECOVERY FULL 
GO

ALTER DATABASE [personal] SET  MULTI_USER 
GO

ALTER DATABASE [personal] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [personal] SET DB_CHAINING OFF 
GO

ALTER DATABASE [personal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [personal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [personal] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [personal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [personal] SET QUERY_STORE = ON
GO

ALTER DATABASE [personal] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [personal] SET  READ_WRITE 
GO

