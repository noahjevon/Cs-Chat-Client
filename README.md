# Cs-Chat-Client
Client for a simple C# chat application. Uses WebSocketSharp for communication with the server.

Improvements:

 - Handle duplicate usernames. Potential solutions:
   - Add an auto incrementing integer for each duplicate username after the first
   - Perform a check prior to joining the server and display an error if the username has been used before
 
 - Handle close event when the default form close button is clicked.
 
 ![](https://github.com/noahjevon/Cs-Chat-Client/blob/master/ChatForm.JPG)
