USE BookstoreDB;
GO

CREATE TABLE Authors (
    AuthorId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID()),
    AuthorName VARCHAR(100) NOT NULL,
    BirthDate DATETIME
);
GO

CREATE TABLE Books (
    BookId UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID()),
	ISBN VARCHAR(13) NOT NULL,
    Title VARCHAR(50) NOT NULL,
	Description VARCHAR(50) NOT NULL,
	PagesNumber INT NOT NULL,
	Quantity INT NOT NULL,
    PublicationDate DATE NOT NULL
);
GO

CREATE TABLE BookAuthors (
	BookID UNIQUEIDENTIFIER,
	AuthorID UNIQUEIDENTIFIER,
	FOREIGN KEY (BookID) REFERENCES Books(BookID) ON DELETE CASCADE,
	FOREIGN KEY (AuthorID) REFERENCES Authors(AuthorID) ON DELETE CASCADE
);


CREATE TABLE Customers (
    CustomerID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID()),
    CustomerName VARCHAR(100) NOT NULL,
    EmailAddress VARCHAR(255) UNIQUE NOT NULL,
);
GO

CREATE TABLE Reservations (
    ReservationID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID()),
    CustomerID UNIQUEIDENTIFIER,
	ReservationStatus INT,
    ReservationDate DATETIME NOT NULL,
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID) ON DELETE CASCADE
);
GO

CREATE TABLE ReservationDetails (
    ReservationDetailID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID()),
    ReservationID UNIQUEIDENTIFIER,
    BookID UNIQUEIDENTIFIER,
    FOREIGN KEY (ReservationID) REFERENCES Reservations(ReservationID) ON DELETE CASCADE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID) ON DELETE CASCADE
);
GO

INSERT INTO Authors (AuthorId, AuthorName, BirthDate) VALUES
    ('1F4D6E9C-1D12-4D3F-9E1A-5C4C7D3A7B1A', 'Isaac Asimov', '1920-01-02'),
    ('2A5D3F9B-4D3F-4E6D-9E1B-6D7C4E2A7C1B', 'Arthur C. Clarke', '1917-12-16'),
    ('3E7B5D4A-1D2C-4F9E-8B1A-7A6D3C9B5A4C', 'Philip K. Dick', '1928-12-16'),
    ('4C9B2E1D-5A7C-4D3F-9E1B-5B6D3A7C9E1A', 'J.K. Rowling', '1965-07-31'),
    ('5A7C9E1B-4C6D-3D2E-9B1A-7B6C4D3F5A7C', 'George R.R. Martin', '1948-09-20'),
    ('6D7C4E3A-9B1A-5C2D-4F3E-7A5D6C9B7E1A', 'J.R.R. Tolkien', '1892-01-03'),
    ('7B6C5D4A-3E2D-9F1B-8A7C-6C4D7B5E3A9F', 'Frank Herbert', '1920-10-08'),
    ('8A5D6C4E-3A7B-9B1A-5C7D-4E6A3C2D9E1A', 'Ursula K. Le Guin', '1929-10-21'),
    ('9E1A7B5D-6C4D-3A2E-9F1B-8C7D5E3A4D2F', 'Douglas Adams', '1952-03-11'),
    ('AE2D9F1B-8C7D-5E3A-4D2F-6A7C3B5D9E1A', 'Orson Scott Card', '1951-08-24');
GO

