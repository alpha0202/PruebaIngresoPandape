// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



window.onload = function () {
    ListCandidates();
}

function ListCandidates() {
    pintar({
        url: "Candidate/GetCandidates",
        cabeceras: ["Name", "Sur Name", "Birth Date", "Email",],
        propiedades: ["Name", "SurName", "BirthDate", "Email"],
        propiedadId: "Id",
        editar: true,
        eliminar: true,
        urleliminar: "Candidate/DeleteCandidate",
        nombreParametroEliminar: "Id",
        popup: true,
        titlePopup:"New Candidate"
    },
        {
            url: "Candidate/GetDetailCandidate",
            formulario: [
                [
                    {
                        class: "col-md-6",
                        label: "Search by Id",
                        type: "text",
                        name: "id"


                    }

                ]
            ]
        },
        {
            type: "popup",
            urlRecuperar: "Candidate/GetDatailCandidates",
            parametroRecuperar: "Id",
            formulario: [
                [
                    {
                        class: "col-md-6",
                        label: "Name",
                        type: "text",
                        name: "Name"
                    },
                    {
                        class: "col-md-6",
                        label: "Sur Name",
                        type: "text",
                        name: "SurName"
                    },
                    {
                        class: "col-md-6",
                        label: "Birth Date",
                        type: "date",
                        name: "BirthDate"
                    },
                    {
                        class: "col-md-6",
                        label: "Email",
                        type: "text",
                        name: "Email"
                    }
                ]
            ]
        }

    )
}

