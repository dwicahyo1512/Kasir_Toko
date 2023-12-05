-- MariaDB dump 10.19  Distrib 10.4.28-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: kasir_toko
-- ------------------------------------------------------
-- Server version	10.4.28-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `barang`
--

DROP TABLE IF EXISTS `barang`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `barang` (
  `barang_id` int(11) NOT NULL AUTO_INCREMENT,
  `barang_nama` varchar(100) DEFAULT NULL,
  `stok_barang` varchar(100) DEFAULT NULL,
  `harga_barang` varchar(100) DEFAULT NULL,
  `barang_ket` varchar(100) DEFAULT NULL,
  `satuan_nama` varchar(100) DEFAULT NULL,
  `kategori_nama` varchar(100) DEFAULT NULL,
  `CreateAt` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`barang_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kasir`
--

DROP TABLE IF EXISTS `kasir`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kasir` (
  `kasir_id` int(50) NOT NULL AUTO_INCREMENT,
  `kasir_nama` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `telepon` int(20) DEFAULT NULL,
  `tgl_lahir` date DEFAULT NULL,
  `LastLogin` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`kasir_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `kategori`
--

DROP TABLE IF EXISTS `kategori`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kategori` (
  `kategori_id` int(50) NOT NULL AUTO_INCREMENT,
  `kategori_nama` varchar(100) DEFAULT NULL,
  `kategori_ket` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`kategori_id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `satuan`
--

DROP TABLE IF EXISTS `satuan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `satuan` (
  `satuan_id` int(50) NOT NULL AUTO_INCREMENT,
  `satuan_nama` varchar(100) DEFAULT NULL,
  `satuan_ket` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`satuan_id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `total_transaksi`
--

DROP TABLE IF EXISTS `total_transaksi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `total_transaksi` (
  `total_transaksi_id` int(50) NOT NULL AUTO_INCREMENT,
  `date_transaksi` timestamp NOT NULL DEFAULT current_timestamp(),
  `total_harga` int(100) DEFAULT NULL,
  `total_barang` int(100) DEFAULT NULL,
  PRIMARY KEY (`total_transaksi_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `transaksi`
--

DROP TABLE IF EXISTS `transaksi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transaksi` (
  `transaksi_id` int(50) NOT NULL AUTO_INCREMENT,
  `barang_id` int(11) DEFAULT NULL,
  `total_transaksi_id` int(50) DEFAULT NULL,
  `barang_nama` varchar(100) DEFAULT NULL,
  `barang_total` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`transaksi_id`),
  KEY `transaksi_FK` (`barang_id`),
  KEY `transaksi_FK_1` (`total_transaksi_id`),
  CONSTRAINT `transaksi_FK` FOREIGN KEY (`barang_id`) REFERENCES `barang` (`barang_id`),
  CONSTRAINT `transaksi_FK_1` FOREIGN KEY (`total_transaksi_id`) REFERENCES `total_transaksi` (`total_transaksi_id`)
) ENGINE=InnoDB AUTO_INCREMENT=31 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping routines for database 'kasir_toko'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-12-04 21:37:37
