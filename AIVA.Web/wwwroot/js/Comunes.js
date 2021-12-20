//$.fn.dataTable.Buttons.defaults.dom.button.className = 'btn btn-white btn-sm';

function EstableceIdiomaDatePicker() {
    $.fn.datepicker.dates['es'] = {
        days: ["Domingo", "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado"],
        daysShort: ["Dom", "Lun", "Mar", "Mié", "Jue", "Vie", "Sáb"],
        daysMin: ["Do", "Lu", "Ma", "Mi", "Ju", "Vi", "Sá"],
        months: ["Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"],
        monthsShort: ["Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"],
        today: "Hoy",
        clear: "Borrar",
        format: "dd/mm/yyyy",
        titleFormat: "MM yyyy", /* Leverages same syntax as 'format' */
        weekStart: 0
    };
}

function InicializarDatePickerDefault() {
    EstableceIdiomaDatePicker();

    $('.date-picker-default .input-group.date').datepicker({
        todayBtn: "linked",
        keyboardNavigation: false,
        forceParse: false,
        calendarWeeks: true,
        autoclose: true,
        format: "dd/mm/yyyy",
        language: "es"
    });
}

function InicializarDatePickerMensual(endDate) {
    EstableceIdiomaDatePicker();

    $('.datepircker').datepicker({
        todayBtn: false,
        keyboardNavigation: false,
        forceParse: false,
        calendarWeeks: true,
        autoclose: true,
        format: "mm/yyyy",
        language: "es",
        viewMode: "months",
        minViewMode: "months",
        endDate: endDate,
        maxDate: endDate
    });
}

function InicializarDataTableDefault() {
    $(".DataTableDefault").DataTable({
        paging: true,
        filter: true,
        buttons: [{}],
        lengthMenu: [25, 50, 75, 100],
        DisplayLength: 25,
        pageLength: 25,
        language: {
            buttons: {
                pageLength: "Mostrar _MENU_ registros",
                print: "Imprimir"
            },
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros por página",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": ">>",
                "sPrevious": "<<"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
    });
}

function InicializarDataTableDefaultBotonesExportar(exportFileName) {
    $.fn.dataTable.Buttons.defaults.dom.button.className = 'btn btn-white btn-sm margen-sup-botones';
    $(".DataTableDefaultExportButtons").css("width", "100%");
    var table = $(".DataTableDefaultExportButtons").DataTable({
        dom: '<"html5buttons"B>lft<"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        paging: true,
        filter: true,
        lengthMenu: [25, 50, 75, 100],
        DisplayLength: 25,
        pageLength: 25,
        buttons: [
            { extend: 'excel', title: exportFileName },
            { extend: 'pdf', title: exportFileName },

            {
                extend: 'print',
                customize: function (win) {
                    $(win.document.body).addClass('white-bg');
                    $(win.document.body).css('font-size', '10px');

                    $(win.document.body).find('table')
                        .addClass('compact')
                        .css('font-size', 'inherit');
                }
            }
        ],
        language: {
            buttons: {
                pageLength: "Mostrar _MENU_ registros",
                print: "Imprimir"
            },
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros por página",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": ">>",
                "sPrevious": "<<"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
    });

    return table;
}

function InicializarDataTableDefaultBotonesExportarPorIdTabla(exportFileName, IdTabla) {
    $.fn.dataTable.Buttons.defaults.dom.button.className = 'btn btn-white btn-sm margen-sup-botones';
    $("#" + IdTabla).css("width", "100%");
    var table = $("#" + IdTabla).DataTable({
        dom: '<"html5buttons"B>lft<"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        paging: true,
        filter: true,
        lengthMenu: [25, 50, 75, 100],
        DisplayLength: 25,
        pageLength: 25,
        buttons: [
            { extend: 'excel', title: exportFileName },
            { extend: 'pdf', title: exportFileName },

            {
                extend: 'print',
                customize: function (win) {
                    $(win.document.body).addClass('white-bg');
                    $(win.document.body).css('font-size', '10px');

                    $(win.document.body).find('table')
                        .addClass('compact')
                        .css('font-size', 'inherit');
                }
            }
        ],
        language: {
            buttons: {
                pageLength: "Mostrar _MENU_ registros",
                print: "Imprimir"
            },
                      
            "pageLength": 25,
            "sProcessing": "Procesando...",
            "sLengthMenu": "Mostrar _MENU_ registros por página",
            "sZeroRecords": "No se encontraron resultados",
            "sEmptyTable": "Ningún dato disponible en esta tabla",
            "sInfo": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "sInfoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sInfoPostFix": "",
            "sSearch": "Buscar:",
            "sUrl": "",
            "sInfoThousands": ",",
            "sLoadingRecords": "Cargando...",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": ">>",
                "sPrevious": "<<"
            },
            "oAria": {
                "sSortAscending": ": Activar para ordenar la columna de manera ascendente",
                "sSortDescending": ": Activar para ordenar la columna de manera descendente"
            }
        }
    });

    return table;
}

class Pila {
    elementos = [];

    push = (elemento) => {
        return this.elementos.push(elemento);
    }
    pop = () => {
        return this.elementos.pop();
    }
    isempty = () => {
        return this.elementos.length === 0;
    }
    empty = () => {
        this.elementos.length = 0;
    }
    size = () => {
        return this.elementos.length;;
    }
    getLastElement = () => {
        var elemento = this.elementos.pop();
        this.elementos.push(elemento);
        return elemento;
    }
}

//Remueve un string al final de otro
function RemoveString(cadena, strRemover) {
    var auxStr = '';
    for (var i = (cadena.length - 1); i >= 0; i--) {
        auxStr = cadena[i] + auxStr;
        if (auxStr === strRemover) {
            if (i === 0) {
                return '';
            }
            else {
                return cadena.substring(0, i);
            }
        }
    }
}