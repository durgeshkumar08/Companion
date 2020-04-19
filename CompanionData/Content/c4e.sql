drop database if exists c4e;
create database c4e;
use c4e;

CREATE TABLE `person` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` char(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `name` char(40) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `nickname` varchar(40) NOT NULL,
  `telefon` varchar(45) DEFAULT NULL,
  `additionalInfo` longtext,
  PRIMARY KEY (`id`)
);


CREATE TABLE `buyer` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `personid` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_person_buyer_idx` (`personid`),
  CONSTRAINT `fk_buyer_person` FOREIGN KEY (`personid`) REFERENCES `person` (`id`)
);

CREATE TABLE `seller` (
  `Id` int NOT NULL,
  `personid` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `fk_person_idx` (`personid`),
  CONSTRAINT `fk_seller_person` FOREIGN KEY (`personid`) REFERENCES `person` (`id`)
);

CREATE TABLE `personservice` (
  `id` int NOT NULL AUTO_INCREMENT,
  `additionalinfo` longtext,
  `sellerid` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_personservice_seller_idx` (`sellerid`),
  CONSTRAINT `fk_personservice_seller` FOREIGN KEY (`sellerid`) REFERENCES `seller` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


CREATE TABLE `servicetype` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `additionalinfo` longtext,
  PRIMARY KEY (`id`)
);


CREATE TABLE `personservicetype` (
  `servicetypeid` int NOT NULL,
  `personserviceid` int NOT NULL,
  KEY `fk_personservice_type_idx` (`servicetypeid`),
  KEY `fk_servicetype_person_idx` (`personserviceid`),
  CONSTRAINT `fk_personservice_type` FOREIGN KEY (`servicetypeid`) REFERENCES `servicetype` (`id`),
  CONSTRAINT `fk_servicetype_person` FOREIGN KEY (`personserviceid`) REFERENCES `personservice` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `personservicephotolink` (
  `id` int NOT NULL AUTO_INCREMENT,
  `personserviceid` int DEFAULT NULL,
  `link` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_personservice_photolink_idx` (`personserviceid`),
  CONSTRAINT `fk_personservice_photolink` FOREIGN KEY (`personserviceid`) REFERENCES `personservice` (`id`)
);

CREATE TABLE `order` (
  `id` int NOT NULL AUTO_INCREMENT,
  `orderNo` char(40) DEFAULT NULL,
  `additionalinfo` longtext,
  `orderbegindatetime` datetime DEFAULT NULL,
  `orderenddatetime` datetime DEFAULT NULL,
  `orderbuyerid` int DEFAULT NULL,
  `ordersellerid` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_order_buyer_idx` (`orderbuyerid`),
  KEY `fk_order_seller_idx` (`ordersellerid`),
  CONSTRAINT `fk_order_buyer` FOREIGN KEY (`orderbuyerid`) REFERENCES `buyer` (`Id`),
  CONSTRAINT `fk_order_seller` FOREIGN KEY (`ordersellerid`) REFERENCES `seller` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

CREATE TABLE `orderfoto` (
  `id` int NOT NULL,
  `link` varchar(50) DEFAULT NULL,
  `orderid` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_foto_order_idx` (`orderid`),
  CONSTRAINT `fk_foto_order` FOREIGN KEY (`orderid`) REFERENCES `order` (`id`)
);



CREATE TABLE `ordercontent` (
  `id` int NOT NULL AUTO_INCREMENT,
  `orderid` int NOT NULL,
  `begin` datetime DEFAULT NULL,
  `end` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_order_ordercontent_idx` (`orderid`),
  CONSTRAINT `fk_order_ordercontent` FOREIGN KEY (`orderid`) REFERENCES `order` (`id`)
);

CREATE TABLE `chatcontent` (
  `id` int NOT NULL AUTO_INCREMENT,
  `begin` datetime DEFAULT NULL,
  `end` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
);

CREATE TABLE `orderoffer` (
  `id` int NOT NULL AUTO_INCREMENT,
  `orderCost` float DEFAULT NULL,
  `buyerOrderCost` float DEFAULT NULL,
  `activ` boolean DEFAULT false,
  `order_id` int DEFAULT NULL,
  `seller_id` int DEFAULT NULL,
  `chatcontent_id` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_order_orderoffer_idx` (`order_id`),
  KEY `fk_seller_orderoffer_idx` (`seller_id`),
  KEY `fk_orderoffer_chatcontent_idx` (`chatcontent_id`),
  CONSTRAINT `fk_order_orderoffer` FOREIGN KEY (`order_id`) REFERENCES `order` (`id`),
  CONSTRAINT `fk_orderoffer_chatcontent` FOREIGN KEY (`chatcontent_id`) REFERENCES `chatcontent` (`id`),
  CONSTRAINT `fk_seller_orderoffer` FOREIGN KEY (`seller_id`) REFERENCES `seller` (`Id`)
);
