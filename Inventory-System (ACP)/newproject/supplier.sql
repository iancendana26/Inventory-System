-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 10, 2023 at 07:12 PM
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
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`supplier_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
