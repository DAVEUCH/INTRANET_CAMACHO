const MODELO_BASE = {
    idFormInterIngre: 0,
    nombPersona: "",
    apePersona: "",
    fechaIng: "",
    dniPersona: "",
    areaPersona: "",
    cargPersona: "",
    tipoPuesto: 1,
    hardwlapt: 1,
    hardwcompu: 1,
    hardwcel: 1,
    softoffice: 1,
    softAntiv: 1,
    softadob: 1,
    softcorr: 1,
    softsys: 1,
    softflex: 1,
    observacion: "",
    usuario: "",
    estado: 1,
}

let tablaData;

$(document).ready(function () {


    tablaData = $('#tbdata').DataTable({
        responsive: true,
        "ajax": {
            "url": '/FormInterIngre/Lista',
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "idFormInterIngre", "visible": false, "searchable": false },
            { "data": "nombPersona" },
            { "data": "apePersona" },
            { "data": "fechaIng" },
            { "data": "dniPersona" },
            { "data": "areaPersona" },
            { "data": "cargPersona" },
            {
                "data": "estado", render: function (data) {
                    return data == 1
                        ? '<span class="badge badge-info">Activo</span>'
                        : '<span class="badge badge-danger">No Activo</span>';
                }
            },
            {
                "defaultContent": `
<div class="d-flex justify-content-center">
        <button class="btn btn-info btn-sm btn-visualizar mr-1" title="Visualizar">
            <i class="fas fa-eye"></i>
        </button>
        <button class="btn btn-primary btn-sm btn-editar mr-1" title="Editar">
            <i class="fas fa-pencil-alt"></i>
        </button>
        <button class="btn btn-danger btn-sm btn-eliminar" title="Eliminar">
            <i class="fas fa-trash-alt"></i>
        </button>
    </div>

            `,
                "orderable": false,
                "searchable": false,
                "width": "80px"
            }
        ],

        order: [[0, "desc"]],
        dom: "Bfrtip",
        buttons: [
            {
                text: 'Exportar Excel',
                extend: 'excelHtml5',
                title: '',
                filename: 'Reporte de Ingreso de Personal',
                exportOptions: {
                    columns: [2,3,4,5,6,7]
                }
            }, 'pageLength'
        ],
        language: {
            url: "https://cdn.datatables.net/plug-ins/1.11.5/i18n/es-ES.json"
        },
    });

})



function mostrarModal(modelo = MODELO_BASE) {
    $("#txtId").val(modelo.idFormInterIngre)

    $("#txtnombPersona").val(modelo.nombPersona)
    $("#txtapePersona").val(modelo.apePersona)
    $("#txtfechaIng").val(modelo.fechaIng?.substring(0, 10))
    $("#txtdniPersona").val(modelo.dniPersona)
    $("#txtareaPersona").val(modelo.areaPersona)
    $("#txtcargPersona").val(modelo.cargPersona)

    $("#chkTipoPuesto").prop("checked", modelo.tipoPuesto == 0)
    $("#chkHardwLapt").prop("checked", modelo.hardwlapt == 0)
    $("#chkHardwCompu").prop("checked", modelo.hardwcompu == 0)
    $("#chkHardwCel").prop("checked", modelo.hardwcel == 0)
    $("#chkSoftOffice").prop("checked", modelo.softoffice == 0)
    $("#chkSoftAntiv").prop("checked", modelo.softAntiv == 0)
    $("#chkSoftAdob").prop("checked", modelo.softadob == 0)
    $("#chkSoftCorr").prop("checked", modelo.softcorr == 0)
    $("#chkSoftSys").prop("checked", modelo.softsys == 0)
    $("#chkSoftFlex").prop("checked", modelo.softflex == 0)

    $("#txtObservacion").val(modelo.observacion)
    $("#cboEstado").val(modelo.estado)
    $("#txtUsuario").val(modelo.usuario)

    $("#modalData").modal("show")
}


$("#btnNuevo").click(function () {
    mostrarModal()
})


