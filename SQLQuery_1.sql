SELECT * FROM [Session5].[dbo].[Aircrafts]

SELECT * FROM [Session5].[dbo].[Amenities]
SELECT * FROM [Session5].[dbo].[AmenitiesCabinType]
SELECT * FROM [Session5].[dbo].[AmenitiesTickets]
SELECT * FROM [Session5].[dbo].[CabinTypes]
SELECT * FROM [Session5].[dbo].[Countries]
SELECT * FROM [Session5].[dbo].[Offices]
SELECT * FROM [Session5].[dbo].[Roles]


SELECT * FROM [Session5].[dbo].[Users]


SELECT * FROM [Session5].[dbo].[Tickets] 

SELECT BookingReference,Count(BookingReference) FROM [Session5].[dbo].[Tickets] GROUP by BookingReference HAVING Count(BookingReference) >1


SELECT * FROM [Session5].[dbo].[Routes]
SELECT * FROM [Session5].[dbo].[Airports]
SELECT * FROM [Session5].[dbo].[Schedules]
SELECT * from [Session5].[dbo].[Tickets] a INNER join [Session5].[dbo].[Schedules] b on a.ScheduleID=b.ID 
    INNER join [Session5].[dbo].[Routes] c on b.RouteID=c.ID
    --
SELECT FlightNumber,DepartureAirportID,ArrivalAirportID,[Date],[Time],BookingReference from [Session5].[dbo].[Tickets] a INNER join [Session5].[dbo].[Schedules] b on a.ScheduleID=b.ID 
    INNER join [Session5].[dbo].[Routes] c on b.RouteID=c.ID INNER join [Session5].[dbo].[Airports] d on d.ID=c.ArrivalAirportID

SELECT * FROM [Session5].[dbo].[Airports]
    INNER JOIN [Session5].[dbo].[Routes] on Routes.DepartureAirportID = Airports.ID --đi
  --  WHERE 
SELECT * FROM [Session5].[dbo].[Airports]
    INNER JOIN [Session5].[dbo].[Routes] on Routes.ArrivalAirportID = Airports.ID -- đến

SELECT IATACode,BookingReference FROM [Session5].[dbo].[Tickets] t INNER JOIN [Session5].[dbo].[Schedules] s
    ON t.ScheduleID = s.ID INNER JOIN [Session5].[dbo].[Routes] r on s.RouteID = r.ID 
    INNER JOIN [Session5].[dbo].[Airports] a on r.ArrivalAirportID = a.ID
   -- WHERE BookingReference = 'AKONZE'
    --get DepartureAirportID (đi)

--getIATAcode by ID IATACode
Select IATACode FROM [Session5].[dbo].[Routes] r INNER JOIN [Session5].[dbo].[Airports] a ON r.DepartureAirportID = a.ID INNER JOIN  [Session5].[dbo].[Schedules] s ON s.RouteID = r.ID WHERE s.RouteID = '2'

WHERE DepartureAirportID = 2

SELECT * FROM Tickets INNER JOIN Schedules on Tickets.ScheduleID = Schedules.ID WHERE  ScheduleID = 117  and BookingReference = '12345B'

SELECT * FROM Tickets INNER JOIN Schedules on Tickets.ScheduleID = Schedules.ID WHERE  ScheduleID = '118'

SELECT * FROM Tickets WHERE  BookingReference = '12345B'

SELECT * FROM Tickets INNER JOIN CabinTypes on Tickets.CabinTypeID = CabinTypes.ID WHERE  BookingReference = '12345B'

SELECT * FROM Amenities INNER JOIN AmenitiesCabinType on Amenities.ID = AmenitiesCabinType.AmenityID 
INNER JOIN CabinTypes ON CabinTypes.ID = AmenitiesCabinType.CabinTypeID 
INNER JOIN Tickets ON Tickets.CabinTypeID = CabinTypes.ID

WHERE AmenitiesCabinType.CabinTypeID = 1  and BookingReference = '12345B' ORDER BY Price 

SELECT * FROM Tickets INNER JOIN CabinTypes ON Tickets.CabinTypeID = CabinTypes.ID WHERE CabinTypes.ID = '3' and Tickets.ID = 9448

SELECT * FROM [Session5].[dbo].[AmenitiesCabinType]
SELECT * FROM Amenities ORDER BY Price 
SELECT * FROM AmenitiesCabinType WHERE CabinTypeID =3 
SELECT * FROM CabinTypes
SELECT * FROM [Session5].[dbo].[Tickets] WHERE BookingReference = '12345B' 

SELECT * FROM AmenitiesTickets
INSERT INTO [dbo].[AmenitiesTickets] VALUES (1,9448,10)
INSERT INTO [dbo].[AmenitiesTickets] VALUES (4,9448,12)
INSERT INTO [dbo].[AmenitiesTickets] VALUES (6,9448,25)

DELETE AmenitiesTickets WHERE TicketID = 9448
TRUNCATE TABLE AmenitiesTickets
1 10
4 12
5 15
6 25
7 0
8 5
9   15
12 25
GO