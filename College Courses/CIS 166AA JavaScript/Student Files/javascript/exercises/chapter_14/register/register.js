var reset_error = function ( field ) {
    $(field + "_error").className = "";
    if ( "message" in fields[field] ) {
        $(field + "_error").firstChild.nodeValue =
            fields[field].message;
    } else {
        $(field + "_error").firstChild.nodeValue = "";
    }
}

var clear_error = function ( field ) {
    $(field + "_error").className = "";
    $(field + "_error").firstChild.nodeValue = "";
}

var register_click = function () {
    $("register").blur();
    var has_errors = false;
    for ( var field in fields ) {
        clear_error(field);
        if ( "validate" in fields[field] ) {
            try {
                fields[field].validate();
            } catch (error) {
                has_errors = true;
                $(field + "_error").className = "error";
                $(field + "_error").firstChild.nodeValue = error.message;
            }
        }
    }
    if ( has_errors ) {
        alert("Please correct the errors on the page.");
    } else {
        $("registration_form").submit();
    }
}

var reset_form_click = function () {
    $("reset_form").blur();
    $("registration_form").reset();
    for ( var field in fields ) {
        reset_error(field);
    }
}

window.onload = function () {
    $("register").onclick = register_click;
    $("reset_form").onclick = reset_form_click;
}