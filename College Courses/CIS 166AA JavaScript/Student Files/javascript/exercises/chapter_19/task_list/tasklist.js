var $ = function (id) { return document.getElementById(id); }

var tasks;
if ( jsLib.cookies.hasCookie("tasklist") ) {
    var raw_tasks = jsLib.cookies.getCookie("tasklist").split(",");
    tasks = [];
    for ( var i in raw_tasks ) {
        tasks.push( decodeURIComponent(raw_tasks[i]) );
    }
}

var list = new TaskList(tasks);

var display_list = function () {
    $("task_list").value = list.getList();
    if ( list.hasTasks() ) {
        var tasks = list.getCookieList();
        jsLib.cookies.setCookie("tasklist", tasks, 365 * 86400);
    } else {
        jsLib.cookies.deleteCookie("tasklist");
    }
}

var add_task_click = function () {
    var task = prompt("Enter a task:");
    if ( task != "" ) {
        list.addTask(task);
    }
    display_list();
}

var delete_task_click = function () {
    if ( list.hasTasks() ) {
        var index = parseInt( prompt("Enter the task number to delete:") );
        index--;
        list.deleteTask(index);
        display_list();
    }
}

var edit_task_click = function () {
    if ( list.hasTasks() ) {
        var index = parseInt( prompt("Enter the task number to edit:") );
        index--;
        if ( list.validIndex(index) ) {
            var task = prompt("Enter update for task " + (index+1) );
            if ( task != "" ) {
                list.editTask(index, task);
                display_list();
            }
        }
    }
}

window.onload = function() {
    $("add_task").onclick = add_task_click;
    $("edit_task").onclick = edit_task_click;
    $("delete_task").onclick = delete_task_click;
    display_list();
}