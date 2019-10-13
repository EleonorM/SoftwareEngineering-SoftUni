ALTER TABLE Users
DROP CONSTRAINT PK_Users;

ALTER TABLE Users
ADD CONSTRAINT PK_Users_Id 
PRIMARY KEY (Id);

ALTER TABLE Users
ADD CONSTRAINT cons_UsernameAtLeast3
CHECK (LEN(Username) > 3),
CONSTRAINT UC_UniqeUsername 
UNIQUE (Username);