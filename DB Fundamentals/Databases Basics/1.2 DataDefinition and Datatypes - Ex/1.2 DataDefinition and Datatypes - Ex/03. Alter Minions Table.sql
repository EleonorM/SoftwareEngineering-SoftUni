ALTER TABLE Minions
ADD TownId INT NOT NULL
CONSTRAINT fk_Minions_TownId
FOREIGN KEY(TownId)
REFERENCES Towns(Id)