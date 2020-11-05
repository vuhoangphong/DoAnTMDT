$("#TrangThai").change(function () {
    var row = $(this).closest("tr");
    var maDDH = row.find("#maDDH").text();
    var idTracking = $("#TrangThai").val();
    $.ajax({
        url: "/Admin/Home/ThayDoiTrangThaiDonHang",
        data: JSON.stringify({ maDDH: parseInt(maDDH), id: idTracking }),
        type: "POST",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        success: function (result) {
            if (result > 0) {
                alert("Cập Nhật Thành Công");
            } else {
                alert("Cập Nhật Thất Bại");
            }
        },
        error: function (errormessage) {
            alert(errormessage.responseText);
        }
    });
})