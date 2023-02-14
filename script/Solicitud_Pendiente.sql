DELIMITER $$

USE `bd`$$

DROP PROCEDURE IF EXISTS `solicitud_doc_siau`$$

CREATE DEFINER=`hgarcia`@`%` PROCEDURE `solicitud_doc_siau`(parsolicitud_id INT(11),
  parfecha_solicitud DATE,
  parnombre1_solicita VARCHAR(35),
  parnombre2_solicita VARCHAR(35),
  parapellido1_solicita VARCHAR(35),
  parapellido2_solicita VARCHAR(35),
  partipo_doc_solicita VARCHAR(30),
  parnum_doc_solicta VARCHAR(15),
  parexp_doc_solicita VARCHAR(60),
  parentesco_solicita VARCHAR(60),`solicitud_doc_siau`
  parNoIdentificacion VARCHAR(50),
  partel_paciente VARCHAR(15),
  paremail_paciente VARCHAR(100),
  parcaso VARCHAR(15),
  parempresa VARCHAR(4),
  parhist_clinica TINYINT(1),
  parimagen_diag TINYINT(1),
  parlectura_rx TINYINT(1),
  parlaboratorio TINYINT(1),
  parcertificado TINYINT(1),
  parfurips TINYINT(1),
  parnum_folio VARCHAR(4),
  parfecha_hora_entrega DATETIME,
  parestado_solicitud VARCHAR(20)
)
BEGIN
    INSERT INTO solicitud_doc_siau(solicitud_id,fecha_solicitud,nombre1_solicita,nombre2_solicita,apellido1_solicita,apellido2_solicita,tipo_doc_solicita,num_doc_solicta,exp_doc_solicita,parentesco_solicita,tel_paciente,email_paciente,caso,empresa,hist_clinica,imagen_diag,lectura_rx,laboratorio,certificado,furips,num_folio,fecha_hora_entrega,estado_solicitud)
    VALUES(parsolicitud_id,parfecha_solicitud,parnombre1_solicita,parnombre2_solicita,parapellido1_solicita,parapellido2_solicita,partipo_doc_solicita,parnum_doc_solicta,parexp_doc_solicita,parparentesco_solicita,partel_paciente,paremail_paciente,parcaso,parempresa,parhist_clinica,parimagen_diag,parlectura_rx,parlaboratorio,parcertificado,parfurips,parnum_folio,parfecha_hora_entrega,parestado_solicitud);
	
    SELECT 'OK' AS Msg;
END$$

DELIMITER ;