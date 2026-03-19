CREATE DATABASE TicketSystem;
USE TicketSystem;
CREATE TABLE Users (
    UserId INT IDENTITY(1,1) PRIMARY KEY,
    Username VARCHAR(50) NOT NULL,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL, -- User / Admin
    CreatedDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE Tickets (
    TicketId INT IDENTITY(1,1) PRIMARY KEY,
    TicketNumber VARCHAR(20),
    Subject VARCHAR(200),
    Description VARCHAR(MAX),
    Priority VARCHAR(10),
    Status VARCHAR(20),
    CreatedBy INT,
    AssignedTo INT NULL,
    CreatedDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_Tickets_CreatedBy FOREIGN KEY (CreatedBy) REFERENCES Users(UserId),
    CONSTRAINT FK_Tickets_AssignedTo FOREIGN KEY (AssignedTo) REFERENCES Users(UserId)
);
CREATE TABLE TicketComments (
    CommentId INT IDENTITY(1,1) PRIMARY KEY,
    TicketId INT,
    CommentText VARCHAR(MAX),
    CommentBy INT,
    CommentDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_TicketComments_Ticket 
        FOREIGN KEY (TicketId) REFERENCES Tickets(TicketId),

    CONSTRAINT FK_TicketComments_User 
        FOREIGN KEY (CommentBy) REFERENCES Users(UserId)
);

CREATE TABLE TicketStatusHistory (
    HistoryId INT IDENTITY(1,1) PRIMARY KEY,
    TicketId INT NOT NULL,
    OldStatus VARCHAR(20),
    NewStatus VARCHAR(20),
    UpdatedBy INT NOT NULL,
    UpdatedDate DATETIME DEFAULT GETDATE(),

    CONSTRAINT FK_TicketStatusHistory_Ticket 
        FOREIGN KEY (TicketId) REFERENCES Tickets(TicketId),

    CONSTRAINT FK_TicketStatusHistory_User 
        FOREIGN KEY (UpdatedBy) REFERENCES Users(UserId)
);