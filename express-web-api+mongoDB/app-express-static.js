const express = require('express');


const hostname = '127.0.0.1';
const port = 3000;

const server = express();

// http://localhost:3000/index.html
// http://localhost:3000/style.css
// http://localhost:3000/img1.png

// http://localhost:3000/api/people
// http://localhost:3000/api/cars
// http://localhost:3000/api/books

server.get('/api*', (req, res) => {

    res.end("API komt hier");
})

server.use(express.static("public"));
server.use(express.static("views"));



server.get('*', (req, res) => {
    res.statusCode = 404;
    res.end();
})

// server.get(['/','/*.html'], (req, res) => {
//     res.sendFile(__dirname + "\\views\\" + req.path);
// })




















server.listen(port, hostname, () => {
    console.log(`Server running at http://${hostname}:${port}/`);
});