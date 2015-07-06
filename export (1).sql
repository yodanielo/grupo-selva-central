--
-- MySQL 5.5.8
-- Sun, 07 Aug 2011 17:15:09 +0000
--

CREATE TABLE `incremento` (
   `idincremento` int(11) not null,
   `criterio` varchar(150),
   `valor` int(11),
   PRIMARY KEY (`idincremento`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `incremento` (`idincremento`, `criterio`, `valor`) VALUES 
('1', 'cliente', '1'),
('2', 'factura', '0'),
('3', 'orden', '0'),
('4', 'boleta', '0'),
('5', 'comprobante', '0');

CREATE TABLE `ste_camionero` (
   `idcamionero` int(11) not null auto_increment,
   `camnombres` varchar(150),
   `camapellidos` varchar(150),
   `camdni` varchar(8),
   `camdireccion` varchar(150),
   `camlicencia` varchar(11),
   `camcategoria` int(11),
   PRIMARY KEY (`idcamionero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_camionero` is empty]

CREATE TABLE `ste_carga` (
   `idcarga` int(11) not null auto_increment,
   `caridunidad` int(11),
   `carfechaasignacion` datetime,
   `carfechasalida` datetime,
   PRIMARY KEY (`idcarga`),
   KEY `fk_ste_carga_ste_unidad` (`caridunidad`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_carga` is empty]

CREATE TABLE `ste_cliente` (
   `idcliente` int(11) not null auto_increment,
   `clitipo` int(11),
   `cliruc` varchar(11),
   PRIMARY KEY (`idcliente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=2;

INSERT INTO `ste_cliente` (`idcliente`, `clitipo`, `cliruc`) VALUES 
('1', '1', '10440035251');

CREATE TABLE `ste_clijuridico` (
   `idste_clijuridico` int(11) not null,
   `jurrepresentante` varchar(250),
   `jurrazonsocial` varchar(250),
   PRIMARY KEY (`idste_clijuridico`),
   KEY `fk_ste_clijuridico_ste_cliente` (`idste_clijuridico`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

INSERT INTO `ste_clijuridico` (`idste_clijuridico`, `jurrepresentante`, `jurrazonsocial`) VALUES 
('1', 'm,lñ,pl', 'vgybhu');

CREATE TABLE `ste_clinatural` (
   `idclinatural` int(11) not null,
   `natnombres` varchar(150),
   `natapellidos` varchar(250),
   `natdni` varchar(250),
   PRIMARY KEY (`idclinatural`),
   KEY `fk_ste_clinatural_ste_cliente` (`idclinatural`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- [Table `ste_clinatural` is empty]

CREATE TABLE `ste_detallecarga` (
   `iddetallecarga` int(11) not null auto_increment,
   `dcaiddetalleenvio` int(11),
   `dcacantidad` int(11),
   `dcaidcarga` int(11),
   PRIMARY KEY (`iddetallecarga`),
   KEY `fk_ste_detallecarga_ste_detalleenvio` (`dcaiddetalleenvio`),
   KEY `fk_ste_detallecarga_ste_carga` (`dcaidcarga`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_detallecarga` is empty]

CREATE TABLE `ste_detalleenvio` (
   `iddetalleenvio` int(11) not null auto_increment,
   `denidenvio` int(11),
   `dencodigo` varchar(20),
   `dendescripcion` text,
   `dencantidad` int(11),
   `denpreciounitario` decimal(10,3),
   `dentipo` int(11),
   `denresta` int(11),
   `umedida` varchar(255),
   `peso` varchar(255),
   PRIMARY KEY (`iddetalleenvio`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_detalleenvio` is empty]

CREATE TABLE `ste_envio` (
   `idenvio` int(11) not null auto_increment,
   `envidcliente` int(11),
   `envfecha_registro` datetime,
   `envdireccion_origen` varchar(250),
   `envdireccion_destino` varchar(250),
   `envdestinatario` varchar(250),
   `envrucdestinatario` varchar(11),
   `envidserie` int(11),
   `envnumcomprobante` bigint(20),
   `envtipocomprobante` int(11),
   `idunidad` int(11),
   `gremision` varchar(11),
   PRIMARY KEY (`idenvio`),
   KEY `fk_ste_envio_ste_cliente` (`envidcliente`),
   KEY `index_serie_comprobante` (`envidserie`),
   KEY `index_num_comprobante` (`envnumcomprobante`),
   KEY `fk_ste_envio_ste_serie` (`envidserie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_envio` is empty]

CREATE TABLE `ste_serie` (
   `idserie` int(11) not null auto_increment,
   `sertipo` int(11),
   `sernumero` int(11),
   `servalmin` int(11),
   `servalmax` int(11),
   PRIMARY KEY (`idserie`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_serie` is empty]

CREATE TABLE `ste_session` (
   `idsession` int(11) not null auto_increment,
   `sesidpantalla` int(11),
   `sesfecha_hora` datetime,
   `sesidusuario` int(11),
   PRIMARY KEY (`idsession`),
   KEY `fk_ste_session_ste_usuario` (`sesidusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_session` is empty]

CREATE TABLE `ste_unidad` (
   `idunidad` int(11) not null auto_increment,
   `uniplaca` varchar(10),
   `uniidcamionero` int(11),
   `unidelaempresa` int(2),
   `razsocial` varchar(255),
   `ruc` varchar(11),
   PRIMARY KEY (`idunidad`),
   KEY `fk_ste_unidad_ste_camionero` (`uniidcamionero`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1;

-- [Table `ste_unidad` is empty]

CREATE TABLE `ste_usuario` (
   `idusuario` int(11) not null auto_increment,
   `usuuser` varchar(150),
   `usupassword` varchar(150),
   `usunombres` varchar(250),
   `usuapellidos` varchar(250),
   `usudni` varchar(10),
   `usuestado` int(11),
   `usutipo` int(11),
   PRIMARY KEY (`idusuario`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=4;

INSERT INTO `ste_usuario` (`idusuario`, `usuuser`, `usupassword`, `usunombres`, `usuapellidos`, `usudni`, `usuestado`, `usutipo`) VALUES 
('1', 'admin', '202cb962ac59075b964b07152d234b70', 'usuario12', 'apellido3', '44001574', '1', '0'),
('2', 'operario', '202cb962ac59075b964b07152d234b70', 'usuario1', 'apellido', '44001574', '1', '1'),
('3', 'operariod', 'd9b1d7db4cd6e70935368a1efb10e377', 'usuario1', 'apellido', '44001574', '1', '1');