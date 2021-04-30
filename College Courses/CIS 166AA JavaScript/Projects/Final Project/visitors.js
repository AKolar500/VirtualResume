var $ = function (id) { return document.getElementById(id); }

//var email = $("email").value;

var addUser = function () {
	var email = $("email").value;
	//validate data
	if ( $("last_name").value != "" ) {
		if ( $("first_name").value != "" ) {
			if ( isEmail( email ) == true ) {
				if ( $("user_name").value != "" ) {
					if ( $("password").value != "" ) {
					
						// get the data from the form
						var userString = $("last_name").value + ", " + 
										  $("first_name").value + " at " + 
										  email + "\n" + "Username: " +
										  $("user_name").value + "\n" + "Password: " +
										  $("password").value;
						
						$("results").value = userString;
						
					} else {
						$("results").value = "Password is empty.";
					}
				} else {
					$("results").value = "User Name is empty.";
				}
			} else {
				$("results").value = "Email is invalid.";
			}
		} else {
			$("results").value = "First Name is empty.";
		}
	} else {
		$("results").value = "Last Name is empty.";
	}
	
}

//the isEmail function copied from the book
var isEmail = function ( email ) {
	if (email.length == 0) return false;
	var parts = email.split("@");
	
	if ( parts.length != 2 ) return false;
	if ( parts[0].length > 64 ) return false;
	if ( parts[1].length > 255 ) return false;
	
	var address = "(^[\\w!#$%&'*+/=?^`{|}~-]+(\\.[\\w!#$%&'*+/=?^`{|}~-]+)*$)";
	var quotedText = "(^\"(([^\\\\\"])|(\\\\[\\\\\"]))+\"$)";
	var localPart = new RegExp( address + "|" + quotedText );
	if ( !parts[0].match(localPart) ) return false;
	
	var hostnames = "(([a-zA-Z0-9]\\.)|([a-zA-Z0-9][-a-zA-Z0-9]{0,62}[a-zA-Z0-9]\\.))+";
	var tld = "[a-zA-Z0-9]{2,6}";
	var domainPart = new RegExp( "^" + hostnames + tld + "$" );
	if ( !parts[1].match(domainPart) ) return false;
	
	return true;
}

var clearFields = function () {
	email = "";
	
    $("last_name").value = "";
    $("first_name").value = "";
    $("email").value = "";
    $("user_name").value = "";
    $("password").value = "";
	
    $("results").value = "";
}

window.onload = function () {
    $("add_button").onclick = addUser;
    $("clear_button").onclick = clearFields;
}