INSERT INTO Books (BookId, ISBN, Title, Description, PagesNumber, Quantity, PublicationDate) VALUES
    ('B1A2E3F4-5C6D-7B8A-9E1A-4D3C5E2A9F7B', '9780451524935', 'Foundation', 'Sci-fi classic', 255, 40, '1951-06-01'),
    ('B2C4E6A7-8F9B-1A2D-5C3E-7B6A5D4C9E3F', '9780345347954', 'Dune', 'Epic sci-fi saga', 412, 35, '1965-08-01'),
    ('B3E7C9A1-2D5B-4F6A-7B8C-9E3F1A5D6C7E', '9780553382563', 'Ender''s Game', 'Sci-fi strategy tale', 324, 25, '1985-01-15'),
    ('B4A3C5E7-9F1B-2D6C-4D3E-7B5A9E1C8D6A', '9780345339683', 'The Hobbit', 'Fantasy adventure', 310, 20, '1937-09-21'),
    ('B5D6A7C9-1B4E-3F5A-2C7B-8D9E4A6C3E5F', '9780553573428', 'A Game of Thrones', 'Epic fantasy', 694, 30, '1996-08-06'),
    ('B6C4D7E8-9A1B-5E3F-2D4A-7C5D6E9A3B1F', '9780747532743', 'Harry Potter and the Philosopher''s Stone', 'Fantasy book', 223, 50, '1997-06-26'),
    ('B7A5D6C4-3E7B-9F1A-2D8C-5B4E9A3C7D1F', '9780358380234', 'The Left Hand of Darkness', 'Sci-fi exploration', 304, 15, '1969-03-01'),
    ('B8C7A5D9-1F3E-4D6B-2A9E-5C8D7A3F6B4E', '9781400032716', 'The Hitchhiker''s Guide to the Galaxy', 'Humorous sci-fi', 216, 50, '1979-10-12'),
    ('B9E4A7C5-6B1D-3A9F-2C8E-5D7A9C3E6B1F', '9780399128967', 'Neuromancer', 'Cyberpunk classic', 271, 18, '1984-07-01'),
    ('BA5D6C7E-8B1A-3F9E-4C7B-2D9A3E6F1B5D', '9780345404473', 'Childhood''s End', 'Sci-fi masterpiece', 224, 22, '1953-08-01');
GO

INSERT INTO BookAuthors (BookID, AuthorID) VALUES
    ('B1A2E3F4-5C6D-7B8A-9E1A-4D3C5E2A9F7B', '1F4D6E9C-1D12-4D3F-9E1A-5C4C7D3A7B1A'), -- Foundation by Isaac Asimov
    ('B2C4E6A7-8F9B-1A2D-5C3E-7B6A5D4C9E3F', '7B6C5D4A-3E2D-9F1B-8A7C-6C4D7B5E3A9F'), -- Dune by Frank Herbert
    ('B3E7C9A1-2D5B-4F6A-7B8C-9E3F1A5D6C7E', 'AE2D9F1B-8C7D-5E3A-4D2F-6A7C3B5D9E1A'), -- Ender's Game by Orson Scott Card
    ('B4A3C5E7-9F1B-2D6C-4D3E-7B5A9E1C8D6A', '6D7C4E3A-9B1A-5C2D-4F3E-7A5D6C9B7E1A'), -- The Hobbit by J.R.R. Tolkien
    ('B5D6A7C9-1B4E-3F5A-2C7B-8D9E4A6C3E5F', '5A7C9E1B-4C6D-3D2E-9B1A-7B6C4D3F5A7C'), -- A Game of Thrones by George R.R. Martin
    ('B6C4D7E8-9A1B-5E3F-2D4A-7C5D6E9A3B1F', '4C9B2E1D-5A7C-4D3F-9E1B-5B6D3A7C9E1A'), -- Harry Potter by J.K. Rowling
    ('B7A5D6C4-3E7B-9F1A-2D8C-5B4E9A3C7D1F', '8A5D6C4E-3A7B-9B1A-5C7D-4E6A3C2D9E1A'), -- The Left Hand of Darkness by Ursula K. Le Guin
    ('B8C7A5D9-1F3E-4D6B-2A9E-5C8D7A3F6B4E', '9E1A7B5D-6C4D-3A2E-9F1B-8C7D5E3A4D2F'), -- The Hitchhiker's Guide by Douglas Adams
    ('B9E4A7C5-6B1D-3A9F-2C8E-5D7A9C3E6B1F', '3E7B5D4A-1D2C-4F9E-8B1A-7A6D3C9B5A4C'), -- Neuromancer by Philip K. Dick
    ('BA5D6C7E-8B1A-3F9E-4C7B-2D9A3E6F1B5D', '2A5D3F9B-4D3F-4E6D-9E1B-6D7C4E2A7C1B'); -- Childhood's End by Arthur C. Clarke
GO


INSERT INTO Customers (CustomerID, CustomerName, EmailAddress) VALUES
    ('C14F8B09-966D-4CD0-B6C8-81EEF2746411', 'Alice Johnson', 'alice.johnson@example.com'),
    ('C24F8B09-966D-4CD0-B6C8-81EEF2746412', 'Bob Smith', 'bob.smith@example.com'),
    ('C34F8B09-966D-4CD0-B6C8-81EEF2746413', 'Charlie Brown', 'charlie.brown@example.com'),
    ('C44F8B09-966D-4CD0-B6C8-81EEF2746414', 'Diana Prince', 'diana.prince@example.com'),
    ('C54F8B09-966D-4CD0-B6C8-81EEF2746415', 'Ethan Hunt', 'ethan.hunt@example.com');
