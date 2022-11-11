// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
function newColor() {
    document.getElementById('hello_world').style.color = "blue";
}
function oldColor() {
    document.getElementById('hello_world').style.color = "darkolivegreen";
}

//animate image
var vw = document.documentElement.clientWidth;
var vh = document.documentElement.clientHeight;

var id = null;
function imgAnimation() {
    var elem = document.getElementById("dragonfly");
    var pos = 0;
    clearInterval(id);
    id = setInterval(frame, 10);

    function frame() {
        if (pos == 500) {
            clearInterval(id);
        } else {
            pos++;
            elem.style.top = pos + 'px';
            elem.style.left = pos + 'px';
        }
    }
}