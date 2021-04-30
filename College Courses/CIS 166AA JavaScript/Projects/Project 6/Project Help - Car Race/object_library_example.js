//Defines a car object with the allowance of user specified model, color, and top speed
var Car = function(model_input, color_input, speed_input) {
	this.model = model_input;
	this.color = color_input;
	//When a new car comes into existence its current speed should be zero until its go method is called
	this.currentSpeed = 0;
	this.topSpeed = speed_input;
}

//This method function creates a random number based on the top speed of the car that it belongs to
Car.prototype.go = function() {

	var random = Math.random() * this.topSpeed;
	this.currentSpeed = random.toFixed(2);
	
}

//Defines a race object which contains a single array of potential car objects as racers
var Race = function() {
	this.racers = new Array();

}
//Adds a racer to the racing game
Race.prototype.addRacer = function(car) {
	//racers is an array object so we can use push to add the car to the racers in the race
	this.racers.push(car);
}

//Determines who is the winner based on the fastest speed
Race.prototype.determineWinner = function() {
	//The winner is undefined at the beginning of the function
	var winner = undefined;
	//The fastest speed at the beginning of the function call is initialized to zero
	var fastestSpeed = 0;
	//Loops through the array of racers and compares each to the fastest speed. It determines
	//which racer out of all the racers has the fastest speed and calls it the winner
	for (var i in this.racers) {
		var single_car = this.racers[i];
		if (single_car.currentSpeed > fastestSpeed) {
			winner = single_car;
			fastestSpeed = winner.currentSpeed;
			
		}
	}
	//Returns the winner back to the game. The winner variable is a Car object
	return winner;

}
