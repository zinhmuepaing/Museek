let audioPlayer;
let audioSource;
let progressBar;
let currentTimeLabel;
let remainingTimeLabel;
let updateInterval;

window.initializeAudioPlayer = () => {
    audioPlayer = document.getElementById("audioPlayer");
    progressBar = document.getElementById("progressBar");
    currentTimeLabel = document.getElementById("currentTime");
    remainingTimeLabel = document.getElementById("remainingTime");

    if (!audioPlayer) return;

    audioPlayer.addEventListener("loadedmetadata", updateTimeDisplay);
    audioPlayer.addEventListener("timeupdate", () => {
        updateProgress();
        updateTimeDisplay();
    });
};

window.loadAudio = function (audioPath) {
    console.log("Loading audio:", audioPath);
    const audio = document.getElementById("audioPlayer");
    if (!audio) {
        console.error("Audio element not found!");
        return;
    }
    console.log("Audio element found, setting src to:", audioPath);
    audio.src = audioPath;
    audio.load();

    audio.addEventListener('error', function (e) {
        console.error("Audio loading error:", e);
        console.error("Failed to load:", audio.src);
    });
};






// Play or pause
window.togglePlayPause = () => {
    if (!audioPlayer) return;

    if (audioPlayer.paused) {
        audioPlayer.play();
    } else {
        audioPlayer.pause();
    }
};

// Seek
window.seekAudio = (value) => {
    if (!audioPlayer || !audioPlayer.duration) return;

    let pos = (value / 100) * audioPlayer.duration;
    audioPlayer.currentTime = pos;
};

// Volume
window.changeVolume = (value) => {
    if (!audioPlayer) return;

    audioPlayer.volume = value;
};

// Update progress bar
function updateProgress() {
    if (!audioPlayer || !audioPlayer.duration) return;

    let progress = (audioPlayer.currentTime / audioPlayer.duration) * 100;
    progressBar.value = progress;
}

// Update time labels
function updateTimeDisplay() {
    if (!audioPlayer) return;

    let current = audioPlayer.currentTime;
    let total = audioPlayer.duration;

    currentTimeLabel.textContent = formatTime(current);

    if (!isNaN(total)) {
        remainingTimeLabel.textContent = "-" + formatTime(total - current);
    }
}

// Format seconds into mm:ss
function formatTime(seconds) {
    if (isNaN(seconds)) return "00:00";

    let m = Math.floor(seconds / 60);
    let s = Math.floor(seconds % 60);

    return (m < 10 ? "0" + m : m) + ":" + (s < 10 ? "0" + s : s);
}

window.nextSong = () => {
    console.log("Next song not implemented yet");
};

window.previousSong = () => {
    console.log("Previous song not implemented yet");
};
