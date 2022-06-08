function teste() {
    $(document).ready(function () {
        $('select').selectize({
            sortField: 'text'
        });
    });
}

function getHtml() {
    var htmlText = document.getElementById("textoTeoria").innerHTML;
    return htmlText;
}
