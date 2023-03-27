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
    var tipoIDPaciente = $("#tipoIDPaciente").val();
    var numIDPaciente = $("#numIDPaciente").val();
    var expedicionIDPaciente = $("#expedicionIDPaciente").val();
    var telefono = $("#telefono").val();
    var fechaIngreso = $("#fechaIngreso").val();
    var fechaEgreso = $("#fechaEgreso").val();
    var correo = $("#correo").val();
    var numCaso = $("#numCaso").val();
    var histClinica = $("#histc").val();
    var imagenesDx = $("#rayox").val();
    var lecturaRx = $("#lect").val();
    var laboratorio = $("#labs").val();
    var certificado = $("#cert").val();
    var furips = $("#furips").val();
    var numFolio = $("#numFolio").val();
    var fechaEntrega = $("#fechaEntrega").val();

    
    //fecha_solicitud,nombre1_solicita,nombre2_solicita,apellido1_solicita,apellido2_solicita,tipo_doc_solicita,num_doc_solicta,exp_doc_solicita,parentesco_solicita,tel_paciente,email_paciente,caso,empresa,hist_clinica,imagen_diag,lectura_rx,laboratorio,certificado,furips,num_folio,fecha_hora_entrega,estado_solicitud
    var parametros = { fechSolic: fechaSolicitud, nom1Solic: nombre1Solicita, nom2Solic: nombre2Solicita, apell1Solic: apellido1Solicita, apell2Solic: apellido2Solicita, tipoIDSolic: tipoIDSolicita, numIDSolic: numIDSolicita, expIDSolic: expedicionIDSolicita, parentesco: parentesco, tipoIDPac: tipoIDPaciente, numIDPac: numIDPaciente, expIDPac: expedicionIDPaciente, telefono: telefono, fecIngreso: fechaIngreso, fecEgreso: fechaEgreso, correo: correo, numCaso: numCaso, histClinica: histClinica, imagenesDx: imagenesDx, lecturaRx: lecturaRx, laboratorio: laboratorio, certificado: certificado, furips: furips, numFolio: numFolio, fechaEntrega: fechaEntrega }

    $.post("DatosSolicitud", { fechSolic: fechaSolicitud, nom1Solic: nombre1Solicita, nom2Solic: nombre2Solicita, apell1Solic: apellido1Solicita, apell2Solic: apellido2Solicita, tipoIDSolic: tipoIDSolicita, numIDSolic: numIDSolicita, expIDSolic: expedicionIDSolicita, parentesco: parentesco, tipoIDPac: tipoIDPaciente, numIDPac: numIDPaciente, expIDPac: expedicionIDPaciente, telefono: telefono, fecIngreso: fechaIngreso, fecEgreso: fechaEgreso, correo: correo, numCaso: numCaso, histClinica: histClinica, imagenesDx: imagenesDx, lecturaRx: lecturaRx, laboratorio: laboratorio, certificado: certificado, furips: furips, numFolio: numFolio, fechaEntrega: fechaEntrega }, function (result) {

        var msg = result;
        console.log(result);

        if (msg == "OK") {
            alert("Datos en Blanco");

        }
        else {
            alert("Investigador Registrado");
        }

    });

}

function PasarValor() {
    var paciente = $("#parentesco").val();
    if (paciente == "paciente") {
        document.getElementById("nombre1Paciente").value = document.getElementById("nombre1Solicita").value;
        document.getElementById("nombre2Paciente").value = document.getElementById("nombre2Solicita").value;
        document.getElementById("apellido1Paciente").value = document.getElementById("apellido1Solicita").value;
        document.getElementById("apellido2Paciente").value = document.getElementById("apellido2Solicita").value;
        document.getElementById("tipoIDPaciente").value = document.getElementById("tipoIDSolicita").value;
        document.getElementById("numIDPaciente").value = document.getElementById("numIDSolicita").value;
        document.getElementById("expedicionIDPaciente").value = document.getElementById("expedicionIDSolicita").value;
        document.getElementById("telefono").focus();
    }
    else {
        document.getElementById("nombre1Paciente").value = "";
        document.getElementById("nombre2Paciente").value = "";
        document.getElementById("apellido1Paciente").value = "";
        document.getElementById("apellido2Paciente").value = "";
        document.getElementById("tipoIDPaciente").value = "";
        document.getElementById("numIDPaciente").value = "";
        document.getElementById("expedicionIDPaciente").value = "";
    }
}

function validaDOC(checkbox) {
    var checkboxes = document.getElementsByName('checkDOC')
    checkboxes.forEach((item) => {
        //if (item !== checkbox) item.checked = false;
        if (item == checkbox && item.value == 'hc') document.getElementById("histc").value = item.value;//$("#histc").val(item.value);
        if (item == checkbox && item.value == 'rx') document.getElementById("rayox").value = item.value;//$("rayox").val(item.value);
        if (item == checkbox && item.value == 'lr') document.getElementById("lect").value = item.value;//$("lect").val(item.value);
        if (item == checkbox && item.value == 'lb') document.getElementById("labs").value = item.value;//$("labs").val(item.value);
        if (item == checkbox && item.value == 'ce') document.getElementById("cert").value = item.value;//$("cert").val(item.value);
        if (item == checkbox && item.value == 'fu') document.getElementById("furips").value = item.value;//$("furips").val(item.value);
        
    });

    
}