/*CURD Operation
 * @Author: Amit Kumar
 * MVC  CURD Operation for ASP .Net Core using JS 
*/

//helper functions
//Web Operations

//const host = "https://localhost:44335/";
//const uri = `${host}api/Stores`;

function objectifyForm(formArray) {
    //serialize data function
    var returnArray = {};
    for (var i = 0; i < formArray.length; i++) {
        returnArray[formArray[i]['name']] = formArray[i]['value'];
    }
    return returnArray;
}

$.fn.formToJson = function () {
    var a = this.serializeArray();
    //console.log(a);
    var aa = {};
    var lastName = "";
    for (var i = 0; i < a.length; i++) {
        if (a[i]['name'] != lastName) {
            aa[a[i]['name']] = a[i]['value'];
           // console.log(a[i]['name'] + ":" + a[i]['value']);
        }
        //else {
        //    console.log(a[i]['name'] + ":" + a[i]['value']);
        //    console.log("Check Box Encoutered");
        //}
        lastName = a[i]['name'];
    }
    return JSON.stringify(aa);

};
$.fn.serializeObject = function () {
    var o = {};
    var a = this.serializeArray();
    $.each(a, function () {
        if (o[this.name]) {
            if (!o[this.name].push) {
                o[this.name] = [o[this.name]];
            }
            o[this.name].push(this.value || '');
        } else {
            o[this.name] = this.value || '';
        }
    });
    return o;
};
//init function to show modals
$(function () {

    $.ajaxSetup({ cache: false });
    $(document).on('click', 'a[data_modal]', function (e) {
        if (this.id == "edit") {
            $("#myModalLabel").html("Edit Items");
            $("modalHead").removeClass("model-success model-primary model-info");
            $("#modalHead").addClass("modal-warning");
        }
        else if (this.id == "detail") {
            $("#myModalLabel").html("Detail Items");
            $("modalHead").removeClass("model-warning model-primary model-info");
            $("#modalHead").addClass("modal-success");
        }
        else if (this.id == "create") {
            $("#myModalLabel").html("Create Items");

            $("modalHead").removeClass("model-success model-warning model-info");
            $("#modalHead").addClass("modal-primary");
        }
        else if (this.id == "delete") {
            $("#myModalLabel").html("Delete Items");

            $("modalHead").removeClass("model-success model-primary model-warning");
            $("#modalHead").addClass("modal-info");
        }
        $('#myModalContent').load(this.href, function () {
            $('#myModal').modal({
                keyboard: true
            }, 'show');
        });
        return false;
    });
});



// Add Function
function addData(formName, activityName, uri) {

    var newData = $(`#${formName}`).formToJson();
    fetch(uri, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: newData
    })
        .then(response => {
            if (response.ok) toastr.success(`New ${activityName} is Added Successfuly.`);
            else toastr.error(`Sorry!, Failed to add new ${activityName}.`);
           
        })
        .then(() => {

            location.reload();
        })
        .catch(error => {
            console.error(error); toastr.error(`Sorry!, Failed to add new ${activityName}.\n Error: ${error}`);
        });

}

//edit function

function updateData(formName, activityName, uri, id) {

    var updateFormData = $(`#${formName}`).formToJson();

    console.log(updateFormData);
    //var id = $(`#${idName}`).val();
    console.log(uri);
    fetch(`${uri}/${id}`, {
        method: 'PUT',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: updateFormData
    })
        .then(() => toastr.success(`${activityName} Details is saved!`))
        .then(() => location.reload())
        .catch(error => toastr.error("Unable to update item. :" + error));
    return false;

}

//delete function
function deleteModal(activityName, uri, id) {
    $('#delButton').attr('onClick', `deleteData('${activityName}', '${uri}', ${id})`);
    $('#deleteModal').modal({
        keyboard: true
    }, 'show');

}

function deleteData(activityName, uri, id) {
   
    fetch(`${uri}/${id}`, {
        method: 'DELETE'
    })
        .then(() => {
            toastr.success(`${activityName} is deleted Successfully!`);
            $('#deleteModal').modal('dispose');
        })
        .then(() => location.reload())
        .catch(error => toastr.error("Unable to delete due to error : " + error));

}

//function for displaying datatable

function initDataTable(datatableID) {
    var table = $(`#${datatableID}`).dataTable({
        "pagingType": "full_numbers",
        columnDefs: [{
            orderable: false,
            className: 'select-checkbox select-checkbox-all',
            targets: 0
        }],
        select: {
            style: 'multi',
            selector: 'td:first-child'
        },
        initComplete: function () {
            this.api().columns().every(function () {
                var column = this;
                var search = $(`<input class="form-control form-control-sm" type="text" placeholder="Search">`)
                    .appendTo($(column.footer()).empty())
                    .on('change input', function () {
                        var val = $(this).val()

                        column
                            .search(val ? val : '', true, false)
                            .draw();
                    });

            });
        }
    });
    $('input.search').val('');
    return table;
}

//get functions

function getItems(uri) {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => toastr.error('Unable to get items.', error));
}
function getItem(uri,id) {
    fetch(`${uri}/${id}`)
        .then(response => response.json())
        .then(data => _displayItems(data))
        .catch(error => toastr.error('Unable to get items.', error));
}