$("#btnGuardar").click(function () {


    const inputs = $("input.input-validar").serializeArray();
    const inputs_sin_valor = inputs.filter((item) => item.value.trim() == "")

    if (inputs_sin_valor.length > 0) {
        const mensaje = `Debe completar el campo : "${inputs_sin_valor[0].name}"`;
        toastr.warning("", mensaje)
        $(`input[name="${inputs_sin_valor[0].name}"]`).focus()
        return;
    }

    const modelo = structuredClone(MODELO_BASE);

    modelo["idFormInterIngre"] = parseInt($("#txtId").val())
    modelo["nombPersona"] = $("#txtnombPersona").val()
    modelo["apePersona"] = $("#txtapePersona").val()
    modelo["fechaIng"] = $("#txtfechaIng").val() || null
    modelo["dniPersona"] = $("#txtdniPersona").val()
    modelo["areaPersona"] = $("#txtareaPersona").val()
    modelo["cargPersona"] = $("#txtcargPersona").val()

    modelo["tipoPuesto"] = $("#chkTipoPuesto").prop("checked") ? 1 : 0
    modelo["hardwlapt"] = $("#chkHardwLapt").prop("checked") ? 1 : 0
    modelo["hardwcompu"] = $("#chkHardwCompu").prop("checked") ? 1 : 0
    modelo["hardwcel"] = $("#chkHardwCel").prop("checked") ? 1 : 0
    modelo["softoffice"] = $("#chkSoftOffice").prop("checked") ? 1 : 0
    modelo["softAntiv"] = $("#chkSoftAntiv").prop("checked") ? 1 : 0
    modelo["softadob"] = $("#chkSoftAdob").prop("checked") ? 1 : 0
    modelo["softcorr"] = $("#chkSoftCorr").prop("checked") ? 1 : 0
    modelo["softsys"] = $("#chkSoftSys").prop("checked") ? 1 : 0
    modelo["softflex"] = $("#chkSoftFlex").prop("checked") ? 1 : 0

    modelo["observacion"] = $("#txtObservacion").val()
    modelo["estado"] = $("#cboEstado").val()
    modelo["usuario"] = $("#txtUsuario").val()


    $("#modalData").find("div.modal-content").LoadingOverlay("show");

    if (modelo.idFormInterIngre == 0) {


        fetch("/FormInterIngre/Crear", {
            method: "POST",
            headers: { "Content-Type": "application/json; charset=utf-8" },
            body: JSON.stringify(modelo)
        })
            .then(response => {
                $("#modalData").find("div.modal-content").LoadingOverlay("hide");
                return response.ok ? response.json() : Promise.reject(response);
            })
            .then(responseJson => {

                if (responseJson.estado) {

                    tablaData.row.add(responseJson.objeto).draw(false)
                    $("#modalData").modal("hide")
                    swal("Listo!", "El registro fue creado", "success")
                } else {
                    swal("Los sentimos", responseJson.mensaje, "error")
                }
            })
    } else {
        fetch("/FormInterIngre/Editar", {
            method: "PUT",
            headers: { "Content-Type": "application/json; charset=utf-8" },
            body: JSON.stringify(modelo)
        })
            .then(response => {
                $("#modalData").find("div.modal-content").LoadingOverlay("hide");
                return response.ok ? response.json() : Promise.reject(response);
            })
            .then(responseJson => {

                if (responseJson.estado) {

                    tablaData.row(filaSeleccionada).data(responseJson.objeto).draw(false);
                    filaSeleccionada = null;
                    $("#modalData").modal("hide")
                    swal("Listo!", "La registro fue modificada", "success")
                } else {
                    swal("Los sentimos", responseJson.mensaje, "error")
                }
            })

    }


})

let filaSeleccionada;
$("#tbdata tbody").on("click", ".btn-editar", function () {

    if ($(this).closest("tr").hasClass("child")) {
        filaSeleccionada = $(this).closest("tr").prev();
    } else {
        filaSeleccionada = $(this).closest("tr");
    }

    const data = tablaData.row(filaSeleccionada).data();

    mostrarModal(data);

})

$('#tbdata tbody').on('click', '.btn-visualizar', function () {
    const fila = tablaData.row($(this).closest('tr')).data();
    if (fila) {
        const url = `/Impresion/ImprimirFormato?idforminteringre=${fila.idFormInterIngre}`;
        window.open(url, '_blank');
    }
});


//let filaSeleccionada_2;
//$("#tbdata tbody").on("click", ".btn-visualizar", function () {

//    if ($(this).closest("tr").hasClass("child")) {
//        filaSeleccionada_2 = $(this).closest("tr").prev();
//    } else {
//        filaSeleccionada_2 = $(this).closest("tr");
//    }

//    const data = tablaData.row(filaSeleccionada_2).data();

//    mostrarModal(data);

//})

$("#tbdata tbody").on("click", ".btn-eliminar", function () {

    let fila;
    if ($(this).closest("tr").hasClass("child")) {
        fila = $(this).closest("tr").prev();
    } else {
        fila = $(this).closest("tr");
    }

    const data = tablaData.row(fila).data();

    swal({
        title: "¿Está seguro?",
        text: `Eliminar el registro "${data.nombPersona}"`,
        type: "warning",
        showCancelButton: true,
        confirmButtonClass: "btn-danger",
        confirmButtonText: "Si, eliminar",
        cancelButtonText: "No, cancelar",
        closeOnConfirm: false,
        closeOnCancel: true
    },
        function (respuesta) {

            if (respuesta) {

                $(".showSweetAlert").LoadingOverlay("show");

                fetch(`/FormInterIngre/Eliminar?idFormInterIngre=${data.idFormInterIngre}`, {
                    method: "DELETE"
                })
                    .then(response => {
                        $(".showSweetAlert").LoadingOverlay("hide");
                        return response.ok ? response.json() : Promise.reject(response);
                    })
                    .then(responseJson => {

                        if (responseJson.estado) {

                            tablaData.row(fila).remove().draw()

                            swal("Listo!", "El registro fue eliminado", "success")
                        } else {
                            swal("Los sentimos", responseJson.mensaje, "error")
                        }
                    })


            }
        }
    )


})






