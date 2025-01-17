'use strict';

// Task functionality
const taskList = document.getElementById('task-list');
const addTaskBtn = document.getElementById('add-task-btn');
const taskInput = document.getElementById('task-input');
const taskDate = document.getElementById('task-date');

// Add task dynamically
addTaskBtn.addEventListener('click', function() {
    const taskText = taskInput.value.trim();
    const date = taskDate.value;

    if (taskText !== "" && date !== "") {
        const li = document.createElement('li');
        li.classList.add('list');
        li.textContent = `${taskText} (Due: ${date})`;
        taskList.appendChild(li);
        taskInput.value = ''; // Clear input field
        taskDate.value = ''; // Clear date field
    } else {
        alert("Please fill in both task and date.");
    }
});

// Mark task as completed on click
taskList.addEventListener('click', function(e) {
    if (e.target.tagName === 'LI') {
        e.target.classList.toggle('completed');
    }
});
