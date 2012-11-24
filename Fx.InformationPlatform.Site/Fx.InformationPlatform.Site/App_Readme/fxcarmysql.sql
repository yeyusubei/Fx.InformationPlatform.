﻿CREATE TABLE `carbuyinfo` (
  `CarBuyInfoId` int(11) NOT NULL AUTO_INCREMENT,
  `PublishTitle` longtext,
  `CatagroyId` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `AreaId` int(11) NOT NULL,
  `CityId` int(11) NOT NULL,
  `CarYear` int(11) NOT NULL,
  `CarMileage` int(11) NOT NULL,
  `PublishUserEmail` longtext,
  `Mark` longtext,
  `Controller` longtext,
  `Action` longtext,
  `UserAccount` longtext,
  `CreatedTime` datetime NOT NULL,
  `IsDelete` tinyint(1) NOT NULL,
  `IsPublish` tinyint(1) NOT NULL,
  `InfoProcessState` int(11) NOT NULL,
  PRIMARY KEY (`CarBuyInfoId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE `cartransferinfo` (
  `CarTransferInfoId` int(11) NOT NULL AUTO_INCREMENT,
  `PublishTitle` longtext,
  `CatagroyId` int(11) NOT NULL,
  `Price` int(11) NOT NULL,
  `AreaId` int(11) NOT NULL,
  `CityId` int(11) NOT NULL,
  `CarYear` int(11) NOT NULL,
  `CarMileage` int(11) NOT NULL,
  `PublishUserEmail` longtext,
  `Mark` longtext,
  `Controller` longtext,
  `Action` longtext,
  `UserAccount` longtext,
  `CreatedTime` datetime NOT NULL,
  `IsDelete` tinyint(1) NOT NULL,
  `IsPublish` tinyint(1) NOT NULL,
  `InfoProcessState` int(11) NOT NULL,
  PRIMARY KEY (`CarTransferInfoId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


CREATE TABLE `transferpicture` (
  `TransferPictureId` int(11) NOT NULL AUTO_INCREMENT,
  `TransferPictureCatagroy` int(11) NOT NULL,
  `PhysicalPath` longtext,
  `ImageUrl` longtext,
  `IsCdn` tinyint(1) NOT NULL,
  `CdnUrl` longtext,
  `CarTransferInfo_CarTransferInfoId` int(11) DEFAULT NULL,
  PRIMARY KEY (`TransferPictureId`),
  KEY `CarTransferInfo_CarTransferInfoId` (`CarTransferInfo_CarTransferInfoId`),
  CONSTRAINT `CarTransferInfo_Pictures` FOREIGN KEY (`CarTransferInfo_CarTransferInfoId`) REFERENCES `cartransferinfo` (`CarTransferInfoId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
