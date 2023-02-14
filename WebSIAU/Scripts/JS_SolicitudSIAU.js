function GuardarDatosSolicitud() {

    var fechaSolicitud = $("#fechaSolicitud").val();
    var nombre1Solicita = $("#nombre1Solicita").val();
    var nombre2Solicita = $("#nombre2Solicita").val();
    var apellido1Solicita = $("#apellido1Solicita").val();
    var apellido2Solicita = $("#apellido2Solicita").val();
    var tipoIDSolicita = $("#tipoIDSolicita").val();
    var numIDSolicita = $("#numIDSolicita").val();
    var expedicionIDSolicita = $("#expedicionIDSolicita").val();
    var parentesco = $("#parentesco").val();
    var nombre1Paciente = $("#nombre1Paciente").val();
    var nombre2Paciente = $("#nombre2Paciente").val();
    var apellido1Paciente = $("#apellido1Paciente").val();
    var apellido2Paciente = $("#apellido2Paciente").val();
    var tipoIDPaciente = $("#tipoIDPaciente").val();
    var numIDPaciente = $("#numIDPaciente").val();
    var expedicionIDPaciente = $("#expedicionIDPaciente").val();
    var telefono = $("#telefono").val();
    var fechaIngreso = $("#fechaIngreso").val();
    var fechaEgreso = $("#fechaEgreso").val();
    var correo = $("#correo").val();
    var numCaso = $("#numCaso").val();
    var histClinica = $("#histClinica").val();
    var imagenesDx = $("#imagenesDx").val();
    var lecturaRx = $("#lecturaRx").val();
    var laboratorio = $("#laboratorio").val();
    var certificado = $("#certificado").val();
    var furips = $("#furips").val();
    var numFolio = $("#numFolio").val();
    var fechaEntrega = $("#fechaEntrega").val();

    //if (aseguradora == null || aseguradora == "undefined") {
    //    alert("Debe seleccionar la Aseguradora");
    //    return;
    //}

    //if (investigador == "-- Seleccione --" || investigador == "undefined") {
    //    alert("Debe seleccionar un Investigador");
    //    return;
    //}

    //if (dx.length < 7 || dx == null) {
    //    alert("Digite un diagnostico del paciente");
    //    return;
    //}
    //fecha_solicitud,nombre1_solicita,nombre2_solicita,apellido1_solicita,apellido2_solicita,tipo_doc_solicita,num_doc_solicta,exp_doc_solicita,parentesco_solicita,tel_paciente,email_paciente,caso,empresa,hist_clinica,imagen_diag,lectura_rx,laboratorio,certificado,furips,num_folio,fecha_hora_entrega,estado_solicitud
    var parametros = { fechSolic: fechaSolicitud, nom1Solic: nombre1Solicita, nom2Solic: nombre2Solicita, apell1Solic: apellido1Solicita, apell2Solic: apellido2Solicita, tipoIDSolic: tipoIDSolicita, numIDSolic: numIDSolicita, expIDSolic: expedicionIDSolicita, parentesco: parentesco, nom1Paciente: nombre1Paciente, nom2Paciente: nombre2Paciente, apell1Paciente: apellido1Paciente, apell1Paciente: apellido2Paciente, tipoIDPac: tipoIDPaciente, numIDPac: numIDPaciente, expIDPac: expedicionIDPaciente, telefono: telefono, fecIngreso: fechaIngreso, fecEgreso: fechaEgreso, correo: correo, numCaso: numCaso, histClinica: histClinica, imagenesDx: imagenesDx, lecturaRx: lecturaRx, laboratorio: laboratorio, certificado: certificado, furips: furips, numFolio: numFolio, fechaEntrega: fechaEntrega }

    $.post("GenerarActa", { fechSolic: fechaSolicitud, nom1Solic: nombre1Solicita, nom2Solic: nombre2Solicita, apell1Solic: apellido1Solicita, apell2Solic: apellido2Solicita, tipoIDSolic: tipoIDSolicita, numIDSolic: numIDSolicita, expIDSolic: expedicionIDSolicita, parentesco: parentesco, nom1Paciente: nombre1Paciente, nom2Paciente: nombre2Paciente, apell1Paciente: apellido1Paciente, apell1Paciente: apellido2Paciente, tipoIDPac: tipoIDPaciente, numIDPac: numIDPaciente, expIDPac: expedicionIDPaciente, telefono: telefono, fecIngreso: fechaIngreso, fecEgreso: fechaEgreso, correo: correo, numCaso: numCaso, histClinica: histClinica, imagenesDx: imagenesDx, lecturaRx: lecturaRx, laboratorio: laboratorio, certificado: certificado, furips: furips, numFolio: numFolio, fechaEntrega: fechaEntrega }, function (result) {

        var msg = result;
        console.log(result);


    });

}