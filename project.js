/*document.onkeydown = checkKey;

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

}*/

class App
{
  runApplication()
  {
    const canvas = document.getElementById("canvas");
    const ctx = canvas.getContext("2d");
    const imagePlayer = document.getElementById("source1");
    const imageBullet = document.getElementById("source2");

    imagePlayer.addEventListener("load", (e) => {
      ctx.drawImage(imagePlayer, 30, 30);
    });
    
    imageBullet.addEventListener("load", (e) => {
      ctx.drawImage(imageBullet, 30, 30);
    });

    let g = canvas.getContext("2d");
    console.log(canvas);

    
  }
}

let app = new App();
app.runApplication();
