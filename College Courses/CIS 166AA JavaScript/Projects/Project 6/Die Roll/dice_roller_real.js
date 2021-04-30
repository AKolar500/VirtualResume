var die;

var $ = function (id) {
    return document.getElementById(id);
}

var roll_dice = function() {
	var value1 = die.getValue();
	var value2 = die.getValue();
	
	//assign the values to each die
	$("die_1").value = value1;
	$("die_2").value = value2;
	
	//display the message
}

window.onload = function () {
    $("roll_dice").onclick = roll_dice;
	die = new Die();
}