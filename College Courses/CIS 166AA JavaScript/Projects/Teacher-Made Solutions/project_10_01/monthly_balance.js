var trans_list = [];

var $ = function(id) { return document.getElementById(id); }

//create the error box
$("errorBox").value = "No errors yet. Click the Add Transaction button to\n" + "check for errors after entering new data.";

//make error checking standards
var datePattern = /^[01]?\d\/[0-3]\d\/\d{4}$/;
//make error messages
var dateError = "Invalid Date. Accepted format is MM/DD/YYYY\n";
var numberError = "The Transaction Amount is not a number.\n";
var emptyString = "The Transaction Amount field is empty.\n";

var update_display = function () {
    // update main text area
    $("trans_list").value = get_trans_list_string(trans_list);
    
    // update summary text boxes
    $("starting_balance").value = get_starting_balance().toFixed(2);
    $("total_deposits").value = get_total_deposits(trans_list).toFixed(2);
    $("total_withdrawals").value = get_total_withdrawals(trans_list).toFixed(2);
    $("ending_balance").value = get_ending_balance(trans_list).toFixed(2);

    // set default values for date and amount
    $("trans_date").value = "12/01/2009";
    $("trans_amount").value = "100";
    
    $("trans_date").focus();
}    

var add_trans_click = function() {
    // create the transaction array
    var trans = [];
	
	//validate the data
	if ( $("trans_date").value == datePattern ) {
		trans["date"] = $("trans_date").value;
		
		trans["type"] = $("trans_type").value;
		
		if ( $("trans_amount").value == isNaN ) {
			$("errorBox").value += numberError;
		}
		else if ( $("trans_amount").value == "" ) {
			$("errorBox").value += emptyString;
		}
		else {
			trans["amount"] = parseFloat( $("trans_amount").value );
		}
	}
	else {
		$("errorBox").value += dateError;
	}
    

    // add the transaction to the list
    trans_list.push(trans);

    update_display();
}

window.onload = function () {
    $("add_trans").onclick = add_trans_click;

    update_display();
}