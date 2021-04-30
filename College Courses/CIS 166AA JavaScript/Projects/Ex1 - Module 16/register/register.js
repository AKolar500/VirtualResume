dojo.require("dojo.parser");
dojo.require("dojo.data.ItemFileReadStore");
dojo.require("dijit.form.Form");
dojo.require("dijit.form.ValidationTextBox");
dojo.require("dojox.validate.regexp");
dojo.require("dojox.validate.creditCard");
dojo.require("dijit.form.FilteringSelect");
dojo.require("dijit.form.CheckBox");
dojo.require("dijit.form.Button");
dojo.require("dojo.fx");

var stateList;

var matchValues = function ( value, constraints ) {
    var matchField = dijit.byId(constraints.matchId);
    if (matchField) {
        return this.attr("value") === matchField.attr("value");
    }
    return false;
}

var stateReset = function () {
    dijit.byId("state").attr("displayedValue", "");
}

var getRadioValue = function ( name ) {
    var value;
    dojo.query("[name=" + name + "]").forEach(function(element) {
        var button = dijit.byId(element.id);
        if ( button.attr("checked") ) value = button.attr("value");
    });
    return value;
}

var checkCardNumber = function ( value, constraints ) {
    var ccType;
    if ( constraints.ccTypeId ) {
        ccType = dijit.byId(constraints.ccTypeId).attr("value");
    } else if ( constraints.ccTypeName ) {
        ccType = getRadioValue( constraints.ccTypeName );
    } else {
        return false;
    }
    if (ccType) {
        return dojox.validate.isValidCreditCard(this.attr("value"), ccType);
    }
    return false;
}

var checkCardCVV = function ( value, constraints ) {
    var ccType;
    if ( constraints.ccTypeId ) {
        ccType = dijit.byId(constraints.ccTypeId).attr("value");
    } else if ( constraints.ccTypeName ) {
        ccType = getRadioValue( constraints.ccTypeName );
    } else {
        return false;
    }
    if (ccType) {
        return dojox.validate.isValidCvv(this.attr("value"), ccType);
    }
    return false;
}
 var checkExpirationDate = function ( value ) {
	// check for valid date pattern
	var datePattern = /^(0?[\d]|1[012])\/[\d]{4}$/;
	if ( !value.match(datePattern) ) return false;
	// parse month and year from entry
	var dateParts = value.split("/");
	var month = parseInt(dateParts[0]);
	var year = parseInt(dateParts[1]);
	// check for valid month value
	if (month < 1 || month > 12 ) return false;
	// check to make sure card hasn't expired
	var now = new Date();
	var exp = new Date (year,month);
	if (now > exp) return false;
	return true;
 }
 
 var submitButtonClick = function() {
	var registerForm = dijit.byId("register_form");
	if ( registerForm.isValid() ) {
		registerForm.submit();
		alert ("Your data has been submitted.");
	}
	else {
		alert ("Please fix the errors and resubmit the form.");
	}
 }
 
 var resetButtonClick = function() {
	dijit.byId("register_form").reset();
 }
 
 var flash = function(id) {
	var anim = [];
	var args = { node: id, duration: 1000 };
	for ( var i = 1; i <=3; i++ ) {
		anim.push( dojo.fadeOut( args ) );
		anim.push( dojo.fadeIn( args ) );
		dojo.fx.chain( anim ).play();
	}
 }

dojo.addOnLoad( function () {
    stateList = new dojo.data.ItemFileReadStore({url: "states.txt"});
    dojo.parser.parse();
    
	flash("register_form");

	dojo.connect( dijit.byId("state"), "reset", stateReset );
	dojo.connect( dijit.byId("submit_button"), "onClick", submitButtonClick );
	dojo.connect( dijit.byId("reset_button"), "onClick", resetButtonClick );
	
    dojo.query("[name=card_type]").forEach( function(element) {
        var button = dijit.byId( element.id );
        var card_number = dijit.byId("card_number");
        var card_cvv = dijit.byId("card_cvv");
        dojo.connect( button, "onChange", card_number, "validate" );
        dojo.connect( button, "onChange", card_cvv, "validate" );
    });
    
	dijit.byId("email").focus();
});