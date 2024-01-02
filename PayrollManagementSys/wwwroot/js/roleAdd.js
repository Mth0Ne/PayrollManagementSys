$(document).ready(function () {
    $('#btnSave').click(function (event) {
        event.preventDefault();

        var addUrl = app.Urls.roleAddUrl;
        var redirectUrl = app.Urls.employeeAddUrl;

        var AppRole = {
            Name: $("input[id=roleName]").val()
        }

        var jsonData = JSON.stringify(AppRole);
        console.log(jsonData);

        $.ajax({
            url: addUrl,
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataTyoe = "json",
            data: jsonData,
            success: function (data) {
                setTimeout(function () {
                    window.location.href = redirectUrl;

                }, 1500);

            },
            error: function () {
                toast.error("Bir hata oluştu", "Hata");
            }
        });
    });
});