-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: pizzashop
-- ------------------------------------------------------
-- Server version	5.7.15-log

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
-- Table structure for table `cashier`
--

DROP TABLE IF EXISTS `cashier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cashier` (
  `orderNo` int(11) NOT NULL AUTO_INCREMENT,
  `cashierName` varchar(100) DEFAULT NULL,
  `custName` varchar(100) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `cash` double DEFAULT NULL,
  PRIMARY KEY (`orderNo`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cashier`
--

LOCK TABLES `cashier` WRITE;
/*!40000 ALTER TABLE `cashier` DISABLE KEYS */;
INSERT INTO `cashier` VALUES (4,'zxc','dsa',1123,1500),(5,'Galagita','qwe',4706,5000),(6,'','',685,700),(7,'','',608,800),(8,'','',430,500),(9,'','',1122,1500),(10,'dqwd','qwd',591,600),(11,'dwd1','12d1',285,300),(12,'','',134,200),(13,'','',136,200),(14,'','',461,500),(15,'','',170,200),(16,'','',132,200),(17,'','',95,200),(18,'','',260,1231),(19,'','',470,1231),(20,'','',472,1231),(21,'','',302,1231);
/*!40000 ALTER TABLE `cashier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemlist`
--

DROP TABLE IF EXISTS `itemlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemlist` (
  `itemID` varchar(50) NOT NULL,
  `name` varchar(100) DEFAULT NULL,
  `price` double DEFAULT NULL,
  PRIMARY KEY (`itemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemlist`
--

LOCK TABLES `itemlist` WRITE;
/*!40000 ALTER TABLE `itemlist` DISABLE KEYS */;
INSERT INTO `itemlist` VALUES ('PP1','Ham Delight',117),('PP10','Bacon n\' Cheese',134),('PP11','Supremos',136),('PP12','Cookies n\' Cheese',155),('PP13','Yummy Hotdog',137),('PP14','Vegetarian',170),('PP15','Tuna Garlic',170),('PP2','Hungarian',130),('PP3','Pepperoni',130),('PP4','Beef & Mushroom',130),('PP5','Aloha',132),('PP6','Cheesy Krainer',95),('PP7','Pizza Supreme',100),('PP8','Hawaiian',100),('PP9','Chicken Garlic',115);
/*!40000 ALTER TABLE `itemlist` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kitchen`
--

DROP TABLE IF EXISTS `kitchen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kitchen` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `orderNo` int(11) DEFAULT NULL,
  `isCompleted` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kitchen`
--

LOCK TABLES `kitchen` WRITE;
/*!40000 ALTER TABLE `kitchen` DISABLE KEYS */;
INSERT INTO `kitchen` VALUES (4,4,'yes'),(5,5,'yes'),(6,6,'yes'),(7,7,'yes'),(8,8,'yes'),(9,9,'yes'),(10,10,'yes'),(11,11,'yes'),(12,12,'yes'),(13,13,'yes'),(14,14,'yes'),(15,15,'yes'),(16,16,'yes'),(17,17,'yes'),(18,18,'yes'),(19,19,'yes'),(20,20,'yes'),(21,21,'no');
/*!40000 ALTER TABLE `kitchen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderlist`
--

DROP TABLE IF EXISTS `orderlist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `orderlist` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `itemID` varchar(50) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  `orderNo` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderlist`
--

LOCK TABLES `orderlist` WRITE;
/*!40000 ALTER TABLE `orderlist` DISABLE KEYS */;
INSERT INTO `orderlist` VALUES (9,'PP12',1,4),(10,'PP11',2,4),(11,'PP15',1,4),(12,'PP5',3,4),(13,'PP2',1,4),(14,'PP15',6,5),(15,'PP4',6,5),(16,'PP5',3,5),(17,'PP2',3,5),(18,'PP12',2,5),(19,'PP11',3,5),(20,'PP10',2,5),(21,'PP14',2,5),(22,'PP1',1,5),(23,'PP13',1,5),(24,'PP3',1,5),(25,'PP6',1,5),(26,'PP9',1,5),(27,'PP8',1,5),(28,'PP7',1,5),(29,'PP11',1,6),(30,'PP12',1,6),(31,'PP2',1,6),(32,'PP5',2,6),(33,'PP11',1,7),(34,'PP15',2,7),(35,'PP5',1,7),(36,'PP2',1,8),(37,'PP15',1,8),(38,'PP4',1,8),(39,'PP2',4,9),(40,'PP5',1,9),(41,'PP15',2,9),(42,'PP4',1,9),(43,'PP2',1,10),(44,'PP12',1,10),(45,'PP15',1,10),(46,'PP11',1,10),(47,'PP12',1,11),(48,'PP2',1,11),(49,'PP10',1,12),(50,'PP11',1,13),(51,'PP12',1,14),(52,'PP11',1,14),(53,'PP15',1,14),(54,'PP15',1,15),(55,'PP5',1,16),(56,'PP6',1,17),(57,'PP3',1,18),(58,'PP4',1,18),(59,'PP4',1,19),(60,'PP14',1,19),(61,'PP15',1,19),(62,'PP5',1,20),(63,'PP15',2,20),(64,'PP5',1,21),(65,'PP15',1,21);
/*!40000 ALTER TABLE `orderlist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-09-09 23:43:45
