var get_trans_list_string = function(trans_list) {
    if ( trans_list.length == 0 ) {
        return "";
    }
    
    var list_string;
    var date; 
    var amount;
    var running_balance = get_starting_balance();

    // store the header in the string
    list_string  = pad_right("Date", 12) + " ";
    list_string += "Amount       ";
    list_string += "Running Balance\n";

    list_string += pad_right("", 12, "-") + " ";
    list_string += pad_left("", 12, "-") + " ";
    list_string += pad_left("", 15, "-") + "\n";

    // store the data in the string
    for ( var i in trans_list ) {
        amount = parseFloat(trans_list[i]["amount"]);        
        date = trans_list[i]["date"];

        type = trans_list[i]["type"];
        if (type == "withdrawal") {
            amount = -amount;
        }
        running_balance += amount;
        
        list_string += pad_right(date, 12) + " ";
        list_string += "$" + pad_left(amount.toFixed(2),  11) + " ";
        list_string += "$" + pad_left(running_balance.toFixed(2),  14) + "\n";
    }

    // return the string
    return list_string;
}

var get_starting_balance = function () {
    return 2000;
}

var get_total_deposits = function (trans_list) {
    var deposits = 0;
    var type;
    for ( var i in trans_list ) {
        type = trans_list[i]["type"];
        if (type == "deposit") {
            amount = parseFloat(trans_list[i]["amount"]);        
            deposits += amount;
        }    
    }
    return deposits;
}

var get_total_withdrawals = function (trans_list) {
    var withdrawals = 0;
    var type;
    for ( var i in trans_list ) {
        type = trans_list[i]["type"];
        if (type == "withdrawal") {
            amount = parseFloat(trans_list[i]["amount"]);        
            withdrawals -= amount;
        }    
    }
    return withdrawals;
}

var get_ending_balance = function (trans_list) {
    return get_starting_balance() + 
           get_total_deposits(trans_list) + 
           get_total_withdrawals(trans_list);
}