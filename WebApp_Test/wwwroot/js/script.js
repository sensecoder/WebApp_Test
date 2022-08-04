function getSelectedMessagesIds() {
    let messages = document.getElementsByClassName("message");
    let selectedMessages = [];
    for (message of messages) {
        if (message.checked) {
            selectedMessages.push(message.id);
        }
    }
    return selectedMessages;
}

function onDeleteSelected() {
    let action = document.forms["deletingForm"].action;
    //alert("almost deleted! " + action);
    const xhttp = new XMLHttpRequest();
    const list = getSelectedMessagesIds();
    if (list.length == 0) {
        return false;
    }
    //alert(list);
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            location.reload();
        }
    }   
    xhttp.open("POST", action);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send(JSON.stringify(list));
}
