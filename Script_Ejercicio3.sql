-- MySQL Script generated by MySQL Workbench
-- Fri Mar 18 16:29:45 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Ejercicio3
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema Ejercicio3
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Ejercicio3` DEFAULT CHARACTER SET utf8 ;
USE `Ejercicio3` ;

-- -----------------------------------------------------
-- Table `Ejercicio3`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `Ejercicio3`.`Usuario` (
  `Codigo` VARCHAR(15) NOT NULL,
  `Contraseña` VARCHAR(10) NULL,
  `PrimerNombre` VARCHAR(15) NULL,
  `PrimerApellido` VARCHAR(25) NULL,
  `TipoUsuario` VARCHAR(15) NULL,
  `EstaActivo` TINYINT(1) NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;