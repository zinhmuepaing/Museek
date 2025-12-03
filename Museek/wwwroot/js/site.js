// Audio Player functionality
let audio;

window.initializeAudioPlayer = () => {
    audio = document.getElementById("audioPlayer");

    if (!audio) return;

    // Time update event
    audio.addEventListener("timeupdate", () => {
        if (audio.duration) {
            const progress = (audio.currentTime / audio.duration) * 100;
            const progressBar = document.getElementById("progressBar");
            if (progressBar) {
                progressBar.value = progress;
            }

            // Update time displays
            updateTimeDisplay(audio.currentTime, audio.duration);
        }
    });

    // When song ends
    audio.addEventListener("ended", () => {
        // You can trigger next song here
        console.log("Song ended");
    });
};

window.togglePlayPause = () => {
    if (!audio) return;

    if (audio.paused) {
        audio.play();
    } else {
        audio.pause();
    }
};

window.playSong = (audioPath) => {
    if (!audio) return;

    audio.src = audioPath;
    audio.load();
    audio.play();
};

window.previousSong = () => {
    // Implement previous song logic
    console.log("Previous song");
};

window.nextSong = () => {
    // Implement next song logic
    console.log("Next song");
};

window.seekAudio = (value) => {
    if (!audio || !audio.duration) return;

    audio.currentTime = (value / 100) * audio.duration;
};

window.changeVolume = (value) => {
    if (!audio) return;

    audio.volume = value;
};

function updateTimeDisplay(currentTime, duration) {
    const currentTimeEl = document.getElementById("currentTime");
    const remainingTimeEl = document.getElementById("remainingTime");

    if (currentTimeEl && remainingTimeEl) {
        currentTimeEl.textContent = formatTime(currentTime);
        remainingTimeEl.textContent = "-" + formatTime(duration - currentTime);
    }
}

function formatTime(seconds) {
    if (isNaN(seconds)) return "00:00";
    const m = Math.floor(seconds / 60);
    const s = Math.floor(seconds % 60);
    return `${m < 10 ? "0" + m : m}:${s < 10 ? "0" + s : s}`;
}