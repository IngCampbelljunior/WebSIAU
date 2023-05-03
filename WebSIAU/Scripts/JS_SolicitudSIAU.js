﻿
$(document).ready(function () {
    
    $('#btnSave').click(function (e) {
        e.preventDefault();
        alert("Botón");
        GuardarDatosSolicitud();

    });
});

// Código (linea 12 a la 27) para establecer fecha actual en el input fechaSolicitud de la vista DatosSolicitud.cshtml
// Método que recibe un elemento input date y un objeto date
function chargeDateInputDate(elem, dateObject = new Date()) {
    var year = dateObject.getFullYear();
    var month = dateObject.getMonth() + 1;
    var month = month > 9 ? month : "0" + month;
    var day = dateObject.getDate() > 9 ? dateObject.getDate() : "0" + dateObject.getDate();
    var dateFormat = year + "-" + month + "-" + day;
    elem.value = dateFormat;
}
// Creamos un objeto date con la fecha actual
var fecha = new Date();
// Obtenemos el elemento input time
var inputDate = document.getElementById("fechaSolicitud");
// Llamamos al método para que cargue la fecha
chargeDateInputDate(inputDate, fecha);

//Función para almacenar en la BD los datos de solicitud
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
    var numIDPaciente = $("#numIDPaciente").val();
    var telefono = $("#telefono").val();
    var fechaIngreso = $("#fechaIngreso").val();
    var fechaEgreso = $("#fechaEgreso").val();
    var motivoSolicitud = $("#motivo").val();
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
    alert("Voy a grabar")
    
    var parametros = { fecha_solicitud: fechaSolicitud, nombre1_solicita: nombre1Solicita, nombre2_solicita: nombre2Solicita, apellido1_solicita: apellido1Solicita, apellido2_solicita: apellido2Solicita, tipo_doc_solicita: tipoIDSolicita, num_doc_solicta: numIDSolicita, exp_doc_solicita: expedicionIDSolicita, parentesco_solicita: parentesco, NoIdentificacion: numIDPaciente, tel_paciente: telefono, motivo_solicitud: motivoSolicitud, email_paciente: correo, caso: numCaso, fechaIngreso: fechaIngreso, fechaEgreso: fechaEgreso, caso: numCaso, hist_clinica: histClinica, imagen_diag: imagenesDx, lectura_rx: lecturaRx, laboratorio: laboratorio, certificado: certificado, furips: furips, num_folio: numFolio, fecha_hora_entrega: fechaEntrega }

    $.post("DatosSolicitud", { nombre1_solicita: nombre1Solicita, nombre2_solicita: nombre2Solicita, apellido1_solicita: apellido1Solicita, apellido2_solicita: apellido2Solicita, tipo_doc_solicita: tipoIDSolicita, num_doc_solicta: numIDSolicita, exp_doc_solicita: expedicionIDSolicita, parentesco_solicita: parentesco, NoIdentificacion: numIDPaciente, tel_paciente: telefono, motivo_solicitud: motivoSolicitud, email_paciente: correo, caso: numCaso, fechaIngreso: fechaIngreso, fechaEgreso: fechaEgreso, hist_clinica: histClinica, imagen_diag: imagenesDx, lectura_rx: lecturaRx, laboratorio: laboratorio, certificado: certificado, furips: furips, num_folio: numFolio, fecha_hora_entrega: fechaEntrega }, function (result) {

        var msg = result;
        console.log(result);

        if (msg == "OK") {
            alert("Datos en Blanco");

        }
        else {
            alert("Solicitud Registrada");
            refresh();
        }

    });

}

//Esta función es llamada desde el input "parentesco" (linea 1256 de la vista DatosSolicitud.cshtml) y 
//copia los valores de los inputs de los datos del solicitante en los input de los datos del paciente siempre y cuando
//se elija el valor "paciente" del datalist parentesco (linea 1256 de la vista DatosSolicitud.cshtml).
//Si se cambia el valor del datalist, los inputs de los datos del paciente se limpian
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
        //GetDatosPacientes(paciente);
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

//Esta función es llamada desde el evento onclick de los inputs soportes solicitados (checkbox) y
//Valida si los checkbox de los soportes solicitados han sido activados y almacena el valor en los
//inputos ocultos lineas 1409 a la 1459 de la vista DatosSolicitud.cshtml
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

//***** FUNCION REFRESCAR O ACTUALIZAR LA PAGINA
function refresh() {
    location.reload(true);
}