CREATE DATABASE IF NOT EXISTS dynamicSite;
USE dynamicSite;
CREATE TABLE IF NOT EXISTS platform (
  platformID int(11) NOT NULL AUTO_INCREMENT,
  name varchar(25) NOT NULL,
  company varchar(25) NOT NULL,
  PRIMARY KEY (platformID)
);
INSERT INTO platform (platformID, name, company) VALUES
(NULL, 'Steam', 'Valve Corporation'),
(NULL, 'Origin', 'Electronic Arts'),
(NULL, 'GOG Galaxy', 'CD Projekt'),
(NULL, 'Uplay', 'Ubisoft'),
(NULL, 'Battle.net', 'Blizzard Entertainment');
CREATE TABLE IF NOT EXISTS games (
  gameID int(11) NOT NULL AUTO_INCREMENT,
  name varchar(50) NOT NULL,
  developer varchar(25) NOT NULL,
  publisher varchar(25) NOT NULL,
  cost float NOT NULL,
  platformID int(11) NOT NULL,
  PRIMARY KEY (gameID),
  FOREIGN KEY (platformID) REFERENCES platform(platformID)
);
INSERT INTO games (gameID, name, developer, publisher, cost, platformID) VALUES
(NULL, 'Counter-Strike: Global Offensive', 'Valve Corporation', 'Valve Corporation', 14.99, 1),
(NULL, 'Grand Theft Auto V', 'Rockstar North', 'Rockstar Games', 59.99, 1),
(NULL, 'Titanfall 2', 'Respawn Entertainment', 'Electronic Arts', 39.99, 2),
(NULL, 'Mass Effect', 'BioWare', 'Electronic Arts', 14.99, 2),
(NULL, 'Fallout', 'Interplay Entertainment', 'Interplay Entertainment', 9.99, 3),
(NULL, 'RollerCoaster Tycoon 2: Triple Thrill Pack', 'Chris Sawyer Productions', 'Infogrames', 9.99, 3),
(NULL, 'Anno 2070', 'Blue Byte', 'Ubiosft', 29.99, 4),
(NULL, 'Far Cry 3', 'MASSIVE Entertainment', 'Ubisoft', 19.99, 4),
(NULL, 'Hearthstone', 'Blizzard Entertainment', 'Blizzard Entertainment', 0, 5),
(NULL, 'Starcraft II', 'Blizzard Entertainment', 'Blizzard Entertainment', 39.99, 5);
CREATE TABLE IF NOT EXISTS users (
  userID int(11) NOT NULL AUTO_INCREMENT,
  username varchar(40) NOT NULL,
  password varchar(40) NOT NULL,
  PRIMARY KEY (userID) 
);
INSERT INTO users (userID, username, password) VALUES
(NULL, 'bob', 'Please99!');