GO

INSERT INTO Reservations (ReservationID, CustomerID, ReservationStatus, ReservationDate) VALUES
    ('35D76FF8-F624-4090-B6D3-3FB64AC51CD4', 'C14F8B09-966D-4CD0-B6C8-81EEF2746411', 1, '2024-11-11 10:00:00'),
    ('30691845-FF01-433A-BA9B-E24F8E9CE792', 'C24F8B09-966D-4CD0-B6C8-81EEF2746412', 0, '2024-12-10 11:30:00'),
    ('A7F9FD7C-821F-4BF8-8909-BCBAAAE23203', 'C34F8B09-966D-4CD0-B6C8-81EEF2746413', 0, '2024-12-15 14:00:00'),
    ('541A5EDD-567E-4B95-970F-08B187611ACD', 'C44F8B09-966D-4CD0-B6C8-81EEF2746414', 0, '2025-01-02 16:15:00'),
    ('DA4D4952-B77D-4632-B8C0-DF540DB52FCD', 'C54F8B09-966D-4CD0-B6C8-81EEF2746415', 0, '2025-01-01 09:45:00');
GO

INSERT INTO ReservationDetails (ReservationDetailID, ReservationID, BookID) VALUES
    ('B0042F9B-242B-4AA7-8B91-24629B8AD2E1', '35D76FF8-F624-4090-B6D3-3FB64AC51CD4', 'B1A2E3F4-5C6D-7B8A-9E1A-4D3C5E2A9F7B'), -- Reservation #1 - Foundation
    ('0240149A-728D-4827-AC72-2E924E39FCFE', '35D76FF8-F624-4090-B6D3-3FB64AC51CD4', 'B2C4E6A7-8F9B-1A2D-5C3E-7B6A5D4C9E3F'), -- Reservation #1 - Dune
    ('A73AD682-D369-4F39-8640-2E021557E17B', '35D76FF8-F624-4090-B6D3-3FB64AC51CD4', 'B3E7C9A1-2D5B-4F6A-7B8C-9E3F1A5D6C7E'), -- Reservation #1 - Ender's Game
    ('24EDAFE8-EBCB-4023-930B-818309BFB2EB', '30691845-FF01-433A-BA9B-E24F8E9CE792', 'B4A3C5E7-9F1B-2D6C-4D3E-7B5A9E1C8D6A'), -- Reservation #2 -The Hobbit
    ('661C4D4E-2B90-431D-B72B-EEA3682C4140', '30691845-FF01-433A-BA9B-E24F8E9CE792', 'B5D6A7C9-1B4E-3F5A-2C7B-8D9E4A6C3E5F'), -- Reservation #2 - A Game of Thrones
    ('4A670C2B-403F-4316-B6F2-949549C64419', '30691845-FF01-433A-BA9B-E24F8E9CE792', 'B7A5D6C4-3E7B-9F1A-2D8C-5B4E9A3C7D1F'), -- Reservation #2 - The Left Hand of Darkness
    ('E8EDC898-8611-493B-A0CA-64989306FA9C', 'A7F9FD7C-821F-4BF8-8909-BCBAAAE23203', 'B8C7A5D9-1F3E-4D6B-2A9E-5C8D7A3F6B4E'), -- Reservation #3 - Hitchhiker's Guide
    ('2BAD1A41-E508-4289-83DB-2431D81ED3C9', 'A7F9FD7C-821F-4BF8-8909-BCBAAAE23203', 'B9E4A7C5-6B1D-3A9F-2C8E-5D7A9C3E6B1F'), -- Reservation #3 - Neuromancer
    ('C0CF3816-278C-4E50-B202-3C9CEBDD5AA0', 'A7F9FD7C-821F-4BF8-8909-BCBAAAE23203', 'BA5D6C7E-8B1A-3F9E-4C7B-2D9A3E6F1B5D'), -- Reservation #3 - Childhood's End
	('04293793-6608-481D-91AF-0B4810755456', '541A5EDD-567E-4B95-970F-08B187611ACD', 'B1A2E3F4-5C6D-7B8A-9E1A-4D3C5E2A9F7B'), -- Reservation #4 - Foundation
    ('E84C6AA6-7078-4EC5-BC02-0A3BAD81AA47', '541A5EDD-567E-4B95-970F-08B187611ACD', 'B2C4E6A7-8F9B-1A2D-5C3E-7B6A5D4C9E3F'), -- Reservation #4 - Dune
    ('37D9AB3A-1DB5-48EB-ABEC-507665EC22AF', '541A5EDD-567E-4B95-970F-08B187611ACD', 'B3E7C9A1-2D5B-4F6A-7B8C-9E3F1A5D6C7E'), -- Reservation #4 - Ender's Game
    ('EF7FD117-3196-4003-8FA6-9A97BB80E65B', 'DA4D4952-B77D-4632-B8C0-DF540DB52FCD', 'B4A3C5E7-9F1B-2D6C-4D3E-7B5A9E1C8D6A'), -- Reservation #5 - The Hobbit
    ('E5F739CE-91F7-436C-A0C0-22DE7547821A', 'DA4D4952-B77D-4632-B8C0-DF540DB52FCD', 'B5D6A7C9-1B4E-3F5A-2C7B-8D9E4A6C3E5F'), -- Reservation #5 - A Game of Thrones
    ('4125A37C-6DB9-4490-B9A9-BC3401790F68', 'DA4D4952-B77D-4632-B8C0-DF540DB52FCD', 'B6C4D7E8-9A1B-5E3F-2D4A-7C5D6E9A3B1F'), -- Reservation #5 - Harry Potter
    ('F97180C7-F82C-4787-9E86-D6731ADE6660', 'DA4D4952-B77D-4632-B8C0-DF540DB52FCD', 'B7A5D6C4-3E7B-9F1A-2D8C-5B4E9A3C7D1F'); -- Reservation #5 - The Left Hand of Darkness
