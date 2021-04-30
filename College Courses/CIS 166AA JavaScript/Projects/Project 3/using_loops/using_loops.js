var $ = function (id) {
    return document.getElementById(id);
}

// A function that implements example 2 in figure 8-8.
// It displays the average of the numbers that you enter.
var finding_average = function() {
	var total = 0, count = 0, number;
	alert("Enter the numbers to average. Enter any non-number to stop.");
	number = parseFloat( prompt("Enter a number") );
	while ( !isNaN(number) ) {
		total += number;
		count++;
		number = parseFloat( prompt("Enter another number") );
	}
	var average = total / count;
	if ( isNaN(average) ) {
		alert("You didn't enter any numbers.");
	} else {
		alert("The average is: " + average);
	}
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
    
    if ( digits == 0 ) {
        // Return an integer
        return Math.floor( Math.random() * ( max - min + 1 ) ) + min;
    } else {
        // Return a decimal with the specified number of digits
        var rand = Math.random() * ( max - min ) + min;
        return parseFloat( rand.toFixed(digits) );
    }
}

// A function that implements example 4 in figure 8-8.
// It displays the average and maximum number of rolls to get a 6
// with a single die in 10,000 tries.
var rolling_six = function() {
	var total = 0, count = 0, max = -Infinity;
	var rolls;
	while ( count < 10000 ) {
		rolls = 1;
		while ( random_number(1, 6) != 6 ) {
			rolls++;
		}
		total += rolls;
		count++;
		if ( rolls > max ) max = rolls;
	}
	var average = total / count;
	alert ("Average rolls: " + average +
	       "\nMax rolls: " + max);
}

// A function that implements example 4 in figure 8-10.
// It determines whether the number 31 is a prime number.
var finding_primes = function() {
	var number = 31, prime = true;
	for ( var i = 2; i < number; i++ ) {
		if ( number % i == 0 ) prime = false;
	}
	if (prime) {
		alert( number + " is prime.");
	} else {
		alert( number + " is not prime.");
	}
}

// A function that needs to be implemented.
// It uses the controls in the web page for this application
var process_test_scores = function () {
	var testScore;
	testScore = parseInt(prompt(
		"Enter a valid test score between 0 and 100.\n" + 
		"To end test score entry, enter 999.", 999));
}

// The code for the onload event that calls the functions above.
window.onload = function () {
    finding_average();
	// rolling_six();
	// finding_primes();
	// process_test_scores();
}