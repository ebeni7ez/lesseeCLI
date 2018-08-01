// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function LeaseHardware() {
    var hardware = {
        platform: $('#platform').val(),
        duration: $('#duration').val(),
    }

    $.ajax({
        url: "http://localhost:5000/leases/",
        method: "POST",
        data: JSON.stringify(hardware),
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        statusCode: {
            400: function(error) {
                message = error['responseJSON']['message'];
                window.location.href = '/Home/Index?errorMsg=' + message;
            }
        },
        success: function(data) {
            message = "Hardware " + data[0]['hardware']['name'] + " with IP " + data[0]['hardware']['ip'] + " was leased succesfully.";
            window.location.href = '/Hardwares/Index?message=' + message;
        },
        error: function(error) {
            message = error['responseJSON']['message'];
            window.location.href = '/Home/Index?errorMsg=' + message;
        }
    })
}

function AddHardware() {
        jQuery.support.cors = true;
        var hardware = {
            name: $('#name').val(),
            platform: $('#platform').val(),
            ip: $('#ip').val(),
        }

        $.ajax({
            url: "http://localhost:5000/hardwares/",
            method: "POST",
            data: JSON.stringify(hardware),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function(data) {
                console.log(data);
                if (data.status == 200) {
                    message = "Hardware was added succesfully.";
                    window.location.href = '/Hardwares/Index?message=' + message;
                }
            },
            error: function(error) {
                message = error['responseJSON']['message'];
                window.location.href = '/Hardwares/Index?errorMsg=' + message;
            },
            statusCode: {
                400: function(error) {
                    message = error['responseJSON']['message'];
                    window.location.href = '/Hardwares/Index?errorMsg=' + message;
                }
            },
        })
}