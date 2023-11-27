//$(document).ready(function () {

//    $("#btn-login").click(function () {

//        var form;

//        form = $(this).find('#pills-signin');
//        form = $(this).parents(".card").find('#pills-signin form');

//        var actionUrl = form.attr('action');
//        var dataToSend = new FormData(form.get(0));

//        //var data = {
//        //	"userid": $("#userid").val(),
//        //	"password": $("#password").val(),
//        //	"rememberme": $("#rememberme").prop("checked")
//        //};
//        $.ajax({
//            url: actionUrl,
//            type: "POST",
//            data: dataToSend,

//            processData: false,
//            contentType: false,
//            error: function () {
//                ShowSweetErrorAlert();
//            },


//        });
//    }).done(function (data) {
//        if (data.Success) {
//            console.log(data);
//            window.location.href = '/Admin/Dashboard/';
//        }
//        if (data == "success") {

//            console.log(data);
//            window.location.href = '/Admin/Dashboard/';
//        }

//    });
//});

$(document).ready(function () {

    $("#btn-login").click(function () {

        var form;

        form = $(this).find('#pills-signin');
        form = $(this).parents(".card").find('#pills-signin form');

        var actionUrl = form.attr('action');
        var dataToSend = new FormData(form.get(0));



        var actionUrl = form.attr('action');
        var dataToSend = new FormData(form.get(0));
        $.ajax({
            url: actionUrl, type: "post", data: dataToSend, processData: false, contentType: false, error: function () {
                ShowSweetErrorAlert();
            }
        }).done(function (data) {

            if (data == "success") {
                window.location.href = '/Admin/Dashboard/';
            }
            else if (data == "requiresTwoFactor") {
                alert("requires");
            }

            else {
                ShowSweetErrorAlert(data);
               /* $('#pills-signin').html($("#pills-signin", data));*/
            }

        });
    });

});


function ShowSweetSuccessAlert(message) {
    Swal.fire({
        position: 'top-middle',
        type: 'success',
        title: message,
        confirmButtonText: 'بستن',
    })
}

function ShowSweetErrorAlert() {
    Swal.fire({
        type: 'error',
        title: 'خطایی رخ داده است !',
        text: 'لطفا تا برطرف شدن خطا شکیبا باشید.',
        confirmButtonText: 'بستن'
    });
}

function ShowSweetErrorAlert(message) {
    Swal.fire({
        type: 'error',
        title: 'خطایی رخ داده است !!!',
        text: message,
        confirmButtonText: 'بستن'
    });
}

