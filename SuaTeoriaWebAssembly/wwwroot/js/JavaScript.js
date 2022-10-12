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



function buscaImagem(conteudo) {
    // criando um HTML com outros elementos, inclusive uma imagem que não tem src com Base 64
    const string = `<img src="data:image/jpeg;base64,iVBORw0KGgoAAAANSUhEUgAAAakAAACYCAYAAABefRbnAAAgAElEQVR4AeydBXRcR7KG9+2+t2/hBTeJ4zh2bAccO2ZmZmZmZmYZZGZmkJmZmZmZSZJl5sSB3ay99c5Xo55cT2RbcgQzSuscnTtzp2/f7urqou7+6w/fBV+TkSuQmCC" alt="">
<p>outra tag</p>
<img src="nao_sou_base64.png">
<img src="data:image/jpeg;base64,FqT8XomvHz8iASWKq5HEADIS7dqmlRQvWEC2rVj6GHjxW6uG9eW111+X2J/ElLffekv+d+PKE2VwdNtmefPNN2Xp9zOfeI2/dmCC" alt="">`;

    // cria o template e coloca a string nele
    const template = document.createElement('template');
    template.innerHTML = conteudo;
    // pega as imagens que tem src com Base 64 e troca para o valor default
    const uri = "http://localhost:5285/uploadimage";
    for (const img of template.content.querySelectorAll('img[src^="data:image/jpeg;base64,"]')) {
        fetch(uri, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: img
        })
            .then(response => response.json())
            .then(() => {
                getItems();
                addNameTextbox.value = '';
            })
            .catch(error => console.error('Unable to add item.', error));
    }





    return "";
}