"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/lobbyHub").build();

// Event listener for the join button
document.getElementById("joinButton").addEventListener("click", function () {
    var roomName = "Room" + Math.floor(Math.random() * 100); // Random room name
    connection.invoke("JoinRoom", roomName).catch(function (err) {
        return console.error(err.toString());
    });
});

// Handle when a user joins a room
connection.on("JoinedRoom", function (room) {
    console.log(`Joined ${room}`);
    var messagesList = document.getElementById("messagesList");
    var li = document.createElement("li");
    li.appendChild(document.createTextNode(`Joined ${room}`));
    messagesList.appendChild(li);
});

// Handle when a room is full
connection.on("RoomFull", function (room) {
    alert(`The room ${room} is full. Please try again later.`);
});

// Handle receiving a message
connection.on("ReceiveMessage", function (user, message) {
    var messagesList = document.getElementById("messagesList");
    var li = document.createElement("li");
    li.appendChild(document.createTextNode(`${user}: ${message}`));
    messagesList.appendChild(li);
});

// Start the connection
connection.start().catch(function (err) {
    return console.error(err.toString());
});

// Event listener for the send button
document.getElementById("sendButtonHub").addEventListener("click", function (event) {
    event.preventDefault(); // Prevent form submission

    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;

    //this is where we are having the issue need to pass the room name
    // You need to store the current room name after joining
    var roomName = "YourRoom"; // Replace with actual logic to get the current room

    connection.invoke("SendMessage", roomName, user, message).catch(function (err) {
        return console.error(err.toString());
    });
});
