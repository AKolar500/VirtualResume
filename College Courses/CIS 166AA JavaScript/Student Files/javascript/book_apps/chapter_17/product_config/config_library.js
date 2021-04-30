var $ = function (id) { return document.getElementById(id); }

var $setSpan = function (id, text) { $(id).firstChild.nodeValue = text; }

var getSelectedRadioButton = function ( groupName ) {
    var buttons = document.getElementsByName( groupName );
    if (buttons.length == 0) {
        throw new Error("No radio buttons found with name " + groupName);
    }
    for ( var i = 0; i <= buttons.length; i++ ) {
        if ( buttons[i].checked ) {
            return buttons[i];
        }
    }
    button[0].checked = true;
    return button[0];
}

var ConfigForm = function () {
    this.baseCost = 145;        // Cost of other hardware
    this.processorCost = [ 125, 190, 200, 245 ];

    this.opticalCost = [
        [ 25, 125, 200 ],       // First Optical Drive
        [ 0, 25, 125, 200 ]     // Second Optical Drive
    ];
    
    this.reset();
}

ConfigForm.prototype.priceText = function (currentPrice, newPrice) {
    var difference = newPrice - currentPrice;
    var action = ( difference > 0 ) ? "Add" : "Subtract";
    difference = Math.abs(difference);
    return " (" + action + " $" + difference.toFixed(2) + ")";
}

ConfigForm.prototype.processorClick = function () {
    var choice = parseInt(getSelectedRadioButton("proc").value);
    var buttons = document.getElementsByName("proc");
    var index, value, text;
    for ( index = 0; index < buttons.length; index++ ) {
        value = buttons[index].value;
        if ( value == choice ) {
            text = "(Included)";
        } else {
            text = this.priceText(this.processorCost[choice],
                                  this.processorCost[value]);
        }
        $setSpan( "proc" + value + "_cost", text );
    }
    this.updateForm();
}

ConfigForm.prototype.opticalChange = function () {
    var choice = parseInt($("optical0").value);
    var options = $("optical0").options;
    var index, option, value, text;
    for( index = 0; index < options.length; index++ ) {
        option = options[index];
        value = option.value;
        text = option.text.replace( / \(.*$/ , "" );
        if ( value == choice ) {
            text += " (Included)";
        } else {
            text += this.priceText(this.opticalCost[0][choice],
                                   this.opticalCost[0][value]);
        }
        option.text = text;
    }
    
    choice = parseInt($("optical1").value);
    options = $("optical1").options;
    for( index = 0; index < options.length; index++ ) {
        option = options[index];
        value = option.value;
        text = option.text.replace( / \(.*$/ , "" );
        if ( value == choice ) {
            text += " (Included)";
        } else {
            text += this.priceText(this.opticalCost[1][choice],
                                   this.opticalCost[1][value]);
        }
        option.text = text;
    }

    this.updateForm();
}

ConfigForm.prototype.showError = function ( error, groupName ) {
    if (error) {
        $setSpan(groupName + "_err", error);
        $(groupName + "_err_p").style.display = "block";
        return true;
    } else {
        $setSpan(groupName + "_err", "");
        $(groupName + "_err_p").style.display = "none";
        return false;
    }
}

ConfigForm.prototype.opticalValidate = function () {
    var error;
    var groupName = "optical";
    var choice0 = parseInt($("optical0").value);
    var choice1 = parseInt($("optical1").value);
    if ( choice1 > 0 && (choice1 - 1) > choice0 ) {
        error = 
            "First drive must be the same as or better than second drive.";
    }
    return this.showError( error, groupName );
}

ConfigForm.prototype.validateAll = function () {
    var error = false;
    error = this.opticalValidate();
    return error;
}

ConfigForm.prototype.updatePrice = function () {
    var proc = parseInt(getSelectedRadioButton("proc").value);
    var optical0 = parseInt($("optical0").value);
    var optical1 = parseInt($("optical1").value);
    
    var total = this.baseCost;
    total += this.processorCost[proc];
    total += this.opticalCost[0][optical0];
    total += this.opticalCost[1][optical1];

    $setSpan("system_cost", "$" + total.toFixed(2) );
}

ConfigForm.prototype.updateForm = function () {
    this.validateAll();
    this.updatePrice();
}

ConfigForm.prototype.reset = function () {
    this.processorClick();
    this.opticalChange();
    this.updateForm();
}