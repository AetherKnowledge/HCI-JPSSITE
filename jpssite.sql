-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 19, 2025 at 01:48 PM
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
-- Database: `jpssite`
--

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `username` varchar(256) NOT NULL,
  `eventName` varchar(256) NOT NULL,
  `comment` varchar(256) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`username`, `eventName`, `comment`) VALUES
('Gucci', 'JPSSITE COMMUNITY EXTENSION', 'One of the best events JPSSITE made! Truly phenomenal!'),
('manaoghanz', 'JPSSITE COMMUNITY EXTENSION', 'Hello, good morning'),
('JCRosuelo', 'JPSSITE COMMUNITY EXTENSION', 'Hi po mam'),
('JCRosuelo', 'Pirate', 'Pirate'),
('JCRosuelo', 'Pirate', 'test'),
('JCRosuelo', 'Pirate', ''),
('JCRosuelo', 'Pirate', '');

-- --------------------------------------------------------

--
-- Table structure for table `eventevaluations`
--

CREATE TABLE `eventevaluations` (
  `eventName` varchar(256) NOT NULL,
  `userName` varchar(256) NOT NULL,
  `activitiesQ1` int(11) NOT NULL,
  `activitiesQ2` int(11) NOT NULL,
  `activitiesQ3` int(11) NOT NULL,
  `activitiesQ4` int(11) NOT NULL,
  `activitiesQ5` int(11) NOT NULL,
  `activitiesQ6` int(11) NOT NULL,
  `activitiesQ7` int(11) NOT NULL,
  `activitiesQ8` int(11) NOT NULL,
  `speakersQ1` int(11) NOT NULL,
  `speakersQ2` int(11) NOT NULL,
  `speakersQ3` int(11) NOT NULL,
  `speakersQ4` int(11) NOT NULL,
  `speakersQ5` int(11) NOT NULL,
  `speakersQ6` int(11) NOT NULL,
  `overallQ1_1` int(11) NOT NULL,
  `overallQ1_2` int(11) NOT NULL,
  `overallQ2` int(11) NOT NULL,
  `dateSubmitted` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `events`
--

CREATE TABLE `events` (
  `eventName` varchar(256) NOT NULL,
  `eventImg` longblob DEFAULT NULL,
  `eventRating` int(11) NOT NULL DEFAULT 0,
  `dateOfEvent` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `officers`
--

CREATE TABLE `officers` (
  `name` varchar(251) DEFAULT NULL,
  `img` longblob DEFAULT NULL,
  `section` varchar(251) DEFAULT NULL,
  `age` int(11) NOT NULL,
  `sex` varchar(16) NOT NULL,
  `achievements` varchar(251) NOT NULL,
  `motto` varchar(251) NOT NULL,
  `position` varchar(251) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `username` varchar(256) NOT NULL,
  `password` varchar(256) NOT NULL,
  `firstname` varchar(256) NOT NULL,
  `surname` varchar(256) NOT NULL,
  `userID` varchar(256) NOT NULL,
  `birthDate` date NOT NULL,
  `courseProgram` varchar(256) NOT NULL,
  `yearLevel` int(11) NOT NULL,
  `sex` varchar(16) NOT NULL,
  `img` longblob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`username`, `password`, `firstname`, `surname`, `userID`, `birthDate`, `courseProgram`, `yearLevel`, `sex`, `img`) VALUES
('admin', 'admin', 'admin', 'admin', 'admin', '2024-05-20', 'BSIT', 1, 'M', NULL),
('EdzDayao', 'edzDayao!', 'Edz', 'Dayao', '100004', '1999-02-01', 'BSIT', 2, 'F', NULL),
('Gucci', 'roiSuperPogi!', 'Roi', 'Ballesteros', '100002', '2004-08-08', 'BSIT', 2, 'M', NULL),
('JCRosuelo', 'Bruh123.', 'John Christian', 'Rosuelo', '51243', '2004-08-15', 'BSIT', 2, 'M', NULL),
('manaoghanz', 'Manaog@17', 'Hanz', 'Manaog', '1234213', '2003-11-17', 'BSIT', 2, 'M', NULL),
('MoiseTheo', 'lebronPogi!', 'Moises', 'Atienza', '100007', '2001-05-22', 'BSIT', 2, 'M', NULL),
('user', 'user', 'user', 'user', 'user', '2024-05-20', 'BSIT', 1, 'M', NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `events`
--
ALTER TABLE `events`
  ADD PRIMARY KEY (`eventName`);

--
-- Indexes for table `officers`
--
ALTER TABLE `officers`
  ADD PRIMARY KEY (`position`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`username`),
  ADD UNIQUE KEY `userID` (`userID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
