var inputNo = document.getElementById("inputNo");

function noClick(no) {
    inputNo.value = inputNo.value.toString() + no.toString();
}

function clearNo() {
    inputNo.value = '';
}

$('#confirmCard-btn').click(() => {

    if (inputNo.value == null || inputNo.value == '') {
        errorMessage("Card No is required.");
        return;
    }

    if (inputNo.value.length != 16) {
        errorMessage("Card No must have 16 digits.");
        return;
    }

    Notiflix.Loading.standard();
    $.ajax({
        url: '/home/loginatmcard',
        type: 'POST',
        data: {
            cardNo: inputNo.value
        },
        success: function (data) {
            if (!data.isSuccess) {

                setTimeout(() => {
                    Notiflix.Loading.remove();
                    errorMessage(data.message)
                    return;
                }, 2000)
            }
            if (data.isSuccess) {

                setTimeout(() => {
                    Notiflix.Loading.remove();
                    return successMessage(data.message, "/");
                    return;
                }, 2000)
            }
        },
        error: function (request, status, error) {
            Notiflix.Loading.remove();
            errorMessage(error);
            console.log({ request, status, error });
        }
    });
})