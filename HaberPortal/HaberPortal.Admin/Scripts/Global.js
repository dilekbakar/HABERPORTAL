function KategoriEkle() {
    Kategori = new Object();
    //Kategori.Select = $("#kategoriSelect").val();
    Kategori.KategoriAdi = $("#kategoriAdi").val();
    Kategori.Url = $("#kategoriUrl").val();
    Kategori.AktifMi = $("#kategoriAktif").is(":checked");

    $.ajax({
        url: "/Kategori/Ekle",
        data: Kategori,
        type: "POST",
        dataType: 'json',
        success: function (response) {
            if (response.Success) {
                bootbox.alert(response.Message, function () {
                    location.reload();
                });
            } else {
                bootbox.alert(response.Message, function () {
                    //geri döndüğünde birşey yapılması isteniyorsa buraya yazılır.
                });
            }
        }
    })
}