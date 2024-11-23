-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 23/11/2024 às 15:19
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `projetods4`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `chamados`
--

CREATE TABLE `chamados` (
  `id` int(11) NOT NULL,
  `nomeResponsavel` varchar(150) DEFAULT NULL,
  `local` varchar(50) DEFAULT NULL,
  `nivel` varchar(200) DEFAULT NULL,
  `descricao` varchar(600) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `chamados`
--

INSERT INTO `chamados` (`id`, `nomeResponsavel`, `local`, `nivel`, `descricao`) VALUES
(1, 'Márcio', 'Laboratório 3', 'Alto', 'Gabriel socou a tela do Notebook e agora não está funcionando.'),
(2, 'Hélio', 'Laboratório 2', 'Médio', 'Aluna Fulana derrubou água no Notebook e agora apresenta linhas verdes na tela.'),
(3, 'Márcio', 'Laboratório 2', 'Médio', 'Mouse caiu no chão e agora ele dá click sozinho');

-- --------------------------------------------------------

--
-- Estrutura para tabela `chamadosfinalizados`
--

CREATE TABLE `chamadosfinalizados` (
  `id` int(11) NOT NULL,
  `nomeResponsavel` varchar(150) DEFAULT NULL,
  `local` varchar(50) DEFAULT NULL,
  `nivel` varchar(200) DEFAULT NULL,
  `descricao` varchar(600) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `chamados`
--
ALTER TABLE `chamados`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `chamadosfinalizados`
--
ALTER TABLE `chamadosfinalizados`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `chamados`
--
ALTER TABLE `chamados`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `chamadosfinalizados`
--
ALTER TABLE `chamadosfinalizados`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