GO

CREATE OR ALTER VIEW GetBooksWithAuthorsView
AS 
	SELECT
	b.BookId, b.ISBN, b.Title, b.Description, b.PagesNumber, b.PublicationDate, b.Quantity, a.AuthorName
	FROM BookAuthors ba
	INNER JOIN Books b ON ba.BookID = b.BookId
	INNER JOIN Authors a ON ba.AuthorID = a.AuthorId;
GO

CREATE OR ALTER VIEW GetReservationView
AS 
	SELECT
	r.ReservationID, r.ReservationStatus, r.ReservationDate, c.CustomerID, c.CustomerName, c.EmailAddress
	FROM Reservations r
	INNER JOIN Customers c ON r.CustomerID = c.CustomerID
GO

CREATE OR ALTER VIEW GetReservationDetailsView
AS 
	SELECT
	rd.ReservationDetailID, rd.ReservationID, rd.BookID, b.ISBN, b.Title
	FROM ReservationDetails rd
	INNER JOIN Books b ON rd.BookID = b.BookId
GO

CREATE OR ALTER VIEW GetAuthorsView
AS 
	SELECT
	AuthorId, AuthorName, BirthDate
	FROM Authors
GO

CREATE OR ALTER VIEW GetCustomersView
AS 
	SELECT
	CustomerID, CustomerName, EmailAddress
	FROM Customers
GO

CREATE OR ALTER VIEW GetCustomersView
AS 
	SELECT
	r.ReservationID, r.ReservationDate, c.CustomerID, c.CustomerName, c.EmailAddress
	FROM Reservations r
	INNER JOIN Customers c ON r.CustomerID = c.CustomerID
GO

CREATE OR ALTER PROCEDURE CreateBook
	@ISBN VARCHAR(13),
    @Title VARCHAR(50),
	@Description VARCHAR(50),
	@AuthorName VARCHAR(100),
	@PagesNumber INT,
	@Quantity INT,
    @PublicationDate DATE
AS
BEGIN

DECLARE @AuthorID UNIQUEIDENTIFIER;
DECLARE @BookID UNIQUEIDENTIFIER;

if not exists (SELECT * FROM Books WHERE ISBN = @ISBN)
	INSERT INTO Books (ISBN, Title, Description, PagesNumber, Quantity, PublicationDate)
	VALUES (@ISBN, @Title, @Description, @PagesNumber, @Quantity, @PublicationDate);

