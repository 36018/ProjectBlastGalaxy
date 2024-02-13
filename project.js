const input = require('readline-sync');

let player = drawImage(image, dx, dy, dWidth, dHeight);

let bullet = drawImage(image, dx, dy, dWidth, dHeight);

document.onkeydown = checkKey;

function checkKey(e) 
{

    e = e || window.event;

    if (e.keyCode == '38') {
        // up arrow
        
    }
    else if (e.keyCode == '40') {
        // down arrow
    }
    else if (e.keyCode == '37') {
       // left arrow
    }
    else if (e.keyCode == '39') {
       // right arrow
    }

}