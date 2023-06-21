function toggleMusic() {
    var button = document.getElementById("musicButton").innerHTML;
    if (button == "🔇" || button == "🎵") {
        document.getElementById("musicButton").innerHTML = "🔊";
        //element.click();
    }
    else if (button == "🔊") {
        document.getElementById("musicButton").innerHTML = "🔇";
        //element.click();
    }
}