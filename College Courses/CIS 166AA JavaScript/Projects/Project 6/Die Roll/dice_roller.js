var $ = function (id) {
    return document.getElementById(id);
}

var roll_dice = function () {
	//create vars
	var die1 = random_number(1,6);
	var die2 = random_number(1,6);
	
	//assign values to the text boxes
	$("die_1").value = die1;
	$("die_2").value = die2;
	
	//assign special craps rolls to the "message" text box
	$("message").value = message_generator( die1, die2 );
}

// The random_number function from figure 7-5.
var random_number = function ( min, max, digits ) {
    // If digits is not a number, set it to zero
    // Otherwise, make it a whole number
    digits = isNaN(digits) ? 0 : parseInt(digits);

    // Make sure digits is between 0 and 16
    if ( digits < 0 ) {
        digits = 0;
    } else if ( digits > 16 ) {
        digits = 16;
    }
    
    if (digits == 0) {
        // Return an integer
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    } else {
        // Return a decimal with the specified number of digits
        var rand = Math.random() * ( max - min ) + min;
        return parseFloat( rand.toFixed(digits) );
    }
}

var message_generator = function ( die1, die2 ) {
	var status = "";
	//first craps circumstance
	if ( die1 + die2 == 7 ) {
		status = "You have craps!";
		return status;
	}
	//second craps circumstance
	if ( die1 + die2 == 2 ) {
		status = "Snake Eyes!";
		return status;
	}
	//third craps circumstance
	if ( die1 + die2 == 12 ) {
		status = "Box Cars!";
		return status;
	}
	//better luck next time
	status = "Better luck next time!";
	return status;
}

window.onload = function () {
    $("roll_dice").onclick = roll_dice;
}