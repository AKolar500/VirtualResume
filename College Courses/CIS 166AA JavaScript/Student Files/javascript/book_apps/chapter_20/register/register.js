dojo.require("dojo.parser");
dojo.require("dojo.data.ItemFileReadStore");
dojo.require("dijit.form.Form");
dojo.require("dijit.form.ValidationTextBox");
dojo.require("dojox.validate.regexp");
dojo.require("dojox.validate.creditCard");
dojo.require("dijit.form.FilteringSelect");
dojo.require("dijit.form.CheckBox");
dojo.require("dijit.form.Button");

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


dojo.addOnLoad( function () {
    stateList = new dojo.data.ItemFileReadStore({url: "states.txt"});
    dojo.parser.parse();
    dojo.connect( dijit.byId("state"), "reset", stateReset );
    dojo.query("[name=card_type]").forEach( function(element) {
        var button = dijit.byId( element.id );
        var card_number = dijit.byId("card_number");
        var card_cvv = dijit.byId("card_cvv");
        dojo.connect( button, "onChange", card_number, "validate" );
        dojo.connect( button, "onChange", card_cvv, "validate" );
    });
    dijit.byId("email").focus();
});