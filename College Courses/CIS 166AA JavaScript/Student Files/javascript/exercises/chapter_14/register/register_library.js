var $ = function (id) { return document.getElementById(id); }

var fields = [];

// Define field objects
fields["email"] = {};
fields["password"] = {};
fields["verify"] = {};
fields["first_name"] = {};
fields["last_name"] = {};
fields["address"] = {};
fields["city"] = {};
fields["state"] = {};
fields["zip"] = {};
fields["phone"] = {};
fields["card_type"] = {};
fields["card_number"] = {};
fields["exp_date"] = {};

// Default field messages
fields["email"].message = "Must be a valid email address.";
fields["password"].message = "Must be at least 6 characters.";
fields["state"].message = "Use 2 character abbreviation.";
fields["zip"].message = "Use 5 or 9 digit ZIP code.";
fields["phone"].message = "Use 999-999-9999 format.";
fields["card_number"].message = "Use 1111-2222-3333-4444 format.";
fields["exp_date"].message = "Use mm/yyyy format.";

// Field errors
fields["email"].required = new Error("Email is required.");
fields["email"].invalid = new Error("Email is not valid.");

fields["password"].required = new Error("Password is required.");
fields["password"].too_short = new Error("Password is too short.");

fields["verify"].required = new Error("Please retype your password.");
fields["verify"].no_match = new Error("Passwords do not match.");

fields["first_name"].required = new Error("First name is required.");

fields["last_name"].required = new Error("Last name is required.");

fields["address"].required = new Error("Address is required.");

fields["city"].required = new Error("City is required.");

fields["state"].required = new Error("State is required.");
fields["state"].invalid = new Error("State is not valid.");

fields["zip"].required = new Error("ZIP Code is required.");
fields["zip"].invalid = new Error("ZIP Code is not valid.");

fields["phone"].required = new Error("Phone number is required.");
fields["phone"].invalid = new Error("Phone number is not valid.");

fields["card_type"].required = new Error("Please select a card type.");

fields["card_number"].required = new Error("Card number is required.");
fields["card_number"].invalid = new Error("Card number is not valid.");

fields["exp_date"].required = new Error("Expiration date is required.");
fields["exp_date"].invalid = new Error("Expiration date is not valid.");
fields["exp_date"].expired = new Error("Card has expired.");

// Field validation functions
fields["email"].validate = function () {
    var email = $("email").value;
    if (email.length == 0) throw this.required;
    
    var parts = email.split("@");
    if (parts.length != 2 ) throw this.invalid;
    if (parts[0].length > 64) throw this.invalid;
    if (parts[1].length > 255) throw this.invalid;
    
    var local_part = /^([-\w!#$%&'*+-/=?^`{|}~]+)|("[^"]*")$/;
    var local_dots = /(^\.)|(^[^"].*\.\..*[^"]$)|(\.$)/;
    if ( !parts[0].match(local_part) ) throw this.invalid;
    if (  parts[0].match(local_dots) ) throw this.invalid;
    
    var host_pattern =
        "(([a-zA-Z0-9])\\.|([a-zA-Z0-9][-a-zA-Z0-9]{0,62}[a-zA-Z0-9])\\.)+";
    var tld_pattern = "[a-zA-Z0-9]{2,6}";
    var domain = new RegExp("^" + host_pattern + tld_pattern + "$");
    if ( !parts[1].match(domain) ) throw this.invalid;
}

fields["password"].validate = function () {
    var password = $("password").value;
    if (password.length == 0) throw this.required;
    if (password.length < 6 ) throw this.too_short;
}

fields["verify"].validate = function () {
    var password = $("password").value;
    var verify = $("verify").value;
    if ( verify.length == 0 ) throw this.required;
    if ( verify != password ) throw this.no_match;
}

fields["first_name"].validate = function () {
    var first_name = $("first_name").value;
    if ( first_name.length == 0 ) throw this.required;
}

fields["last_name"].validate = function () {
    var last_name = $("last_name").value;
    if ( last_name.length == 0 ) throw this.required;
}

fields["address"].validate = function () {
    var address = $("address").value;
    if ( address.length == 0 ) throw this.required;
}

fields["city"].validate = function () {
    var city = $("city").value;
    if ( city.length == 0 ) throw this.required;
}

fields["state"].validate = function () {
    var states = new Array(
        "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "DC", "FL",
        "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME",
        "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH",
        "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI",
        "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY");
    
    $("state").value = $("state").value.toUpperCase();
    var state = $("state").value;
    
    if ( state == "" ) throw this.required;
    
    var valid = false;
    for( var i in states ) {
        if ( state == states[i] ) {
            valid = true;
            break;
        }
    }
    if ( !valid ) throw this.invalid;
}

fields["zip"].validate = function () {
    var zip = $("zip").value;
    if ( zip.length == 0 ) throw this.required;
    
    var zip_pattern = /^[\d]{5}(-[\d]{4})?$/;
    if ( !zip.match(zip_pattern) ) throw this.invalid;
}

fields["phone"].validate = function () {
    var phone = $("phone").value;
    if ( phone.length == 0 ) throw this.required;
    
    var phone_pattern = /^[\d]{3}-[\d]{3}-[\d]{4}$/;
    if ( !phone.match(phone_pattern) ) throw this.invalid;
}

fields["card_type"].validate = function () {
    var card_index = $("card_type").selectedIndex;
    if ( card_index == 0 ) throw this.required;
}

fields["card_number"].validate = function () {
    var card_number = $("card_number").value;
    if ( card_number.length == 0 ) throw this.required;
    
    var card_number_pattern = /^[\d]{4}-[\d]{4}-[\d]{4}-[\d]{4}$/;
    if ( !card_number.match(card_number_pattern) ) throw this.invalid;
}

fields["exp_date"].validate = function () {
    var exp_date = $("exp_date").value;
    if ( exp_date.length == 0 ) throw this.required;
    
    var date_pattern = /^[01]?[\d]\/[\d]{4}$/;
	alert ( exp_date.match(date_pattern) );                // testing
    if ( !exp_date.match(date_pattern) ) throw this.invalid;
    
    var date_parts = exp_date.split("/");
    var month = parseInt(date_parts[0]);
    var year = parseInt(date_parts[1]);
    if ( month < 1 || month > 12 ) throw this.invalid;
    
    var now = new Date();
    var exp = new Date( year, month);
    if ( now > exp ) throw this.expired;
}