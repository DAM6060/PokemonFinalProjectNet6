﻿"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/battleHub").build();

document.getElementById("sendButton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var li = document.createElement("li");
    document.getElementById("messagesList").appendChild(li);
    li.textContent = `${user} says ${message}`;
});


connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    event.preventDefault();
    event.stopPropagation();
    var player = document.getElementById("playerInput").value;
    var message = document.getElementById("messageInput").value;


    connection.invoke("SendMessage", player, message).catch(function (err) {
        return console.error(err.toString());
    });

});