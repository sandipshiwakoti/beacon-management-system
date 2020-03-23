-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 06, 2019 at 05:42 PM
-- Server version: 5.7.24
-- PHP Version: 7.2.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `beacon_management_tool`
--

-- --------------------------------------------------------

--
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
CREATE TABLE IF NOT EXISTS `admins` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `email` varchar(255) NOT NULL,
  `mob_no` varchar(10) NOT NULL,
  `password` varchar(20) NOT NULL,
  `dob` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admins`
--

INSERT INTO `admins` (`id`, `name`, `email`, `mob_no`, `password`, `dob`) VALUES
(1, 'Sandip', 'Sandip.shiwakoti.3@gmail.com', '9860082391', 'sandip123', '1999-10-12'),
(2, 'Anuj', 'AnujMahat69@gmail.com', '9860514123', 'anuj', '2000-10-11'),
(3, 'Sajjan', 'Sajjan_Raj_Vaidya@gmail.com', '9841121552', 'hEhEhasdEli', '1990-03-21'),
(4, 'Labrinth', 'Labrinth1000@gmail.com', '9841657523', 'rInkIyAkpApA', '1996-06-25'),
(5, 'Sushant', 'Sushant.Kc61012@gmail.com', '9860258545', 'gSjdHjjH', '2001-05-06'),
(6, 'Ronaldo', 'ronaldo7@gmail.com', '9860082359', 'cr7djjdsdksjks', '1999-09-12'),
(7, 'Safal', 'safalhero@yahoo.com', '9865122325', 'safal', '2000-03-03');

-- --------------------------------------------------------

--
-- Table structure for table `ads`
--

DROP TABLE IF EXISTS `ads`;
CREATE TABLE IF NOT EXISTS `ads` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `start_date` datetime NOT NULL,
  `end_date` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `ads`
--

INSERT INTO `ads` (`id`, `title`, `description`, `start_date`, `end_date`) VALUES
(1, 'Men Faded Denim Jacket', 'Discount Price:Rs.5000', '2019-02-23 14:15:31', '2019-02-24 14:15:31'),
(2, 'Chicken Medium Pan Pizza', 'Discount Price:Rs.800', '2019-02-24 04:15:59', '2019-02-25 05:15:59'),
(3, 'NaviForce NF9061M Watch', 'Discount Price:Rs.2500', '2019-02-23 11:15:41', '2019-02-26 12:15:41'),
(4, 'Potato Red', 'Discoun Price:Rs.40/kg', '2019-02-22 13:15:31', '2019-02-24 13:15:31'),
(5, 'Men Taper Fade Hair Cut', 'Discount Price:Rs.200', '2019-02-24 10:10:21', '2019-02-28 10:10:21'),
(6, 'Duckside Shoe', 'Discount Price:Rs.2000', '2019-03-19 10:10:12', '2019-03-21 10:10:12'),
(7, 'Dell Gaming Laptop', 'Discount Price:Rs.150000', '2019-03-20 12:05:06', '2019-03-25 12:05:06');

-- --------------------------------------------------------

--
-- Table structure for table `areas`
--

DROP TABLE IF EXISTS `areas`;
CREATE TABLE IF NOT EXISTS `areas` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `description` text NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `areas`
--

INSERT INTO `areas` (`id`, `name`, `description`) VALUES
(1, 'Kirtipur', 'Nayabazar Area'),
(2, 'Bhaktapur', 'Lokanthali Area'),
(3, 'Pokhara', 'Lake Side Area'),
(4, 'Thamel', 'Thamel Chowk'),
(5, 'Kalanki', 'Kalanki Chowk'),
(6, 'Pepsicola', 'Town Planning Area'),
(7, 'Bouddha', 'Bouddha Chowk'),
(8, 'Tinkune', 'Gairigaun Area');

-- --------------------------------------------------------

--
-- Table structure for table `beacons`
--

DROP TABLE IF EXISTS `beacons`;
CREATE TABLE IF NOT EXISTS `beacons` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `uuid` varchar(36) NOT NULL,
  `mfd_date` datetime NOT NULL,
  `mfd_company` varchar(100) NOT NULL,
  `description` text NOT NULL,
  `proximity` varchar(200) NOT NULL,
  `area_id` int(11) NOT NULL,
  `client_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `area_id_fk` (`area_id`),
  KEY `client_id_fk` (`client_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `beacons`
--

INSERT INTO `beacons` (`id`, `name`, `uuid`, `mfd_date`, `mfd_company`, `description`, `proximity`, `area_id`, `client_id`) VALUES
(1, 'Aone Shop', 'af109d65-25e3-41b0-b012-d8ba007bd720', '2019-02-14 14:15:31', 'BlueCats', 'Clothes and shoes', '60', 1, 1),
(2, 'Shiwakoti Restaurant', '277d6232-c300-4d01-892a-839eba57a150', '2018-10-12 13:40:02', 'BlueSense', 'Food and beverage', '70', 2, 2),
(3, 'Watch Shop', 'b2f54e8f-047b-4dd5-af85-12a67ea08a10', '2017-10-02 15:26:59', 'Estimote', 'Branded watch', '50', 3, 3),
(4, 'Jogendra Shop', 'fdd9791f-9ab7-48f3-978c-45dfa971e27e', '2019-08-20 16:25:35', 'Sonic', 'Vegetable and fruit', '65', 4, 4),
(5, 'Rinkiya Saloon', 'c3c54100-374f-11e9-b210-d663bd873d93', '2017-09-25 13:14:15', 'Sensorberg', 'Girls and Boys Hair cut', '30', 5, 5),
(6, 'Chaulagain Market', '503dfa22-8b09-4d4b-958e-e8d6c1f280c0', '2019-03-19 00:00:00', 'BN', 'Clothes', '50', 6, 6),
(7, 'Mahat Laptop Shop', '0f9f93b8-324f-454c-b9c7-d0df5ba6805a', '2017-02-03 00:00:00', 'Unique', 'Laptop', '30', 7, 7);

-- --------------------------------------------------------

--
-- Table structure for table `beacon_ad`
--

DROP TABLE IF EXISTS `beacon_ad`;
CREATE TABLE IF NOT EXISTS `beacon_ad` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad_id` int(11) NOT NULL,
  `beacon_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ad_id_fk` (`ad_id`),
  KEY `beacon_id_fk1` (`beacon_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `beacon_ad`
--

INSERT INTO `beacon_ad` (`id`, `ad_id`, `beacon_id`) VALUES
(1, 1, 1),
(2, 2, 2),
(3, 3, 3),
(4, 4, 4),
(5, 5, 5),
(6, 6, 6),
(7, 7, 7);

-- --------------------------------------------------------

--
-- Table structure for table `clicks`
--

DROP TABLE IF EXISTS `clicks`;
CREATE TABLE IF NOT EXISTS `clicks` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datetime` datetime NOT NULL,
  `ad_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ad_id_fk1` (`ad_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clicks`
--

INSERT INTO `clicks` (`id`, `datetime`, `ad_id`) VALUES
(1, '2019-02-23 14:15:40', 1),
(2, '2019-02-24 04:15:21', 2),
(3, '2019-02-23 10:05:31', 3),
(4, '2019-02-22 14:15:39', 4),
(5, '2019-02-21 19:01:31', 5),
(6, '2019-10-20 10:02:09', 6),
(7, '2019-06-26 13:06:45', 7);

-- --------------------------------------------------------

--
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
CREATE TABLE IF NOT EXISTS `clients` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) NOT NULL,
  `email` varchar(255) NOT NULL,
  `description` text NOT NULL,
  `address` varchar(200) NOT NULL,
  `dob` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `clients`
--

INSERT INTO `clients` (`id`, `name`, `email`, `description`, `address`, `dob`) VALUES
(1, 'Rajesh', 'Rajesh1@gmail.com', 'Works in BlueCats Company', 'Kirtipur', '1980-11-20'),
(2, 'Ramesh', 'BboyRamu@gmail.com', 'Works in BlueSense Company', 'Bhaktapur', '1980-11-20'),
(3, 'Suresh', 'Hero.kto@gmail.com', 'Works in Estimote Company', 'Pokhara', '1990-03-21'),
(4, 'Hannah', 'Hannah@gmail.com', 'Works in Sonic Notify Company', 'Thamel', '1999-10-12'),
(5, 'Himesh', 'himesh@gmail.com', 'Works in Sensorberg Company', 'Kalanki', '2001-05-06'),
(6, 'Ashwin', 'ashwin@gmail.com', 'Works in BN Company', 'Lazimpat', '1990-08-31'),
(7, 'Anuj', 'anuj@outlook.com', 'Works in Unique Company', 'Kathmandu', '2000-10-11');

-- --------------------------------------------------------

--
-- Table structure for table `impressions`
--

DROP TABLE IF EXISTS `impressions`;
CREATE TABLE IF NOT EXISTS `impressions` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `datetime` datetime NOT NULL,
  `ad_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `ad_id_fk2` (`ad_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `impressions`
--

INSERT INTO `impressions` (`id`, `datetime`, `ad_id`) VALUES
(1, '2019-02-23 14:15:40', 1),
(2, '2019-02-24 04:15:21', 2),
(3, '2019-02-24 10:05:31', 3),
(4, '2019-02-23 14:15:39', 4),
(5, '2019-02-26 19:17:31', 5),
(6, '2019-03-20 02:12:45', 6),
(7, '2019-06-26 13:06:45', 7);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `beacons`
--
ALTER TABLE `beacons`
  ADD CONSTRAINT `area_id_fk` FOREIGN KEY (`area_id`) REFERENCES `areas` (`id`),
  ADD CONSTRAINT `client_id_fk` FOREIGN KEY (`client_id`) REFERENCES `clients` (`id`);

--
-- Constraints for table `beacon_ad`
--
ALTER TABLE `beacon_ad`
  ADD CONSTRAINT `ad_id_fk` FOREIGN KEY (`ad_id`) REFERENCES `ads` (`id`),
  ADD CONSTRAINT `beacon_id_fk1` FOREIGN KEY (`beacon_id`) REFERENCES `beacons` (`id`);

--
-- Constraints for table `clicks`
--
ALTER TABLE `clicks`
  ADD CONSTRAINT `ad_id_fk1` FOREIGN KEY (`ad_id`) REFERENCES `ads` (`id`);

--
-- Constraints for table `impressions`
--
ALTER TABLE `impressions`
  ADD CONSTRAINT `ad_id_fk2` FOREIGN KEY (`ad_id`) REFERENCES `ads` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
