function post(url, dataObject) {
    var data = JSON.stringify(dataObject);

    $.ajax({
        type: "POST",
        url: url,
        data: data,
        contentType: "application/json"
    });
}