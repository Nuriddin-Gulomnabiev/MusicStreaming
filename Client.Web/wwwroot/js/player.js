window.setAudioSource = (audioElement, url) => {
    audioElement.src = url;
};

window.playAudio = (audioElement) => {
    audioElement.play().catch(error => {
        console.error("Audio playback failed:", error);
    });
};

window.pauseAudio = (audioElement) => {
    audioElement.pause();
};

window.getAudioCurrentTime = (audioElement) => {
    return audioElement.currentTime;
};

window.setAudioCurrentTime = (audioElement, time) => {
    console.log("Setting current time to", time);
    if (audioElement) {
        audioElement.currentTime = time;
    } else {
        console.warn("Audio element not found");
    }
};
