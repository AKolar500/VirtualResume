var progressBar, goal, timer;

// Updates the progress bar
var updateBar = function () {
    // Get the current value of the bar
    var value = progressBar.getPercent();
    // Quit if the goal has been reached
    if ( value == goal ) return;
    // Determine which direction to move the bar
    var delta = (goal - value) / Math.abs(goal - value);
    // Apply the new value to the bar
    progressBar.setPercent( value + delta );
    // Set a timer to update again in 40ms
    timer = setTimeout( updateBar, 40 );
}

// Event handler for the toggle button
var toggleClick = function () {
    $("toggle").blur();
    // Clear any existing timers
    clearTimeout(timer);
    // Change the goal...
    if ( goal == 0 ) {
        // from 0 to 100
        $("toggle").value = "Go to 0%";
        goal = 100;
    } else {
        // or from 100 to 0
        $("toggle").value = "Go to 100%";
        goal = 0;
    }
    // Run the update function
    updateBar();
}

// Initialize the application
jsLib.dom.ready( function () {
    // Set the initial goal
    goal = 0;
    // Create and initialize the progress bar controller
    progressBar = new ProgressBar("progressbar", goal);
    // Attach event handler to the toggle button
    jsLib.event.add( $("toggle"), "click", toggleClick );
    $("toggle").value = "Go to 100%";
});