const http = require('http');
const fs = require('fs');

const hostname = '127.0.0.1';
const port = 3000;

const server = http.createServer((req, res) => {
    if (req.method === "GET")
    {  
        if(req.url === '/')
        { 
        res.statusCode = 200;
        res.setHeader('Content-Type', 'text/plain');
        res.end('Hello World\n');
        }
        else if (req.url === '/givemetext')
        {
            res.statusCode = 200;
            res.setHeader('Content-Type', 'text/html');
            res.end('<strong>Hello World\n</strong>');
        }
        else if (req.url === '/givemefile') 
        {
            // res.statusCode = 200;
            // res.setHeader('Content-Type', 'text/html');
            res.writeHead(200, {"Content-Type": "text/html"})
            var fileStream = fs.createReadStream("index.html");
            fileStream.pipe(res);
        }
        else {
            res.statusCode = 404;
            res.end();
        }
    }
});

server.listen(port, hostname, () => {
  console.log(`Server running at http://${hostname}:${port}/`);
});
