/*Alex Kolar
*6/24-25/2013
*CIS166AA Section 15309
*Project 8 Vending Machine
*/

var $ = function (id) {
    return document.getElementById(id);
}

//create global vars
var deposit = 0;
$("deposit").value = 0;

//soda price and stock
var sodaprice = 75;

var cokestock = 2;
var dietcokestock = 2;
var mountaindewstock = 2;
var drpepperstock = 2;
var rootbeerstock = 2;
var waterstock = 2;

//dollar button
var dollar = function () {
	deposit += 100;
	$("deposit").value += deposit;
}

//quarter button
var quarter = function () {
	deposit += 25;
	$("deposit").value += deposit;
}

//dime button
var dime = function () {
	deposit += 10;
	$("deposit").value += deposit;
}

//nickel button
var nickel = function () {
	deposit += 5;
	$("deposit").value += deposit;
}

//refund button
var refund = function () {
	deposit = 0;
	$("deposit").value = deposit;
}

//purchase function (for all soda buttons)
var purchase = function () {
	if ( deposit < 75 ) {
		$("message").value = "You have not deposited enough change for a soda.\n" + "You need at least 75 cents to purchase a soda.";
	} else {
		deposit -= sodaprice;
		stock();
		$("message").value = "Please enjoy your " + message_generator() + "and take your " + deposit + " cents change.";
		$("deposit").value = deposit;
	}
}

//determine whether or not to disable the soda button
var stock = function () {
	if ( $("coke").onclick == true ) {
		cokestock -= 1;
		if ( cokestock == 0 ) {
			$("coke").disabled = true;
		}
	} else if ( $("dietcoke").onclick == true ) {
		dietcokestock -= 1;
		if ( dietcokestock == 0 ) {
			$("dietcoke").disabled = true;
		}
	} else if ( $("mountaindew").onclick == true ) {
		mountaindewstock -= 1;
		if ( mountaindewstock == 0 ) {
			$("mountaindew").disabled = true;
		}
	} else if ( $("drpepper").onclick == true ) {
		drpepperstock -= 1;
		if ( drpepperstock == 0 ) {
			$("drpepper").disabled = true;
		}
	} else if ( $("rootbeer").onclick == true ) {
		rootbeerstock -= 1;
		if ( rootbeerstock == 0 ) {
			$("rootbeer").disabled = true;
		}
	} else {
		waterstock -= 1;
		if ( waterstock == 0 ) {
			$("water").disabled = true;
		}
	}
}

//determine which soda to put in the label
var message_generator = function () {
	var status = "";
	
	if ( $("coke").onclick == true ) {
		status = "Coke ";
		return status;
	} else if ( $("dietcoke").onclick == true ) {
		status = "Diet Coke ";
		return status;
	} else if ( $("mountaindew").onclick == true ) {
		status = "Mountain Dew ";
		return status;
	} else if ( $("drpepper").onclick == true ) {
		status = "Dr. Pepper ";
		return status;
	} else if ( $("rootbeer").onclick == true ) {
		status = "Root Beer ";
		return status;
	} else if ( $("water").onclick == true ) {
		status = "Water ";
		return status;
	} else {
		status = "You have not clicked a button. ";
		return status;
	}
}

window.onload = function () {
	//deposit buttons
    $("dollar").onclick = dollar;
    $("quarter").onclick = quarter;
    $("dime").onclick = dime;
    $("nickel").onclick = nickel;
	$("refund").onclick = refund;
	
	//purchase buttons
	$("coke").onclick = purchase;
	$("dietcoke").onclick = purchase;
	$("mountaindew").onclick = purchase;
	$("drpepper").onclick = purchase;
	$("rootbeer").onclick = purchase;
	$("water").onclick = purchase;
}