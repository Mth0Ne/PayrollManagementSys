$(function () {
    var totalEmployeeUrl = app.Urls.totalEmployeeUrl;
    var totalDepartmanUrl = app.Urls.totalDepartmanUrl;

    // AJAX request for total employee count
    $.ajax({
        type: "GET",
        url: totalEmployeeUrl,
        dataType: "json",
        success: function (data) {
            $("h6#totalEmployeeCount").append(data);
        },
        error: function () {
            toastr.error("Toplam çalışan sayısı yüklenirken hata oluştu", "Hata");
        }
    });

    $.ajax({
        type: "GET",
        url: totalDepartmanUrl,
        dataType: "json",
        success: function (data) {
            $("h6#totalDepartmanCount").append(data);
        },
        error: function () {
            toastr.error("Toplam departman sayısı yüklenirken hata oluştu", "Hata");
        }
    });

    // AJAX request for average salary by department
    $.ajax({
        type: "POST",
        url: 'Dashboard/GetAvarageSalaryByDepartman',
        data: JSON.stringify({}),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            var dataPoints = json; // Assuming the returned JSON is an array of data points

            // Render chart
            var chart = new CanvasJS.Chart("avarageSalaryByDepartman", {
                animationEnabled: true,
                theme: "light2",
                exportEnabled: true,
                title: {
                    text: "Medals Won by Few Countries - 2016 Summer Olympics"
                },
                data: [{
                    type: "column",
                    dataPoints: dataPoints
                }]
            });
            chart.render();
        },
        error: function () {
            toastr.error("Avarage salary yüklenirken hata oluştu", "Hata");
        }
    });
});
