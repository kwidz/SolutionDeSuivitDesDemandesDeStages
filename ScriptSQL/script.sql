USE [master]
GO
/****** Object:  Database [SSDS_Geoffrey]    Script Date: 2014-12-18 16:20:51 ******/
CREATE DATABASE [SSDS_Geoffrey]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SSDS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SSDSgg.mdf' , SIZE = 6144KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SSDS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\SSDSgg_log.ldf' , SIZE = 20096KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SSDS_Geoffrey] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SSDS_Geoffrey].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SSDS_Geoffrey] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET ARITHABORT OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SSDS_Geoffrey] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SSDS_Geoffrey] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SSDS_Geoffrey] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SSDS_Geoffrey] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SSDS_Geoffrey] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET RECOVERY FULL 
GO
ALTER DATABASE [SSDS_Geoffrey] SET  MULTI_USER 
GO
ALTER DATABASE [SSDS_Geoffrey] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SSDS_Geoffrey] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SSDS_Geoffrey] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SSDS_Geoffrey] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SSDS_Geoffrey', N'ON'
GO
USE [SSDS_Geoffrey]
GO
/****** Object:  User [Glangine.Geoffrey]    Script Date: 2014-12-18 16:20:51 ******/
CREATE USER [Glangine.Geoffrey] FOR LOGIN [Glangine.Geoffrey] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [Glangine.Geoffrey]
GO
/****** Object:  StoredProcedure [dbo].[CompterFichierListe]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

Create PROCEDURE [dbo].[CompterFichierListe]
@id int 
AS
BEGIN
Select	count(noFICH)
from Fichier
where dateSuppression is null
and noUTIL=@id
END

GO
/****** Object:  StoredProcedure [dbo].[compterUserByMail]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create PROCEDURE [dbo].[compterUserByMail]
@mail VARCHAR(MAX)
AS
BEGIN
Select noUTIL, noTYPUTIL
from Utilisateur
where dateSuppression is null
and courielUTIL = @mail
and estActif = 1
END

GO
/****** Object:  StoredProcedure [dbo].[compterUserConsultationDemarches]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[compterUserConsultationDemarches]

@nomUTIL VARCHAR(25),
@prenomUTIL VARCHAR(25),
@bouton INT
AS
BEGIN


SET NOCOUNT ON;
select COUNT(nomUTIL)
from Utilisateur
where 
		((@nomUTIL = '') OR (nomUTIL LIKE '%' + @nomUTIL + '%')) AND
		((@prenomUTIL = '') OR (prenomUTIL LIKE '%' + @prenomUTIL + '%')) AND
		((@bouton = 2) OR (estActif = @bouton)) and 
		noTYPUTIL = 2 and
		dateSuppression is null
END

GO
/****** Object:  StoredProcedure [dbo].[compterUsers]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[compterUsers]
@mail VARCHAR(MAX),
@pass VARCHAR(MAX)
AS
BEGIN
Select noUTIL, noTYPUTIL
from Utilisateur
where dateSuppression is null
and courielUTIL = @mail
and @pass = mdpUTIL
and estActif = 1
END

GO
/****** Object:  StoredProcedure [dbo].[InsererFichierListe]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

Create PROCEDURE [dbo].[InsererFichierListe]
@id int ,
@contenu VarBinary(MAX)
AS
BEGIN
Insert INTO Fichier(contenu, noUTIL)
values(@contenu, @id)
END

GO
/****** Object:  StoredProcedure [dbo].[InsertContact]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertContact]
@nom varchar(25),
@prenom varchar(25),
@titre varchar(25),
@description varchar(25),
@noTelephone varchar(25),
@couriel varchar(25),
@noENT int
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO Contact (nomCON, prenomCON, titreCON, NOTEcon, telephoneCON, courielCON, dateCreation, noENT)
VALUES (@nom, @prenom, @titre, @description, @noTelephone, @couriel,  cast(getdate() as date ),@noENT); 
END

GO
/****** Object:  StoredProcedure [dbo].[InsertDemarche]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertDemarche]
@dateDem date,
@noteDEM varchar(MAX),
@noTypeDemarche int,
@noEntreprise int,
@noContact int
AS
BEGIN


SET NOCOUNT ON;
INSERT INTO Demarche (dateDEM, noteDEM, noTYPDEM, noENT, noCON, dateCreation)
VALUES (@dateDem, @noteDEM, @noTypeDemarche, @noEntreprise, @noContact, cast(getdate() as date )); 
END

GO
/****** Object:  StoredProcedure [dbo].[InsertEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertEntreprise]
@nom varchar(50),
@adresse varchar(50),
@ville varchar(25),
@codePostal varchar(25),
@noTelephone varchar(25),
@couriel varchar(25),
@description varchar(MAX),
@noSTA int,
@noUTIL int
AS
BEGIN


SET NOCOUNT ON;
INSERT INTO Entreprise (nomENT, adresseENT, villeENT, codePostalENT, noTelephoneENT, courrielENT, descriptionENT, dateCreation, noSTAENT, noUTIL)
VALUES (@nom, @adresse, @ville, @codePostal, @noTelephone, @couriel, @description, cast(getdate() as date ), @noSTA, @noUTIL); 
END

GO
/****** Object:  StoredProcedure [dbo].[InsertUtilisateur]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertUtilisateur]
@couriel varchar(50),
@nom varchar(35),
@prenom varchar(35),
@estActif bit,
@noTYPUTIL int,
@pass varchar(MAX)
AS
BEGIN
SET NOCOUNT ON;
INSERT INTO Utilisateur (courielUTIL, prenomUTIL, nomUTIL, estActif, noTYPUTIL, mdpUTIL, dateCreation)
VALUES (@couriel, @prenom, @nom, @estActif, @noTYPUTIL, @pass,  cast(getdate() as date )); 
END

GO
/****** Object:  StoredProcedure [dbo].[ListerUserByAllNPA]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListerUserByAllNPA]

@nomUTIL VARCHAR(25),
@prenomUTIL VARCHAR(25),
@bouton INT
AS
BEGIN


SET NOCOUNT ON;
select noUTIL, CONCAT(nomUTIL,', ',prenomUTIL) as nomPrenom, estActif, dateCreation
from Utilisateur
where 
		((@nomUTIL = '') OR (nomUTIL LIKE '%' + @nomUTIL + '%')) AND
		((@prenomUTIL = '') OR (prenomUTIL LIKE '%' + @prenomUTIL + '%')) AND
		((@bouton = 2) OR (estActif = @bouton)) and 
		noTYPUTIL = 2 and
		dateSuppression is null
END

GO
/****** Object:  StoredProcedure [dbo].[ListerUserByAllNPAWithType]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ListerUserByAllNPAWithType]

@nomUTIL VARCHAR(25),
@prenomUTIL VARCHAR(25),
@bouton INT,
@noTypeUtil INT
AS
BEGIN


SET NOCOUNT ON;
select noUTIL, CONCAT(nomUTIL,', ',prenomUTIL) as nomPrenom, nomTYPUTILl, estActif, dateCreation
from Utilisateur
JOIN REF_TypeUtilisateur on Utilisateur.noTYPUTIL = REF_TypeUtilisateur.noTYPUTIL
where 
		((@nomUTIL = '') OR (nomUTIL LIKE '%' + @nomUTIL + '%')) AND
		((@prenomUTIL = '') OR (prenomUTIL LIKE '%' + @prenomUTIL + '%')) AND
		((@noTypeUtil = 0) OR (Utilisateur.noTYPUTIL = @noTypeUtil)) AND
		((@bouton = 2) OR (estActif = @bouton))
		and Utilisateur.dateSuppression is null
END

GO
/****** Object:  StoredProcedure [dbo].[ModifierFichierListe]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

Create PROCEDURE [dbo].[ModifierFichierListe]
@id int ,
@contenu VarBinary(MAX)
AS
BEGIN
Update Fichier
SET contenu=@contenu
where noUTIL=@id

END

GO
/****** Object:  StoredProcedure [dbo].[rapportListeContactParEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[rapportListeContactParEntreprise]
@id int 
AS
BEGIN
select CONCAT(u.nomUTIL,' ',u.prenomUTIL) as nomPrenom, e.nomENT, e.villeENT, c.nomCON, c.prenomCON, c.courielCON, c.telephoneCON
from Entreprise e
left join Utilisateur u on u.noUTIL = e.noUTIL
left join Contact c on c.noENT = e.noENT and c.dateSuppression is null

where u.noUTIL = @id
and e.dateSupression is null
and u.dateSuppression is null

or @id=0
and e.dateSupression is null
and u.dateSuppression is null

group by u.nomUTIL, u.prenomUTIL, e.nomENT, e.villeENT, e.noTelephoneENT, c.nomCON, c.prenomCON, c.courielCON, c.telephoneCON
order by nomPrenom
END
GO
/****** Object:  StoredProcedure [dbo].[rapportNombreContactParEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[rapportNombreContactParEntreprise]
@id int 
AS
BEGIN
select CONCAT(u.nomUTIL,' ',u.prenomUTIL) as nomPrenom, e.nomENT, e.villeENT, e.noTelephoneENT,  count(d.noDEM) as nb
from Entreprise e
left join Utilisateur u on u.noUTIL = e.noUTIL 
left join Demarche d on d.noENT = e.noENT and d.dateSuppression is null 
where u.noUTIL = @id
and e.dateSupression is null
and u.dateSuppression is null
or @id=0
and e.dateSupression is null
and u.dateSuppression is null
group by u.nomUTIL, u.prenomUTIL, e.nomENT, e.villeENT, e.noTelephoneENT
order by nomPrenom
END
GO
/****** Object:  StoredProcedure [dbo].[SelectionContact]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionContact]

@noENT int

AS
BEGIN
	Select c.noCON, CONCAT(c.nomCON,' ',c.prenomCON)
from Contact c
where dateSuppression is null
and c.noENT = @noENT
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionContactPourGestion]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionContactPourGestion]
@id int 
AS
BEGIN
Select noCON, nomCON, prenomCON, titreCON, telephoneCON
from Contact
where dateSuppression is null
and noENT = @id
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionContactPourGestionById]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionContactPourGestionById]
@id INT
AS
BEGIN
Select noCON, nomCON, prenomCON, titreCON, telephoneCON, courielCON, noteCON, dateCreation, dateModification,noENT
from Contact
where noCON=@id
and dateSuppression is null
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionDemarchesById]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionDemarchesById]

@id INT

AS
BEGIN
	Select noDEM, dateDEM, t.nomTYPDEM, c.nomCON, noteDEM
from Demarche
JOIN REF_TypeDemarche t on Demarche.noTYPDEM = t.noTYPDEM 
JOIN Contact c on Demarche.noCON = c.noCON
where Demarche.noENT = @id 
and Demarche.dateSuppression is null
	 
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionDemarchesById2]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionDemarchesById2]

@id INT

AS
BEGIN
	Select noDEM, dateDEM, noteDEM, dateCreation, dateModification, dateSuppression, noTYPDEM, noENT, noCON
from Demarche
where Demarche.noDEM = @id 
and dateSuppression is null
	 
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionDesFichierListe]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionDesFichierListe]
@id int 
AS
BEGIN
Select	contenu
from Fichier
where dateSuppression is null
and noUTIL=@id
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionEntreprise]

@idUser int

AS
BEGIN
	Select e.noENT, e.nomENT, e.villeENT, REF_StatutEntreprise.nomSTAENT as Statut, e.dateCreation from Entreprise e
	Join REF_StatutEntreprise on REF_StatutEntreprise.noSTAENT = e.noSTAENT
	where noUTIL=@idUser
	and e.dateSupression is null
	 
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionEntreprisesById]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionEntreprisesById]

@id INT

AS
BEGIN
	Select e.noENT, e.nomENT,e.adresseENT, e.villeENT, e.CodePostalENT, e.descriptionENT, e.noTelephoneENT, e.courrielENT, e.dateCreation, e.dateModification, noSTAENT as Statut, e.dateCreation from Entreprise e
	
	where e.noENT = @id
	and e.dateSupression is null
	 
END
GO
/****** Object:  StoredProcedure [dbo].[selectionnerUtilisateurById]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectionnerUtilisateurById]

@id int
AS
BEGIN


SET NOCOUNT ON;
select noUTIL, nomUTIL, prenomUTIL, u.courielUTIL, u.dateCreation, u.estActif, dateModif, noTYPUTIL from Utilisateur u
where @id = noUTIL
and dateSuppression is null
END
GO
/****** Object:  StoredProcedure [dbo].[SelectionNomEntrepriseById]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionNomEntrepriseById]
@id int
AS
BEGIN
	Select nomENT
from Entreprise
where noENT = @id
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionNomPrenomEtudiantById]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionNomPrenomEtudiantById]
@id int
AS
BEGIN
	Select Concat(CONCAT(nomUTIL,', '),prenomUTIL)
from Utilisateur
where noUTIL = @id
END

GO
/****** Object:  StoredProcedure [dbo].[selectionRefTypUtilWithTous]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectionRefTypUtilWithTous]


AS
BEGIN


SET NOCOUNT ON;
select noTYPUTIL, nomTYPUTILl from REF_TypeUtilisateur
union 
SELECT 0, '(Tous)'

order by noTYPUTIL
END
GO
/****** Object:  StoredProcedure [dbo].[SelectionStatutENT]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

CREATE PROCEDURE [dbo].[SelectionStatutENT]

AS
BEGIN
	Select noSTAENT, nomSTAENT
from REF_StatutEntreprise
END

GO
/****** Object:  StoredProcedure [dbo].[SelectionTypeDEM]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

create PROCEDURE [dbo].[SelectionTypeDEM]

AS
BEGIN
	Select noTYPDEM, nomTYPDEM
from REF_TypeDemarche
END

GO
/****** Object:  StoredProcedure [dbo].[selectionUsersWithTous]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[selectionUsersWithTous]


AS
BEGIN


SET NOCOUNT ON;
select u.noUTIL, CONCAT(u.nomUTIL,' ' ,u.prenomUTIL) as nomPrenom from Utilisateur u
where u.noTYPUTIL = 2
and u.dateSuppression is null
and u.estActif = 1
union 
SELECT 0, '(Tous)'

order by u.noUTIL
END
GO
/****** Object:  StoredProcedure [dbo].[supprimerContact]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[supprimerContact]
@noCON int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Contact
SET dateSuppression=cast(getdate() as date )
WHERE Contact.noCON = @noCON
END

GO
/****** Object:  StoredProcedure [dbo].[SupprimerDemarche]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SupprimerDemarche]
@noDemarche int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Demarche
SET dateSuppression=cast(getdate() as date )
WHERE Demarche.noDEM = @noDemarche
END

GO
/****** Object:  StoredProcedure [dbo].[SupprimerEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SupprimerEntreprise]
@noEntreprise int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Entreprise
SET dateSupression=cast(getdate() as date )
WHERE Entreprise.noENT = @noEntreprise
END

GO
/****** Object:  StoredProcedure [dbo].[SupprimerEntreprisePhy]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SupprimerEntreprisePhy]
@noEntreprise int
AS
BEGIN
begin try
	begin transaction
	delete from Demarche where noENT = @noEntreprise
	delete from Contact where noENT = @noEntreprise
	delete from Entreprise where noENT = @noEntreprise
	commit transaction
	Print 'done'
end try

begin catch
	rollback transaction
	print 'fail'
end catch
END

GO
/****** Object:  StoredProcedure [dbo].[SupprimerFichierListe]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================

Create PROCEDURE [dbo].[SupprimerFichierListe]
@id int 
AS
BEGIN
Delete
from Fichier
where noUTIL=@id
END

GO
/****** Object:  StoredProcedure [dbo].[supprimerUtilisateur]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[supprimerUtilisateur]
@noUTIL int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Utilisateur
SET dateSuppression=cast(getdate() as date )
WHERE Utilisateur.noUTIL = @noUTIL
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateContact]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[UpdateContact]
@nom varchar(25),
@prenom varchar(25),
@titre varchar(25),
@description varchar(25),
@noTelephone varchar(25),
@couriel varchar(25),
@noContact int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Contact
SET nomCON=@nom, prenomCON=@prenom, titreCON=@titre, NOTEcon=@description, telephoneCON=@noTelephone, courielCON=@couriel, dateModification=cast(getdate() as date )
WHERE Contact.noCON = @noContact
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateDemarche]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[UpdateDemarche]
@dateDem date,
@noteDEM varchar(MAX),
@noTypeDemarche int,
@noEntreprise int,
@noContact int,
@noDemarche int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Demarche
SET dateDEM=@dateDem, noteDEM=@noteDEM, noTYPDEM=@noTypeDemarche, noENT=@noEntreprise, noCON=@noContact, dateModification=cast(getdate() as date )
WHERE Demarche.noDEM = @noDemarche
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateEntreprise]
@nom varchar(50),
@adresse varchar(50),
@ville varchar(25),
@codePostal varchar(25),
@noTelephone varchar(25),
@couriel varchar(25),
@description varchar(MAX),
@noSTA int,
@noEntreprise int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Entreprise
SET nomENT=@nom, adresseENT=@adresse, villeENT=@ville, codePostalENT=@codePostal, noTelephoneENT=@noTelephone, courrielENT=@couriel,descriptionENT=@description, dateModification=cast(getdate() as date ), noSTAENT=@noSTA
WHERE Entreprise.noENT = @noEntreprise
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateMdpUtilisateur]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[UpdateMdpUtilisateur]
@noUTIL int,
@pass varchar(MAX)
AS
BEGIN


SET NOCOUNT ON;
UPDATE Utilisateur
SET Utilisateur.mdpUTIL=@pass
WHERE Utilisateur.noUTIL = @noUTIL
END

GO
/****** Object:  StoredProcedure [dbo].[UpdateUtilisateur]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[UpdateUtilisateur]
@couriel varchar(50),
@nom varchar(35),
@prenom varchar(35),
@estActif bit,
@noTYPUTIL int,
@noUTIL int
AS
BEGIN


SET NOCOUNT ON;
UPDATE Utilisateur
SET nomUTIL=@nom, prenomUTIL=@prenom,  estActif=@estActif, noTYPUTIL=@noTYPUTIL, courielUTIL=@couriel, dateModif=cast(getdate() as date )
WHERE Utilisateur.noUTIL = @noUTIL
END

GO
/****** Object:  Table [dbo].[Contact]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contact](
	[noCON] [int] IDENTITY(1,1) NOT NULL,
	[nomCON] [varchar](25) NULL,
	[prenomCON] [varchar](25) NULL,
	[titreCON] [varchar](25) NULL,
	[telephoneCON] [varchar](25) NULL,
	[courielCON] [varchar](25) NULL,
	[noteCON] [varchar](max) NULL,
	[dateCreation] [date] NULL,
	[dateSuppression] [date] NULL,
	[dateModification] [date] NULL,
	[noENT] [int] NOT NULL,
 CONSTRAINT [PK__Contact__11DCBB5DE3916F31] PRIMARY KEY CLUSTERED 
(
	[noCON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Demarche]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Demarche](
	[noDEM] [int] IDENTITY(1,1) NOT NULL,
	[dateDEM] [date] NULL,
	[noteDEM] [varchar](max) NULL,
	[dateCreation] [date] NULL,
	[dateModification] [date] NULL,
	[dateSuppression] [date] NULL,
	[noTYPDEM] [int] NOT NULL,
	[noENT] [int] NOT NULL,
	[noCON] [int] NULL,
 CONSTRAINT [PK__Demarche__129C5647DAC04AC0] PRIMARY KEY CLUSTERED 
(
	[noDEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Entreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Entreprise](
	[noENT] [int] IDENTITY(1,1) NOT NULL,
	[nomENT] [varchar](50) NULL,
	[adresseENT] [varchar](50) NULL,
	[villeENT] [varchar](25) NULL,
	[CodePostalENT] [varchar](25) NULL,
	[noTelephoneENT] [varchar](25) NULL,
	[courrielENT] [varchar](25) NULL,
	[descriptionENT] [varchar](max) NULL,
	[dateCreation] [date] NULL,
	[dateSupression] [date] NULL,
	[dateModification] [varchar](25) NULL,
	[noSTAENT] [int] NOT NULL,
	[noUTIL] [int] NOT NULL,
 CONSTRAINT [PK__Entrepri__115C9F6C5CD404A3] PRIMARY KEY CLUSTERED 
(
	[noENT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fichier]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fichier](
	[noFICH] [int] IDENTITY(1,1) NOT NULL,
	[dateCreation] [date] NULL,
	[dateModification] [date] NULL,
	[dateSuppression] [date] NULL,
	[noTYPFICH] [int] NULL,
	[noUTIL] [int] NOT NULL,
	[contenu] [varbinary](max) NULL,
 CONSTRAINT [PK__Fichier__AB3B811AB246653A] PRIMARY KEY CLUSTERED 
(
	[noFICH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REF_StatutEntreprise]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REF_StatutEntreprise](
	[noSTAENT] [int] IDENTITY(1,1) NOT NULL,
	[nomSTAENT] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[noSTAENT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REF_TypeDemarche]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REF_TypeDemarche](
	[noTYPDEM] [int] IDENTITY(1,1) NOT NULL,
	[nomTYPDEM] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[noTYPDEM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REF_TypeFichier]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REF_TypeFichier](
	[noTYPFICH] [int] IDENTITY(1,1) NOT NULL,
	[nomTYPFICH] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[noTYPFICH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[REF_TypeUtilisateur]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[REF_TypeUtilisateur](
	[noTYPUTIL] [int] IDENTITY(1,1) NOT NULL,
	[nomTYPUTILl] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[noTYPUTIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 2014-12-18 16:20:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[noUTIL] [int] IDENTITY(1,1) NOT NULL,
	[courielUTIL] [varchar](50) NULL,
	[nomUTIL] [varchar](35) NULL,
	[prenomUTIL] [varchar](35) NULL,
	[mdpUTIL] [varchar](40) NULL,
	[estActif] [bit] NULL,
	[dateCreation] [date] NULL,
	[dateModif] [date] NULL,
	[dateSuppression] [date] NULL,
	[noTYPUTIL] [int] NOT NULL,
 CONSTRAINT [PK__Utilisat__25638A80EA3100F6] PRIMARY KEY CLUSTERED 
(
	[noUTIL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Contact] ON 

INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (1, N'Coriandel', N'Stephane', N'Mr', N'555-555-555', N'Steph.coriandel@cdrin.com', N'personne à l acceuil', CAST(0x11390B00 AS Date), NULL, NULL, 2)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (2, N'foucault', N'jean pierre', N'Mr', N'555-555-555', N'jpf@cdrin.com', N'directeur', CAST(0x11390B00 AS Date), NULL, NULL, 2)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (5, N'tr', N't', N't', N't', N't', N't', CAST(0x39390B00 AS Date), CAST(0x39390B00 AS Date), NULL, 7)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (6, N't', N't', N't', N't', N't', N't', CAST(0x39390B00 AS Date), CAST(0x39390B00 AS Date), NULL, 7)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (7, N't', N't', N't', N't', N't', N't', CAST(0x39390B00 AS Date), CAST(0x39390B00 AS Date), NULL, 3)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (8, N'UnContact', N'prenom', N'Mr', N'555-555-5555', N'unContact@uc.com', N'note', CAST(0x39390B00 AS Date), NULL, NULL, 3)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (9, N'UnSecondContact', N'secondPrenom', N'SecondTitre', N'555-555-5555', N'seconContact@uc.com', N'noteSceonde', CAST(0x39390B00 AS Date), NULL, NULL, 8)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (10, N'UnTroisiemeContact', N'trois', N'troisiemetitre', N'555-555-5555', N'couriel3', N'note3', CAST(0x3B390B00 AS Date), NULL, NULL, 4)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (11, N'4contact', N'4', N'4titre', N'555-555-5555', N'couriel4', N'note4', CAST(0x3B390B00 AS Date), NULL, NULL, 2)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (12, N't', N't', N't', N't', N't', N't', CAST(0x3B390B00 AS Date), CAST(0x3B390B00 AS Date), NULL, 5)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (13, N't', N't', N'tt', N't', N't', N't', CAST(0x3B390B00 AS Date), CAST(0x3B390B00 AS Date), NULL, 5)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (14, N'5emeContact', N'5', N'titre5', N'555-555-5555', N'couriel5', N'note5', CAST(0x3B390B00 AS Date), NULL, NULL, 2)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (15, N'6emeContact', N'six', N'titre6', N'666-666-6666', N'courriel6', N'note6', CAST(0x3B390B00 AS Date), NULL, NULL, 5)
INSERT [dbo].[Contact] ([noCON], [nomCON], [prenomCON], [titreCON], [telephoneCON], [courielCON], [noteCON], [dateCreation], [dateSuppression], [dateModification], [noENT]) VALUES (16, N'tata', N'test etst', N'test', N'test', N'teszt', N'etszt', CAST(0x4D390B00 AS Date), CAST(0x50390B00 AS Date), NULL, 9)
SET IDENTITY_INSERT [dbo].[Contact] OFF
SET IDENTITY_INSERT [dbo].[Demarche] ON 

INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (1, CAST(0x5A390B00 AS Date), N'la demande de stage à été acceptée', CAST(0x5C390B00 AS Date), CAST(0x38390B00 AS Date), NULL, 1, 2, 2)
INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (2, CAST(0x5A390B00 AS Date), N'premier entretient', CAST(0x5C390B00 AS Date), NULL, NULL, 1, 2, 1)
INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (5, CAST(0x38390B00 AS Date), N'test', CAST(0x38390B00 AS Date), NULL, CAST(0x38390B00 AS Date), 1, 4, 1)
INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (6, CAST(0x38390B00 AS Date), N'ggggggggg', CAST(0x38390B00 AS Date), CAST(0x38390B00 AS Date), CAST(0x38390B00 AS Date), 4, 4, 1)
INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (13, CAST(0x39390B00 AS Date), N'asadd', CAST(0x39390B00 AS Date), NULL, CAST(0x39390B00 AS Date), 1, 3, 8)
INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (14, CAST(0x4D390B00 AS Date), N'test de la demarche', CAST(0x4D390B00 AS Date), NULL, NULL, 1, 4, 10)
INSERT [dbo].[Demarche] ([noDEM], [dateDEM], [noteDEM], [dateCreation], [dateModification], [dateSuppression], [noTYPDEM], [noENT], [noCON]) VALUES (15, CAST(0x4D390B00 AS Date), N'test', CAST(0x4D390B00 AS Date), NULL, CAST(0x4D390B00 AS Date), 1, 9, 16)
SET IDENTITY_INSERT [dbo].[Demarche] OFF
SET IDENTITY_INSERT [dbo].[Entreprise] ON 

INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (2, N'CDRIN', N'608 avenue du st redempteur', N'Matane', N'G4W1L1', N'555-555-555', N'service@cdrin.qc.ca', N'imagerie', CAST(0x11390B00 AS Date), NULL, N'', 2, 1)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (3, N'test', N'test', N'test', N'tes', N'test', N'test', N'test', CAST(0x38390B00 AS Date), CAST(0x39390B00 AS Date), NULL, 1, 2)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (4, N'Savoir Faire linux', N'St catherine', N'Montreal', N'G4adf', N'555-555-5555', N'info@savoirfairelinux.org', N'Société de consultants en logitiel libre', CAST(0x38390B00 AS Date), NULL, NULL, 1, 1)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (5, N'Industrielle alliance', N'Quebec', N'Quebec', N'G4444', N'555-555-5555', N'industrielleAliance@indus', N'Société d''assurances qui paie bien', CAST(0x38390B00 AS Date), NULL, N'2014-11-08', 2, 1)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (6, N'test', N'tetst', N'test', N'test', N'test', N'test', N'test', CAST(0x38390B00 AS Date), CAST(0x38390B00 AS Date), NULL, 3, 1)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (7, N'te', N't', N't', N't', N't', N't', N't', CAST(0x39390B00 AS Date), CAST(0x39390B00 AS Date), NULL, 1, 1)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (8, N'UneEntreprise', N'adresse', N'ville', N'CP', N'666-666-6666', N'couriel', N'description', CAST(0x39390B00 AS Date), NULL, NULL, 3, 2)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (9, N'RAMQ', N'QUEBEC', N'quebec', N'1234', N'555-555-5555', N'Ramq@ramq.qc.ca', N'test sans conract', CAST(0x4D390B00 AS Date), NULL, NULL, 1, 1)
INSERT [dbo].[Entreprise] ([noENT], [nomENT], [adresseENT], [villeENT], [CodePostalENT], [noTelephoneENT], [courrielENT], [descriptionENT], [dateCreation], [dateSupression], [dateModification], [noSTAENT], [noUTIL]) VALUES (10, N'CGI', N'Quebec', N'Quebec', N'arsfw', N'555-555-5555', N'test@cgi.com', N'CGI a quebec', CAST(0x50390B00 AS Date), NULL, NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Entreprise] OFF
SET IDENTITY_INSERT [dbo].[Fichier] ON 

INSERT [dbo].[Fichier] ([noFICH], [dateCreation], [dateModification], [dateSuppression], [noTYPFICH], [noUTIL], [contenu]) VALUES (6, NULL, NULL, NULL, NULL, 1, 0x255044462D312E340A25C7EC8FA20A352030206F626A0A3C3C2F4C656E6774682036203020522F46696C746572202F466C6174654465636F64653E3E0A73747265616D0A789CD57D4BAF25C7919E86A4F8B814288A7A8D2D8F7C0CD8C0BD327898EFC7C630349A91A59529119001D163186D6B06029B83E666BCD5D24B6F0DAFFC17BC37E07FE6F822F2555551F7F66DF61D8024BA3B10115999F16554664466569E171773B5EE62F07F279E3DBF7971632E291973794E848DE6F2C54DB46643B2F88B9BBFBB09215F924F917441C6EC03F16D897E43B30AF4BD2BAE17603ADA9A491252291B7A9408504ACEA2062243AD869F5AEA866615AEC1DB7C092538D400DADB0049C8CE6F68D6E935849C7B0DAE9AD29FBAD2AC027D576BB9B8540010D3D1C1D0104C5849D6E8CF77D197F6FC9A7C7FE442B202B47FF7B3CB9737F6F2B70D7B813B10F5D57FBDF9C3CDA737E69A5CA9269186B539523581342F96E0620D62268D993566D198556192290726B7A0584DDB694CAF3183C6D4AC2A47ABCCB5061B1A144533B0680616CDC0AA1868AB665CD58CAB47E3361D55353BAB6667D57AAF6AC655CDB8AA18E78C629C3347E3CCD5576BAD47939D51EC7446E9446714E39C518C1B1E93A999B65ED2B15A76BF82C2F486AA8E765E8CC68CA558BAFC0315FD35FDF923FDF965C326D22BF7BCD3F4A6482FC4C29411EA59F341E1A262D1648ACA3F6BCD89F456364D5F7B79A29EB5BE6DDCDA357BFDCFE835FF2DBDDFBF044C65B44968D4C41DA6B46970B3EB6D62AAB58969699351DA244F05576A82E6A85FDA34714AD60C9C1281DABCD5FBF64C501D27E17207B94151F98113B9EF8AE86AD3827EED9ABDFE3D4EAD4D42A32671EC639B061788489B986A6D629CA44D1ACE137D41079AA3FE8E93A5B9F2ABBF6D03076689E76DDCAB3C330A5D52629A5E0057429DB46F3A54B658CC735269A7EDD411BA95C51BDF9EE96860712587C92F7EF2AB15BEE933D81F7EF68D69AAF4797FE58BCFD25EA65DF3A3E24AEB3350CFDA00DBB8A56B0A95450E3A30179AA1F739A8EEC7C2E59A58B3D7FF0CF02DC3B943A8E35C369740D65A196E1A33558D593466D6984963C69569670B52D0B4BDC6741AD36A4CCDAAB8B16A9977BB5C33306A0646CDC01835A6665CD48C8B6EDBBA7D4745CDCEA8D919B4DE0B9A7141332E68C605CDB810B64D1E3359976B7606AD1383665C30E7882491D310E683D93F0A5C9A213AB748ADCC2D835BA581CCCD9D4B78B259CC4D836B0501E6C6D581A9D318309684A1EF055BE6FAC10DD20DCC75831BA5C7983BEC8F493A97B9C3BED8FC005C5715378E451C891586A9B18ACF3177989A8CB8277387A9C98A2733370EAE13A767EE303379793F983BCC4C415E25E63AA5EF3020E35D648561714AF2DA3277589CDA1B0EAE1D3D9A8A0C06CC1D66A62AE306738799D9C810C3DC6166B6322231779889291583177383E2D5D9CB90C70AC3E21C647464EEE85864351848993BCC445A833197B9E61863579A497CA4792A60EA6EAE264C0A0E43897B66410AB8672277F47B26BDD6C5ED99F45A17BB0ECA5D40AF76317B6D7A9F73DD339177963DD322D3DC33C9AABCB70A534D1E56ADC950939381796F20669DBC3710B34EDE1B885927DB3D938CCB7BE330E3A4BD71987152B91C87A02E273BD3DE4E4C3E696F27269FB4EF3DCC38696F1C669CB4370E334EDA1B871927ED8DC38C93CC6CF24C2F9A9CEC8C7B3B31F9C47D2762C6897BE330E3C4B47A0C209151305D6C3D544BE2D4E68A4B1F2516478B27C528D6C9CD9AA51805D1A420205140556930629A52D728DDD1290E888446FF8B261C4DCA1345F2420195704B294D532829DF687059936BEAF52F81BDF042996DC2382FB5032CA54DA9B7096FAF94276AB409DCD6A6A4B5094F154DAEA9D7BF244035968953B6BDF53404349C84923631CD3865DB718A65E05443ECDC89E8C1267E2A6B724DBDFE15A758264ED9F6D673ED8CD3B14DA9B789718A65E024353177227A68133F9535B9A65EFF2E0192C530CC70BC18D6A68C2F88E689B8D11E134CB14C3B33691365DA18744853C7DB59B6D1FCCC5098E6C9D057A67976697C64339DDFDBC609D037A5A93D01A267B776A1BDAECDBBAEDA36B31355248C7876D3696475CE495CD4CA739F51DBACD00EBDDB34854A220FFDA9BE2133EB3F2440093394416BEC0C3D1B33684CAF319DC6B41AD3AC4C3B5B80F8ECA08D50EEC8CC1A33694CCDAAB8B16A8D1C9B5C33306A0646CDC0681466D08C0B9A71216F5BB7EFA8A0D919343B83D67B41332E68C605CDB8A019E7EBB6C973D26B72CD4EAF75A2D78CF3F11C9124727BA925ED9F04661CCC2275821906B34AEBC0EC712C56FAD92430DD605A311ECC8DEB2296349C6CD56286B617508999EB6006811FCC3298513A0ACC3C9849BA14CC6155699D0FE671CDDC619F859D07F26160A9E266600E03AB118704731858ADB82E9803FEEAC4C9C11CC6552FAF0331D330AE067971C02C4A47D5282F1EE4C3CE9AE4150573D859DBCB0CE6E8BD5AE4B5077318877567C3E11AF65E8499B1B76538B0ABC90DA69581074C3B984E862830CDD175B3F132AE913CD65128C808086619CC286325987930938CAA60A603221CF639431341B6DB189998869871C7A41720DBB0671662FA3D3313D3ED998998C70C8704910466AF1D2ED9D43DD313B3EC998E9879CF24ABCCDE2AAA8481D2331C67A83E46775388EAE37ED832C940B337901EC5DDBC659271666F1C55C2AEB365FA0B3BD95947517DEC99DB42F6C23EBC659A0B7BFBC2A4BFEA855F912DB35CF865DA32F3855FBB2D93B2836AF7CC78E15759CF70E82FB2B3D47D21B2B3943D938C2B79CF24E3CA31C3E1C1EE3CC3E19153C970C4B0D30C87AD51321C06A965134C733CCBDDD1A9DCA35C7646D66477E7F24CB56C42B8C81B44532829DF6827D944ABA9D7BFCB70A8C175B60908A37636506B53EE6D72B1B7C9C5D92617479BF2B14DF2546913D7D4EBDF653803A76C7BEB118F0A4E42E59E4D349CB2ED38C53270428ED0B813D1834DFCD4107B4DBDFE5D863370CAB6B71E93A5E0746C53EE6D72B1B7C9C5D926172F2BA2BB36B5A7729BB8A65EBF96E1F094D6D2069E2B5A883F684CFE268F9460D032CEDB49073B755C9A651BCDCF0CBEA70DF46E849E360C3EC70F8DDFDB36339C6F405337190EB7AB653812EA23C391E01C590D070E2DC3915017198E84AA523EF89EE148ACCABD2B9A4C519D2DC3694FF50D9959FF3EC3F109D6716CE37AC043BCACF08AC2AB475E320ACFEE7996EB460471D0F50A2F28BCA8F0145BD2C196657E25B1625652CCCA8A59F96016F11493B262523E98B4E995AC589715EBB2D2535931292B2615C5A4A298540E262D5394E780FE5044E9B0A298540E260DC7083CD22A6720D8C50292FFE5E4C42FA550341812A43C16C112AFF8E60BF715886782ADF0780DBD088192CF049448211E6BE190139704F14CFC4B78A8CA76824BF6E19D5E0A3F9A81855469863D3603B54B336A6F469DCDA8AD02B4E7D00CDB78A8CA76623463A081FDA48E068D7182068D09D20C6F061ACC437B580B440CA38D295F16CC160306B6BC04DE092EB941A33783F7346D4363DF0CD424CDA8BD197536A3B60A06666B333AB6787EEAC46CC612AF863160E5BE0B63C318B0569E55784EE17985170E3CAE7B0C58AB6E527859E11585A7D8920FB6ACC944C88A5959312B2B66E5A359212B2665C5A47C3069D32B59B12E2BD615A5A78A6252514C2A8A494531A91C4C5AE3F15014EB8AD2614531A91C4DEA8E51E2C960C72E56D27EB0E342D4B1882199C4891078048714E82B10CF045BE11100A20522581682C4C2036BA5D04AF242A83C8D79787EEC4458073B8B7D9EDE0C90D28C706C066A621EE553A205A23503245700AD433342E3E1F9B113611DEC04C21A3A1A054E81F617BC0F7818888686F0A826D10251C368A3C99705B3C580812D40308D90921B347A33404A33C2B119A8947964B9688168CD001AA6F7D8A1191D5B80601AB134634DCE2325C10E2B78CE2DE9B570B3CA4D2A37AADCA072FD96BBB4C3A9FA56E51A8DEBAACA55ED735BFB362B2AA2A09AEA54539D6AAAF32A5735D3A9663AB36BE4BEEFAC6AB1552DB66A8F5AD54CAB9A695533AD6AA675BBA62F4B16A2A05A6CD58E35AA99A69CB91235F464B58412206EDB7691C55B9ACFCE8B799CA93D14A3D8053B4EECD238C24F5918D31E9ECFCED8290E511A4D018C6812C4ADBC8D2CA7D7BD718BED9A424979A1F154D6E49A7AFD4B3C253C39F42F3511DD6AA7BF9436719DAC49AED5CA9B34DBC45CAE7D69DDD2267E2A6B724DBDFE25D444B7769C70825B5A8F83EA6251A3F8998D26EB4593EBB466E2E47CE74E448F380327D6649C7AFD2B4ED60C9CA426B45E6A8745C736A14ED16444AC9938714DCC9D881EDAC438B126E3D4EBDF9FA32D94E473419A244A323232E2DB881A068D95ACE4E4802972F8418736F20EDA86A183D3C4BD6CA3E59936C9B717094664A6739EFC5427BFB74DCED17E439A3ACED156F19D240B90A50D7FD5BB36D6364A8E06F8F6BE354DCFCBA35E28C86D69D359B5A16BDA3647B0BC8FE0D5D636FC8EFAF78B2CBCCA1B71B62CB9ED9278F4FC9C0333684CAF319DC6B41BE6D202A3689BAA318BC6CC1A53B3CA6CACDA6F68905C33D068061ACD406335A6629CAB8A71AE966DEB761DE5AA62A7AB8A9DAE2ABDE7AA629CAB8A71AE2AC6B9AA18E7AAD93679BBA111C900A550513AD115CDB8924E1071B1E000306F0E97FE711631CB64DAC1AC93D9B717633593E907D34E66184C3799EB09DA58FD14A4A11D26330F669CCC32986932EB604EABD2B0AA4EABD2D175493E0D1CFBA7F8407030C736B29906CE3D59330D9CBBB7661A37F779CD346EEE089B699CBA8D6CA69D73EFD94C3BE72EB59976CEFD6C338D9B3BDF761A37F7C8ED346EEEA6DB695C1EC6D9695C3EE6B6249F76CE1D7E3BED9C6701EC346E9E1AB0D3B8723C28DBE458B39BBB97ED49847FACCB590AAE937A2ACD1DD1D63AEAD334F74E9B49D4FB69EEB236E3C965D2B21F2B2D0054983AE7EE6D03955C31CD2DDF063F396D9A9BC3ADA31071CD6DE4D6A538136916ABB8F3111D9BE530C87202829D87DEB5641703D9CDF0D5AA5D0C6487C4EC6A1703D975115DCF1DF5E6E411F3F9621CBF0E1403A4B94BDF5E9C40C6597D8CE1170F5FD8DABC14829D38326ACBC2849D8827969330F2DA4B88BB30615CE0197961C2B8C061C0C284718163DD8509E3020734CAA8DBC7358CBA8B9D32026E46DD395626B71827A32A46DDB27ACC322F9CEE07F364B0CB701CBB4F3829E61DFB7730870C87F148563E5236427BF9E087DCAE53AE670BDC894D3320F2163C11797BCF2E082E7F98CC9A4249F946D35345936BEAF5AF913BF3B2996DCAA6B72439B54DBEB7896370992EC26C13B8AD4D5E6B139E2A9A5C53AF7FCD70429A3879DF5BEF7CC7C9F9D926A61927EF7BEB421A38C93746CC9D881E6CE2A7B226D7D4EB5F710A69E2E47D6FBDF31DA7639B7C6F13E314D2C0496AEA99DEDABAB54DFC54D6E49A7AFD870C075FB8236E43DA40EF2B879D2DF41F34BEA1C79726A0314277BAB4A0B6D37815BA8ECB7994ED349E89800B34BDD314C944492DFCE49B38F8A36D2DC3F96634756638843EEB22C34941688B53651CD40A8532C8505296905D34618D94F7F27528D652395520CA74CDD8E2F067B298D29E1AA384BAB3FE7D86132C3E0FA8F259548F0889E93566D0985163268D990F4C2B2D289A765598D83F3C32ADC6D4AC4A47AB96B996E49A814933306906A6A381C4D48C4B9A71F968DCA6A3B26667D6ECCC5AEF65CDB8AC199735E3B2665C3E1AB7CC5E01EB73C74245EBC4A219578EC6ED3C46DB79E9EE67765FE873B168CAC987FD5C2C9A1A773B36520CF03DEF343CCEF24E32BE9841BF33F54C3AA97109C5A6C9540E22078D184234112A49F99A599E5CE7724D655079DDB02097ADB34D4C734D31AB6D4A9D4B0354D364AAB589696953D2DA1473E7724D6550A34D0B4E2E4F9C10878B45884DE5993C4635EB99CB75B226532ECF36077359115D6D9AE8734D61502E1F716A6D629A6B8A596D53EA5C468435996A6D623A8CBE3DB469A2CF3585418D368DB956060BB90346C6BAC277D734BAF01D2D169FD3566327ED9A0EDE451F99CE0B5D179DBA94E52F01DB330B3EFEE3F3548D9FF2E4F3F9ABD9369E6BBF294DED736D1BD4ACBC1B42D74B1B3E5DEB73A69EF57982B93CA6B0A650F26E308D185D34918D497913BB1F372ED7C49ABDFEC3912D7C8CEC327FA8E9FADA87C777CB0AB32A4C0C6947A6D598EEC0E474C3E3F4D9513B68CCA83193C6D4AC0A47ABD6E35B3E680646CDC0A819188F061253332E6AC6C5A3719B8E8A9A9D51B3336ABD1735E392665CD28C4B9A71E968DC9A29FAA4D999B44E4C9A71E968DCF0180A2CFDC9912EB89FE76F653673EDE268A7C528BC2EFBA3608287E1CBB784B6C8461979C79413EA59F73BE672657650FC6E0A8D63E7A2891372521ED4B3D69FC2454DA2D9EB5FF2358FCFCC7B9B98E69A9253DB34B8F85C4D34996A6D02DDDAE4B436A5C1454DA2D9EB5FF25A6967741327EAE986538EBD4D394E9C98CBE8A441B55C9A69EAC215D1D5A6893ED7C49ABDFE034EAD4D4C734DC9A96D1A5C46270DAAB5896969938AF3449F6B62CD5EFF6EAEE582DEB6FBD602F610797BABD17CC58C476EE80D5FFBD2E8D474A8ACE1AD31AE74D079D1C94BD964E63313F650F9CA98C6B779F25D64BAB78DE7DA6F4A53FB5CDB4607BE99AED134B8B01F79C3AB332803EA990CAA8D8B1A4493A9DC7C9F69705993F28456BE98EEC78D2BB5A6CBACBFCDB573C18D3F3AA8BCD26AC7FAFEB83D8FA721BB6156D1749D89FB10F8A88FFE7D4FF1554AE19BB3B1EB8062F22CCF49C8CAE5508274FB19B2E871BB02163991C2775DE662B594B9B6DFD3F142155C7E77F9F226E2FE96C8E7503DAE14696DA546BEB829578FFFF8E2C4957EF6FCF2F3CF6E3EF90D1E74F98C2DAB859A0D99BDA4780D9718FD9592D7CF9EDFDCFED91B6FBEF5EDB7DFBAFBEC8F377FF5D9CDA7BB3BFE0409B92B24F961866D4C3F57BB1BB38866D9181C9B5D730E8140B459300ABCD02597762F212F1A9F96FE19357ED1A9B23A6EB1283D345E74816B82DCA17E71C1B12C06C963C1A6B485B6E70465BDFCE2EF199B17971A047052E19B7DC85349E5E7BFBAF9E42F7FFBC96FACB9F9E47794D1DE7CF2EFC8BB6E3EF9F9BFFFCB0BFDF3D79FFCF51737BFFAC5E5BFFDAFDFFEE68D37BFFDAFFEE5FFFCD39FDEFBC5BFFEF39FFCE4DFFEDD1FDEFC2FFFF7A3FF63FFC3DFFCEAFF7DEB7FFFCD9FBEF59FFEFB7BFFF9DF7CEBFA3F3EF8FB9BBFFAD5E5D3FB21497C09135B8993A7210E205ECE47ACBDD4ABF1F84C6E780A8DDCE22A255C0B96A3EA9570205FF9FDED9FDD7D6CEBD5D33B77FBC61DF9091CE0F6CDBB90AED5667FFBD6DDC7E14AD37FB5B7DFBECBA1FCC7CF7E2D4EB5ED15B642EB95ADE0AC57A0B5ED1546410A330AA13DF6F561E0DCD5857B3078FBCEA7ABF50968780F268151AE15A72DEEC502A987985CB7586041EB612CA0A560214FDD78C4EBC3C2F03F8CC53B770EB6DADB77EF6CA401DAA7DBF7EEBCB9E6E0FD19500465F12E296E63EABD50E1E351D56DF0A9E9C32F33B414A8E4A94FE33694E15E69AA60A83EFFF22E01A17AFB3EE14210151317A606E0E24A2FF35E796CFC6A00ED042700B1D611A056F88900CAE6EACA1EA0F7EE6CBE069AEE6FBF43FE159DCF65E10D9FFBFCABD5C1AC17675ABC6E9679ACAFF9ECAAFA5AFAECCD4B40092D054A79EAD3BC9634575D4B83F20332D293E759B700F3DD09CC74B6C51735D4778399B7F15ED422CEE96B0ED86EB9BCFF0D652D053579EA1339A08FD774CFB8BE3AA5F25ABEC408EFB189AD82B2159C81022D051429FC44A0582AD866FC0FEFD8D6E86EBF7767130070EA9B3A40D106B2EFD143822FD5EBA360F3D162A90F624A2738E2AC978AA3ABF9259C0B5A0A8EF2D4277A250DB11F89E347772E8272785FD3D514475E3886BCFD7C1BC282F2F709D16BA6ECDD12692DBDFF84E8A361B62332DEC18C7DC38761869602B33CF569DCD51782363C0EE61FF0CB5EABABCBCBFE218AD0585956D47EC89AC9C4CD6049232CC1EE62CEDDB9ADFB3ACE8D7B2354D4B78233D4A1A5A02E859F08F544B6DE3774FE0886E7E0328D8E40C30777FBE3BBE8C280E0FECC86D0F5F1F20FD4E25FD39F3FCE04FD48FCE6973383C6A1016785FEE2E6B72208FC51BA08027F04DE04A8B60B3C1F626E0244D05D007A08102F7601E82EE038A909BCDC37DC0498F5BB00F4106062EB82C8E70B9A2084D15CA687C04D03991E021B4773991E02634673991E760856A263A5B5F89ABCF1410E3E95CE0BB8794A3E3D2CCB54B9C833F6E386FD3707F68B3255AEF68CFDAC222FA3441C1BBC674DA6F2263E4AF9598A9FB45F91B1B8FC8555FBB5A7EC6AFC05E07E45C6C9DACA7145662F182B320E7B0CFC4DE56B5B9171255E33CF15B7EFBCFBDEB73FFFF2EDF7DFBD674DC6F24517B07B597E11E66E4D8691604DB331D9A96B32A2CD8251E0852E51D66494D2873519E74ED238E75E268D63ADFBD764F87AE07F8C3599134812DFA43BD3CA575B93E18DE839F8A6CDE0EBB21D89A50CBEA678197C69FEB236DCFEB92C48D0E8CBE3303D23D1A457EA4994EACC49EEB8139CF58A5173C756F89527A0FB318861E48E98F6AB45BCC3D33E69B7509366DC2CD37E361417ADA818B01C91F7C062EBC803B7B0F0C1B1079D95B58EB0B4A7BE72D0793F2C6461CF0375D75881F1FC8CF87860F249AAB7139C01032D0598FCF552BDFB814118F73877E1A4865093709B8469810C715F36A6BAA5A8C47D2954849596FC933AF8BEB8CFF26F8A28EB0C247889E490B51418E5A94FE45FC65DDDE36094603B5A622E6EF821E404905D5193689BB2990D57A26D43E1D611F558EAE3610F27B9E44E7080BD0AECD062D869FC5F710F33997CEDEE6BE99FFA48E03999648A9249A24AA4141C3924156E2B694269FECDE964244B92A493B9B85740DA9FA4933BC19983FBC30E4C9270EF6BA593F7039DF24827F501F4C777DEA264B8FD27E4980E497AB9FDA7771F13D844E6C7CEBDD69DEC87F0EFBE3C3CC93835F96B4F7D9A41C046B3DB0FD963342DA7EC8F32ED50C8B9B6E9DF1604B3D9EF5840302FB311C25A0A0852F8891C85BABEDE1B84BD79177888E365670F1042DAAD15DE1F493E3E07E69CA5257C4CF7848F23D22E704BE2CA415A17982571E530A509981E823C1357A68700134F17801E82301357A687C0CFC495E921703333B76EC9CCB94BBBC0AC068AE54DA78E8CB6F1F9AAB4CEE72C764295A76493D186603C5FEA848B85C7578EFD47F7D64CB531A368C6C1C46F49E1D29C303F355B4FA5E3001B4AF165CBE3A34B14E367719A59572E1FF4265DD3AAF07C25734230CA1FCBD4951D4D14F692D7AA127EA93CDF7E1770161851FBEBC86C3D0DA5585F70D7CCEFC9ED77DE7CEBF32FDFFDFCABCFBFFCE0BB27E9AD60C23F12C1DF86777BB230979CB5318368DAADE5A1D9B71C5B8384D559304ABCD025BBF4F6A4F426BDF57C7B378EBA58647FCB40D625B6494E8673CF377D43ED3CC3A5EAE1BA123F3F698A7B0F2C9E7F914B2CC52D58AF98E3BA65744570D5BCA624F88B2B65BB3553FB3E9F8F141EFEE8EE630A096389CE63538A82524A8AE3D914231DC0570FA85DC357053CDC3550DB768D20210F66245E659AB91F07CAF5BD3B078277D48D2956E65C7CDAC82BAEF66AAAD92FB9EE0031D99D00B2959C0202350D1029FE448050E26F5AF0C1F1AFA32C806362839B1E25983512CC223AF6D54B046B13A572939AD215B8977124BE9E42C56D2739C38DD514DC5AF127C2CDA7360EFFFEF627E4205EB68DDE175F7114CE7E47253925208CF3ABBC73141F84E5CD5AA1DA4A4EA1829A0695147F22A8B09DD1A0E24500F2ACB8BC73D3D9A6135102601D650E39DDBE319D8CD33272C61AC8571D3429895DC07DB4EB25FE614DCDF524EB7F104FA86978CA8337A3F9EBC3D3204B3A1FC37E8C94B506931767DB786007F91DDEF78C945AB5D31FFC9CF9C8AFE7AB012715556C25B37F10DBB130B0C3561EFC34BE8A858179EE83378329E17FE3BB0393391E4EEA7DEDF53E71CB979A4A782742C76E2B39C50E6A1A7652FC89B0A300352E8B2AFD9DEE88CCF718476A02FB938EE2E298F38D5FE48B8F3EFA95974C5E83762B3985D61D4E4C0AB46D89E069A05D960826B473BE5E609AAF379FD3A211A1AA93B85A788BB1BA102558C9528036116D25A7281E971804C5B6C6F034287A370E5BBE348A1FDDF90207B3B77310C05A9F2164B7E1D1D1CFBF7FF7B1BB52069B1C214BDE594A75F703CB37A36BDE596D7D0958EB613F8F5195A73ECD6C6479B1F391A0FEE0EE631A2B32BDB56FCC328BF3C9CA75F5BE2CC02DA3C6D772DE9C838E313EB3791863FE30E788B13CF5691CB796B139A74DF81FDDB98009BFC8622A3BEB3F23D733D742C0BCCAE4CD6B201A445BC11944E9B053C71049E1A781A8D8737CFEE2CED10BE97D5C42A39FDE592C38D678FBCFEF42B6CB12E23D993AF91CAE427ED925C4B93CF4FC26E0977499C6C2984890F27709E829912BFE44225703760972C12E013D249CED3409D35382E0BE4B72098B04616A97245F170982AC2E013D259E8FFF88C4B7E33F2291554691F4554691C832A348FA32234BAA1D8DAE766973CEA3C9392F2D860B357EF22B628272D36980E17A872EE00B529B20F0A772BD5F70A550136CD72BF1A338FC397F0B996449CC9576F1C0BA62D9B94574F3E072A5E174C91267B4B858E074212DE5E469EBA2A5B0F9E7AAA16DC717A9B8F411B72C6E572D998D1F463FAC5A6A1259B5C4D77309B749F05D2AAF63D532188BB12BD3C82DCBFBB71F7EF0F6FB1FBC4BE3B6BE62C990C8AF49D7364CA0C5B631D725CBC6E5DF050B7E6336EEAED82F594222EA908C122F74C97EC9522FBD5DB2C4C7E8897FBA6D3F762A12653FD4E3137756DB6D886ED62CF1D22593CDD3AF599EE3E2E52AB910F771C5E3D62C237EB2728EE9B63B0DA62E9A6929A25AA63D7A4CA47C9FB74AABCBF5F642CC74C514F7538CF5096118EF12D1F0976FFFC55DB64699DFD015B19A3E8FD56D2745DCAF70FF0C874E62B5DD140748DA835F39D47A0010B2726658E19AE86DE16DEB7C4DF41A4B30442F5FE1A514D4E2C2820807ABF4D8B448D5C2B2314D2D0C401BCB30D69D6D4C0B6A392A8BC18AE4144FA869784AF1578E19EEC733D574B58FC5F307D8FDA7143EBA059C597AC14EA25843930547B1356492238A7570DAF4BAB0E7BB0D55ECF982C37B035AC61E6A1AF6F2E027F2E5944B3BA3F908EC2919AB10732ED6C68377704A3D644ABCDEE1FC02F1BFE6E9DF47C4E770BA63528F079B7FBB44057B2B39051B6A1AD852FCA91C3DD96B08F70CA51418D72B0E0AE1108645D89C790D96F2A9ECF2D71969BD53764514C9D974C86ABBE9501093F24FE59E61EE8BA888FD05768A6A72716237B139E414E733E963738A11BC51EC8ADB4099E67097259892BB04F490F0CCD4244C4F49E6DFD116498E69916004E812D0530277ED9290F22241B77409E8D9366975D76AD13E5FFEDA24A08724E08AD169699A92DD41F90813F0631D888225A60BB2C3BD3D56D09891154DE7957B23744A5BBD14C285AFAECE52F2A4353E176EE14305B1DFD68B2300C7E09CB95A6CAE09E4A43CEE3047649EB182FB5A4ECA5BEC222C81F9F7BEF3E147DFFFC1E75FBD7B7F84DE20C1770114DDE76E506ABC25406FCCC08A69B55C09CF21106506AAEBBF5005BBE05C2FBB3D2D6F385E0D87A84F11EC87A280DF4EF3A22523513806E67CB51CEE36AE4F1E979F23020F6DC6F0B8388178C4C8484EBD78CBF850092715F721B9A740A8622F8F064D43DD4A63A1F3D7924AC244E228BA32C66122A1D9D8179A982FBCAF67F1EDEB4F798EA68C9366928F695A37A99CCD24E8A3C83F83AA74DE4E70D279ACB5EB3CA0D54A6FD07A5D586167E23EB0DEC66A5D914FB97CBE1ABF038DA615262F7758D6C411C98731BBD73B1E37D58CB1E8F90D1F4C1B330D0BE0655D00BA0B18D026607A9468433974AA691F49B9312D801C7C9BAB9D75E3C2E82E397E2415F8D75197B19F2FC3ACE6F09554E05F225EC67E2CA7F085DAF77C25C58536633FEEBBE127ED3F938AF885F875ECC7E9B918B3726F4D0C632D63FB95D45ED0BE92427C480E5D71B8EE357D2585DF0489B15F5C33C6FE1FBEF5C18F3EF8EEB7DF7AF7C7E7E33F8237DC64B68CFFF8384A78BB2FA6189465FC6F46EA97D888328335C77F4DA07C2E752C7BF85A8A7F4043FB406027D086108E448DB977FCE7AB85DDD39F253B4724715C6CC6070BAF73FC0F1216DBCDFD35634CA3C4CB98F0C040463173A1E1CBD6A13707B46DC8BCED379CE654FB6D2B38EB3768ED877E0025A53740BD2E98D6F3DC7B8CDEBE43CC55637A70B65CF162CD5C36887D0C32551C3670C1ED8E419F78C8E34F41F398D40E0933DD0F09B3A7758137F3843223DB05A087401E253A6DC70367891B3FC9A5C1661E2B9E75E729D92ED367C7B7ADB1C76433D6866D6EDC7599BE719DE89AC12DB81BD59E2FD3672FC5B0F09E6A5DCAC9D336CBF4C29669C3A6386AC16DA8B9BAFD323DD8FC13CE87657A45D296E9F9476BF956D9D7F4D92C81744D980DE573A4DB87A781060ACFBDFCF3A7DD9CD4B89B957AE15AD14D5BD393B2548F1FB9657D968C222F4E4487C57ABDFC6EB53EF3452FDAF284481E3AC8E0717D38D4EE3960ECA987420CF91F61B1FE1C181FF0F324F1B85EF2C8AF68F17A8C1513F2FBBE6212B1541243D9AD98949ADB974DBEA6282B263470F18A094929E293259380AF7B4EC67FE90B9F9563118AE4B497A0B65F75032652FC9557DD1E4004E7C7D2384DE62A4D0D21F14AA3353EF8B68AC930F18A653F0561AE311B3E3A65717C440E9335E68AA2E7D325FE6551E41F7B5351E4DF3A7DD8D7A1A6A1280F7EE595B80750C4367EBAC7AFDEC6DC48935AFC3AD8F06DF72A365BC9293650D3B091E24FE461A1A6711414EBE0D6B8B8F8D274A02D70CDFDF89EBDE228FCD05F4D8A48B28BE55EE07C0DCA699A2679E8380D80633505B8F6E02772AA904B4B7D7EBFC0807D0882D0E605CC57F7299AA59553348AE4149A620EE768189A3237199FC0A7B05720C84CFFE1EF577DC6153FBC3143DE15F99011BE038FC1AEE3DBA2B00C663FA467797C767C86568ADABEB9481E3A2FCC6825650B1168C9839FCA9142987B58E23BBC8745A8D91509FE8E98DEABB66FE211FE2FEF6917AA651714E7CB8B5D2A8AFE6B3DC333AADB8247C9299E50D3F08C735BF009BC8F079D4742CA5BB2E49B7E0568967E8C1722523D1E0C10C983FB7B40CD2BFB7BB5F6073F95179ABA5C32F792A8F1662A4EA7AE71C81CF8783795FC346B7ECA675C2B59BD50AFE6A6EE2C00DF49D4FD4100EEB4FDC15A7BF927F2535FDDFDD1EE9C48654BB50049D9524DC6F94745C3F747F78FDE41EC7925F6D590B8A6B17F07496CFB7790C4B17F070982E52E013D25F2D3D822013D25087FBA04F490F0FCDE244C4F49693B959094B1530909585D82BFA624B69D4A48E2D8A984042F5E97809E12372D657AB65AD0E95A7DA7123FBFD224A087849876222ABF9BD7772AF9473203E5C38EBF30B8D8BEEAF092AE182F95F7E7C667F3DD0F5D25A7B9C4C509BD7557B94BC2E1760A834D02732D3160DFFE8D3BFA7738D4A737FF1FDF7763D6656E6473747265616D0A656E646F626A0A362030206F626A0A393734370A656E646F626A0A32312030206F626A0A3C3C2F4C656E677468203232203020522F46696C746572202F466C6174654465636F64653E3E0A73747265616D0A789CD5584B6F1C45100EB11D9C210A60221208873E80B41394D97E3F2E08E58973C28EA52061829021892CAFA3F5255C7DE4C81571E22F7047E29FF1F563666776CA0B912CA478B572F9ABEA9EAED7573D9E33DE08C978FCB4C2C1AC9A579C59CB399B411086B3A3CA083E1093FAA87A517927999536DA46D15819804BE9FC404E26D15E86E0DB05492E565A733D90BB154F6EB1E34AB0E7E52CF9F11AD2C94FD5B36AA7E28D953E700B0B658D655659C50493CA650B808E023D050602C43908508C40914E602565AD285053A0A140CA2B3BF68A37410B5D426129072DE5A0A31C7463070152CE39CA3937766E902847F9E9283F1D953D4739E728E73CE59CA79CF363E778A3821042A5237BCA4F4F25D153CEF9B1734B1583E3138F4DE587C2948AE9769940A39E3C2F5992A8C55929326963039582E32AC93A3E58F285AC8A4D0C82D149F63D39F46C426F6D0A6FD9D3C7260EA6C325BCEB7024E7A877B6A3EAD9ADCAB25738F7237C0FD1C80FDF98A3BFA81EE3BCCFDB3D944AE7CDB267A58EB564A561201DB40D9BD094DC64992595F55196094DA7D4ED7A48076D776434B496EDF30F62387BBD2434C15A4213AC0590602D4D3016C071B1031C17BB482720580B2051F09A602D80E36E0648794550558FF4A0A71C24580B20E520C15A0029E708AA024851722F51046B01A4FC24580B20E51CC15A0029E708AA023876AEC73ED0537E7A2A899E72CE13CE0D2B8622BD527E34E9E52C65E6C8459699A3145CEA72A17568BBBFC8AAD8E8962D4A408A1C7A36A1B73685B7EC1944CB1C19CFCC51F0C41C8BB325D27B538EDA925CD923915C2B7B56EA1674561A24915C69D084A66426CB2CA9AC3799BA8A25E8ACAC4F2457764DA897ADA5EF4832915C5711B812AA7C3D8C3D2072492CEE8FE87FC386A8E2C9947760A47A934C756BDAA30E1DA39B56C51460CBC5B2BC973226AAFA303A1788F1E5198AEB38424434C69EAD7186391A2DC1429A8CCF690D7B82EB2EFE040170F049004F0904249F17079D57BE51F127DDD6FBF2C18CDDD9ABA6BB0E3BB1BDE45DF03C249D8803A491CC29D928CBF666D5E4FD2BEF6DDD58DF58BFBE7E656D7DFF7873FF64FFF8EABB9BF5DE61757F0FF7EAC1CDBA840729134C73D779E60AA88089211A92A91D064117577BF79FA8C9E6296AED8A39AD61E575207E4ECE5C7D0BA7EFD9207526A0638488470DC5644E6A52FCE7201E9F03A7398399CE6678399AEE0ACDEEBD4C019AB3A0731A028C30DA4C40D3C2E8CE7635BDFB18A6BC9A3EC16B4B35FD0A3B55D33B5FDF65F8F560FAE0A8DABEC77EFEFDF1EEC5B58DCF3EFDEDF4F4F2BDCF6FDCBCF9E58B676B3FFEB5F5A7F8E6E9F6DF17FE787A7AE1FB5F2EFFF0C585E6D7AB2FABFBDB6C67755C94403116876CEABC2E1CFFAD768460A141ADF7EAC7B405E46D83A9E784471DA180BE9DBC55DF16AAC1FB989A5CAC256F50B462B2552BDE781BF4E47AAD5CC36590934F9221C70D7BF2616DA0754A4F366A812780D56068A4FE6EEF51AEBBA5BCB9A0CEC8DB507366DEA2D952DE7298F2FA4198CE2D481CBDE35744E952AD44E315C2B0556BDD70C53DC220558C8D1FC64B0404D13BC4EBB66C44705E2F056C6545D846C671FD0AAE3DC2F770C1796361F7618F9266E8793045928F301FF2336269154D92179A18CD5613E54E53766BADCA1A11EF5F4513E54EA3E348E94E00B9D3ECF4078294CE8D0642F71F88FE3CC8E0701CF8F8F415D3404AE9C7D320AE1A0F838C2ECD822025310A124A4D024A910A3A285DE68070E7330784900DF7CB83E0836BFB279B6F6F5EDED83FBEF4CE1933A0046538038214E31150C0C104282E8E07405490FC4F2996E89F5E3B60FF80EC91E44F28080E09D2FF2BF5A36CFE1FE65F11916E449D3FF10B50159C5B49FCA24F5F1F81A96CC30366C0C7F56DD304E5B99EDCA8B584284299013E98C9B5DA073F66FE941A8AF809C5593923685F74F3E0BC69BF0DD14ADA478C0AED9BDE6C1C062B927D14FBC18A18EEF54BC15A550DAF49FA1DFBCCD0E3822F383F3D21537E5274949F1499F1B3A265FCDE56C5262F10F152581449EE34586F7B4FB77DBE8FF42075E00C8428F09613FFF5FB1A04280C1216EC225F4E967CC9E01BD44803F22FC952A045BC4D4DD66BD9386F50AF6B35EE31066F6A0109C4EF2EF23BD53FB6DCA356656E6473747265616D0A656E646F626A0A32322030206F626A0A313536310A656E646F626A0A342030206F626A0A3C3C2F547970652F506167652F4D65646961426F78205B30203020363132203739325D0A2F526F7461746520302F506172656E742033203020520A2F5265736F75726365733C3C2F50726F635365745B2F504446202F496D61676543202F496D61676549202F546578745D0A2F436F6C6F725370616365203137203020520A2F584F626A656374203138203020520A2F466F6E74203139203020520A3E3E0A2F436F6E74656E74732035203020520A3E3E0A656E646F626A0A32302030206F626A0A3C3C2F547970652F506167652F4D65646961426F78205B30203020363132203739325D0A2F526F7461746520302F506172656E742033203020520A2F5265736F75726365733C3C2F50726F635365745B2F504446202F496D61676543202F496D61676549202F546578745D0A2F436F6C6F725370616365203233203020520A2F584F626A656374203234203020520A2F466F6E74203235203020520A3E3E0A2F436F6E74656E7473203231203020520A3E3E0A656E646F626A0A332030206F626A0A3C3C202F54797065202F5061676573202F4B696473205B0A34203020520A3230203020520A5D202F436F756E7420320A3E3E0A656E646F626A0A312030206F626A0A3C3C2F54797065202F436174616C6F67202F50616765732033203020520A2F4D65746164617461203332203020520A3E3E0A656E646F626A0A31302030206F626A0A5B2F496E64657865640A2F4465766963655247420A31350A285C3030305C3030305C3030305C3337375C3337375C3337375C3336305C3336305C3336305C3337375C3337375C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C3030305C303030295D656E646F626A0A31372030206F626A0A3C3C2F5231300A3130203020523E3E0A656E646F626A0A31382030206F626A0A3C3C2F5231340A3134203020522F5231330A3133203020522F52390A39203020523E3E0A656E646F626A0A31342030206F626A0A3C3C2F537562747970652F496D6167650A2F436F6C6F7253706163652F4465766963655247420A2F5769647468203233380A2F486569676874203134300A2F42697473506572436F6D706F6E656E7420380A2F46696C7465722F466C6174654465636F64650A2F4465636F64655061726D733C3C2F507265646963746F722031350A2F436F6C756D6E73203233380A2F436F6C6F727320333E3E2F4C656E677468203539343E3E73747265616D0A789CEDDC3B521B51144551530604CC7F6A8C808F0C26E013182440CE5F53653900BA77AD159EE8063B7CDD07BBDDEE072CCDD3D3D3B01C489925923211522642CA444899082913216522A44C849489903211522642CA444899082913216522A44C8494899032115226E2F1F17158A4CC224999082913216522A44C849489903211522642CA444899082913216522A44CC4C3C3C3B0489945923211522642CA444899082913216522A44C849489903211522642CA44489988FBFBFB6191328B246522A44C8494899032111FA4BCDDBE0ED3EBDBFB57DD03FF7674F8733AFEBEBB1B16293377522642CA444899082913B16FCA9B69CAAF6F9F7514FCBFE3A3C3E978737B3B2C5266EEA44C849489903211522642CA444899082913216522A44C84948990321152266275FC41CAEB5F37C32265E64ECA444899082913216522F64E79B31DA6AD949993D5EA683AAED7526669A44C849489903211522642CA444899082913216522A44C849489903211FBA6FC324D79F2560EBED1C9EA783A5E5DAF8745CACC9D9489903211522642CA44EC9BF2F3CB6698A4CCAC9C9EACA6E3E5D5F5B04899B9933211522642CA444899082913216522A44C849489903211522642CA44EC9DF2F398F2663BBE95836F7476FA41CA1797526669A44C849489903211522642CA44EC9BF29FE797619AFE7A0BBED1D9D9C974BCB8B81A16293377522642CA444899082913216522A44C849489903211522642CA44EC9BF2F9F9F997DC039F4BCA444899082913216522A44C84948938D8FA928F05DAED76C322651649CA444899082913216522A629FF05C6FDF1080A656E6473747265616D0A656E646F626A0A31332030206F626A0A3C3C2F537562747970652F496D6167650A2F436F6C6F7253706163652F4465766963655247420A2F5769647468203233380A2F486569676874203133390A2F42697473506572436F6D706F6E656E7420380A2F46696C7465722F466C6174654465636F64650A2F4465636F64655061726D733C3C2F507265646963746F722031350A2F436F6C756D6E73203233380A2F436F6C6F727320333E3E2F4C656E677468203539313E3E73747265616D0A789CEDDC3B521B51144551530604CC7F6A8C808F0C26E013182440CE5F53653900BA77AD159EE8063B7CDD07BBDDEE072CCDD3D3D3B01C489925923211522642CA444899082913216522A44C849489903211522642CA444899082913216522A44C8494899032115226E2F1F17158A4CC224999082913216522A44C849489903211522642CA444899082913216522A44CC4C3C3C3B0489945923211522642CA444899082913216522A44C849489903211522642CA44DCDFDF0F8B9459242913216522A44C8494899032111FA4BCDDBE0ED3EBDBFB57DD03FF7674F8733AFEBEBB1B16293377522642CA444899082913B16FCA9B69CAAF6F9F7514FCBFE3A3C3E978737B3B2C5266EEA44C849489903211522642CA444899082913216522A44C849489903211ABE30F525EFFBA1916293377522642CA444899082913216522F64E79B31DA6AD949993D5EA683AAED7526669A44C849489903211522642CA444899082913216522A44C849489D837E59769CA930746F08D4E56C7D3F1EA7A3D2C5266EEA44C849489903211522642CA44EC9BF2F3CB6698A4CCAC9C9EACA6E3E5D5F5B04899B9933211522642CA444899082913216522A44C849489903211522662EF949FC79437DBF181117CA3B3D30F52BEB894324B236522A44C849489903211522662DF94FF3CBF0CD3F4D75BF08DCECE4EA6E3C5C5D5B04899B9933211522642CA444899082913216522A44C849489903211522662DF94CFCFCFBFE41EF85C522642CA444899082913216522A44CC4C1D6977C2CD06EB71B1629B348522642CA444899082913314DF92FFE8EE8570A656E6473747265616D0A656E646F626A0A392030206F626A0A3C3C2F537562747970652F496D6167650A2F436F6C6F7253706163652F4465766963655247420A2F5769647468203233380A2F486569676874203133380A2F42697473506572436F6D706F6E656E7420380A2F46696C7465722F466C6174654465636F64650A2F4465636F64655061726D733C3C2F507265646963746F722031350A2F436F6C756D6E73203233380A2F436F6C6F727320333E3E2F4C656E677468203538393E3E73747265616D0A789CEDDC3B521B51144551530604CC7F6A8C808F0C26E013182440CE5F53653900BA77AD159EE8063B7CDD07BBDDEE072CCDD3D3D3B01C489925923211522642CA444899082913216522A44C849489903211522642CA444899082913216522A44C8494899032115226E2F1F17158A4CC224999082913216522A44C849489903211522642CA4448990829132165221E1E1E8645CA2C929489903211522642CA444899082913216522A44C849489903211522642CA44DCDFDF0F8B9459242913216522A44C849489F820E5EDF675985EDFDEBFEA1EF8B7A3C39FD3F1F7DDDDB04899B9933211522642CA444899887D53DE4C537E7DFBACA3E0FF1D1F1D4EC79BDBDB61913273276522A44C849489903211522642CA444899082913216522A44C849489903211ABE30F525EFFBA1916293377522642CA444899082913B177CA9BED306DA5CC9CAC5647D371BD96324B236522A44C849489903211522642CA444899082913216522A44C849489D837E59769CA93B772F08D4E56C7D3F1EA7A3D2C5266EEA44C849489903211522662DF949F5F36C3246566E5F464351D2FAFAE8745CACC9D9489903211522642CA444899082913216522A44C849489903211522662EF949FC79437DBF1AD1C7CA3B3D30F52BEB894324B236522A44C849489903211FBA6FCE7F96598A6FF2B826F747676321D2F2EAE8645CACC9D9489903211522642CA444899082913216522A44C849489903211FBA67C7E7EFE25F7C0E7923211522642CA4448990829132165220EB6BEE4638176BBDDB0489945923211522642CA4448998869CA7F01AE27E2920A656E6473747265616D0A656E646F626A0A31392030206F626A0A3C3C2F5231310A3131203020522F52370A37203020522F5231350A3135203020523E3E0A656E646F626A0A32332030206F626A0A3C3C2F5231300A3130203020523E3E0A656E646F626A0A32342030206F626A0A3C3C2F5231340A3134203020523E3E0A656E646F626A0A32352030206F626A0A3C3C2F5231310A3131203020522F52370A37203020522F5231350A3135203020523E3E0A656E646F626A0A32392030206F626A0A3C3C2F46696C7465722F466C6174654465636F64652F4C656E677468203335353E3E73747265616D0A789C5D924D6E83301046F79C821B30E3189348D16CD24D16ADAAB61720668858C4204216BD7DE7A7E9A28B0FE961CFD80FA6399D5FCE65DAEAE67D9DF3276FF5389561E5FBFC5833D717BE4EA5C2500F53DE7EC99EF9D62F55737AED97AFEF856BD9C0A3F35B7FE3E6231CEC0D7A4D9E07BE2F7DE6B52F57AE8E00741C47AAB80CFF9676C12B2EE3732BD21182041293E08E3C10778A913C1047C5963C106D73220FA441B1230F74A0B8270F7441F1401E48AD624F1EE8A2E2853C900E8A993C90B2E2401E487B45260F24BBE4481EE8B4338ABC4656B5338AA0461015C515CDB7D55A145734DFCE505CD17DD508C515CD3725457145F38D7690B8A2F9B67690B8A2F946437145F36DD508C515CDB7D58F83E28AE6DB59677145F38D76497145F36DED207145F38DD64A5CD17CA37E9C20AEC17CA3B60AE21ACC37EE6D029EBF5A8741A7EA3944757EAC2B97CD46CF464B476A2AFC379DCBBC68552DA97E0049B5B75E0A656E6473747265616D0A656E646F626A0A31312030206F626A0A3C3C2F42617365466F6E742F4C4C58504B4F2B5365676F6555492F466F6E7444657363726970746F72203132203020522F546F556E69636F6465203239203020522F547970652F466F6E740A2F46697273744368617220312F4C617374436861722033332F5769647468735B2035363620353836203631392037353420373438203836312035383820333438203532332033333920323432203234322035363620343632203536360A3538392035303920353331203432342038393820333133203530362035323420373031203535332035363020343739203634352036383720323636203437310A343838203731305D0A2F537562747970652F54727565547970653E3E0A656E646F626A0A33302030206F626A0A3C3C2F46696C7465722F466C6174654465636F64652F4C656E677468203330333E3E73747265616D0A789C5D92C16E83300C86EF3C45DE001B4868A5CA97EED2C3A669DB0BD0E0541C1A10A587BDFD627BECB0C387F49338C917A73E5F5E2E79DA5CFDBECEF1933797A63CAEFC989F6B6477E5DB942B6CDC38C5ED37E937DE87A5AACFAFC3F2F5BDB02B1338597E1BEE5C7FB4A07FD06AE23CF2631922AF43BE717502A0534A54711EFF0D359D555CD33E15C980AEA5121B322024892D191058624706F49D444F06049418C880A04BF56440A7930F6440F0128F644018250E6440DF48BC9201E1203192019DD68E64400F12990C084789890CE8E51858EE4228B541627145F5F5B2111657545F2FBE585C517DBD9C198B2B9AAFAC8CC515D5D7CB31B0B8A2F94689C515D5B7D7D1E28AEAEB5BEDC47EE5D214E9EEDE4C179FEBCA79D327A02D96D64E99FF5EC9322F52E50AD50F66DD9C5E0A656E6473747265616D0A656E646F626A0A372030206F626A0A3C3C2F42617365466F6E742F4D4957485A572B5365676F6555492C426F6C642F466F6E7444657363726970746F722038203020522F546F556E69636F6465203330203020522F547970652F466F6E740A2F46697273744368617220312F4C617374436861722032342F5769647468735B2036323420363131203630352033383920353338203438302037333720353431203931362033393820363032203533322036323020323834203434300A35323020363533203431352035383620353338203732332032383420363035203536315D0A2F537562747970652F54727565547970653E3E0A656E646F626A0A33312030206F626A0A3C3C2F46696C7465722F466C6174654465636F64652F4C656E677468203137383E3E73747265616D0A789C5D8F3B0EC32010447B4EC10DF8B9B4689CC645A228C905302C168501615CE4F6E113A748312B3D76679925D37C99BDCB98DC53D04FC8D83A6F12ECE1481AF002ABF388716C9CCE5F6A556F2A22325D557CBD23E03200B6F34D6D401E82B517D63D3A18D8A3D290945F018D94CAD15A89C09BBFD6D00D8B3D2799ECA29CCA825C7651C12A0AD945B9A938C82E2A785B7EAEA9FFD4C0673EAC8F94C0E776554B5DD33A0FBFC36388D5858BD00755445C220A656E6473747265616D0A656E646F626A0A31352030206F626A0A3C3C2F42617365466F6E742F4844574A45522B5461686F6D612F466F6E7444657363726970746F72203136203020522F546F556E69636F6465203331203020522F547970652F466F6E740A2F46697273744368617220312F4C6173744368617220342F5769647468735B203331332035343620333633203534365D0A2F537562747970652F54727565547970653E3E0A656E646F626A0A31322030206F626A0A3C3C2F547970652F466F6E7444657363726970746F722F466F6E744E616D652F4C4C58504B4F2B5365676F6555492F466F6E7442426F785B36202D32323920383035203735305D2F466C61677320340A2F417363656E74203735300A2F436170486569676874203731310A2F44657363656E74202D3232390A2F4974616C6963416E676C6520300A2F5374656D56203132300A2F4D697373696E675769647468203634350A2F58486569676874203531310A2F466F6E7446696C6532203236203020523E3E0A656E646F626A0A32362030206F626A0A3C3C2F46696C7465722F466C6174654465636F64650A2F4C656E677468312032303734342F4C656E67746820383130333E3E73747265616D0A789CED7C0B7854D5D5E8DEE731CF3399576632C904329321E171422664C80B033992078F100C21FA27D8680283243C9402F21282365134C44AACD116ADAF2237552B27403150B0A9A556AAB4B63EEA5B8A5E9FA0A95ACB8564F2AFB5CF4C08D1DAF6BFF77EDFFFDD9BB3B3D7DE7BED7DCE59AFBDD6DA2710420921167223E149E5650B83D9845DF3FB005CB16455C36A6D5C514308DDB264FD3ADF552B673D05883709317E75CDEA65AB8E164E1A24C4F4128C5B96ADDC748DB63EB99090A46B1B9736844FBEF17A8890CA170099DB0808BBD5EE23241E9E47C635AE5AB7515B7FD96C787EE3CAEB963468E3DCC709713FBEAA61E36A5B330FEF8BDF0248DFB50DAB9646E983F791A4D5D7AD5DA78D2B559C5FBD66E9EA73074FC1B3E2EF2344FF63F134711322EE229E181C7E0944C30C7E3878DB05484864E2E0DFD87A1239ACADE44E0C9E111F22166EF6E0277C2D488B0C7E42BEE58A3C11EB19A255D0866D51F4DA68BB02EA7741F68BBFE561AF40F9F72F9574918E68BF8BEC1EC263FF5ED23834BE87B447296B61ED5D4334FEF3EB249407C97BF429CA7D6DEE162884FC86FC9ADC44E692456481F886F806E06AC84EA86DC0F385EB0F0C22971BC906B2993440BD293A771393116173AB587B27E0EE243BE0CDF7D017C93CB28E8481ABA14B1720C7C972583B0F9ED3449E250FC3BB9AC90AD0A79D1B47EC3C19FC0C9EB00CE4FE5FBFEE204BC8DDA4377224F239BC3D4CD6932DDC57601FB09384BB07BF20D5A40C685841E6E99B2253C87BE4C8FFC6BB46AFD16BF41ABD46AFD1EBFFEFAB05E2E85DE4AEC19B079F205564A22E9E3C0171B62C5223D64344BE19CA7758E425CA827075D565F32BE695CF9D337B5659F1CC4B95A219D30B2F9956909F979B3335943D252B983939439E3471C2F8F4B4718154BF2F65EC98646F52A227C1ED8A773AEC366B9C45329B8C06BD4E14788E920CEA513DC535A5CBD5C4E27A550A94046C3E559ADF57115489C3EB0FD87DA160EDE4E82A559455E22C57E32B6BBA89925FABEAE4914BE6AB7C9AED733FDC5CE1F595AA421AFC04E63684D5095535FE80ED15EFD07C2DDCA32615D7F8FD5E954B839F3930053F731B7C61D5560978BF57C3CC5149650DD69EC153F98024F9FE5A805535EAD8D8B0B6F69B883C04096DEF0832E7D3365BB794585CA292F86E229D52890B97F5E5436A59A84E9081101BF4D8D34850A5F19FABD4A9525705907CF12BF0B693F9DF2083D2F0F24069B809241AAEBF20D33E4DA27E5F9BAFADAAC61E822E23BA5C7D76414DB7D9541C285E6A02046108D26D3203C68C0878C4EA6E2ACDA0ACC349A5D3BA3962B080F81C486E29D6E5AAB2A31E3A8112901BCC382FCCF40CF6B60F9F22705BACE7D47A1A11AAAE58D56B44F89A54A541253B7CDD19BD6DED3D36B2B85E96C28170C3776A54BE011674133EADB4B15A4D2EAF5C04287815D4FA461FAABB8401549EAFB4D1D706635C5B0F3050824ABF081F6E5C5A8F6642EB032530672CAED9EEEFF5AA0E684B55BBAC5A609965F37B5EBEADD4D3E4C3615BDB769FFA20903B6CD68F108CC003A4B79506E06DF0B0D2E5335125C121B5316B9C1366CA517634F8D41B172FD76CAFA13D66FFFE369B2A7DE507ED807EE04E76635494E1FAE548F2F20664B374B9AF6DC752C66A3B630DECD557BABC042BDE08D64F2E87BB17D59436064A2FBC1018870E9F36F25EBF5F4D94F1C6B6B65224B1210CD46B24C3C405FA714F78650AF414AB4A356B4835D301BC516928A98DA2A20B16E16D38535F525BEBD7F40E4B557DDA763133E06BC327EAD3D478D9E63F0673BD9333CAAB6A4A4BBC8C7B952BAE997EC6E33D03FDF2CA2134F5C09AB6E019AF26A3F28581F2059A1534C6407DB5B681B921CDC3D2E87AF6D4131EEF09E89705CAEADBDACA02BEB2B6FAB6869EC11B17077CB6405BB724B5AD2EADF7B19D4F017F7887572D6BAF556DF58D741A2819EDADACAA5C752EB812D553E66B6CD09C4551C09FEFF5DB6B636B2AFFD174749F81C583DDE33E6BB39D06DA24F0485E5F19BA971EF00A5ED5968FDB1428B9BC06F6C11266B30CC0FE58080FF7E24EE16BD34A9B16460504D6183518F47B0BA2587888DF8F7B68478F4216C340BD71418D36F691C5DE7D4409CAA0BB7A9CE98DCDB82EC7991B633343B7D70740579EF285FFC4A687DB739B3DE0F0150499FC99BB0DABBDD5C0E3D97CD5901F55B7B3B886F772D11EE7E5B16792C17D15AA0932BB1165025EB2CD16F0BD10506DB22A16D7F47A0B6B7D363BB8370A6B66CBB86BC08BBE10384ED17792789B4A0B55EA463C015FCA5C3A9F900F9343C6E32B6DAB8F5AD770B6A20120DCF8CDBCC11A5B00D8F36AEBED8E0072F83C7369514F9D56867BC9EBD756CCAD55E3D01FAB71A719007ABDC5353EF03EB05B17B08EAFD4D788CA567DF525CC0DD47A87A37B064FD697A0DB03927189376AD60035D15E6C6BFFBA85DF08167E537B6D2358B7AA4C020E7C39F05AB65BAA6BA252CAF7467711BE6B0EB272F1FC9014636BBE2EDDF2EA8B46C39E8B01C10FD3F9437BBFBA462D93638FD2C6B364EFF0E1EC11D37362D30424E1B3CF41A142FCC9F75E8403FD2A1A0AFCC856EF668C271C99D91DA0B72EE856E8AD0B17D51CB211E2BBB5BA661F47B9E2FA99B5DDE360AEE6900F922086E5108B481CF87040CA293C6D1F6760EBBD8714426E64B30243B0F1921E4A18CE10C351B2A487D370B6188E039CA0E11486D3D20B5F6953C964027710C3C3031142A471FDEDE77F6A7E1B31175D8B1063BE9CFC942492AB891E9E672341B29410E1FB83834424F410F1D119078C1E3AD7D7430B639DA9B14E76AC138C7532639D8C58478A758458878F75A8F219EB0D321861B09FC12F18FC2B837D0C6A2BCF30F831836F32F83A83AF32F8228327187C9EC1DF31789CC167197C86C1630C3ECD602F834719D428EB66702F83ED0CEE60B08DC1DB186C65B085C16D0C3633B895C1C50C5632389BC13884C1A7843320F2CB84D30015E113E572A3A5E09D93EE84E4975E0670C316B7F7862D897FFC13F4D76F00B06A358095D7015871ADDBBBE2DA6D6B92D65D1FEF4A5EB61CC0354D009636C67B9736DEFCDDA4C4B5EECDC589FE4D504F3E25FC1D9E7F92419FD0B7DF622F507A848FF799E30B0E0DF60A9FEDF7A616145D6A11BE84F93B842F006645E1678CAE0FF79B6D0545BFA4336164A5979207A17283270FFC75A20C0FA2CAFEE9C55A3B6E02B645FB33825A9B908CED74C59D2E17BCFF012F2B1F646416281F78015D9D925200FB4B713F17081428AF4D9C54B0B08A93AB4E71B24F355B0A0E510ECCC1CBC903FD26F9FC5E51FE1C667EFD1B4E565E4F482C78030670F3FE535953D843124F8D195BA0BC929050F0C9539CFCD42E4EFE11D45D9D22AC3AF9E4A7F1EE823B3B78EC2BD2974E77C1E94E41EEE81C978208F3124F62C1354BE8DD9DF8C893FB3BD3261480251EDCCAC9FD6F98E44374062DDC07AF0573DF97320EA682FBB6C2A368E6FE565E7E01ECFAE75479154842328CC752D30A94A7810C24AE37C98BED93BD3647C189E7F1F5BD4F1E07667FF72CEB2BEE3EE0F3E3664ECE5A2C49BAE2EEBD9CBCB759E3EB45AB833DE2E8F809ECC1C9ED63C716DCD626C86DAD267907BCF8A66D54DEDA2CC8CDAD1A5B972E062E16B752F956A8DBA1DE0CB5A555903F6AFD5FAD5C532B1DDF4ABD792E4FAECB95E3724C7559432E29DB659CE2D265B9F8A08B64BA2E1D43A7D14B40BDF9B480C4D15C9A47E28899E6934BA096437D0EAA00985CC0E4922BA1F2C446A7114A75FBF8C1944BFDD444CD70BF811AE17E1DD5C3FD2BA8014CC60CF012A8E5507F01F513A8E7A1EA60C6044F32911D5079AA5392E141E9E3E3268CB74E92E332646B6A206E5CC03A3625CE976225BFA453E08553C0034D8157139AA5DC48574F3A39892385D4364E19B77ADC83E304ABCD2E194D6649A73748BC204A847252BA2E3945C77B52AC7C11FF0ECF3F40DE219C3521252198C05BE353E283F1BC978EB178F44916972DC1E210E22D412FCD289C5438A130BD705C616AA1AF706CA1B7D053E82A74145A0B8D85BA42BE90145686AAA9EA2827E5D53355278576E14C352497F7F0BE2A355B2E578D9557D67453FAFD5AC0AADCADE0C0AB55E156F0D9D570465874654D0F4DC4E99BBD874086442DAFBFF9F65A591EA386318BB8714CAD9A8D9D9D636A21DFCB5EA07A0333E591D75A06E08A8D2FF4BB27A497AA934A1BD48CD2FA1236B5AE87EA4A9B7AA8A9B4A90160A0A4871AB4713DF40225D107F4D06988CD2F6D02743EAE62E35C36CED5960D5D74EDBAEBBF46D5480265990CF5BEF502DAA30CAC5D27C3C1412D02997EC3AA6E23CAB7B26A66B96A804CDA5079A59A1480C1B330C885811498D94D20AA7773087400AEBCB2E652179D41C2B410EA54A8D950835033A1664095A00A5079A854B92C3C188E84FBC35F84FF1AEE0B7F163E13FE38FC66F8F5F0ABE117C327C2CF877F173E1E7E36FC4CF858F8E9706FF868F840B83BBC37DC1EDE116E0BDF166E0DB784B7859BC35BC38BC395E1D9E1B8F0BFC0FC88ABF6DFBF05233847F640B46E15D7C316D19324C5ACA7BC407851340A2478C251103C014DD189295921BBDF9EE6B7FBF7F06FF71FE40E0ECC15D79F6BBB4B980F4FC0DFD039C45D70BF951C53266DD0D38D3A6AB449A48233C0DEA2664B9C9517A4B502DD422945BCE0315BE83CDA33F8E101EC48E0B358C78CCE2B077B7116A34910CD92C1A2AB9014877BB6A4335839BEC36AD5F15434582533CFC5192D2693B841A41B0915E1594A9C5922F3888741621783F6505096EBEA1C090524182C2A080E1CB31DB3BD25CBC70033250BAC51C6E9EDBDBD71BDBDB6ED00C4DE5E0A187F80F7F3011A72F2E9E3033A3D2F3A0EFF70E0C13B7EC1A53FF1C05FCC66C1647987DE19B956DCD57F07B764ECCCE981811F63B674D5E08742BBB88FB8C836C572BD896E2274334F8B12A811D92A03BE798F995498CCC4E7A22E97B38373668174CC960E0338CA2C64BB08C709361D706DD34900B68A36E88B06E88B4E3300E048FE48964133757288149DC90ED63110B287184B7575A4AE2E4D17F011BB8DF8B3135CE98154EC86B2F384F607CE447E1FD949EFA7339EBF65D7E1BF474ED0948F5EBDBFB09AB65185D6D0AE4BF65F113918391D3917395E8FB67104343B23AAD9DB15DF7A9EC28FB183380C1D6026A81B0129130C4099B0D5D233F8E57E18420B39036BBF8A8E3F563CB0C462B11B913523B266D401C6D84C7011E0A08DE062D6C20C89328A9CCAD12EB05B74664A160516C11C7DC8206F0F21A7FE23B49DFB2A7265E481975EA14974DAC04171D74069E4406495C89DBF9B665217371E3404FCF007801F336954328D1D8A8EA3BA0E394BC7993AA843ECE08027C14088456742324D48A609C93435D3284FD09E4332590B3334466636D0190A05838C467B814C3CC1A40A20D60F7BC615ADFC810103F7EAC00B9C6EE01C5729EEFA6124704FC414A5EB2EA0CB48EA9474B123084701CEA077D00E032F089061733AA44787F4E8901E5DB3BE67F03CD2A38FCA18DB8330A30F9A69DD4534318AD05C50721A210120E52E8D8C2EEE55918BD8EE19B8197F5DCE28113E6712DAACCCE23B14834E348084403A0E13AFE38D0409214808414248F336DCD22818074A855A0C02AE107085802B8466D89A679154316A1E68C231EA60FF61170C19AE0B3203028148743921E1F3AE81A4AE2EEEFD2EEEFB036B40AB3BB8EB31D50462FB189D4B148533DD69E679FD9D8A8E0A71BCDE30D3A45778248347327824836F361804C018380901600C8A8556481643F360167304B2ADE22F00933C27B2650AFD6CA4E64C366C2E909B0BA871F97342F6400EED6B6F8F28EDEDE2AE9DE76FD9B953D8BC332A377E37D023929683021813C78B683136C6765F94FD3EC63EB666D67EB8DFC4DA93FB8DACED553CA694D9A2A8FF9A0C695486D07EAE1851D2E270E38BEE11B6458A34A303E1F1BB073C5D9C22EE3A17D128D481FC88971C565C9B93E8F54E9AEECC75726BDCD4CDDCB125E68E992FCDC39E3B898A468BCE617738202AE07E27B8DF8981A93E09114968001E248DEAA2FBE2E748DA182790AC24C084D332CC9F213BB6663BB081ECD8A3D66B07F251F805D9C08A2C07E5BA10E3AB00D8015F8D6E1AB73D7A66FBD43C70C93440C135BB5D6825D49D10CACDA321DD9AFF1127789C11775524C1E5160C0FBF4D7B42569D9C447FF527FEE9358F344C3ABF4F28CB5A72C5AFFB4126FD9EB505EBA7F1EF69921101439CE4678A658344D798E9468E6EA514C2519F02EEBAC26A88CAE5AC1264D1C94145C168E28DD4FAF50D61A7769487DD8EA2B2E33D89306177994503AE35E05A03AE35341BA37230E22AE390538CA9B5203B2A0D360891A0260C1005042914C6C54248CFB18744E5F70363931D3A43D7EBDCEF275B045397B0410E66DE73FE4B71D7F97BCB926674F29FA3678758253E0AB1CA4C12C80D4A92A38338A50E9D30D23D6F7545AD17DA8F5153D8820C74153E57968B73B912AD788715EFB0E21DD6AD3C7A03DE861BCF861B2F9878C121B1A875912F17B538C5208D062A845C24F28748075D4F67D2897445A43DF2D2A9C8FBD4F9D6696A8B9CF5D03B01BF88DE17591D391A7928D22866470E47FE0EE5289D4A5D34190E1B5AF41226825E4DC4416E56021B7434C74A498724F19CC3DC010E03ED578F5AD2A341EBB7DA704BA2A9E206188BE68A1CD86CF112452E3503472E693317DD90D07EC934C70980E7867BDE618CC20878ADABA3E87AB3DDAE781280C0959D9B63F3D370176D7B7F20F2C16747D5279E8CA8DCD88153E2AE93CF3F1FE9E7DE1B38F040074D46FFB269F043FE6DD0570E39A2B86EC8A19B33E9FA34BA2E89AE77D1A91E482D2621EDD04E606E865424220FE5D0B1E3AC31C3992A78A624C129C84BBD633A3C820FB6ADAE638AD3EBCD484539A4A21C52510EA95B9D4E9A81B80CC465202E63AB11F78215156FA446631E3568FE8769F42F9A6AA30D307C0C72921375C0A13D9A69B1440BAEBC9CB13CF23D35931B9FC9E74C9DC185B414258E73C58FE512C6F2AEF8382E909AC96D4ABDBA69F9E47B7F145A74C3ACF2EFD5E75DD1BEBFEEA5866DBFCDBBF68ADC89956BCB2BDA1AA72FBCBDE79AD47063DDB467C666F91D6B574EBB62D6A5E3D2E75FB5A17271C75599A1A3350953AB2EC9AB9C39232DBDFA9A2D95CB7FF09D8966570A4873225886C4F29A1B14230F9B19520174D82CA44306724E99801D91C4811F9FF907918AA28143897028110E79E79A798C273CEE5C0BDA396F3418151435F8F17DE03364D9CE8C60C8EE21A89CF20433D12230AEB0680CE690E317A4C8E2AEC812FE5D913B1711B91FA2BE1F855CF265A0D042D62A93D34C39262ECD9063E08C90334ABCC87FDDEB40E22801CE6C46EA1360C26CD5E3223D2ED2E3227DB300B99562C4D022606819222EE662300A6B766A83EC0A4288D6082F0FBC33F055175D479775712503BBB9527E55FFFD9159F451FEBB48AB03A459CF685DAAF8D7420C36522AF20E0BD069E490060E69E0749AD4A2791EB68A9B094EB46C25C4AA63414827FAACE02F4232E4EE1FD963F2C338809BE84408C300C56D44637E5FA88F8CEF8A847E492FD58DE14DC914F2AAFE8D039F72717CFBC046695E6A2E772BF88245B07F5A040F892729A45399B5C146D719A98E1D155C779B6D4C720EEAE2933B45B71536F46CABD5D2E9B0F9AC5956CE6A4E1929EF56CA69D1F8CB6832F8A992801B82FAAD892D06093D3CFA83A0811AD0E37D14BAE00F2049AC6379BB0CA008590491B343474E4017484DCFB1A5A5D902A9FA9CDC90CFAED7EB74AE78376E19BE65B7B0E2851FFD8C56D1D08B873AEFF90D6DDAFDF735EB56D46E7EE0C19E876FA12941998ACD5DF591EFDD956A5BB0ACFCEAC75A4037F5C0F762E0DB057654B591A713AD05562E8B1D3F3A39379C3D3A0D36E2936805649948B61953A3D5604C88338F0CDC2D623C6632B8500C0C3B8DA0010167419931C6CE23604614CF21A924672A896E728D953CBE7EFDC36F44BEA0A99F6F5FB6E67B3F3E7EF4815BD60767D131EF0ED0507657E55F9E3CF0422DFA6FA05DB089A7898D8C21ED4A161C2A9399C2382F2889BAE25C9D669B95D82D231393562A6ACA391B554E9F32892927C583FC78901F0FF2E36931A0E60D71A8AF248CC8C1948B82D590CA30ADCA2E62B9201CB1A2AAE234CEE0E4059E6C88BD5CC1B65B58F3E9AF3EA0E4E517EB85DDBB7737DFFDF8233B6E7BEC8967A8F34C8466EFE1369F7FF79E2D8FBFF974F78967A27CF26F818E1C2491DCBB7FA39EEA30154C33C7CDD6E904DA999868153A8D6E77A7D5B64D4FF56EDCCFA81DBD9EB438D9C91964029D17F603D2198DD74E74FFE8C49C4E6F224501511490E6B65B24645BC2182D8D018434226CC91F6563661E3DCA04B1CAA84FBF1BD5E71A62DDE11A9F8E7CEBF9B706260BEAAE9F756C7FFBB5B3D47AFCF89B5D74FBC6750F3BE99F1F3BBC66D7629A30F0199D1CE9FF20E7FBF7EFB9057D460E30FEA08E83FDD87C88D880DDA978327601D6204A9D162BD7E9A0C0205A5A10964B4412E38CC88611D930221BC65653345EB35662EDFB90AF41C7E47605DDB4CE3E4C87D9783A8333B3764283D054102C426D02032E5708127C2839A19CA9B9A052EEC1ACE98FF7F5FD64EFDEC33BCA33C4EF785FBBBFBDBF9D5FD7BEE7A15F38809C3D90ED9F05CBB4835D06AEB751F8A12EA34B12404726F2756771217B8F99E459652C3349A73432296C35725A46C8DC24B607594EE8BCF85C37945D30C3D40EC5901DDBD00CD9D92984FE833FBBFBD38D6082C2FAD7E9226E3E550E750C1C114F0F2C7F3A7235581E1E5DAE115F832CD04A2E5352754B141267B51817F316895F3C98252169129226216952AB254A95254A151CE86D9A8C31F6B363139C9A8A5E490297E6045786C2846C47E70482CE65CC989131B9A828B07BB7281466664E9F9E9931E35CBF403479D2B9204F9E4C53606773DF28C2485474ECCD1061840B6F2628013FA6C173E1E9A7B527EAAA614FA590370FCE91E81C818E0523791273793FE59361B72893F003959B4A82E8727B054BA732C663735A4DD4F16D2F3FAD24E3DBE34C0ED3CC783B2EB4E3423B2EB4B73A30F84E81B1230EC60EEFC874BAD564C2A4C184474F7893C4FBFCA6D62C30C2ABAFAA8B1D400B3C51A6D831B42FCAA027180A15158592CE2464C35AB4DBABEB64ED3C941E55F990EA5D21147B02EA5F57BDBB694BD30F767FB4B21D8C60D51F9BEE1BB3E614ADE2E63DFAC3DE5B067AB87A9AF9F38E811E813C7CF8FAAB5F029B88DA36F34668DBF6986D9BACCCBABF49365FFD03DB8EFF976D3BFE1FD8369AF637D8B6C6A00B8DFB868780AF756F76EDE366D3B243B7232B8F3EFDDA8968F4A8043EF084D3A2A4242A66AEC2D149DC52A7CE36522F2DC38E397D2C9DD78E373D836FB3D081E71C743E56D3D039A7453BE7A083E213BFE19C830171F8372B598448C84E3790FDF3B158017183AB7A37F2579AD4F73F298D7CF2D6FD3D87EF7BE0B1C73C34E50CE5686AE4FD737F8BBCC6EFF9F3D1837FFAFD53BD2FE0F7DAC844012D5B8B8A810D26CA7BA9ABD3EA16AC3A6FA7D13672D3B678A2DEC783874D89B5EF2A18ED3C9E149D636482D6CA325A3BF2869F4A78CA781B1616B3BFA6212D99AD4B0B0CE9C6E1B24112CF0FF1088AA3F321140A9B3E7AE6ED73AFFD76F523DB3A7F7AFFF63B9EB86BA053FCF381E723673E880C469EE3E6DCB1ADFBBDE71E7BFAB79A1D72470407F0597B884810CDC6639CD3BB0C56424C5C9C6D35FEEED9611AF965AC55DF33F8851287992F26B97A917D148BD10E4E1FC2DA896C485262CE7FC8A498E33F222F68BA1D080DECAC5552F945FE671E1BF84A202FAEDC14877EAA1122B515649F497628EE0DE974AD9B6E94E84623BD8150D986F439D0802663CF948F509C601D2BC44F4E48EC8CB7F9681655284FF9CEC9EE848409635BAC5632A105BFFFB044D82766899C286611342C921CFD066A67072C3C5DB1A3D5C0337550F15825E3B92A7AA80231FFD32355E32D0FBD9A5674F9949265A58199D7DE5E7E73D3777F90393767CC98FCCA50C9CA79138B57DF59797F9ABA64E7C4828C80D39B575A73C9ECEBCAD333F7CC75A5E7F826E44E4A8D4FCA2B5D3463DEEAB9E35016F2E0C7DC4D621022F84A25C4B3C42C3EDE0149A5C904CEAF530F6AB228E06F2DA020B361E467825621FAE943887E1683F6533C7D09C302767630A8C56BE8B3AC1258C64FDB7616A9F3D8B74C965172374DBB3AF285AAEEA65C2452B660C664938F667057B59FCB89FCB17DE097CB6A5291E29DA0BD53106FEC7002C8DAA4A3F063614ACBE7C1C5F112649536ABC14ABFE6E3B659A9150F87C842CF603F928B2D730D56AB73E4C7E256BD69E8E0C531F3738ECC2A2F7CF584CDC3DC39737198566A072FDC3790579EDA2D5CF34AE4CE9F9CDD78EFEE870FD3035C78E060E448F71DDC7CE0074C927F0E3F0FC329D6B2C94C37717403A5EB05FC6E755231E3714AF021641F29D0495109C07A4822D92F1BCC7A9E73F15633CEC6C38499D8B45F9D58045C27F0D14F093C6801CF631091F07B5C4101FB1A173BD3531A183A8BF1CF451A1F8A6C394085317AC1E4A63681F413810C78AAA657CCE04EB37F33E2FF3F541E218FD038BA9E3ECDE9A15CC9FD84952FF99BF8F3C22AE1452CE266F1399D3F5AD68E289FE93ED357E87F65B8C4B00B4AC438939515268369A5E955F33C28774BC9D2F5D25B96BCD1325A46CB68192DA365B48C96D1325A46CB68192DA365B48C96D1325A46CB68192DFF2F15F6BF23B4FFF1188FFF8188109A0455079D0555E9D9532A175E3EFB3FE65D565E5633AB24F78AAC3913F2C617866AC7E5670427CAFFF7FE84C67F8B4B607FEF4C8002F2E9F30F0E02A408618C7F286D01A922E9249B4C21956421B99CCC26FF41E691CB483929233564162921B9E40A9245E69009248F8C278524446AC938924F3248904C2432D1FE5D1947F0EF92E9F00FB02D5CBAECBAA5BECBE7B01942771291FD59B67FE51AB1AE8FF40D5E8488FEAF567112D9F3DFAA4E246EACC297E42AF13E724490C811FE43AD8A4F90239C9F64C52A7F8C1CD10701DF4F8EE80CE42AE106581FAB0AD9244C2113C56DE4D1E15558491CDF5A1D6411567E1FA9170E420D927AEE26928355D84EF6D03EB27358DDA37B8FEC41BCA0C2DA03D042E59E257BF8A5A4913B486498DBC9BF4CE2B4BDF42D17EA43944E74AB7B0F5F6D2DFC1BF16A0ADCFBB7C2BDD81E9F5B7A457FFB40C4FCB601FF96A031A6BFFF0455806E7F0A656E6473747265616D0A656E646F626A0A382030206F626A0A3C3C2F547970652F466F6E7444657363726970746F722F466F6E744E616D652F4D4957485A572B5365676F6555492C426F6C642F466F6E7442426F785B2D31202D32333420383538203734305D2F466C61677320340A2F417363656E74203734300A2F436170486569676874203731310A2F44657363656E74202D3233340A2F4974616C6963416E676C6520300A2F5374656D56203132380A2F4D697373696E675769647468203634350A2F58486569676874203531320A2F466F6E7446696C6532203237203020523E3E0A656E646F626A0A32372030206F626A0A3C3C2F46696C7465722F466C6174654465636F64650A2F4C656E677468312031363139362F4C656E67746820353532333E3E73747265616D0A789CED3B0D7854D595E7BE9FF94FE6CD6F261948DE649210F26226CC6448060632269900094212024C8068020142140982D2A2FCB8244A076CD51845C46A5DCAEAD6D517DC6AB05571AB6DB5F2AD5AA952ED823F95560966ADA2ABE4CD9EFB66020175D7DD6F77BF7EFBE5DEDCFBEE3DE7BC7BEEF9BD7718060800A4C17660A161FE029F1FD43243C46ED18AB5EDDDC9F9F43B0048D78AEB368A8DE1867B10F01680FEF355DDABD73E152E4A00185EC3F98ED5577D775592DE550360DADFB9B2BDE39DB77EBF14A0D284C0A99D08B099AD1F02D86338CFEB5CBBF13B297EF8241BAF5AB7A23D39CFFB1380F3E1B5EDDFE9B6E4B2BF40FA1B10285EDDBE76658A9E7639DDEB366C4CCE679EA2F8EE6B56767F77CF13BF47FA7D00EC83FC297001F07B2153ED5D7041E180C2011227937DE276EC91AF3239F1A94A0FCA93E7A9716E63662786D826B021DD107CABA24B358E4E7E0A7F845754F0C114FA1EB8131E80A370FD372E304CAE22D16FC76B6C21CDA49A4C215E757C290913E9DC384444B8FD1C5D0649271A50E063F8339C80D7F1F905CEDF86CFE19FE083AF59581EC36303A9235EF2059C85335FA17B112B103F11E0B7B01376C316E885F538FE18DE1FBB86BA8E53EDB3D4C92678021E86CD70630AF92074A446B7C201781AE9D24911DAC2C2E4818585C447608153F024EC8377107F3BFCDF970EACF5DF84D4AE51A690E9A8D1F1325EC6CB78192FE365BCFCF7CA0EF839DC0177247A138F40134CD6D8E111A8855A25C6B7C10FF07ED10BCBA019218D91C68EE6A6F9F32E9B5B5F3767F6ACDAEAAA4B2395336784A74F0B55944F0D9605FC534A7D2597144B45930B2715E4E779733D624EF6C409EEAC4C5786D361B7592D82393DCD6434E8755A0DCFB10C8162E2925DD5B168979C59DD269BBC355E41944DF3862FF3C960757BBC1631E06BB9244525F3920CB67AD9DE101B8048458BAC912E269927B3F9C2C71E7CF932B71895B97CFCF3D6B577C8854D318F57F89DFB1CBE05DF91B3AA631E8F5B66F2F16F0EA2F0AFAE5DEC908506847BDC49C81C191A62B40D26DEA9402054785AB06F8AC9D9A3D39696AFDBE421BCD01EBE689BF3485C18306556D7C8601F00D33B323828D970055EDFC272A1841B1170A4AE063E99D83F96894D268ECB70CB17B2A0AF9DA8F81A1D443BBABCD18E35A8D18EB6F33A1D4E6AD423C6C57853CC12C0A1BAE97AF9D78DB101A3A1DA5BBDD28000500130603022C44801B844F70031CD24EA803145A70D30A04B43F559E976A3B475C9915D6D38F0D6A0DE10633B8F194C1CDE3D1605F8DAE8C8961C2537216BAA656D7213E21A39D22EC32E71A0F8707CF7A000CBDB245387B7A37D594C66DB916000D8FC6867B33CA1BE6109829015B6B64E919ABB46EDA8F1C468A718C739A56DC3DE5B438D7E01BCA373651B7513D2E6AD419CBE3A76B3E7B05BB6E2332A5B24390DC9D236BFE766E351D71A914EE3F19B45F97EDCEE18AC87F6E8042EDC7A3CEA456EB858B4AB8A9AC477CE6CAA37CEE9508D13D9D52ECADB9777257DAF7DF7A8FF7BE2826C3AE341EBA07DF04DF5C5942A3BDABAE896BBDAA998D12E31BE6BA52AEA6E5534F45731DA55431B7D11BD1F16E2DB4B62D14E6FF43C43141C076CFEC5EF7A3C72A6445F8CC7A3748BED1DB8FBE49611717EFF3426DC12C1FD54CB9166F501CDAA0D9063A4BDA625054A112CA1AF514C5B4D4B8B2769772495B5F937F3255E314E57D4E6CB7649F03C87B8C39714D737C5A2356E557A99A98ECD1872B987705CDF700E4C5C4813F70DB9933AAA5FE0AD6F4C7A41E768D7D69C0C60E69CE5913445AFAE7AC4E53E82E35A6F6D5B3C5EEB156BE36DF1F6C1C4F6E55E51F0C6074CA67877B44D54239F20FCC95D6EB976778B2CB47592696864EA6FB54DF5B2AD7129354FADD8D99E4C16955E4F85DB636919A569F826742ACED0E3D1EF699CC58553B837136624B7584BD3CB206605B72C54D030C59D2C8C611CAC507D56ED303E16E0E26E1A296C4B7E74CD829482D01B530E43F35E630A8A8B783C3486760D4660394EE4ED8DB1E45C84E5EE8310F14968BB368A393C8A712CA498EDA39873AFB779D156AEFA05FF894F8FF5E7B8C56B15433E55FF6ABAED900F37A38C9F57C8BA8A94B96DD531D6CDA4468C9BA5238384E92B2C6748EA8B54279825E382577CD92B0B92CC57C70EBBC32DA260C1F4469066B644A306B3E8CBDE1708CD9D60176412968993C20173A99AD2D98C0A449E731E311A6F4B79D758B152074047E7D7CB86348217C57327E92D562F95F02535A5A532757E2D8D25B7274951D722A7D37C2CA79F523BDCAFBB3A2662F6C1686D54076254ECA4C696C5B61A350DB4B8C782071327DA6A68DAC32D531277CAADB14FAAF6425FFBF61EBE1D3DFCC6DD2D9DE8DD72A408251083C8568D96E6584A4B15EE5414515E73A82817E2CF697194E6ABDAAD6FBE6036665D7A2078105D712EF69B6372AD34BA54723E4B728F9DCEBE083D67140DA809D132872A15CF9F0AF70530B46F2409C23CB2C5BD999E270C540D78C9CEC68108D9B96049EC900020EE6C8E1D640853DD56D5329087B8D8211120A242190AA5403A11E904EA09AE7690D1A9F4EE431180ED2A965301EA7CC5200115A61B85115831C82461C2288C41189784455458F27A2146D7D45C02F806E81E185100D26F3F5BFCA5267D26855C505A29C4B8101E824CB802B4B89E003E5809C0FB1309E0813C033E6E0889E673A7B08F701F4616EAD342C74F383326BC7614BBEB6F70BAAFBF21F39557717CDD26ECD6766377D53AECAEBCDAE9BEF2EA6DD7646DBCD6EE98B0BA0BBB556BB05BD96977AFECEC5D9F95B9C1B9B93AD3F35D6C279EE63EC3F54FA8BDC80D3F9666094506B90F0E1AEDA14389C3DC478FB973439597A6719F20FE07DC5FB02F4DF51FA9FBFAD363462154F914A9C299995C0AF7934B2369CCE79F31D2A79FF0D2279F7112DAF6B1CFBCDE103E23AD9FD99CA13F9D64A593EF3352E47D9B2354F62C59F01B466AC276DFDDBCB4EF6E4EBAE76E46DA7BB746BABBDF20B5DFCB49F7F631D21D7D9C74FB6DBC745B1F2BF5F53B728415E20A66D60F19694FBF39E7AE7E56BAB39F414E2722E9FDF985A145FDE4857EF297335A95F9990CB7CABCF84CBA39F4619C933E88B3D22E7C7E2FAE91E23D7AE9C66D44DABE9593B661DBB2552B6DED61D5B5DE58EECA0C2DEF21D24E6C3763BBA987977A7B34D28E1EADE42E77B8A63A1C4187B5CC610E384C7E877E8A4353EA607D0E28710CFFABF9F447E9A786D2AF3C4D8CA7A79FAE3FFDB3D35F9EE68DC34B87770D7F39CC9D6213390593D20B27990B342EA9484A2F96CCB9DEF43CAF393B275DCC319B058B496F309A345A9D89E5781310C6A4615D3966B6929DCF1E67B9FBE038306E3231CDA5CD4A7308196956CE9EE67393E27051B8305C10CE0BE786C57076D81D76851D616BD81CD6873561360CE186403391ADF550DF5C25DB083E1754C901A97E90159B64BF542FEB1B96C60608F97E0B426566278643B3CCEDC40868C61BD792A5B1419249D1BDEE434008C8F56DBDB7B448D244B983E6E4ED135B643F1DDC3AB1054F4F7FA3ECF6564917970D6AB7E102D8406141542E8AB6CBC5D1B61A15BD513E159587A36BDAE561BCC29DC6FBD170B44D3EEDADB9E03DF295D5B1C0868DE7195DC836C57AC306953FA5935D72252AE1ABBBDC30A0A70A6968AAAA97757891D0352C95B3BC38F9354EA6E2C4E4ADC2C83D00C0F5F0D7018B719C15316A09CB01CBF37A0E7C47AC21DF117C541E99521AB0782CF91E8BE700FB2F671F671E1FA9E3AFFB227E07370F03A72E71927B903F080E688A04BD8680812986303093ECE5766692A9DCC414E8A7EA1987C3761B63138DC4684CBB4DC761F233961A19A33143D8C2FB8690536BC00795437E5F2BEDA69492D6D656686DCDD77845B008E0F167580ABCB91A87DD19F097730FDE3BA23CAEDC441E220B5EBDF5D6C1173FFFE0974FDD1B984B7A483589918783CA0B8B94632F7FB60C50C2FD9897F6F17B513E0126475CFA3EB0EAFA50CC2D621A494BB3EAB78A508A64BE56751743B889CA21556091F2652D013F7EF42CF0EE276799B3CA15CA8F0FDDFFEA4743BFE3F78E449501A59BEB3BBBE1ECB1231FD2BCB99F7E5F809C8C303D92ABEFD36818431FB1F27D0CCBE9385D920DA4690C5B45524A1882CCFCAAE0019F4FE56A09F990B307D53C5A3938BB9F9DAEE8C851456232F9BDCABF29CF2A5F2883296EECDBC84D0F65916C64C2E8B456D2A763392EC5C9C868B68ADA522DA33DC749E56355D990734CD8B7150D7945F1294FB133B83EE57EE58B91DFE2BA49CD2D56BF85C9855991C2E93662D38B5BD2D321B97F92E746E5194A0D8CC16674B7EB7486AC76234B0CE00B2465B186C6CA88D3562A1D5BC27ABD94AF68B1A7335A47369B4150C9F403BE975FACDC723CB3C417C85EAC3CC500632869DE34470C57041C23F7EDEEAC8CBC4DD61755F93247DE44556CAEDFB6AACEC1192E09473D2C28EBC33396FC9CEA6519FA6319FA6310AE8BCC2B0A4E0B325E894C9A4CF23383994C9EABCCC5486632399D14C134F4D209445F62C9E39C81AC9C3B9C1C100105E3EE08D8B2B24AF2B65848C916514FF4FAF2518BA92E22BC46C583CA915FB662B3583342D45FD15B93A5DCE244279DC904CB4A98490505C1B2994CC0EFCCB0A0DCB9E98CC39ECD6464B30E94DD9B5BB07CF14B9D3396CEC82E5D704DD5833F5E72CF4BD774FFC39CBC854B5A0ACB97CCCC2DA8EDA85CF4BDE5654BF7FDF386EB8E9693C89C39CE49C19CA2AA8A3277ED8B3FE8FE51E714F704E5686641A6C95110F4E4850253B2F21A57ED58FC9DBF5D595C88BAC8418FEC537D7F52C4CE5A09DFA761F180E699ADA52C6159BDCEA20A14F0AB1EE8AF3CEF16E808AB959F2B6BB88D5CDF976BB93EA2A5BAED4B9CE483B85E1AE4471C7A0C6813CBB3B0D568346BB78A5C29C770C930C228AAA4514404B4322E977CF0C191032383A406956C24D5CCDA91CDCC26367CF6B0B29F34B073D59B87F23ADB949887D928ED1FC93106084D40AAB3063D6CD3D947D826E5F54DE899A1C449F6189789392707DA23330AB5155A66B226A4613667901519246396B1D6B808D38B8D38D88977F14E73C4609D6D36A7EDB10966A3137A530EEC3167DDA4F30D85924A482520892AC2126A15865A5B9376F578825E0D1A2B28E4E7977973B5C1A95303A2850F6A93E9682A7B4C39CAAD7EB1FF27A49D381F7FE2C7557FBC9C3CAEBCFEE4DEFA484B77DFC30FDD428A4AF21F5C7B3AB74CA97F2EEAB26F9A1ABD9E4A3B1BA5B84595A238E2C204D9CF38313BF6EB04632A8233841DA3C951DD5A3235624ECC85E0C53991BDE5CA174F296F9110D1FCB471C5E69DF7EDE9BD6E7DFE4C92FD0EE1C925A5CA2775F7EDDE794F1DCD88C8979B887C2D9001CD9129C013608889E77996FC30926167337E38BB94BD4BE7B4EF49172A3544A321969B446BA995B15A3333488FD1978C691A04AD6AE292C0E5CBBA8CCEA7945E71796B2BF1383DFE7287BACF3208F8AD0EAA378D969B38D22110FD43DBBFFFEEE7CA6952F8C6894F95370FCE5D6722078E37BC3797D8CE24489172E6BD196F6DBD1CF5D38BDEBB8C3F85FB94222EA27798B87EB36000E821C466D2F588FA523DA34F6518EA7168B7809A3F293387EAC7016A296E99F2FCFEE64EE53912E636FE8A2C636ADFDEDA3E32C89F1AB9614051CF8875688E37F99398B9CD9017B1A739D2CDB042037A56CF9A7AC4B4D23426ED7C9854D230416F289B8A61EDB06B6CC888E437AC5AD5D0B87265BDCAE5812BA2B3962C99357BD99797739094843C8B92B0E08C9888034DDB73EE0C00BA1E4DFAE459FA2E7F2A49AF398E16CA86D648194C142632460DD15B1C5633D73F41C8B29BFA5D02E98940BACEA2AFB20B3D602106D692A5EB89E873447D4F61A944548B847C688E213FCE84CB3EC9A2679BDF4F0508A09E08A2C6E8EA9CCE1C01746F7F06559CE6382A6EDE72E5B91F35B6AB724D195873ACE1DA77C93C66F6F19B3A467EC1CC3BB6FDEA915F71707FD3EA679E513A52B272CB55EF4A5ACD6056EDF64D5643A35D6C3547D26ACB95E7FFBEA94BE5BBFE0DD2CC844E53AB71F0C0CF9425292FDE877C8C60A7D9C8D20F4E53BF46D0EF106DA536C666739A77B0BE0BCE745EA4EEE8F183C30E2CF212027E8BC0AC4D80F2261A834D905CE5E8D9EE1B4EBF9B4972CE28244779FB544279838DECBD4539467C24877A4AAF32997B04B90A300142915CD64D1CFD662767D664F5EB05D30ED155EA625CAE6C8D95E911D9529661A9A4FED15DF82B935936DF3B2A27C6868007019BCC24410175409EE754A1AF7DED57C7465E3DD4D5BDF4AA4DAFB65FBF69E420FFFADEC7948F3EC40DBFC8943575DDF4777793F4BE94CE590F6745EFF54526681D3AB3A1123F57A609A93C6231687ACEDF0492617BA4D5AF3A72C158ADFB33584F68EEEA8D2AFFFA5FF82730EFE6DCF5374A06074FBF8CD778A8C28CD58CD2FB61FE13DA624B2EE79C42E8A7937CA3309B106ECF14E7BAAC6D594C56D6C43D4E212B2BB7B837C9565B46727B2CBEA1E746F3C6F9AB9E943C3F9387E654F5CC2C6147CF4C4741C157CECCAA79F7449BDB8BA34D05335A2B3DF55B7EB4B866774DF87B5539E545AEBC69B3BC95ABE64C9ABFE327CB1E7213F09594F8B20BB35DE68C60EDB2CA4537CCCF77D83FF17A8D0E8F6342E1C40C93B3ACF6F24B97DED8988FB24D4E9C6486F972B0C1DC4871215BC13270A7CDA6B560563618D28D9A3BB566BCBDF9301FA6698C3A738FC89136AE5B3DF2686AC0E4D0EA538F101CFB462F7344BDC15A2CDE6020986F0938BC163BE66A66B8F616E5E0810364FAFBEF6FF3074DF9642939FAE73F2C515EF8B3B2FCFE89D4A2D7A2773761EE4846918335F5F34E416736AB6164386F4D1A44783804927E953CA9D423D74EB589E77893F23C7FED73CA3E32FDE185ABC8F47D3F258F325D23078F6D5AC5D401499C5572B866E463C7DB7B89244C1718C168D4D9798DC6A4EB6727D84D669E18FD46928F37774130D9531EE5E4D34CBE40C012F0B5A2735B02ADAD162ABB5F95FB884505A1F484F1E44E0AD2E3A99C786CCE8CC0D4721BD7ACB4DDA9BCBAA1AEB26E73E954A58D5CFE8CD5C0E95DCF72F0E523CAFAACB3F91BB6B1CAC86DD3E64FBB8C594FFFBDC1F33F58D7E3279E3F90F46FA86BC8474C0633EB6BEA52AC4F63FD82F9829DA7D61DEC636AFD0D37996BE5F670EF72EFF2197C2FFF920652B569BC8ED7F13A5EC7EB781DAFE375BC8ED7F13A5EC7EB781DAFE375BC8ED7F13A5EC7EBFF8F0AF41BA2E4FF96B3034B1FF4D791EAAF080B9A1A17D7D44E9ADDB0B0BE70C1DC45938355E5CB2AE6C7A6FE2FFFF4E2AFA670D0A0F61CD5CFB02B91A03F91A53DCEE98F6C0BA0091A6131D4402D4C82D948BD10EAA11016C05C580493210855500ECBA002E6430C926A2360457D3338D2401AC08295ABD7AD1417CE29AE5A7795FA4D24905B81577FC6FB6DCA4574C3309CB80090FA5F907C111CF86B6C9C0275FCFBB09FABC236F9BFD6F8103E6F80659C0C39FC0BD0F76D1A8BDE4E1B370F42B4B1AFC36CDAB8E631ED15E8656A61DD98D6AB6D865EEE756CEF21FE0C3EB1B13E6CBD50C54E84C988BBF682362F31928CA5FFA050DBF0A62303F2A34F5E610E7F0AEEA4311FFD34FC287DBE50175D7CB67844499FA9DB8DB4FA515BFE3B1E04DF970A656E6473747265616D0A656E646F626A0A31362030206F626A0A3C3C2F547970652F466F6E7444657363726970746F722F466F6E744E616D652F4844574A45522B5461686F6D612F466F6E7442426F785B30203020383735203735305D2F466C6167732036353534300A2F417363656E74203735300A2F436170486569676874203735300A2F44657363656E7420300A2F4974616C6963416E676C6520300A2F5374656D56203133310A2F4D697373696E67576964746820313030300A2F466F6E7446696C6532203238203020523E3E0A656E646F626A0A32382030206F626A0A3C3C2F46696C7465722F466C6174654465636F64650A2F4C656E677468312031323137322F4C656E67746820333234383E3E73747265616D0A789CED1A6B705355FA3BE72669DAA46DD2A60F92B6F7864B4B21604ADAA60D5472FB4885294B79144C8A40D2A62530D686A5BA3E973AEB0303228CAE8FD5116667577759576E6F79A4C8A3AB8E23AE2EE8AE32C3E28AE8AA3B2BCA30EBCE8A2BD9EFDCA4B530ACEE3AEE8F9DC9F9EE77CEF73CE73BDFF972EFCD244000201B06818345ED4B9D2E50DB557761B7BCBB2F144DF2332B014853F74D03C27D7B1EBE1E05A700387D6F744DDF6D6716BC86F4FB00BA9E35D7DFD29BB437B500D09A484F28FCA7F37FDD0EE0EC40A13B82825C7FDE0300590B909F12E91BB839B5DE29B6DEF5FDDDA1249F8772EBB37DA19BA3E60D19FBD19EC521DC10EAEB49D9B3188AA3FD1B0692BCB386E9A3DFEF89BEFBD1499C3B6B1B80764857A6B368CF695FD7DCAE59C9BD012680C48789772FDE7C317C31C03D0E53D1E761D80523F012FC0EC6DA41785E1D6F020546E1B730B1DD090FC153F02A9C844FC7658FC293F02B90917A04A93B482FB91DB6A9D29FC12FE159188603F0027C53FB3D294D512F500B4946F01730D2D7C906B215677E049A105E9AE0B109CFCC83F02D1A49D0F99C9776D257E97DB49FD625A5F456DCDD28F706F7342C401885B7E0F0159CEF249F93CF6100FE8C797B85FC98BE04CFC0D37037C6B31D77FD73E4FAE15E78001E879D97BBEA625AB3E6FC25A238FC1AEE81EBE08F98E917D1E31E580A2C9358337007648115786D3065BB0B7EFA6D76FBBF689A55742F66EB21FA1AD7440F529973520D77906CC77ABBC069208810C0F817601E7AA10DF3F114FC022BEB0ED5790B5696025BB13E585B8FF013F807FC88EE42FB1BE146EE096E16EA0EC2D5D0456E237AF4F6C03EF2249C814E8428EC8633E405CC3E7A6A0E4204ABEDA0E6644671C6C7B01A1623EE22FB35FBB46FC20FA10FF145E893BCCB3AE6CD99EDA9AF73D7D654BB665539AF9A39C3317D5AE5D48AF229E264BBC0979596D8AC938A8B0A0B2CF97966536E4EB6D19095A9CFD069351C253083C8C5CDFEA149190E9BDD6E0FCC4CF1D64B79992B379DB7CB90778991ED32A792CBF8D2CBF8B2717EA10C16B9556C6E61130F41EB0732E4CBC422035B85E47F0F574A39F9C2EB44DF5A7952733818448F16D124C8ADE79CA950D4B9870C59CD62734FD6CC1930946540D28014DA468748EB5CA212B4D5377B88823E7BE60C39CF21D3721FC375B2B4398884D88233A126FF2B4D3C31BA65A20AD06D8CCA4F5244D635CB19EABAC25A590AC9B059189A311ADB12374157D0610C8BE1D07598B910C638045CB92FD2C1F2E863188C08B20627573B1B4A045F4488892C1DBE48107BB105BDAE28477166B3FF5EFBA84DCEC3D1279B1DF2356871CDADEFDBB898AF78ADC0D858EC5E41DEB9D83F516B677D201028C680633E1127C4C97CEB9A702BC5CE9933927B4A25201C5CC7D65C176271FAD609B1CD3D6AAC5BD41854535F040F26F44D56B1982F2CFAC2A1705372F66659EA5007E8E8F4AB1BC4D4B50452A294016A34AA26D812B02793DDB6C4DFCC0213432DB6E4B18F4B8229090A7C634A8145301F2790856E4186257E114DEB59D7530FB1EE7AB578EC01825E8BBEF292B5E52651887D0632098A673FBE54124A4974E5A6CF8091AD626B30166B1585D65830168A2706BB44C124C686DADA62515F10575DE447AF78E2C0669BDCBA25209B8211321B73CF2AA07589DF6BB39B0363ECA23116B0A4B0B00CEA76300B78CD4F0D9865E8F0DB054CD4327FC08679F233BA03E9E4C80A090BB71ECF38953696A39EFAF1F434A748BB9D55E7E6B8045DC8C8838BFD495E802E9B0292D381E711649AD1314DC132A6191CD38CBB07455C650FB0378D02595F317EE59A0AF37D91D93229FC1A754F522FE737FB391B0D24296AE31895E5C04F7A835CE440BAD211C343382ECA2687ACF58FDA1A0282C98C7700767A4BC5B6C59D7EC1171BAF82A424B553560758EA6228124B7D9458D15F59DAB6742CE1AC62F123BD19333ED8B50E8B06AFD01676FBB1C74C72EBDFED367BCC2CE6091E270B953677F827AE3A7663BA3412BCFD340D8964D3E221896C5ADAE91FC177166153875FA18436079B02435350E71F110024554A99940919233006DA58CD2B54AFDADB4624804155AB51052ADF1D27A0CAF4633202DD719A9499C66414659AA44C5265ACFDFB9DB067191EA19E5C0C00187BBFA8B970AB51500F75622B6092ECE5F8342CC627A31E17318104CBF10D727B22015AA0431DD09847EE403313F612E236440EBCE44658ADE24DC849A47FB872A65B8A937EA5C8E68E93F5C3DC6CFBB6462B598F9E55D82F428C22EE403C82F80EA20E72B1F722AE46DC88A8498C92A54A49A97B04896E252F5F25162AD53529624A054EBE70B8A190CF3D4456C0A7881457EF1C9E6465AB770E1714A8A36232A91E81E1CC2C2688A6C28BB2F09862A5529024BA144B418A48ADBB648C58A338DD2922A742257A95CC6C95088D113D4AB53B45544E4F11A50206D9A35827F149D3F6C5299FB9DE143129B94068385F0D37346CC866E36AA5D2A52ADA95E59D4962D833C75DD55848DA7197ED98C576CC7614FB41448A271CC6730923751CFBD38C2261251A56176E55F22DEE2451589822301B8C6852CC2CB52F229195A34AE62A45C52A71B56240825411A76470F11F7E14E63F7AA38A170E120F9EA307E7F7285C31DF9845E61017160B4FEA70CCC6B196B8140BEF6C34224F889B54430E4A6B70B4E0388B542B265E3A40EAB180EA2527CD7DCFF91E954E4E9EE27EFD84977FEB84951F7C93BC89037F82444F90578E4EE75F39EAA97F85185E6E7999E21D72DFA94CB3BBFD0D82A454A64C73B94D8AA048CA2225AA0C2A3B155939AE9C56B24695730AB3965AF6E286F81692BB9C5F4EDB97AD5E46EB8F4CE7FB8F901D47761FA1752305BCF33972F070117FE870217FF850017F606409BF6F641ABF7FC4C5C711476A3D7C9C6C90667B5D7C03E2D5DEABF9B95E3BDFEC2DE59BBC4BF8464409D15BEBE25DD561BEBAB686AFADE9E06B6ACBF8E335A76BCED570F1C427C37BCAE7B9E389D3C37B4C228E9F48397B3273DD7BACF3F8E33790D3EBD5DD643ECA8A743D6E2F9EF88D9419CDC3A2E8C7CA603AEB0D9979EEE863445A836ED1DEC1DE9DBD72AF6677CF911E7597D3C3E8D5FFE0C60769FF3612DD4A366ED9B1850EEE24D0B5A86BB48B9342D11035AD10566C5BC1C5C980B4DFE2E2239679FC30E24C8B999F6129E71D160F3FDD92CFBF53F969253D56C906AED262E29F149A79DE52C6E3B38B172C0DFC0EEB12DE6ABB86B7591B782BCE53807EF996463ECF62E5CD88510B912C8DCD6ED0915C82979378493FD948769323E418F9942448562E905C708217BF926CC4D7E623700CBFB825202B2BB38ECFA5B91C3D468F71099AE034C66C8F56E3E1A88780679196C4D15BCE6B83B68E26399FE0B8B46928D3E56893C34B9AEEBEFFFE52F961F6E01D2C0DC4F568834F70996C0DC87AF67050497060DB3080D7860199F3C93A5F2424EBC4960D8CC9614C0EBE6FE5F8E45C46E78A2D44B6F822B2456C716C704C6C38478A483507BB26A8E046C795DA80BABA1A81830C3800BD54893A13EB1C63DDF84203579E29A95537E4C0FBAC2F821D6E44B5660BB0BB3A65B7F90CBCBFE2CD22032CFB7554030C9DAFBDFD9ADACDAAB29BEDE672EC085A5D18D4C2176C0424D853A393CEA25BE907E85D2A659226BA913D2558BD0D1BCD75D4E9A876AE04E7D95955C45E6BA75BBF7C95D6D0597BD1E60C2E18D7BE0546D826D569F7E974999C01EB4EEF04B21BD55A0299069A9DDDB4CC60341A596F3060AF371AE91C8340046E90A3EC33B3273B9BCE41E2A264602A0ECD54FE6F7B8C469D4A4839D9D93A55813D97936DCEF338939959597D960D1E971383C487CB970DDE6A16AA1D4335DB6B5DEEBA6AB39D8B7F399DE45C3CFFD8F6CCC789FE51EE834DD7DE72E179B6F33EFC2EA9D19E830AB84BAAB64E2E2F72F00E7B83D65DE41117685B8BE68B1D459DF615937B8A82B681A21FD86E13364ECEB758720E4CA2B4FC00D1B337B9BD06535D45859E4559C6F6A7B77B4BDA4B688995EDA5A4B0BCB004BF9D92517C836009CDCA66095DB9BEA8DA89C3594CAD03837679CF563B6755ADC4A8DDEE3A377E4DAC985A51214ED665E8741922CAAA5DF8D550E5F0B26B34FF5CDB2D77ECBA7DEA64F1BABADA3ED7F485C586B96F771FFF78DA94F2C8EC551FFAE8A9D7573DB3F2B9776F9EBB8A2F2BB359CC55E63FF073DE3E74ED43DEC6C1B9BDA7F03504F86F803929788258D3908634A4210D6948431AD2908634A4210D6948431AD2908634A4210D6948431AD29086EF12D4FFAED0D4BF592CC0A97F764129D121C1594C05DFF51F4CFF9F9A062AD55EC3F2734E9348604F588FBC06D86FC2163041324504F2308F14291DFBB9B82314E9EF0B313FB20DB4A0FF0F57BCCCEE1C9C4B5C22206366641CE920FCF7F811744E44CD2A38C37EB14D9EFFD734B63E57326D48DE7D60756EC367604B06FCECE88112361E7DE6E8F35FD45C6C350AFA566433D57C60FB1709E94C510A656E6473747265616D0A656E646F626A0A33322030206F626A0A3C3C2F547970652F4D657461646174610A2F537562747970652F584D4C2F4C656E67746820313536383E3E73747265616D0A3C3F787061636B657420626567696E3D27EFBBBF272069643D2757354D304D7043656869487A7265537A4E54637A6B633964273F3E0A3C3F61646F62652D7861702D66696C74657273206573633D2243524C46223F3E0A3C783A786D706D65746120786D6C6E733A783D2761646F62653A6E733A6D6574612F2720783A786D70746B3D27584D5020746F6F6C6B697420322E392E312D31332C206672616D65776F726B20312E36273E0A3C7264663A52444620786D6C6E733A7264663D27687474703A2F2F7777772E77332E6F72672F313939392F30322F32322D7264662D73796E7461782D6E73232720786D6C6E733A69583D27687474703A2F2F6E732E61646F62652E636F6D2F69582F312E302F273E0A3C7264663A4465736372697074696F6E207264663A61626F75743D27757569643A31323934656130312D353037392D313165342D303030302D3830336633636165383230662720786D6C6E733A7064663D27687474703A2F2F6E732E61646F62652E636F6D2F7064662F312E332F273E3C7064663A50726F64756365723E47504C2047686F737473637269707420392E31303C2F7064663A50726F64756365723E0A3C7064663A4B6579776F7264733E28293C2F7064663A4B6579776F7264733E0A3C2F7264663A4465736372697074696F6E3E0A3C7264663A4465736372697074696F6E207264663A61626F75743D27757569643A31323934656130312D353037392D313165342D303030302D3830336633636165383230662720786D6C6E733A786D703D27687474703A2F2F6E732E61646F62652E636F6D2F7861702F312E302F273E3C786D703A4D6F64696679446174653E323031342D31302D30375430383A32383A33362D30343A30303C2F786D703A4D6F64696679446174653E0A3C786D703A437265617465446174653E323031342D31302D30375430383A32383A33362D30343A30303C2F786D703A437265617465446174653E0A3C786D703A43726561746F72546F6F6C3E50444643726561746F722056657273696F6E20312E372E333C2F786D703A43726561746F72546F6F6C3E3C2F7264663A4465736372697074696F6E3E0A3C7264663A4465736372697074696F6E207264663A61626F75743D27757569643A31323934656130312D353037392D313165342D303030302D3830336633636165383230662720786D6C6E733A7861704D4D3D27687474703A2F2F6E732E61646F62652E636F6D2F7861702F312E302F6D6D2F27207861704D4D3A446F63756D656E7449443D27757569643A31323934656130312D353037392D313165342D303030302D383033663363616538323066272F3E0A3C7264663A4465736372697074696F6E207264663A61626F75743D27757569643A31323934656130312D353037392D313165342D303030302D3830336633636165383230662720786D6C6E733A64633D27687474703A2F2F7075726C2E6F72672F64632F656C656D656E74732F312E312F272064633A666F726D61743D276170706C69636174696F6E2F706466273E3C64633A7469746C653E3C7264663A416C743E3C7264663A6C6920786D6C3A6C616E673D27782D64656661756C74273E4469616772616D6547656F6666726579476C616E67696E653C2F7264663A6C693E3C2F7264663A416C743E3C2F64633A7469746C653E3C64633A63726561746F723E3C7264663A5365713E3C7264663A6C693E313434313033393C2F7264663A6C693E3C2F7264663A5365713E3C2F64633A63726561746F723E3C64633A6465736372697074696F6E3E3C7264663A5365713E3C7264663A6C693E28293C2F7264663A6C693E3C2F7264663A5365713E3C2F64633A6465736372697074696F6E3E3C2F7264663A4465736372697074696F6E3E0A3C2F7264663A5244463E0A3C2F783A786D706D6574613E0A2020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020200A2020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020200A3C3F787061636B657420656E643D2777273F3E0A656E6473747265616D0A656E646F626A0A322030206F626A0A3C3C2F50726F64756365722847504C2047686F737473637269707420392E3130290A2F4372656174696F6E4461746528443A32303134313030373038323833362D303427303027290A2F4D6F644461746528443A32303134313030373038323833362D303427303027290A2F417574686F72285C3337365C3337375C303030315C303030345C303030345C303030315C303030305C303030335C30303039290A2F43726561746F72285C3337365C3337375C303030505C303030445C303030465C303030435C303030725C303030655C303030615C303030745C3030306F5C303030725C303030205C303030565C303030655C303030725C303030735C303030695C3030306F5C3030306E5C303030205C303030315C3030302E5C303030375C3030302E5C30303033290A2F4B6579776F72647328290A2F5375626A65637428290A2F5469746C65285C3337365C3337375C303030445C303030695C303030615C303030675C303030725C303030615C3030306D5C303030655C303030475C303030655C3030306F5C303030665C303030665C303030725C303030655C303030795C303030475C3030306C5C303030615C3030306E5C303030675C303030695C3030306E5C30303065293E3E656E646F626A0A787265660A302033330A303030303030303030302036353533352066200A30303030303131393630203030303030206E200A30303030303336303134203030303030206E200A30303030303131383934203030303030206E200A30303030303131353036203030303030206E200A30303030303030303135203030303030206E200A30303030303039383332203030303030206E200A30303030303135393630203030303030206E200A30303030303235303132203030303030206E200A30303030303133393331203030303030206E200A30303030303132303235203030303030206E200A30303030303135333131203030303030206E200A30303030303136363131203030303030206E200A30303030303133313339203030303030206E200A30303030303132333434203030303030206E200A30303030303136343531203030303030206E200A30303030303330383338203030303030206E200A30303030303132323630203030303030206E200A30303030303132323932203030303030206E200A30303030303134373230203030303030206E200A30303030303131363939203030303030206E200A30303030303039383532203030303030206E200A30303030303131343835203030303030206E200A30303030303134373732203030303030206E200A30303030303134383034203030303030206E200A30303030303134383336203030303030206E200A30303030303136383235203030303030206E200A30303030303235323331203030303030206E200A30303030303331303337203030303030206E200A30303030303134383838203030303030206E200A30303030303135353839203030303030206E200A30303030303136323035203030303030206E200A30303030303334333639203030303030206E200A747261696C65720A3C3C202F53697A65203333202F526F6F74203120302052202F496E666F2032203020520A2F4944205B3C44444537333636364336393543313738314439324336303033444643413346353E3C44444537333636364336393543313738314439324336303033444643413346353E5D0A3E3E0A7374617274787265660A33363438390A2525454F460A00)
SET IDENTITY_INSERT [dbo].[Fichier] OFF
SET IDENTITY_INSERT [dbo].[REF_StatutEntreprise] ON 

INSERT [dbo].[REF_StatutEntreprise] ([noSTAENT], [nomSTAENT]) VALUES (1, N'À contacter')
INSERT [dbo].[REF_StatutEntreprise] ([noSTAENT], [nomSTAENT]) VALUES (2, N'En attente d''une réponse')
INSERT [dbo].[REF_StatutEntreprise] ([noSTAENT], [nomSTAENT]) VALUES (3, N'Suivit a effectuer')
INSERT [dbo].[REF_StatutEntreprise] ([noSTAENT], [nomSTAENT]) VALUES (1002, N'Entrevue à venir')
INSERT [dbo].[REF_StatutEntreprise] ([noSTAENT], [nomSTAENT]) VALUES (1003, N'Ne plus me contacter')
INSERT [dbo].[REF_StatutEntreprise] ([noSTAENT], [nomSTAENT]) VALUES (1004, N'Stage obtenu')
SET IDENTITY_INSERT [dbo].[REF_StatutEntreprise] OFF
SET IDENTITY_INSERT [dbo].[REF_TypeDemarche] ON 

INSERT [dbo].[REF_TypeDemarche] ([noTYPDEM], [nomTYPDEM]) VALUES (1, N'Envoi de courriel')
INSERT [dbo].[REF_TypeDemarche] ([noTYPDEM], [nomTYPDEM]) VALUES (2, N'Appel téléphonique')
INSERT [dbo].[REF_TypeDemarche] ([noTYPDEM], [nomTYPDEM]) VALUES (3, N'Rencontre en personne')
INSERT [dbo].[REF_TypeDemarche] ([noTYPDEM], [nomTYPDEM]) VALUES (4, N'Entrevue')
SET IDENTITY_INSERT [dbo].[REF_TypeDemarche] OFF
SET IDENTITY_INSERT [dbo].[REF_TypeFichier] ON 

INSERT [dbo].[REF_TypeFichier] ([noTYPFICH], [nomTYPFICH]) VALUES (1, N'CV')
INSERT [dbo].[REF_TypeFichier] ([noTYPFICH], [nomTYPFICH]) VALUES (2, N'video')
SET IDENTITY_INSERT [dbo].[REF_TypeFichier] OFF
SET IDENTITY_INSERT [dbo].[REF_TypeUtilisateur] ON 

INSERT [dbo].[REF_TypeUtilisateur] ([noTYPUTIL], [nomTYPUTILl]) VALUES (1, N'Coordinateur')
INSERT [dbo].[REF_TypeUtilisateur] ([noTYPUTIL], [nomTYPUTILl]) VALUES (2, N'Étudiant')
INSERT [dbo].[REF_TypeUtilisateur] ([noTYPUTIL], [nomTYPUTILl]) VALUES (3, N'Enseignant')
SET IDENTITY_INSERT [dbo].[REF_TypeUtilisateur] OFF
SET IDENTITY_INSERT [dbo].[Utilisateur] ON 

INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (1, N'glangine.geoffrey@cgmatane.qc.ca', N'GLANGINE', N'Geoffrey', N'aafdc23870ecbcd3d557b6423a8982134e17927e', 1, CAST(0x03390B00 AS Date), NULL, NULL, 2)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (2, N'marie.roy@gmail.com', N'ROY', N'Marie', N'aafdc23870ecbcd3d557b6423a8982134e17927e', 1, CAST(0x11390B00 AS Date), NULL, NULL, 2)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (3, N'gagnon.nicolas@cgmatane.qc.ca', N'GAGNON', N'Nicolas', N'aafdc23870ecbcd3d557b6423a8982134e17927e', 1, CAST(0x11390B00 AS Date), NULL, NULL, 1)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (5, N'bourgoin.ken@cgmatane.qc.ca', N'BOURGOIN', N'Ken', N'aafdc23870ecbcd3d557b6423a8982134e17927e', 1, CAST(0x11390B00 AS Date), NULL, NULL, 3)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (22, N't', N't', N't', N'5295b6c98da35aa14d6353b28cc98719c01a0bbd', 1, CAST(0x3E390B00 AS Date), NULL, CAST(0x3E390B00 AS Date), 3)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (23, N't@gmail.com', N't', N't', N'd2808317e110215a7ee129c511bd1961a4176fb1', 1, CAST(0x3E390B00 AS Date), NULL, CAST(0x3E390B00 AS Date), 3)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (24, N'cabrol.morgane@qcca', N't', N'T', N'00c604bda0a0026d4575ac1a008bd7039fc49b51', 1, CAST(0x3E390B00 AS Date), NULL, CAST(0x3E390B00 AS Date), 2)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (25, N'glangine.geoffrey@cgmatane.qc.ca', N't', N't', N'634299313d4da5fa04ce333617963938ddee74d4', 1, CAST(0x3E390B00 AS Date), NULL, CAST(0x3E390B00 AS Date), 2)
INSERT [dbo].[Utilisateur] ([noUTIL], [courielUTIL], [nomUTIL], [prenomUTIL], [mdpUTIL], [estActif], [dateCreation], [dateModif], [dateSuppression], [noTYPUTIL]) VALUES (26, N'cabrol.morgane@cgmatane.qc.ca', N't', N't', N'164552a41e0535a3fa44413d5254d7f5307727ad', 1, CAST(0x3E390B00 AS Date), NULL, CAST(0x3E390B00 AS Date), 3)
SET IDENTITY_INSERT [dbo].[Utilisateur] OFF
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_noENT] FOREIGN KEY([noENT])
REFERENCES [dbo].[Entreprise] ([noENT])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_noENT]
GO
ALTER TABLE [dbo].[Demarche]  WITH CHECK ADD  CONSTRAINT [FK_Demarche_noCON] FOREIGN KEY([noCON])
REFERENCES [dbo].[Contact] ([noCON])
GO
ALTER TABLE [dbo].[Demarche] CHECK CONSTRAINT [FK_Demarche_noCON]
GO
ALTER TABLE [dbo].[Demarche]  WITH CHECK ADD  CONSTRAINT [FK_Demarche_noENT] FOREIGN KEY([noENT])
REFERENCES [dbo].[Entreprise] ([noENT])
GO
ALTER TABLE [dbo].[Demarche] CHECK CONSTRAINT [FK_Demarche_noENT]
GO
ALTER TABLE [dbo].[Demarche]  WITH CHECK ADD  CONSTRAINT [FK_Demarche_noTYPDEM] FOREIGN KEY([noTYPDEM])
REFERENCES [dbo].[REF_TypeDemarche] ([noTYPDEM])
GO
ALTER TABLE [dbo].[Demarche] CHECK CONSTRAINT [FK_Demarche_noTYPDEM]
GO
ALTER TABLE [dbo].[Entreprise]  WITH CHECK ADD  CONSTRAINT [FK_Entreprise_noSTAENT] FOREIGN KEY([noSTAENT])
REFERENCES [dbo].[REF_StatutEntreprise] ([noSTAENT])
GO
ALTER TABLE [dbo].[Entreprise] CHECK CONSTRAINT [FK_Entreprise_noSTAENT]
GO
ALTER TABLE [dbo].[Entreprise]  WITH CHECK ADD  CONSTRAINT [FK_Entreprise_noUTIL] FOREIGN KEY([noUTIL])
REFERENCES [dbo].[Utilisateur] ([noUTIL])
GO
ALTER TABLE [dbo].[Entreprise] CHECK CONSTRAINT [FK_Entreprise_noUTIL]
GO
ALTER TABLE [dbo].[Fichier]  WITH CHECK ADD  CONSTRAINT [FK_Fichier_noTYPFICH] FOREIGN KEY([noTYPFICH])
REFERENCES [dbo].[REF_TypeFichier] ([noTYPFICH])
GO
ALTER TABLE [dbo].[Fichier] CHECK CONSTRAINT [FK_Fichier_noTYPFICH]
GO
ALTER TABLE [dbo].[Fichier]  WITH CHECK ADD  CONSTRAINT [FK_Fichier_noUTIL] FOREIGN KEY([noUTIL])
REFERENCES [dbo].[Utilisateur] ([noUTIL])
GO
ALTER TABLE [dbo].[Fichier] CHECK CONSTRAINT [FK_Fichier_noUTIL]
GO
ALTER TABLE [dbo].[Utilisateur]  WITH CHECK ADD  CONSTRAINT [FK_Utilisateur_noTYPUTIL] FOREIGN KEY([noTYPUTIL])
REFERENCES [dbo].[REF_TypeUtilisateur] ([noTYPUTIL])
GO
ALTER TABLE [dbo].[Utilisateur] CHECK CONSTRAINT [FK_Utilisateur_noTYPUTIL]
GO
USE [master]
GO
ALTER DATABASE [SSDS_Geoffrey] SET  READ_WRITE 
GO
