# --------------------------------------------------------
# Host:                         127.0.0.1
# Database:                     gselvacentraldb
# Server version:               5.5.8
# Server OS:                    Win32
# HeidiSQL version:             5.0.0.3272
# Date/time:                    2011-05-14 14:29:58
# --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

# Dumping structure for table gselvacentraldb.incremento
DROP TABLE IF EXISTS `incremento`;
CREATE TABLE IF NOT EXISTS `incremento` (
  `idincremento` int(11) NOT NULL,
  `criterio` varchar(150) DEFAULT NULL,
  `valor` int(11) DEFAULT NULL,
  PRIMARY KEY (`idincremento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.incremento: 5 rows
DELETE FROM `incremento`;
/*!40000 ALTER TABLE `incremento` DISABLE KEYS */;
INSERT INTO `incremento` (`idincremento`, `criterio`, `valor`) VALUES (1, 'cliente', 0), (2, 'factura', 0), (3, 'orden', 0), (4, 'boleta', 0), (5, 'comprobante', 0);
/*!40000 ALTER TABLE `incremento` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_camionero
DROP TABLE IF EXISTS `ste_camionero`;
CREATE TABLE IF NOT EXISTS `ste_camionero` (
  `idcamionero` int(11) NOT NULL AUTO_INCREMENT,
  `camnombres` varchar(150) DEFAULT NULL,
  `camapellidos` varchar(150) DEFAULT NULL,
  `camdni` varchar(8) DEFAULT NULL,
  `camdireccion` varchar(150) DEFAULT NULL,
  `camlicencia` varchar(11) DEFAULT NULL,
  `camcategoria` int(11) DEFAULT NULL COMMENT 'Uno\nDos B\nTres profesional\nEspecializado B\nEspecializado C\n',
  PRIMARY KEY (`idcamionero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_camionero: 0 rows
DELETE FROM `ste_camionero`;
/*!40000 ALTER TABLE `ste_camionero` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_camionero` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_carga
DROP TABLE IF EXISTS `ste_carga`;
CREATE TABLE IF NOT EXISTS `ste_carga` (
  `idcarga` int(11) NOT NULL AUTO_INCREMENT,
  `caridunidad` int(11) DEFAULT NULL,
  `carfechaasignacion` datetime DEFAULT NULL,
  `carfechasalida` datetime DEFAULT NULL,
  PRIMARY KEY (`idcarga`),
  KEY `fk_ste_carga_ste_unidad` (`caridunidad`),
  CONSTRAINT `fk_ste_carga_ste_unidad` FOREIGN KEY (`caridunidad`) REFERENCES `ste_unidad` (`idunidad`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_carga: 0 rows
DELETE FROM `ste_carga`;
/*!40000 ALTER TABLE `ste_carga` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_carga` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_cliente
DROP TABLE IF EXISTS `ste_cliente`;
CREATE TABLE IF NOT EXISTS `ste_cliente` (
  `idcliente` int(11) NOT NULL AUTO_INCREMENT,
  `clitipo` int(11) DEFAULT NULL COMMENT '0=natural\n1=juridico',
  `cliruc` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_cliente: 0 rows
DELETE FROM `ste_cliente`;
/*!40000 ALTER TABLE `ste_cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_cliente` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_clijuridico
DROP TABLE IF EXISTS `ste_clijuridico`;
CREATE TABLE IF NOT EXISTS `ste_clijuridico` (
  `idste_clijuridico` int(11) NOT NULL,
  `jurrepresentante` varchar(250) DEFAULT NULL,
  `jurrazonsocial` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idste_clijuridico`),
  KEY `fk_ste_clijuridico_ste_cliente` (`idste_clijuridico`),
  CONSTRAINT `fk_ste_clijuridico_ste_cliente` FOREIGN KEY (`idste_clijuridico`) REFERENCES `ste_cliente` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_clijuridico: 0 rows
DELETE FROM `ste_clijuridico`;
/*!40000 ALTER TABLE `ste_clijuridico` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_clijuridico` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_clinatural
DROP TABLE IF EXISTS `ste_clinatural`;
CREATE TABLE IF NOT EXISTS `ste_clinatural` (
  `idclinatural` int(11) NOT NULL,
  `natnombres` varchar(150) DEFAULT NULL,
  `natapellidos` varchar(250) DEFAULT NULL,
  `natdni` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`idclinatural`),
  KEY `fk_ste_clinatural_ste_cliente` (`idclinatural`),
  CONSTRAINT `fk_ste_clinatural_ste_cliente` FOREIGN KEY (`idclinatural`) REFERENCES `ste_cliente` (`idcliente`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_clinatural: 0 rows
DELETE FROM `ste_clinatural`;
/*!40000 ALTER TABLE `ste_clinatural` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_clinatural` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_detallecarga
DROP TABLE IF EXISTS `ste_detallecarga`;
CREATE TABLE IF NOT EXISTS `ste_detallecarga` (
  `iddetallecarga` int(11) NOT NULL AUTO_INCREMENT,
  `dcaiddetalleenvio` int(11) DEFAULT NULL,
  `dcacantidad` int(11) DEFAULT NULL,
  `dcaidcarga` int(11) DEFAULT NULL,
  PRIMARY KEY (`iddetallecarga`),
  KEY `fk_ste_detallecarga_ste_detalleenvio` (`dcaiddetalleenvio`),
  KEY `fk_ste_detallecarga_ste_carga` (`dcaidcarga`),
  CONSTRAINT `fk_ste_detallecarga_ste_carga` FOREIGN KEY (`dcaidcarga`) REFERENCES `ste_carga` (`idcarga`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_ste_detallecarga_ste_detalleenvio` FOREIGN KEY (`dcaiddetalleenvio`) REFERENCES `ste_detalleenvio` (`iddetalleenvio`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_detallecarga: 0 rows
DELETE FROM `ste_detallecarga`;
/*!40000 ALTER TABLE `ste_detallecarga` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_detallecarga` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_detalleenvio
DROP TABLE IF EXISTS `ste_detalleenvio`;
CREATE TABLE IF NOT EXISTS `ste_detalleenvio` (
  `iddetalleenvio` int(11) NOT NULL AUTO_INCREMENT,
  `denidenvio` int(11) DEFAULT NULL,
  `dencodigo` varchar(20) DEFAULT NULL,
  `dendescripcion` text,
  `dencantidad` int(11) DEFAULT NULL,
  `denpreciounitario` decimal(10,3) DEFAULT NULL,
  `dentipo` int(11) DEFAULT NULL COMMENT '0=boleta\n1=factura\n2=orden de despacho',
  `denresta` int(11) DEFAULT NULL,
  `umedida` varchar(255) DEFAULT NULL,
  `peso` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`iddetalleenvio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_detalleenvio: 0 rows
DELETE FROM `ste_detalleenvio`;
/*!40000 ALTER TABLE `ste_detalleenvio` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_detalleenvio` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_envio
DROP TABLE IF EXISTS `ste_envio`;
CREATE TABLE IF NOT EXISTS `ste_envio` (
  `idenvio` int(11) NOT NULL AUTO_INCREMENT,
  `envidcliente` int(11) DEFAULT NULL,
  `envfecha_registro` datetime DEFAULT NULL,
  `envdireccion_origen` varchar(250) DEFAULT NULL,
  `envdireccion_destino` varchar(250) DEFAULT NULL,
  `envdestinatario` varchar(250) DEFAULT NULL,
  `envrucdestinatario` varchar(11) DEFAULT NULL,
  `envidserie` int(11) DEFAULT NULL,
  `envnumcomprobante` bigint(20) DEFAULT NULL,
  `envtipocomprobante` int(11) DEFAULT NULL COMMENT '0=>Boleta\n1=>Factura\n2=>Orden de despacho',
  `idunidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`idenvio`),
  KEY `fk_ste_envio_ste_cliente` (`envidcliente`),
  KEY `index_serie_comprobante` (`envidserie`),
  KEY `index_num_comprobante` (`envnumcomprobante`),
  KEY `fk_ste_envio_ste_serie` (`envidserie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_envio: 0 rows
DELETE FROM `ste_envio`;
/*!40000 ALTER TABLE `ste_envio` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_envio` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_serie
DROP TABLE IF EXISTS `ste_serie`;
CREATE TABLE IF NOT EXISTS `ste_serie` (
  `idserie` int(11) NOT NULL AUTO_INCREMENT,
  `sertipo` int(11) DEFAULT NULL COMMENT '0=boleta\n1=factura\n2=orden de despacho\n',
  `sernumero` int(11) DEFAULT NULL,
  `servalmin` int(11) DEFAULT NULL,
  `servalmax` int(11) DEFAULT NULL,
  PRIMARY KEY (`idserie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_serie: 0 rows
DELETE FROM `ste_serie`;
/*!40000 ALTER TABLE `ste_serie` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_serie` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_session
DROP TABLE IF EXISTS `ste_session`;
CREATE TABLE IF NOT EXISTS `ste_session` (
  `idsession` int(11) NOT NULL AUTO_INCREMENT,
  `sesidpantalla` int(11) DEFAULT NULL COMMENT '0=administrador\n1=operario\n',
  `sesfecha_hora` datetime DEFAULT NULL,
  `sesidusuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`idsession`),
  KEY `fk_ste_session_ste_usuario` (`sesidusuario`),
  CONSTRAINT `fk_ste_session_ste_usuario` FOREIGN KEY (`sesidusuario`) REFERENCES `ste_usuario` (`idusuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_session: 0 rows
DELETE FROM `ste_session`;
/*!40000 ALTER TABLE `ste_session` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_session` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_unidad
DROP TABLE IF EXISTS `ste_unidad`;
CREATE TABLE IF NOT EXISTS `ste_unidad` (
  `idunidad` int(11) NOT NULL AUTO_INCREMENT,
  `uniplaca` varchar(10) DEFAULT NULL,
  `uniidcamionero` int(11) DEFAULT NULL,
  `unidelaempresa` int(2) DEFAULT NULL,
  `razsocial` varchar(255) DEFAULT NULL,
  `ruc` varchar(11) DEFAULT NULL,
  PRIMARY KEY (`idunidad`),
  KEY `fk_ste_unidad_ste_camionero` (`uniidcamionero`),
  CONSTRAINT `fk_ste_unidad_ste_camionero` FOREIGN KEY (`uniidcamionero`) REFERENCES `ste_camionero` (`idcamionero`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_unidad: 0 rows
DELETE FROM `ste_unidad`;
/*!40000 ALTER TABLE `ste_unidad` DISABLE KEYS */;
/*!40000 ALTER TABLE `ste_unidad` ENABLE KEYS */;


# Dumping structure for table gselvacentraldb.ste_usuario
DROP TABLE IF EXISTS `ste_usuario`;
CREATE TABLE IF NOT EXISTS `ste_usuario` (
  `idusuario` int(11) NOT NULL AUTO_INCREMENT,
  `usuuser` varchar(150) DEFAULT NULL,
  `usupassword` varchar(150) DEFAULT NULL,
  `usunombres` varchar(250) DEFAULT NULL,
  `usuapellidos` varchar(250) DEFAULT NULL,
  `usudni` varchar(10) DEFAULT NULL,
  `usuestado` int(11) DEFAULT NULL COMMENT '0=inactivo\n1=activo',
  `usutipo` int(11) DEFAULT NULL COMMENT '0=administrador\n1=operario\n',
  PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

# Dumping data for table gselvacentraldb.ste_usuario: 3 rows
DELETE FROM `ste_usuario`;
/*!40000 ALTER TABLE `ste_usuario` DISABLE KEYS */;
INSERT INTO `ste_usuario` (`idusuario`, `usuuser`, `usupassword`, `usunombres`, `usuapellidos`, `usudni`, `usuestado`, `usutipo`) VALUES (1, 'admin', '202cb962ac59075b964b07152d234b70', 'usuario12', 'apellido3', '44001574', 1, 0), (2, 'operario', '202cb962ac59075b964b07152d234b70', 'usuario1', 'apellido', '44001574', 1, 1), (3, 'operariod', 'd9b1d7db4cd6e70935368a1efb10e377', 'usuario1', 'apellido', '44001574', 1, 1);
/*!40000 ALTER TABLE `ste_usuario` ENABLE KEYS */;
/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
