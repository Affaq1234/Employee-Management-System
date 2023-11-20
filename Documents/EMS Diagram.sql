CREATE TABLE [Employee] (
  [id] integer PRIMARY KEY,
  [department_id] integer NOT NULL,
  [user_id] integer NOT NULL,
  [salary] integer,
  [attendance] float,
  [rating] integer,
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [Department] (
  [id] integer PRIMARY KEY,
  [name] nvarchar(255),
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [HOD] (
  [id] integer PRIMARY KEY,
  [user_id] integer NOT NULL,
  [department_id] integer,
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [User] (
  [id] integer PRIMARY KEY,
  [password] nvarchar(255) NOT NULL,
  [name] nvarchar(255),
  [DOB] nvarchar(255),
  [CNIC] nvarchar(255),
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [AllowanaceRequests] (
  [id] integer PRIMARY KEY,
  [HOD_id] integer,
  [Request] nvarchar(255),
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [AllowanaceStatus] (
  [Allowanace_id] integer,
  [Status] nvarchar(255),
  [Purpose] nvarchar(255),
  [Spent] integer,
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [Attendance] (
  [attendance_date] integer,
  [id] integer,
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

CREATE TABLE [attendance_details] (
  [Employee_id] integer,
  [attendance_id] integer,
  [Status] nvarchar(255),
  [created_at] datetime,
  [updated_at] datetime,
  [active] bit
)
GO

ALTER TABLE [User] ADD FOREIGN KEY ([id]) REFERENCES [Employee] ([user_id])
GO

ALTER TABLE [Department] ADD FOREIGN KEY ([id]) REFERENCES [Employee] ([department_id])
GO

ALTER TABLE [AllowanaceStatus] ADD FOREIGN KEY ([Allowanace_id]) REFERENCES [AllowanaceRequests] ([id])
GO

ALTER TABLE [attendance_details] ADD FOREIGN KEY ([attendance_id]) REFERENCES [Attendance] ([id])
GO

ALTER TABLE [HOD] ADD FOREIGN KEY ([user_id]) REFERENCES [User] ([id])
GO

ALTER TABLE [HOD] ADD FOREIGN KEY ([department_id]) REFERENCES [Department] ([id])
GO

ALTER TABLE [HOD] ADD FOREIGN KEY ([id]) REFERENCES [AllowanaceRequests] ([HOD_id])
GO

ALTER TABLE [attendance_details] ADD FOREIGN KEY ([Employee_id]) REFERENCES [Employee] ([id])
GO
