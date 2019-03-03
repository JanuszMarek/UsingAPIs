function ChangePageValue(btn) {
    var button = btn.innerText;
    var page = document.getElementById("page").value = btn.innerText;
    //console.log(page);
    //document.getElementById("ajaxform").submit();

    var form = $('#ajaxform');
    console.log(form)
    var formData = $(form).serialize();
    console.log(formData)

    ajax = $.ajax(
        {
            type: 'POST',
            url: '/Pokemons/Home/Index/',
            data: formData,
        })

    //console.log(ajax.data)
}