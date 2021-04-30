var TaskList = function (tasks) {
    this.list = [];
    if ( tasks instanceof Array ) {
        for ( var i in tasks ) {
            this.list[this.list.length] = tasks[i].toString();
        }
    }
}

TaskList.prototype.hasTasks = function () {
    return this.list.length > 0;
}

TaskList.prototype.validIndex = function (index) {
    index = parseInt(index);
    if ( isNaN(index) ) {
        alert("You did not enter a number.");
        return false;
    } else if ( index < 0 ) {
        alert("The task number is too low.");
        return false;
    } else if ( index >= this.list.length ) {
        alert("The task number is too high.");
        return false;
    } else {
        return true;
    }
}

TaskList.prototype.getList = function () {
    var tasks;
    if ( this.list.length == 0 ) {
        tasks = "There are no items in the task list.";
    } else {
        tasks = "";
        for ( var i in this.list ) {
            tasks += (parseInt(i)+1) + ": " + this.list[i] + "\n";
        }
    }
    return tasks;
}

TaskList.prototype.getCookieList = function () {
    var tasks = [];
    for ( var index in this.list ) {
        tasks.push( encodeURIComponent(this.list[index]) );
    }
    return tasks.join(",");
}

TaskList.prototype.addTask = function(task) {
    this.list.push( task );
}

TaskList.prototype.editTask = function(index,task) {
    if ( this.validIndex(index) ) {
        this.list[index] = task;
    }
}

TaskList.prototype.deleteTask = function(index) {
    if ( this.validIndex(index) ) {
        this.list.splice(index, 1);
    }
}