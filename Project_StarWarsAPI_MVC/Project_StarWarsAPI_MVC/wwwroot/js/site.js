//function toggleMusic() {
//    document.getElementById("youtube-audio").click();
//}

function toggleMusic() {
    var button = document.getElementById("musicButton").innerHTML;
    var player = document.getElementById("youtube-audio");
    if (button == "🔇" || button == "🎵") {
        document.getElementById("musicButton").innerHTML = "🔊";
        player.click();
    }
    else if (button == "🔊") {
        document.getElementById("musicButton").innerHTML = "🔇";
        player.click();
    }
}