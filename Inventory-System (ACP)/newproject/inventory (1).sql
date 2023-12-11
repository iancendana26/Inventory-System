-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2023 at 07:14 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `inventory`
--

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `loginId` int(11) NOT NULL,
  `userName` varchar(250) DEFAULT NULL,
  `PASSWORD` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`loginId`, `userName`, `PASSWORD`) VALUES
(1, 'nathan', '123'),
(2, 'ian', 'ian'),
(3, 'bon', 'bonpogi143');

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `Product_ID` int(11) NOT NULL,
  `Name` varchar(250) DEFAULT NULL,
  `stocks` varchar(250) DEFAULT NULL,
  `supplier` varchar(250) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`Product_ID`, `Name`, `stocks`, `supplier`) VALUES
(1, 'Mega Sardines', '200', 'Mega Global'),
(2, 'Datu Puti Vinegar', '200', 'NutriAsia, Inc.'),
(3, 'Doreen Sweetened Condensed Creamer ', '500', 'Etika Dairies SDN BHD '),
(4, 'Mang Tomas Siga', '506', 'NutriAsia'),
(5, 'Marca Pina Soy Sauce ', '50', 'Piñakamasarap Corporation');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `supplier_id` int(11) NOT NULL,
  `Supplier_Name` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Contact_Number` varchar(255) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`supplier_id`, `Supplier_Name`, `Address`, `Contact_Number`, `Email`) VALUES
(7, 'Piñakamasarap Corporation', '23 Pablo Dela Cruz, Novaliches, Quezon City, 1123 Metro Manila', '(02) 3418 0556', 'amelia.ortega@marcapina.com'),
(8, 'NutriaAsia', 'JY Campos Centre, 9th Ave., Taguig, Metro Manila, Philippines', '(02) 8800 3888', 'rosalie.bulseco@nutriasia.com'),
(9, 'Mega Global', '70, Sgt. Esguerra Street corner Quezon Avenue, South Triangle, Quezon City 1103 Metro Manila', '+63 (2) 8 888 8600', 'rrodriguez@megasardines.com'),
(10, 'Etika Dairies SDN BHD', 'Unit L01, East Wing, Level 1, Quattro West, No 4, Lorong Persiaran Barat, 46200 Petaling Jaya, Selangor Darul Ehsan.', '1300-30-1300', 'customercareline@etikaholdings.com');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`loginId`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Product_ID`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `login`
--
ALTER TABLE `login`
  MODIFY `loginId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `Product_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
