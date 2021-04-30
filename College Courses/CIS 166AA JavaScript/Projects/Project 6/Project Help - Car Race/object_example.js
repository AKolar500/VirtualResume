//Typical user interface (UI) $ helper function
var $ = function(id) { return document.getElementById(id); }
//Variable that will refer to a Race object
var race;

//Function to create an instance of a car based on the values from the user input
var car_button_click = function() {
	
	var model = $("model").value;
	var color = $("color").value;
	var speed = parseInt($("speed").value);
	//Create a new Car object called my_car
	var my_car = new Car(model, color, speed);
	//Add it to the race object
	race.addRacer(my_car);
	//Display the state of the race
	displayRace();	
	
}
//Displays the race participants and their current speed
function displayRace() {
	var output = "Car Name\tCar Color\tCar Speed\n";
		output += "==============================================\n"
	for (var i in race.racers) {
		car = race.racers[i];
		output += car.model + "\t\t" + car.color + "\t\t" + car.currentSpeed + "\n";
	}
	$("output").value = output;

}
//Clears out the race and sets the values of all text fields to blanks
var clear_click = function() {
	race = new Race();
	$("output").value = "";
	$("winner").value = "";
	$("model").value = "";
	$("color").value = "";
	$("speed").value = "";
}

//Starts the race
var start_race_click = function() {
	//Loops through all the racers in the race and makes the cars go
	for (var i in race.racers) {
		car = race.racers[i];
		car.go();
	}
	//Displays the state of the race
	displayRace();
	//Determine which racer won
	var winner = race.determineWinner();
	//Displays a message of who won the race
	var winDisplay = "The " + winner.color + " " + winner.model + " is the winner!";
	$("winner").value = winDisplay; 
}

//Wiring up UI interactions to the document in the browser window
window.onload = function() {

	$("car_button").onclick = car_button_click;
	$("race_button").onclick = start_race_click;
	$("clear_button").onclick = clear_click;
	//Creates a new race game based on the race variable defined globally on line 4
	race = new Race();

}

