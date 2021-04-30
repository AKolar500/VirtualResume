var $ = function (id) { return document.getElementById(id); }

// Object type to control the progress bar
// barId is the CSS id of the outer progress bar div
// initialValue is an optional initial value (0 used if omitted)
var ProgressBar = function ( barId, initialValue ) {
    // Store a reference to the outer div node
    this.outerNode = $(barId);
    // Get and store a reference to the inner div node
    this.innerNode = this.outerNode.getElementsByTagName("div")[0];
    // If two arguments were provided...
    if ( arguments.length == 2 ) {
        this.setPercent( initialValue );  // set the initial value
    } else {
        this.setPercent( 0 );             // or set it to 0
    }
}

// Helper method to ensure a value is in the range 0 to 100
ProgressBar.prototype.inRange = function (value) {
    value = parseInt(value);          // Parse the value
    if ( isNaN(value) ) return 0;     // Return 0 if not a number
    if ( value < 0 ) return 0;        // Return 0 if below 0
    if ( value > 100 ) return 100;    // Return 100 if above 100
    return value;                     // Return the value
}

// Sets the width of the progress bar to a percentage from 0 to 100
ProgressBar.prototype.setPercent = function ( value ) {
    // Validate value
    this.value = this.inRange(value);
    // Set width of inner node
    this.innerNode.style.width = this.value + "%";
    // Set color of progress bar based on value
    if ( value < 40 ) {
        this.innerNode.style.backgroundColor = "red";
    } else if ( value < 80 ) {
        this.innerNode.style.backgroundColor = "yellow";
    } else {
        this.innerNode.style.backgroundColor = "green";
    }
}

// Returns the current progress bar value
ProgressBar.prototype.getPercent = function () {
    return this.value;
}