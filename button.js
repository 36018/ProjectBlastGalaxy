let uibutton = document.getElementById("Mybutton")

let localeFunction = function (e){
    if(this.stop === true){
   this.stop = false;
   myMusic.sound.play();
 }else{
        this.stop = true;
        myMusic.sound.pause();
    }
    };

uibutton.addEventListener("click" , localeFunction)