if not exists (SELECT * FROM Authors WHERE AuthorName = AuthorName)
	INSERT INTO Authors (AuthorName) 
	VALUES (@AuthorName);

SELECT @AuthorID = AuthorId FROM Authors WHERE AuthorName = AuthorName;
SELECT @BookID = BookId FROM Books WHERE ISBN = @ISBN;

if not exists (SELECT * FROM BookAuthors WHERE AuthorID = @AuthorID AND BookID = @BookID)
	INSERT INTO BookAuthors (AuthorID, BookID)
	VALUES (@AuthorID, @BookID);
END
GO

CREATE OR ALTER PROCEDURE UpdateBook
	@BookId UNIQUEIDENTIFIER,
	@ISBN VARCHAR(13),
    @Title VARCHAR(50),
	@Description VARCHAR(50),
	@PagesNumber INT,
	@Quantity INT,
    @PublicationDate DATETIME
AS
	UPDATE Books SET
	ISBN = @ISBN, Title = @Title, Description = @Description, PagesNumber = @PagesNumber, Quantity = @Quantity, PublicationDate = @PublicationDate
	WHERE BookId = @BookId
GO

CREATE OR ALTER PROCEDURE DeleteBook
	@BookId UNIQUEIDENTIFIER
AS
	DELETE FROM Books WHERE BookId = @BookId
GO

CREATE OR ALTER PROCEDURE CreateReservation
	@CustomerName VARCHAR(100),
	@ReservationStatus INT,
	@ReservationDate DATETIME
AS
BEGIN

DECLARE @CustomerID UNIQUEIDENTIFIER;
SELECT @CustomerID = CustomerID FROM Customers WHERE CustomerName = @CustomerName;

	INSERT INTO Reservations(CustomerID, ReservationStatus, ReservationDate)
	VALUES (@CustomerID, @ReservationStatus, @ReservationDate);
END
GO

CREATE OR ALTER PROCEDURE UpdateReservation
	@ReservationID UNIQUEIDENTIFIER,
	@ReservationDate DATETIME,
	@ReservationStatus INT
AS
	UPDATE Reservations SET
	ReservationDate = @ReservationDate, ReservationStatus = @ReservationStatus
	WHERE ReservationID = @ReservationID
GO

CREATE OR ALTER PROCEDURE CompleteReservation
	@ReservationID UNIQUEIDENTIFIER,
	@ReservationStatus INT
AS
	UPDATE Reservations SET
	ReservationStatus = @ReservationStatus
	WHERE ReservationID = @ReservationID
GO

CREATE OR ALTER PROCEDURE AddBookToReservation
	@ReservationID UNIQUEIDENTIFIER, 
	@BookID UNIQUEIDENTIFIER
AS
BEGIN
	INSERT INTO ReservationDetails(ReservationID, BookID)
	VALUES (@ReservationID, @BookID);
END
GO

CREATE OR ALTER PROCEDURE RemoveBookFromReservation
	@ReservationDetailID UNIQUEIDENTIFIER
AS
	DELETE FROM ReservationDetails WHERE ReservationDetailID = @ReservationDetailID
GO

CREATE OR ALTER PROCEDURE GetActiveReservations
AS
BEGIN
    SELECT c.CustomerName, c.EmailAddress, r.ReservationID, r.ReservationDate, b.Title AS BookTitle, b.ISBN, r.ReservationStatus
    FROM Reservations r
    JOIN Customers c ON r.CustomerID = c.CustomerID
    JOIN ReservationDetails rd ON r.ReservationID = rd.ReservationID
    JOIN Books b ON RD.BookID = B.BookID
    WHERE r.ReservationStatus = 1
    ORDER BY r.ReservationDate;
END
GO

CREATE OR ALTER PROCEDURE GetAvailableBooks
AS
BEGIN
    SELECT b.Title, b.ISBN, b.Quantity,
		COUNT(rd.BookID) AS ReservedQuantity, (b.Quantity - COUNT(rd.BookID)) AS AvailableQuantity
    FROM Books b
    LEFT JOIN ReservationDetails rd ON b.BookID = rd.BookID
    GROUP BY b.BookID, b.Title, b.ISBN, b.Quantity
    HAVING (b.Quantity - COUNT(rd.BookID)) > 0
    ORDER BY AvailableQuantity DESC;
END
GO
