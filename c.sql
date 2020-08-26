USE [Session5]
GO
/****** Object:  View [dbo].[V1]    Script Date: 8/13/2020 6:42:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V1]
AS
	SELECT dbo.Amenities.Service, dbo.CabinTypes.Name
	FROM dbo.AmenitiesCabinType INNER JOIN
		dbo.CabinTypes ON dbo.AmenitiesCabinType.CabinTypeID = dbo.CabinTypes.ID INNER JOIN
		dbo.Amenities ON dbo.AmenitiesCabinType.AmenityID = dbo.Amenities.ID INNER JOIN
		dbo.AmenitiesTickets ON dbo.Amenities.ID = dbo.AmenitiesTickets.AmenityID

GO
/****** Object:  View [dbo].[V2]    Script Date: 8/13/2020 6:42:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[V2]
AS
	SELECT Name AS N'Amenities', Service, COUNT(*) AS N'Count'
	FROM dbo.V1
	GROUP BY Name, Service
GO
/****** Object:  UserDefinedFunction [dbo].[F1]    Script Date: 8/13/2020 6:42:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[F1] ()
RETURNS @T1 TABLE
(
	Amentites NVARCHAR(50),
	ExtraBlanket INT,
	NextSeatFree INT,
	TwoNeighboringSeatsFree INT,
	TabletRental INT,
	LaptopRental INT,
	LoungeAccess INT,
	SoftDrinks INT,
	PremiumHeadphonesRental INT,
	ExtraBag INT,
	FastCheckinLane INT,
	WiFi50mb INT,
	WiFi250mb INT
)
AS
BEGIN

	INSERT INTO @T1
		([Amentites])
	SELECT Name
	FROM dbo.CabinTypes
	DECLARE @i INT = 1, @Name NVARCHAR(50)
	WHILE @i <= 3
	BEGIN
		SELECT @Name = Name
		FROM dbo.CabinTypes
		WHERE ID = @i
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Extra Blanket')
			BEGIN
			UPDATE @T1 SET ExtraBlanket = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Extra Blanket')
				WHERE Amentites = @Name
		END
		ELSE
			BEGIN
			UPDATE @T1 SET ExtraBlanket = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Next Seat Free')
			BEGIN
			UPDATE @T1 SET NextSeatFree = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Next Seat Free')
				WHERE Amentites = @Name
		END
		ELSE
			BEGIN
			UPDATE @T1 SET NextSeatFree = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Two Neighboring Seats Free')
		BEGIN
			UPDATE @T1 SET TwoNeighboringSeatsFree = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Two Neighboring Seats Free')
			WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET TwoNeighboringSeatsFree = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Tablet Rental')
		BEGIN
			UPDATE @T1 SET TabletRental = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Tablet Rental') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET TabletRental = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Laptop Rental')
		BEGIN
			UPDATE @T1 SET LaptopRental = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Laptop Rental') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET LaptopRental = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Lounge Access')
		BEGIN
			UPDATE @T1 SET LoungeAccess = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Lounge Access') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET LoungeAccess = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Soft Drinks')
		BEGIN
			UPDATE @T1 SET SoftDrinks = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Soft Drinks') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET SoftDrinks = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Premium Headphones Rental')
		BEGIN
			UPDATE @T1 SET PremiumHeadphonesRental = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Premium Headphones Rental') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET PremiumHeadphonesRental = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Extra Bag')
		BEGIN
			UPDATE @T1 SET ExtraBag = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Extra Bag') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET ExtraBag = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Fast Checkin Lane')
		BEGIN
			UPDATE @T1 SET FastCheckinLane = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Fast Checkin Lane') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET FastCheckinLane = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Wi-Fi 50 mb')
		BEGIN
			UPDATE @T1 SET WiFi50mb = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Wi-Fi 50 mb') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET WiFi50mb = 0 WHERE Amentites = @Name
		END
		IF EXISTS(SELECT Count
		FROM V2
		WHERE Amenities = @Name AND Service = 'Wi-Fi 250 mb')
		BEGIN
			UPDATE @T1 SET WiFi250mb = (SELECT Count
			FROM V2
			WHERE Amenities = @Name AND Service = 'Wi-Fi 250 mb') WHERE Amentites = @Name
		END
		ELSE
		BEGIN
			UPDATE @T1 SET WiFi250mb = 0 WHERE Amentites = @Name
		END
		SET @i = @i + 1
	END

	RETURN
END