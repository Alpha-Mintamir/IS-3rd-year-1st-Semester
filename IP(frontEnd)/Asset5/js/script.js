// Function to add a new task
function addTaskk() {
    var textBox = document.getElementById("taskDescription");
    var unorderedList = document.getElementById("unorderedList");

    if (textBox !== "") {
        var newElement = document.createElement("li");
        newElement.textContent = textBox;
        unorderedList.appendChild(newElement);

        // Clear the input field after adding the task
        document.getElementById("taskDescription").value = "";
    }
}

// Function to remove the last task
function removeTaskk() {
    var listItems = document.getElementById("unorderedList").getElementsByTagName("li");

    // Check if there are items in the list before trying to remove
    if (listItems.length > 0) {
        var last = listItems[listItems.length - 1];
        last.parentNode.removeChild(last);
    }
}

// Add event listeners
var addTaskButton = document.getElementById("addTask");
addTaskButton.addEventListener("click", addTaskk);

var removeTaskButton = document.getElementById("removeTask");
removeTaskButton.addEventListener("click", removeTaskk);
