function noClick(no) {
    var inputNo = document.getElementById("inputNo");
    inputNo.value = inputNo.value.toString() + no.toString();
}

function clearNo() {
    var inputNo = document.getElementById("inputNo");
    inputNo.value = '';
}