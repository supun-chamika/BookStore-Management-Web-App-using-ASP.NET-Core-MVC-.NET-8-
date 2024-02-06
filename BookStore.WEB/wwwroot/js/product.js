var dataTable;

$(document).ready(function () {
    loadDataTable();
})

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        ajax: {url: '/admin/product/getall'},
        columns: [
            { data: 'title', "width":"25%" },
            { data: 'isbn', "width": "15%" },
            { data: 'listPrice', "width": "10%" },
            { data: 'author', "width": "15%" },
            { data: 'category.name', "width": "15%" },
            {
                data: 'id',
                "render": function (data) {
                    return `
                    <div class="button-group text-end" role="group">
                        <a href="/admin/product/upsert?id=${data}" class="btn btn-outline-primary mb-2 btn-sm">
                            <i class="bi bi-pencil-square"></i> Edit
                        </a>
                        <a Onclick=Delete("/admin/product/delete/${data}") class="btn btn-outline-danger mb-2 btn-sm">
                            <i class="bi bi-trash3-fill"></i> Delete
                        </a>
                    </div>`
                },
                "width": "20%"
            }
        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: "DELETE",
                success: function (data) {
                    dataTable.ajax.reload();
                    toastr.success(data.message);
                }
            })
        }
    });
}