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

// Add this method
var setSelectedRadioButton = function ( groupName, value ) {
    var buttons = document.getElementsByName(groupName);
    for ( var i = 0; i <= buttons.length; i++ ) {
        if ( buttons[i].value == value ) {
            buttons[i].checked = true;
            return buttons[i];
        }
    }
}

var ConfigForm = function () {
    this.baseCost = 145;        // Cost of other hardware
    this.processorCost = [ 125, 190, 200, 245 ];
    this.memoryCost = [ 40, 70, 130 ];
    this.osCost = [ 100, 140, 230 ];

    // use as opticalCost[driveNum][type]
    this.opticalCost = [
        [ 25, 125, 200 ],       // First Optical Drive
        [ 0, 25, 125, 200 ]     // Second Optical Drive
    ];

    // use as hdCost[size][num]
    this.hdCost = [
        [ 65, 130, 185, 250 ],  // 500 GB
        [ 80, 160, 230, 300 ],  // 750 GB
        [ 125, 250, 350, 450 ]  // 1 TB
    ];

    // use as displayCost[size][num]
    this.displayCost = [
        [ 0, 120, 230 ],        // 19"
        [ 0, 180, 350 ],        // 22"
        [ 0, 250, 480 ]         // 24"
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

ConfigForm.prototype.memoryClick = function () {
    var choice = parseInt(getSelectedRadioButton("mem").value);
    var buttons = document.getElementsByName("mem");
    var index, value, text;
    for ( index = 0; index < buttons.length; index++ ) {
        value = buttons[index].value;
        if ( value == choice ) {
            text = "(Included)";
        } else {
            text = this.priceText(this.memoryCost[choice],
                                  this.memoryCost[value]);
        }
        $setSpan( "mem" + value + "_cost", text );
    }
    this.updateForm();
}

ConfigForm.prototype.osClick = function () {
    var choice = parseInt(getSelectedRadioButton("os").value);
    var buttons = document.getElementsByName("os");
    var index, value, text;
    for ( index = 0; index < buttons.length; index++ ) {
        value = buttons[index].value;
        if ( value == choice ) {
            text = "(Included)";
        } else {
            text = this.priceText(this.osCost[choice], 
                                  this.osCost[value]);
        }
        $setSpan( "os" + value + "_cost", text );
    }

    // Add this code
    if ( choice == 2) {
        setSelectedRadioButton("mem", 1);
        this.memoryClick();
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

ConfigForm.prototype.hdChange = function () {
    var hdNum = parseInt($("hd_num").value);
    var hdSize = parseInt($("hd_size").value);
    var hdRaid = parseInt($("hd_raid").value);
    
    var options = $("hd_num").options;
    var index, option, value, text;
    for( index = 0; index < options.length; index++ ) {
        option = options[index];
        value = option.value;
        text = option.text.replace( / \(.*$/ , "" );
        if ( value == hdNum ) {
            text += " (Included)";
        } else {
            text += this.priceText(this.hdCost[hdSize][hdNum],
                                   this.hdCost[hdSize][value]);
        }
        option.text = text;
    }
    
    options = $("hd_size").options;
    for( index = 0; index < options.length; index++ ) {
        option = options[index];
        value = option.value;
        text = option.text.replace( / \(.*$/ , "" );
        if ( value == hdSize ) {
            text += " (Included)";
        } else {
            text += this.priceText(this.hdCost[hdSize][hdNum],
                                   this.hdCost[value] [hdNum]);
        }
        option.text = text;
    }

    var sizes = [ 500, 750, 1000 ];
    var size = sizes[hdSize];
    var num = hdNum + 1;
    var total;
    switch ( hdRaid ) {
        case 2: total = ( size * num ) / 2; break;
        case 3: total = size * (num - 1); break;
        default: total = size * num; break;
    }
    if ( total >= 1000 ) {
        $("hd_total").value = (total/1024).toFixed(1) + " TB";
    } else {
        $("hd_total").value = total.toFixed(0) + " GB";
    }

    this.updateForm();
}

ConfigForm.prototype.displayChange = function () {
    var displayNum = parseInt($("display_num").value);
    var displaySize = parseInt($("display_size").value);
    
    var options = $("display_num").options;
    var index, option, value, text;
    for( index = 0; index < options.length; index++ ) {
        option = options[index];
        value = option.value;
        text = option.text.replace( / \(.*$/ , "" );
        if ( value == displayNum ) {
            text += (displayNum == 0) ? " (No Charge)" : " (Included)";
        } else {
            text += this.priceText(
                this.displayCost[displaySize][displayNum],
                this.displayCost[displaySize][value]);
        }
        option.text = text;
    }
    
    options = $("display_size").options;
    if ( displayNum == 0 ) {
        for( index = 0; index < options.length; index++ ) {
            options[index].text = options[index].text.replace( / \(.*$/ , "" );
        }
        $("display_size").disabled = true;
    } else {
        $("display_size").disabled = false;
        for( index = 0; index < options.length; index++ ) {
            option = options[index];
            value = option.value;
            text = option.text.replace( / \(.*$/ , "" );
            if ( value == displaySize ) {
                text += " (Included)";
            } else {
                text += this.priceText(
                    this.displayCost[displaySize][displayNum],
                    this.displayCost[value]      [displayNum]);
            }
            option.text = text;
        }
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

ConfigForm.prototype.osValidate = function () {
    var error;
    var groupName = "os";
    var osValue = parseInt(getSelectedRadioButton("os").value);
    if ( osValue == 2 ) {
        var memValue = parseInt(getSelectedRadioButton("mem").value);
        if ( memValue < 1 ) {
            error = "Premium OS requires at least 4 GB of memory.";
        }
    }
    return this.showError( error, groupName );
}

ConfigForm.prototype.opticalValidate = function () {
    var error;
    var groupName = "optical";
    var choice0 = parseInt($("optical0").value);
    var choice1 = parseInt($("optical1").value);
    if ( choice1 > 0 && (choice1 - 1) > choice0 ) {
        error = "First drive must be the same as or better than second drive.";
    }
    return this.showError( error, groupName );
}

ConfigForm.prototype.hdValidate = function () {
    var error;
    var groupName = "hd";
    var hdRaid = parseInt($("hd_raid").value );
    var hdNum = parseInt($("hd_num").value) + 1;
    switch ( hdRaid ) {
        case 1:
            if ( hdNum != 2 && hdNum != 4 ) {
                error = "For RAID 0 you must select 2 or 4 drives.";
                $("hd_total").value = "";
            }
            break;
        case 2:
            if ( hdNum != 2 && hdNum != 4 ) {
                error = "For RAID 1 you must select 2 or 4 drives.";
                $("hd_total").value = "";
            }
            break;
        case 3:
            if ( hdNum < 3 ) {
                error = "For RAID 5 you must select at least 3 drives.";
                $("hd_total").value = "";
            }
            break;
    }
    return this.showError( error, groupName );
}

ConfigForm.prototype.displayValidate = function () {
    var error;
    var groupName = "display";
    var displayNum = parseInt($("display_num").value);
    var displaySize = parseInt($("display_size").value);
    if ( displayNum == 2 && displaySize < 1 ) {
        error = "For dual displays, you must select at least 22\" displays.";
    }
    return this.showError( error, groupName );
}

ConfigForm.prototype.validateAll = function () {
    var error = false;
    error = this.osValidate()        || error;
    error = this.opticalValidate()   || error;
    error = this.hdValidate()        || error;
    error = this.displayValidate()   || error;
    return error;
}

ConfigForm.prototype.updatePrice = function () {
    var proc = parseInt(getSelectedRadioButton("proc").value);
    var mem  = parseInt(getSelectedRadioButton("mem").value);
    var os   = parseInt(getSelectedRadioButton("os").value);
    var optical0 = parseInt($("optical0").value);
    var optical1 = parseInt($("optical1").value);
    var hdNum  = parseInt($("hd_num").value);
    var hdSize = parseInt($("hd_size").value);
    var displayNum  = parseInt($("display_num").value);
    var displaySize = parseInt($("display_size").value);
    
    var total = this.baseCost;
    total += this.processorCost[proc];
    total += this.memoryCost[mem];
    total += this.osCost[os];
    total += this.opticalCost[0][optical0];
    total += this.opticalCost[1][optical1];
    total += this.hdCost[hdSize][hdNum];
    total += this.displayCost[displaySize][displayNum];
    $setSpan("system_cost", "$" + total.toFixed(2) );
}

ConfigForm.prototype.updateForm = function () {
    this.validateAll();
    this.updatePrice();
}

ConfigForm.prototype.reset = function () {
    this.processorClick();
    this.memoryClick();
    this.osClick();
    this.opticalChange();
    this.hdChange();
    this.displayChange();
    this.updateForm();
}