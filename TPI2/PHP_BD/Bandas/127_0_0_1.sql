-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 30-Ago-2019 às 19:39
-- Versão do servidor: 10.1.33-MariaDB
-- PHP Version: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `teste01`
--
CREATE DATABASE IF NOT EXISTS `teste01` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `teste01`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `bandas`
--

CREATE TABLE `bandas` (
  `id` int(11) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `pais` int(9) NOT NULL,
  `data_origem` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `bandas`
--

INSERT INTO `bandas` (`id`, `nome`, `pais`, `data_origem`) VALUES
(2, 'Queen', 1, '2016-07-19'),
(3, 'Killer', 1, '2013-03-21'),
(5, 'restart', 4, '2010-06-16'),
(7, '5 Seconds of Summer', 5, '2012-01-05'),
(10, 'AC/DC', 1, '2000-02-09'),
(11, 'AC/DC', 1, '2000-02-09'),
(12, 'AC/DC', 1, '2000-02-09');

-- --------------------------------------------------------

--
-- Estrutura da tabela `pais`
--

CREATE TABLE `pais` (
  `id_pais` int(9) NOT NULL,
  `nm_pais` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `pais`
--

INSERT INTO `pais` (`id_pais`, `nm_pais`) VALUES
(1, 'Estados Unidos'),
(3, 'México'),
(4, 'Brasil\r\n'),
(5, 'Hawai'),
(6, 'Austrália'),
(7, 'Argentina'),
(8, 'Suíça'),
(9, 'Irlanda'),
(10, 'Holanda'),
(11, 'França'),
(12, 'Itália'),
(13, 'Portugal'),
(14, 'Coréia do Norte'),
(15, 'Coréia do Sul'),
(16, 'Japão'),
(17, 'China');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `bandas`
--
ALTER TABLE `bandas`
  ADD PRIMARY KEY (`id`),
  ADD KEY `pais_fk` (`pais`);

--
-- Indexes for table `pais`
--
ALTER TABLE `pais`
  ADD PRIMARY KEY (`id_pais`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `bandas`
--
ALTER TABLE `bandas`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT for table `pais`
--
ALTER TABLE `pais`
  MODIFY `id_pais` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `bandas`
--
ALTER TABLE `bandas`
  ADD CONSTRAINT `pais_fk` FOREIGN KEY (`pais`) REFERENCES `pais` (`id_pais`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
