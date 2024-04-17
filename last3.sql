-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	5.7.38

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `car`
--

DROP TABLE IF EXISTS `car`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `car` (
  `idCar` int(11) NOT NULL AUTO_INCREMENT,
  `brand` varchar(45) NOT NULL,
  `model` varchar(45) NOT NULL,
  PRIMARY KEY (`idCar`),
  UNIQUE KEY `idCar_UNIQUE` (`idCar`)
) ENGINE=InnoDB AUTO_INCREMENT=1116 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `car`
--

LOCK TABLES `car` WRITE;
/*!40000 ALTER TABLE `car` DISABLE KEYS */;
INSERT INTO `car` VALUES (2,'Опель','Астра'),(3,'Lada','2105'),(4,'Daewoo','Matiz'),(5,'Lada','2107'),(6,'Chery','Amulet'),(7,'Daewoo','Nexia'),(8,'Chery','QQ6'),(9,'Renault','Logan'),(10,'Chevrolet','Spark'),(11,'Acura','CDX'),(12,'Acura','CL'),(13,'Acura','EL'),(14,'Acura','ILX'),(15,'Acura','Integra'),(16,'Acura','MDX'),(17,'Acura','NSX'),(18,'Acura','RDX'),(19,'Acura','RL'),(20,'Acura','RLX'),(21,'Acura','RSX'),(22,'Acura','TL'),(23,'Acura','TLX'),(24,'Acura','TLX-L'),(25,'Acura','TSX'),(26,'Acura','ZDX'),(27,'Alfa Romeo','146'),(28,'Alfa Romeo','147'),(29,'Alfa Romeo','147 GTA'),(30,'Alfa Romeo','156'),(31,'Alfa Romeo','156 GTA'),(32,'Alfa Romeo','159'),(33,'Alfa Romeo','166'),(34,'Alfa Romeo','4C'),(35,'Alfa Romeo','8C Competizione'),(36,'Alfa Romeo','Brera'),(37,'Alfa Romeo','Giulia'),(38,'Alfa Romeo','Giulietta'),(39,'Alfa Romeo','GT'),(40,'Alfa Romeo','GTV'),(41,'Alfa Romeo','MiTo'),(42,'Alfa Romeo','Spider'),(43,'Alfa Romeo','Stelvio'),(44,'Alfa Romeo','Tonale'),(45,'Aston Martin','Cygnet'),(46,'Aston Martin','DB11'),(47,'Aston Martin','DB9'),(48,'Aston Martin','DBS'),(49,'Aston Martin','DBS Superleggera'),(50,'Aston Martin','DBS Violante'),(51,'Aston Martin','DBX'),(52,'Aston Martin','Rapide'),(53,'Aston Martin','V12 Vanquish'),(54,'Aston Martin','V12 Vantage'),(55,'Aston Martin','V8 Vantage'),(56,'Aston Martin','Valkyrie'),(57,'Aston Martin','Vanquish'),(58,'Aston Martin','Vantage'),(59,'Aston Martin','Virage'),(60,'Aston Martin','Zagato Coupe'),(61,'Audi','A1'),(62,'Audi','A2'),(63,'Audi','A3'),(64,'Audi','A4'),(65,'Audi','A4 Allroad Quattro'),(66,'Audi','A5'),(67,'Audi','A6'),(68,'Audi','A7'),(69,'Audi','A8'),(70,'Audi','Allroad'),(71,'Audi','e-tron'),(72,'Audi','e-tron GT'),(73,'Audi','e-tron Sportback'),(74,'Audi','Q2'),(75,'Audi','Q3'),(76,'Audi','Q3 Sportback'),(77,'Audi','Q4'),(78,'Audi','Q4 Sportback'),(79,'Audi','Q5'),(80,'Audi','Q5 Sportback'),(81,'Audi','Q7'),(82,'Audi','Q8'),(83,'Audi','R8'),(84,'Audi','RS e-tron GT'),(85,'Audi','RS Q3'),(86,'Audi','RS Q3 Sportback'),(87,'Audi','RS Q7'),(88,'Audi','RS Q8'),(89,'Audi','RS3'),(90,'Audi','RS4'),(91,'Audi','RS5'),(92,'Audi','RS6'),(93,'Audi','RS7'),(94,'Audi','S1'),(95,'Audi','S3'),(96,'Audi','S4'),(97,'Audi','S5'),(98,'Audi','S6'),(99,'Audi','S7'),(100,'Audi','S8'),(101,'Audi','SQ2'),(102,'Audi','SQ5'),(103,'Audi','SQ5 Sportback'),(104,'Audi','SQ7'),(105,'Audi','SQ8'),(106,'Audi','TT'),(107,'Audi','TT RS'),(108,'Audi','TTS'),(109,'Bentley','Arnage'),(110,'Bentley','Azure'),(111,'Bentley','Bentayga'),(112,'Bentley','Brooklands'),(113,'Bentley','Continental'),(114,'Bentley','Continental Flying Spur'),(115,'Bentley','Continental GT'),(116,'Bentley','Flying Spur'),(117,'Bentley','Mulsanne'),(118,'BMW','1 series'),(119,'BMW','2 series'),(120,'BMW','3 series'),(121,'BMW','4 series'),(122,'BMW','5 series'),(123,'BMW','6 series'),(124,'BMW','7 series'),(125,'BMW','8 series'),(126,'BMW','i3'),(127,'BMW','i4'),(128,'BMW','i8'),(129,'BMW','iX'),(130,'BMW','iX3'),(131,'BMW','M2'),(132,'BMW','M3'),(133,'BMW','M4'),(134,'BMW','M5'),(135,'BMW','M6'),(136,'BMW','M8'),(137,'BMW','X1'),(138,'BMW','X2'),(139,'BMW','X3'),(140,'BMW','X3 M'),(141,'BMW','X4'),(142,'BMW','X4 M'),(143,'BMW','X5'),(144,'BMW','X5 M'),(145,'BMW','X6'),(146,'BMW','X6 M'),(147,'BMW','X7'),(148,'BMW','Z3'),(149,'BMW','Z4'),(150,'BMW','Z8'),(151,'Brilliance','H230'),(152,'Brilliance','V3'),(153,'Brilliance','V5'),(154,'Bugatti','Chiron'),(155,'Bugatti','Divo'),(156,'Bugatti','Veyron'),(157,'Buick','Century'),(158,'Buick','Enclave'),(159,'Buick','Encore'),(160,'Buick','Envision'),(161,'Buick','GL8 ES'),(162,'Buick','La Crosse'),(163,'Buick','LaCrosse'),(164,'Buick','Le Sabre'),(165,'Buick','Lucerne'),(166,'Buick','Park Avenue'),(167,'Buick','Rainier'),(168,'Buick','Regal'),(169,'Buick','Rendezvouz'),(170,'Buick','Terraza'),(171,'Buick','Verano'),(172,'BYD','Qin'),(173,'Cadillac','ATS'),(174,'Cadillac','ATS-V'),(175,'Cadillac','BLS'),(176,'Cadillac','CT4'),(177,'Cadillac','CT4-V'),(178,'Cadillac','CT5'),(179,'Cadillac','CT5-V'),(180,'Cadillac','CT6'),(181,'Cadillac','CTS'),(182,'Cadillac','De Ville'),(183,'Cadillac','DTS'),(184,'Cadillac','Eldorado'),(185,'Cadillac','ELR'),(186,'Cadillac','Escalade'),(187,'Cadillac','Seville'),(188,'Cadillac','SRX'),(189,'Cadillac','STS'),(190,'Cadillac','XLR'),(191,'Cadillac','XT4'),(192,'Cadillac','XT5'),(193,'Cadillac','XT6'),(194,'Cadillac','XTS'),(195,'Changan','CS35'),(196,'Changan','CS35 Plus'),(197,'Changan','CS55'),(198,'Changan','CS55 Plus'),(199,'Changan','CS75'),(200,'Changan','CS75 Plus'),(201,'Changan','CS95'),(202,'Changan','Eado'),(203,'Changan','Raeton'),(204,'Changan','Raeton CC'),(205,'Changan','Uni-K'),(206,'Changan','Uni-T'),(207,'Changan','Uni-V'),(208,'Chery','Amulet'),(209,'Chery','Arrizo 5 Plus'),(210,'Chery','Arrizo 6'),(211,'Chery','Arrizo 6 Pro'),(212,'Chery','Arrizo 7'),(213,'Chery','Arrizo 8'),(214,'Chery','Bonus'),(215,'Chery','Bonus 3'),(216,'Chery','CrossEastar'),(217,'Chery','Eastar'),(218,'Chery','eQ'),(219,'Chery','eQ1'),(220,'Chery','eQ5'),(221,'Chery','Fora'),(222,'Chery','IndiS'),(223,'Chery','Kimo'),(224,'Chery','M11'),(225,'Chery','Omoda 5'),(226,'Chery','QQ'),(227,'Chery','QQ3'),(228,'Chery','QQ6'),(229,'Chery','Tiggo'),(230,'Chery','Tiggo 3'),(231,'Chery','Tiggo 4'),(232,'Chery','Tiggo 4 Pro'),(233,'Chery','Tiggo 5'),(234,'Chery','Tiggo 7'),(235,'Chery','Tiggo 7 Pro'),(236,'Chery','Tiggo 8'),(237,'Chery','Tiggo 8 Plus'),(238,'Chery','Tiggo 8 Pro'),(239,'Chery','Tiggo 8 Pro Max'),(240,'Chery','Tiggo e'),(241,'Chery','Very'),(242,'Chevrolet','Astro'),(243,'Chevrolet','Avalanche'),(244,'Chevrolet','Aveo'),(245,'Chevrolet','Beat'),(246,'Chevrolet','Blazer'),(247,'Chevrolet','Bolt'),(248,'Chevrolet','Bolt EUV'),(249,'Chevrolet','Camaro'),(250,'Chevrolet','Captiva'),(251,'Chevrolet','Cavalier'),(252,'Chevrolet','Cobalt'),(253,'Chevrolet','Colorado'),(254,'Chevrolet','Corvette'),(255,'Chevrolet','Cruze'),(256,'Chevrolet','Epica'),(257,'Chevrolet','Equinox'),(258,'Chevrolet','Express'),(259,'Chevrolet','HHR'),(260,'Chevrolet','Impala'),(261,'Chevrolet','Lacetti'),(262,'Chevrolet','Lanos'),(263,'Chevrolet','Malibu'),(264,'Chevrolet','Monte Carlo'),(265,'Chevrolet','Niva'),(266,'Chevrolet','Orlando'),(267,'Chevrolet','Rezzo'),(268,'Chevrolet','Silverado'),(269,'Chevrolet','Silverado 1500'),(270,'Chevrolet','Silverado 2500 HD'),(271,'Chevrolet','Spark'),(272,'Chevrolet','SSR'),(273,'Chevrolet','Suburban'),(274,'Chevrolet','Tahoe'),(275,'Chevrolet','TrailBlazer'),(276,'Chevrolet','Traverse'),(277,'Chevrolet','Trax'),(278,'Chevrolet','Uplander'),(279,'Chevrolet','Venture'),(280,'Chrysler','200'),(281,'Chrysler','300'),(282,'Chrysler','300M'),(283,'Chrysler','Aspen'),(284,'Chrysler','Concorde'),(285,'Chrysler','Crossfire'),(286,'Chrysler','Grand Caravan'),(287,'Chrysler','Grand Voyager'),(288,'Chrysler','Pacifica'),(289,'Chrysler','PT Cruiser'),(290,'Chrysler','Sebring'),(291,'Chrysler','Town & Country'),(292,'Chrysler','Voyager'),(293,'Citroen','Berlingo'),(294,'Citroen','C-Crosser'),(295,'Citroen','C-Elysee'),(296,'Citroen','C1'),(297,'Citroen','C2'),(298,'Citroen','C3'),(299,'Citroen','C3 Aircross'),(300,'Citroen','C3 Picasso'),(301,'Citroen','C3 Pluriel'),(302,'Citroen','C4'),(303,'Citroen','C4 Aircross'),(304,'Citroen','C4 Cactus'),(305,'Citroen','C4 Picasso'),(306,'Citroen','C4 SpaceTourer'),(307,'Citroen','C5'),(308,'Citroen','C5 Aircross'),(309,'Citroen','C6'),(310,'Citroen','C8'),(311,'Citroen','DS 7 Crossback'),(312,'Citroen','DS3'),(313,'Citroen','DS4'),(314,'Citroen','DS5'),(315,'Citroen','Grand C4 Picasso'),(316,'Citroen','Grand C4 SpaceTourer'),(317,'Citroen','Jumper'),(318,'Citroen','Jumpy'),(319,'Citroen','Nemo'),(320,'Citroen','Saxo'),(321,'Citroen','Spacetourer'),(322,'Citroen','Xsara'),(323,'Citroen','Xsara Picasso'),(324,'Dacia','Dokker'),(325,'Dacia','Lodgy'),(326,'Dacia','Solenza'),(327,'Dacia','Spring'),(328,'Dacia','SupeRNova'),(329,'Daewoo','Evanda'),(330,'Daewoo','Kalos'),(331,'Daewoo','Leganza'),(332,'Daewoo','Magnus'),(333,'Daewoo','Matiz'),(334,'Daewoo','Nexia'),(335,'Daewoo','Nubira'),(336,'Daihatsu','Applause'),(337,'Daihatsu','Cast'),(338,'Daihatsu','Copen'),(339,'Daihatsu','Cuore'),(340,'Daihatsu','Gran Move'),(341,'Daihatsu','Luxio'),(342,'Daihatsu','Materia'),(343,'Daihatsu','Mebius'),(344,'Daihatsu','Move'),(345,'Daihatsu','Rocky'),(346,'Daihatsu','Sirion'),(347,'Daihatsu','Terios'),(348,'Daihatsu','Trevis'),(349,'Daihatsu','YRV'),(350,'Datsun','mi-DO'),(351,'Datsun','on-DO'),(352,'Dodge','Avenger'),(353,'Dodge','Caliber'),(354,'Dodge','Caliber SRT4'),(355,'Dodge','Caravan'),(356,'Dodge','Challenger'),(357,'Dodge','Charger'),(358,'Dodge','Dakota'),(359,'Dodge','Dart'),(360,'Dodge','Durango'),(361,'Dodge','Intrepid'),(362,'Dodge','Journey'),(363,'Dodge','Magnum'),(364,'Dodge','Neon'),(365,'Dodge','Nitro'),(366,'Dodge','Ram 1500'),(367,'Dodge','Ram 2500'),(368,'Dodge','Ram 3500'),(369,'Dodge','Ram SRT10'),(370,'Dodge','Stratus'),(371,'Dodge','Viper'),(372,'Dongfeng','580'),(373,'Dongfeng','A30'),(374,'Dongfeng','AX7'),(375,'Dongfeng','H30 Cross'),(376,'Exeed','TXL'),(377,'Exeed','VX'),(378,'FAW','Bestune T77'),(379,'FAW','Besturn B30'),(380,'FAW','Besturn B50'),(381,'FAW','Besturn B70'),(382,'FAW','Besturn X40'),(383,'FAW','Besturn X80'),(384,'FAW','Oley'),(385,'FAW','Vita'),(386,'Ferrari','296'),(387,'Ferrari','348'),(388,'Ferrari','360'),(389,'Ferrari','456'),(390,'Ferrari','458'),(391,'Ferrari','488'),(392,'Ferrari','512'),(393,'Ferrari','550'),(394,'Ferrari','575 M'),(395,'Ferrari','599 GTB Fiorano'),(396,'Ferrari','599 GTO'),(397,'Ferrari','612'),(398,'Ferrari','812'),(399,'Ferrari','California'),(400,'Ferrari','California T'),(401,'Ferrari','Challenge Stradale'),(402,'Ferrari','Enzo'),(403,'Ferrari','F12'),(404,'Ferrari','F355'),(405,'Ferrari','F430'),(406,'Ferrari','F50'),(407,'Ferrari','F512 M'),(408,'Ferrari','F8 Spider'),(409,'Ferrari','F8 Tributo'),(410,'Ferrari','FF'),(411,'Ferrari','GTC4 Lusso'),(412,'Ferrari','LaFerrari'),(413,'Ferrari','Portofino'),(414,'Ferrari','Portofino M'),(415,'Ferrari','Roma'),(416,'Ferrari','SF90 Spider'),(417,'Ferrari','SF90 Stradale'),(418,'Fiat','124 Spider'),(419,'Fiat','500'),(420,'Fiat','500L'),(421,'Fiat','500X'),(422,'Fiat','Albea'),(423,'Fiat','Brava'),(424,'Fiat','Bravo'),(425,'Fiat','Coupe'),(426,'Fiat','Croma'),(427,'Fiat','Doblo'),(428,'Fiat','Ducato'),(429,'Fiat','Freemont'),(430,'Fiat','Grande Punto'),(431,'Fiat','Idea'),(432,'Fiat','Linea'),(433,'Fiat','Marea'),(434,'Fiat','Multipla'),(435,'Fiat','Palio'),(436,'Fiat','Panda'),(437,'Fiat','Panda 4x4'),(438,'Fiat','Punto'),(439,'Fiat','Qubo'),(440,'Fiat','Sedici'),(441,'Fiat','Siena'),(442,'Fiat','Stilo'),(443,'Fiat','Strada'),(444,'Fiat','Tipo'),(445,'Fiat','Ulysse'),(446,'Fisker','Karma'),(447,'Ford','B-Max'),(448,'Ford','Bronco'),(449,'Ford','Bronco Sport'),(450,'Ford','C-Max'),(451,'Ford','Cougar'),(452,'Ford','Crown Victoria'),(453,'Ford','EcoSport'),(454,'Ford','Edge'),(455,'Ford','Endura'),(456,'Ford','Equator'),(457,'Ford','Escape'),(458,'Ford','Excursion'),(459,'Ford','Expedition'),(460,'Ford','Explorer'),(461,'Ford','Explorer Sport Trac'),(462,'Ford','F-150'),(463,'Ford','F-250'),(464,'Ford','F-350'),(465,'Ford','Falcon'),(466,'Ford','Fiesta'),(467,'Ford','Five Hundred'),(468,'Ford','Flex'),(469,'Ford','Focus'),(470,'Ford','Focus Active'),(471,'Ford','Focus Electric'),(472,'Ford','Freestar'),(473,'Ford','Freestyle'),(474,'Ford','Fusion'),(475,'Ford','Galaxy'),(476,'Ford','Ka'),(477,'Ford','Kuga'),(478,'Ford','Maverick'),(479,'Ford','Mondeo'),(480,'Ford','Mustang'),(481,'Ford','Mustang Mach-E'),(482,'Ford','Mustang Shelby GT350'),(483,'Ford','Mustang Shelby GT500'),(484,'Ford','Puma'),(485,'Ford','Ranger'),(486,'Ford','S-Max'),(487,'Ford','Taurus'),(488,'Ford','Taurus X'),(489,'Ford','Thunderbird'),(490,'Ford','Tourneo Connect'),(491,'Ford','Transit'),(492,'Ford','Transit Connect'),(493,'Foton','Sauvana'),(494,'GAC','GS5'),(495,'GAC','Trumpchi GM8'),(496,'GAC','Trumpchi GS8'),(497,'GAZ','3102'),(498,'GAZ','31105'),(499,'GAZ','Gazelle'),(500,'GAZ','Gazelle Business'),(501,'GAZ','Gazelle Next'),(502,'GAZ','Gazelle NN'),(503,'GAZ','Gazelle Sity'),(504,'GAZ','Siber'),(505,'GAZ','Sobol'),(506,'Geely','Atlas'),(507,'Geely','Atlas Pro'),(508,'Geely','Azkarra'),(509,'Geely','Coolray'),(510,'Geely','Emgrand 7'),(511,'Geely','Emgrand EC7'),(512,'Geely','Emgrand GS'),(513,'Geely','Emgrand X7'),(514,'Geely','GC9'),(515,'Geely','GС6'),(516,'Geely','MK'),(517,'Geely','Monjaro'),(518,'Geely','Otaka'),(519,'Geely','Preface'),(520,'Geely','Tugella'),(521,'Geely','Vision'),(522,'Genesis','G70'),(523,'Genesis','G80'),(524,'Genesis','G90'),(525,'Genesis','GV60'),(526,'Genesis','GV70'),(527,'Genesis','GV80'),(528,'GMC','Acadia'),(529,'GMC','Canyon'),(530,'GMC','Envoy'),(531,'GMC','Sierra 1500'),(532,'GMC','Sierra 2500'),(533,'GMC','Sierra 3500'),(534,'GMC','Terrain'),(535,'GMC','Yukon'),(536,'Great Wall','Cowry'),(537,'Great Wall','Deer'),(538,'Great Wall','Hover'),(539,'Great Wall','Hover M2'),(540,'Great Wall','Pegasus'),(541,'Great Wall','Peri'),(542,'Great Wall','Poer'),(543,'Great Wall','Safe'),(544,'Great Wall','Sailor'),(545,'Great Wall','Sing'),(546,'Great Wall','Socool'),(547,'Great Wall','Wingle'),(548,'Great Wall','Wingle 7'),(549,'Haval','Dargo'),(550,'Haval','F7'),(551,'Haval','F7x'),(552,'Haval','H4'),(553,'Haval','H6'),(554,'Haval','H9'),(555,'Haval','Jolion'),(556,'Holden','Commodore'),(557,'Holden','Corvette C8'),(558,'Honda','Accord'),(559,'Honda','Amaze'),(560,'Honda','City'),(561,'Honda','Civic'),(562,'Honda','Civic Type R'),(563,'Honda','CR-V'),(564,'Honda','CR-Z'),(565,'Honda','Crosstour'),(566,'Honda','e'),(567,'Honda','Element'),(568,'Honda','Fit'),(569,'Honda','FR-V'),(570,'Honda','HR-V'),(571,'Honda','Insight'),(572,'Honda','Jade'),(573,'Honda','Jazz'),(574,'Honda','Legend'),(575,'Honda','Odyssey'),(576,'Honda','Passport'),(577,'Honda','Pilot'),(578,'Honda','Prelude'),(579,'Honda','Ridgeline'),(580,'Honda','S2000'),(581,'Honda','Shuttle'),(582,'Honda','Stepwgn'),(583,'Honda','Stream'),(584,'Honda','Vezel'),(585,'Hummer','H1'),(586,'Hummer','H2'),(587,'Hummer','H3'),(588,'Hyundai','Accent'),(589,'Hyundai','Atos Prime'),(590,'Hyundai','Azera'),(591,'Hyundai','Bayon'),(592,'Hyundai','Centennial'),(593,'Hyundai','Creta'),(594,'Hyundai','Creta Grand'),(595,'Hyundai','Elantra'),(596,'Hyundai','Entourage'),(597,'Hyundai','Eon'),(598,'Hyundai','Equus'),(599,'Hyundai','Galloper'),(600,'Hyundai','Genesis'),(601,'Hyundai','Genesis Coupe'),(602,'Hyundai','Getz'),(603,'Hyundai','Grandeur'),(604,'Hyundai','H-1'),(605,'Hyundai','i10'),(606,'Hyundai','i20'),(607,'Hyundai','i20 N'),(608,'Hyundai','i30'),(609,'Hyundai','i30 N'),(610,'Hyundai','i40'),(611,'Hyundai','Ioniq'),(612,'Hyundai','Ioniq 5'),(613,'Hyundai','ix20'),(614,'Hyundai','ix35'),(615,'Hyundai','Kona'),(616,'Hyundai','Kona N'),(617,'Hyundai','Kusto'),(618,'Hyundai','Matrix'),(619,'Hyundai','Mistra'),(620,'Hyundai','Nexo'),(621,'Hyundai','Palisade'),(622,'Hyundai','Porter'),(623,'Hyundai','Santa Cruz'),(624,'Hyundai','Santa Fe'),(625,'Hyundai','Solaris'),(626,'Hyundai','Sonata'),(627,'Hyundai','Staria'),(628,'Hyundai','Terracan'),(629,'Hyundai','Trajet'),(630,'Hyundai','Tucson'),(631,'Hyundai','Veloster'),(632,'Hyundai','Venue'),(633,'Hyundai','Veracruz'),(634,'Hyundai','Verna'),(635,'Hyundai','Xcent'),(636,'Hyundai','XG'),(637,'Infiniti','EX'),(638,'Infiniti','FX'),(639,'Infiniti','G'),(640,'Infiniti','I35'),(641,'Infiniti','JX'),(642,'Infiniti','M'),(643,'Infiniti','Q30'),(644,'Infiniti','Q40'),(645,'Infiniti','Q45'),(646,'Infiniti','Q50'),(647,'Infiniti','Q60'),(648,'Infiniti','Q70'),(649,'Infiniti','QX30'),(650,'Infiniti','QX4'),(651,'Infiniti','QX50'),(652,'Infiniti','QX55'),(653,'Infiniti','QX56'),(654,'Infiniti','QX60'),(655,'Infiniti','QX70'),(656,'Infiniti','QX80'),(657,'Isuzu','Ascender'),(658,'Isuzu','Axiom'),(659,'Isuzu','D-Max'),(660,'Isuzu','D-Max Rodeo'),(661,'Isuzu','I280'),(662,'Isuzu','I290'),(663,'Isuzu','I350'),(664,'Isuzu','I370'),(665,'Isuzu','mu-X'),(666,'Isuzu','Rodeo'),(667,'Isuzu','Trooper'),(668,'Isuzu','VehiCross'),(669,'Iveco','Daily'),(670,'Jac','iEV7S'),(671,'Jac','T6'),(672,'Jaguar','E-Pace'),(673,'Jaguar','F-Pace'),(674,'Jaguar','F-Type'),(675,'Jaguar','I-Pace'),(676,'Jaguar','S-Type'),(677,'Jaguar','X-Type'),(678,'Jaguar','XE'),(679,'Jaguar','XF'),(680,'Jaguar','XJ'),(681,'Jaguar','XK/XKR'),(682,'Jeep','Cherokee'),(683,'Jeep','Commander'),(684,'Jeep','Compass'),(685,'Jeep','Gladiator'),(686,'Jeep','Grand Cherokee'),(687,'Jeep','Grand Wagoneer'),(688,'Jeep','Liberty'),(689,'Jeep','Meridian'),(690,'Jeep','Patriot'),(691,'Jeep','Renegade'),(692,'Jeep','Wagoneer'),(693,'Jeep','Wrangler'),(694,'Kia','Carens'),(695,'Kia','Carnival'),(696,'Kia','Ceed'),(697,'Kia','Cerato'),(698,'Kia','Clarus'),(699,'Kia','EV6'),(700,'Kia','Forte'),(701,'Kia','K5'),(702,'Kia','K8'),(703,'Kia','K900'),(704,'Kia','Magentis'),(705,'Kia','Mohave'),(706,'Kia','Niro'),(707,'Kia','Opirus'),(708,'Kia','Optima'),(709,'Kia','Picanto'),(710,'Kia','ProCeed'),(711,'Kia','Quoris'),(712,'Kia','Ray'),(713,'Kia','Rio'),(714,'Kia','Rio X'),(715,'Kia','Rio X-Line'),(716,'Kia','Seltos'),(717,'Kia','Shuma'),(718,'Kia','Sonet'),(719,'Kia','Sorento'),(720,'Kia','Sorento Prime'),(721,'Kia','Soul'),(722,'Kia','Spectra'),(723,'Kia','Sportage'),(724,'Kia','Stinger'),(725,'Kia','Stonic'),(726,'Kia','Telluride'),(727,'Kia','Venga'),(728,'Lamborghini','Aventador'),(729,'Lamborghini','Centenario'),(730,'Lamborghini','Diablo'),(731,'Lamborghini','Gallardo'),(732,'Lamborghini','Huracan'),(733,'Lamborghini','Murcielago'),(734,'Lamborghini','Reventon'),(735,'Lamborghini','Sian'),(736,'Lamborghini','Urus'),(737,'Lancia','Delta'),(738,'Lancia','Lybra'),(739,'Lancia','Musa'),(740,'Lancia','Phedra'),(741,'Lancia','Thema'),(742,'Lancia','Thesis'),(743,'Lancia','Ypsilon'),(744,'Land Rover','Defender'),(745,'Land Rover','Discovery'),(746,'Land Rover','Discovery Sport'),(747,'Land Rover','Evoque'),(748,'Land Rover','Freelander'),(749,'Land Rover','Range Rover'),(750,'Land Rover','Range Rover Sport'),(751,'Land Rover','Range Rover Velar'),(752,'Lexus','CT'),(753,'Lexus','ES'),(754,'Lexus','GS'),(755,'Lexus','GX'),(756,'Lexus','HS'),(757,'Lexus','IS'),(758,'Lexus','LC'),(759,'Lexus','LFA'),(760,'Lexus','LM'),(761,'Lexus','LS'),(762,'Lexus','LX'),(763,'Lexus','NX'),(764,'Lexus','RC'),(765,'Lexus','RC F'),(766,'Lexus','RX'),(767,'Lexus','SC'),(768,'Lexus','UX'),(769,'Lifan','Breez'),(770,'Lifan','Cebrium'),(771,'Lifan','Celliya'),(772,'Lifan','Murman'),(773,'Lifan','Myway'),(774,'Lifan','Smily'),(775,'Lifan','Solano'),(776,'Lifan','X50'),(777,'Lifan','X60'),(778,'Lifan','X70'),(779,'Lifan','X80'),(780,'Lincoln','Aviator'),(781,'Lincoln','Corsair'),(782,'Lincoln','Mark LT'),(783,'Lincoln','MKC'),(784,'Lincoln','MKS'),(785,'Lincoln','MKT'),(786,'Lincoln','MKX'),(787,'Lincoln','MKZ'),(788,'Lincoln','Nautilus'),(789,'Lincoln','Navigator'),(790,'Lincoln','Town Car'),(791,'Lincoln','Zephyr'),(792,'Lotus','Elise'),(793,'Lotus','Europa S'),(794,'Lotus','Evora'),(795,'Lotus','Exige'),(796,'Marussia','B1'),(797,'Marussia','B2'),(798,'Maserati','3200 GT'),(799,'Maserati','Ghibli'),(800,'Maserati','Gran Cabrio'),(801,'Maserati','Gran Turismo '),(802,'Maserati','Gran Turismo S'),(803,'Maserati','Grecale'),(804,'Maserati','Levante'),(805,'Maserati','MC20'),(806,'Maserati','Quattroporte'),(807,'Maserati','Quattroporte S'),(808,'Maybach','57'),(809,'Maybach','57 S'),(810,'Maybach','62'),(811,'Maybach','62 S'),(812,'Maybach','Landaulet'),(813,'Mazda','2'),(814,'Mazda','3'),(815,'Mazda','323'),(816,'Mazda','5'),(817,'Mazda','6'),(818,'Mazda','626'),(819,'Mazda','B-Series'),(820,'Mazda','BT-50'),(821,'Mazda','CX-3'),(822,'Mazda','CX-30'),(823,'Mazda','CX-30 EV'),(824,'Mazda','CX-4'),(825,'Mazda','CX-5'),(826,'Mazda','CX-60'),(827,'Mazda','CX-7'),(828,'Mazda','CX-8'),(829,'Mazda','CX-9'),(830,'Mazda','MPV'),(831,'Mazda','MX-30'),(832,'Mazda','MX-5'),(833,'Mazda','Premacy'),(834,'Mazda','RX-7'),(835,'Mazda','RX-8'),(836,'Mazda','Tribute'),(837,'McLaren','540C'),(838,'McLaren','570S'),(839,'McLaren','600LT'),(840,'McLaren','650S'),(841,'McLaren','675LT'),(842,'McLaren','720S'),(843,'McLaren','720S Spider'),(844,'McLaren','765LT'),(845,'McLaren','Artura'),(846,'McLaren','MP4-12C'),(847,'McLaren','P1'),(848,'Mercedes','A-class'),(849,'Mercedes','AMG GT'),(850,'Mercedes','AMG GT 4-Door'),(851,'Mercedes','B-class'),(852,'Mercedes','C-class'),(853,'Mercedes','C-class Sport Coupe'),(854,'Mercedes','Citan'),(855,'Mercedes','CL-class'),(856,'Mercedes','CLA-class'),(857,'Mercedes','CLC-class '),(858,'Mercedes','CLK-class'),(859,'Mercedes','CLS-class'),(860,'Mercedes','E-class'),(861,'Mercedes','E-class Coupe'),(862,'Mercedes','EQA'),(863,'Mercedes','EQB'),(864,'Mercedes','EQC'),(865,'Mercedes','EQE'),(866,'Mercedes','EQE AMG'),(867,'Mercedes','EQS'),(868,'Mercedes','EQS AMG'),(869,'Mercedes','EQV'),(870,'Mercedes','G-class'),(871,'Mercedes','GL-class'),(872,'Mercedes','GLA-class'),(873,'Mercedes','GLA-class AMG'),(874,'Mercedes','GLB-class'),(875,'Mercedes','GLC-class'),(876,'Mercedes','GLC-class AMG'),(877,'Mercedes','GLC-class Coupe'),(878,'Mercedes','GLE-class'),(879,'Mercedes','GLE-class AMG'),(880,'Mercedes','GLE-class Coupe'),(881,'Mercedes','GLK-class'),(882,'Mercedes','GLS-class'),(883,'Mercedes','GLS-class AMG'),(884,'Mercedes','M-class'),(885,'Mercedes','R-class'),(886,'Mercedes','S-class'),(887,'Mercedes','S-class Cabrio'),(888,'Mercedes','S-class Coupe'),(889,'Mercedes','SL-class'),(890,'Mercedes','SL-Class AMG'),(891,'Mercedes','SLC-class'),(892,'Mercedes','SLK-class'),(893,'Mercedes','SLR-class'),(894,'Mercedes','SLS AMG'),(895,'Mercedes','Sprinter'),(896,'Mercedes','Vaneo'),(897,'Mercedes','Viano'),(898,'Mercedes','Vito'),(899,'Mercedes','X-class'),(900,'Mercury','Grand Marquis'),(901,'Mercury','Mariner'),(902,'Mercury','Milan'),(903,'Mercury','Montego'),(904,'Mercury','Monterey'),(905,'Mercury','Mountaineer'),(906,'Mercury','Sable'),(907,'MG','Hector'),(908,'MG','TF'),(909,'MG','XPower SV'),(910,'MG','ZR'),(911,'MG','ZS'),(912,'MG','ZS EV'),(913,'MG','ZT'),(914,'MG','ZT-T'),(915,'Mini','Clubman'),(916,'Mini','Clubman S'),(917,'Mini','Clubvan'),(918,'Mini','Cooper'),(919,'Mini','Cooper Cabrio'),(920,'Mini','Cooper S'),(921,'Mini','Cooper S Cabrio'),(922,'Mini','Cooper S Countryman All4'),(923,'Mini','Countryman'),(924,'Mini','One'),(925,'Mitsubishi','3000 GT'),(926,'Mitsubishi','ASX'),(927,'Mitsubishi','Carisma'),(928,'Mitsubishi','Colt'),(929,'Mitsubishi','Dignity'),(930,'Mitsubishi','Eclipse'),(931,'Mitsubishi','Eclipse Cross'),(932,'Mitsubishi','Endeavor'),(933,'Mitsubishi','Galant'),(934,'Mitsubishi','Grandis'),(935,'Mitsubishi','i-MiEV'),(936,'Mitsubishi','L200'),(937,'Mitsubishi','Lancer'),(938,'Mitsubishi','Lancer Evo'),(939,'Mitsubishi','Mirage'),(940,'Mitsubishi','Outlander'),(941,'Mitsubishi','Outlander Sport'),(942,'Mitsubishi','Outlander XL'),(943,'Mitsubishi','Pajero'),(944,'Mitsubishi','Pajero Pinin'),(945,'Mitsubishi','Pajero Sport'),(946,'Mitsubishi','Raider'),(947,'Mitsubishi','Space Gear'),(948,'Mitsubishi','Space Runner'),(949,'Mitsubishi','Space Star'),(950,'Mitsubishi','Xpander'),(951,'Nissan','350Z'),(952,'Nissan','370Z'),(953,'Nissan','Almera'),(954,'Nissan','Almera Classic'),(955,'Nissan','Almera Tino'),(956,'Nissan','Altima'),(957,'Nissan','Ariya'),(958,'Nissan','Armada'),(959,'Nissan','Bluebird Sylphy'),(960,'Nissan','Frontier'),(961,'Nissan','GT-R'),(962,'Nissan','Juke'),(963,'Nissan','Leaf'),(964,'Nissan','Maxima'),(965,'Nissan','Micra'),(966,'Nissan','Murano'),(967,'Nissan','Navara'),(968,'Nissan','Note'),(969,'Nissan','NP300'),(970,'Nissan','Pathfinder'),(971,'Nissan','Patrol'),(972,'Nissan','Primera'),(973,'Nissan','Qashqai'),(974,'Nissan','Qashqai+2'),(975,'Nissan','Quest'),(976,'Nissan','Rogue'),(977,'Nissan','Sentra'),(978,'Nissan','Skyline'),(979,'Nissan','Sylphy'),(980,'Nissan','Teana'),(981,'Nissan','Terrano'),(982,'Nissan','Tiida'),(983,'Nissan','Titan'),(984,'Nissan','Titan XD'),(985,'Nissan','X-Trail'),(986,'Nissan','XTerra'),(987,'Nissan','Z'),(988,'Opel','Adam'),(989,'Opel','Agila'),(990,'Opel','Ampera-e'),(991,'Opel','Antara'),(992,'Opel','Astra'),(993,'Opel','Astra GTC'),(994,'Opel','Astra OPC'),(995,'Opel','Cascada'),(996,'Opel','Combo'),(997,'Opel','Corsa'),(998,'Opel','Corsa OPC'),(999,'Opel','Crossland'),(1000,'Opel','Crossland X'),(1001,'Opel','Frontera'),(1002,'Opel','Grandland'),(1003,'Opel','Grandland X'),(1004,'Opel','Insignia'),(1005,'Opel','Insignia OPC'),(1006,'Opel','Karl'),(1007,'Opel','Meriva'),(1008,'Opel','Mokka'),(1009,'Opel','Omega'),(1010,'Opel','Signum'),(1011,'Opel','Speedster'),(1012,'Opel','Tigra'),(1013,'Opel','Vectra'),(1014,'Opel','Vivaro'),(1015,'Opel','Zafira'),(1016,'Opel','Zafira Life'),(1017,'Opel','Zafira Tourer'),(1018,'Peugeot','1007'),(1019,'Peugeot','107'),(1020,'Peugeot','108'),(1021,'Peugeot','2008'),(1022,'Peugeot','206'),(1023,'Peugeot','207'),(1024,'Peugeot','208'),(1025,'Peugeot','3008'),(1026,'Peugeot','301'),(1027,'Peugeot','307'),(1028,'Peugeot','308'),(1029,'Peugeot','4007'),(1030,'Peugeot','4008'),(1031,'Peugeot','406'),(1032,'Peugeot','407'),(1033,'Peugeot','408'),(1034,'Peugeot','5008'),(1035,'Peugeot','508'),(1036,'Peugeot','607'),(1037,'Peugeot','807'),(1038,'Peugeot','Boxer'),(1039,'Peugeot','Expert'),(1040,'Peugeot','Landtrek'),(1041,'Peugeot','Manager'),(1042,'Peugeot','Partner'),(1043,'Peugeot','RCZ Sport'),(1044,'Peugeot','Rifter'),(1045,'Peugeot','Traveller'),(1046,'Plymouth','Road Runner'),(1047,'Pontiac','Aztec'),(1048,'Pontiac','Bonneville'),(1049,'Pontiac','Firebird'),(1050,'Pontiac','G5 Pursuit'),(1051,'Pontiac','G6'),(1052,'Pontiac','G8'),(1053,'Pontiac','Grand AM'),(1054,'Pontiac','Grand Prix'),(1055,'Pontiac','GTO'),(1056,'Pontiac','Montana'),(1057,'Pontiac','Solstice'),(1058,'Pontiac','Sunfire'),(1059,'Pontiac','Torrent'),(1060,'Pontiac','Vibe'),(1061,'Porsche','718 Boxster'),(1062,'Porsche','718 Cayman'),(1063,'Porsche','911'),(1064,'Porsche','Boxster'),(1065,'Porsche','Cayenne'),(1066,'Porsche','Cayman'),(1067,'Porsche','Macan'),(1068,'Porsche','Panamera'),(1069,'Porsche','Taycan'),(1070,'Ravon','Gentra'),(1071,'Renault','Alaskan'),(1072,'Renault','Arkana'),(1073,'Renault','Avantime'),(1074,'Renault','Captur'),(1075,'Renault','Clio'),(1076,'Renault','Duster'),(1077,'Renault','Duster Oroch'),(1078,'Renault','Espace'),(1079,'Renault','Fluence'),(1080,'Renault','Grand Scenic'),(1081,'Renault','Kadjar'),(1082,'Renault','Kangoo'),(1083,'Renault','Kaptur'),(1084,'Renault','Kiger'),(1085,'Renault','Koleos'),(1086,'Renault','Laguna'),(1087,'Renault','Latitude'),(1088,'Renault','Logan'),(1089,'Renault','Logan Stepway'),(1090,'Renault','Master'),(1091,'Renault','Megane'),(1092,'Renault','Modus'),(1093,'Renault','Sandero'),(1094,'Renault','Sandero Stepway'),(1095,'Renault','Scenic'),(1096,'Renault','Symbol'),(1097,'Renault','Taliant'),(1098,'Renault','Talisman'),(1099,'Renault','Trafic'),(1100,'Renault','Triber'),(1101,'Renault','Twingo'),(1102,'Renault','Twizy'),(1103,'Renault','Vel Satis'),(1104,'Renault','Wind'),(1105,'Renault','Zoe'),(1106,'Rolls-Royce','Cullinan'),(1107,'Rolls-Royce','Dawn'),(1108,'Rolls-Royce','Ghost'),(1109,'Rolls-Royce','Phantom'),(1110,'Rolls-Royce','Wraith'),(1111,'Rover','25'),(1112,'Rover','400'),(1113,'Rover','45'),(1114,'Rover','600'),(1115,'Rover','75');
/*!40000 ALTER TABLE `car` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `client` (
  `idClient` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `patronymic` varchar(45) NOT NULL,
  `drivingexp` int(11) NOT NULL,
  `acidentnumb` int(11) NOT NULL,
  `passport` varchar(12) NOT NULL,
  `driverlicense` varchar(45) NOT NULL,
  `Dateofbirth` varchar(45) NOT NULL,
  PRIMARY KEY (`idClient`,`driverlicense`),
  UNIQUE KEY `idClient_UNIQUE` (`idClient`),
  UNIQUE KEY `passport_UNIQUE` (`passport`),
  UNIQUE KEY `driverlicense_UNIQUE` (`driverlicense`)
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Максим','Максименко','Максимов',5,1,'6574892345','69ОК647384','12.12.2000'),(2,'Антон','Антонов','Антонович',3,0,'7643783465','45ОК657384','12.12.1998'),(3,'Николай','Николаев','Николаевич',12,0,'3429583845','21ОК345723','05.02.1984'),(4,'Петр','Петров','Петрович',3,0,'2387563256','12ОК241247','17.04.1995'),(5,'Арнольд','Андреев','Дамирович',22,1,'9672840167','7701397000','22.08.1970'),(6,'Филипп','Моисеев','Гордеевич',29,2,'9660302137','74АА397530','12.06.1968'),(7,'Владлен','Голубев','Богуславович',53,1,'8759210265','36РА784534','26.06.2000'),(8,'Карл','Афанасьев','Владимирович',57,2,'8934568848','32АА782323','29.03.1997'),(9,'Казимир','Богданов','Богданович',43,0,'9523239194','12АА654325','01.10.1999'),(10,'Владимир','Шестаков','Агафонович',58,0,'9632654561','32АА643235','15.09.1981'),(11,'Леонтий','Егоров','Александрович',27,0,'9247458740','32АА823675','15.09.1987'),(12,'Арсений','Дмитриев','Аркадьевич',35,0,'8810914644','32АА124654','18.05.1983'),(13,'Сергей','Шестаков','Николаевич',37,0,'8685765837','32АА754345','14.12.1966'),(14,'Венедикт','Беляков','Георгиевич',11,0,'8894132508','32АА124421','01.01.1976'),(15,'Альфред','Константинов','Агафонович',50,0,'8640959638','32АА643634','23.07.2001'),(16,'Вениамин','Брагин','Егорович',29,1,'9030457678','32АА634623','09.12.1986'),(17,'Гордей','Зайцев','Олегович',4,2,'9804946214','32АА634612','31.05.1968'),(18,'Герман','Борисов','Анатольевич',15,1,'8812808376','32АА543534','31.03.1979'),(19,'Аскольд','Ширяев','Геннадиевич',18,5,'8113881525','32АА232232','25.03.1998'),(20,'Винетта','Соболева','Егоровна',58,0,'8561729056','32АА234324','01.11.1993'),(21,'Роксана','Устинова','Христофоровна',15,0,'8549191026','32АА543234','26.08.1979'),(22,'Моника','Васильева','Якуновна',41,0,'7648099154','32АА654345','24.05.1994'),(23,'Августа','Михеева','Никитевна',41,0,'7823457737','32АА646456','26.10.1981'),(24,'Нания','Пономарёва','Якововна',55,0,'8412128083','32АА235235','28.04.1977'),(25,'Тереза','Комиссарова','Давидовна',23,0,'8521543450','32АА532523','25.12.1997'),(26,'Любава','Андреева','Валентиновна',18,1,'8136347629','32АА423423','05.02.1974'),(27,'Ксения','Ефремова','Михайловна',14,2,'7699803533','32АА123321','05.11.1964'),(28,'Наталия','Моисеева','Романовна',53,3,'7574654726','32АА543537','11.08.2001'),(29,'Женевьева','Капустина','Вадимовна',1,1,'7783021397','32АА453534','14.01.1980'),(30,'Данута','Панфилова','Гордеевна',24,2,'7529848527','32АА097435','03.02.1982'),(31,'Эдилия','Устинова','Эдуардовна',51,1,'7919346567','32АА765434','24.05.1962'),(32,'Гера','Копылова','Максимовна',1,2,'8693835103','32АА645363','16.11.1980'),(33,'Анастасия','Кабанова','Прокловна',39,0,'7701697265','32АА356356','17.06.1988'),(34,'Дария','Кабанова','Эльдаровна',35,1,'7002770414','32АА123543','01.07.1962');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders` (
  `Car_idCar` int(11) NOT NULL,
  `vin` varchar(17) NOT NULL,
  `car_year_realase` varchar(45) NOT NULL,
  `trailer` varchar(45) NOT NULL,
  `usedfor` varchar(45) NOT NULL,
  `cost` varchar(45) NOT NULL,
  `premium` varchar(45) NOT NULL,
  `deteout` varchar(45) NOT NULL,
  PRIMARY KEY (`Car_idCar`),
  CONSTRAINT `fk_Orders_Car` FOREIGN KEY (`Car_idCar`) REFERENCES `car` (`idCar`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders_has_client`
--

DROP TABLE IF EXISTS `orders_has_client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orders_has_client` (
  `Orders_Car_idCar` int(11) NOT NULL,
  `Client_idClient` int(11) NOT NULL,
  PRIMARY KEY (`Orders_Car_idCar`,`Client_idClient`),
  KEY `fk_Orders_has_Client_Client1_idx` (`Client_idClient`),
  KEY `fk_Orders_has_Client_Orders1_idx` (`Orders_Car_idCar`),
  CONSTRAINT `fk_Orders_has_Client_Client1` FOREIGN KEY (`Client_idClient`) REFERENCES `client` (`idClient`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Orders_has_Client_Orders1` FOREIGN KEY (`Orders_Car_idCar`) REFERENCES `orders` (`Car_idCar`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders_has_client`
--

LOCK TABLES `orders_has_client` WRITE;
/*!40000 ALTER TABLE `orders_has_client` DISABLE KEYS */;
/*!40000 ALTER TABLE `orders_has_client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `idUsers` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `privileges` enum('user','admin') NOT NULL,
  `name` varchar(45) NOT NULL,
  `surname` varchar(45) NOT NULL,
  `patronymic` varchar(45) NOT NULL,
  PRIMARY KEY (`idUsers`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Admin','E3AFED0047B08059D0FADA10F400C1E5','admin','Даниил','Юрик','Владимирович'),(2,'user','EE11CBB19052E40B07AAC0CA060C23EE','user','Иван','Иванов','Иванович');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'mydb'
--

--
-- Dumping routines for database 'mydb'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-04-04 11:36:55
