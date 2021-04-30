var $ = function (id) {
    return document.getElementById(id); 
}

var email_click = function () {
    var emailAddress = $("email").value;
    alert ( emailAddress );
}

var date_click = function () {
    var dateEntry = $("date").value;
	alert ( dateEntry );
}

window.onload = function () {
    $("processEmail").onclick = email_click;
	$("processDate").onclick = date_click;
}