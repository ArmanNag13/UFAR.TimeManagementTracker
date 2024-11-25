window.animateText = function (elementId, text, speed = 60) {
    const element = document.getElementById(elementId);
    let i = 0;
    element.innerHTML = ''; // Clear any previous content

    function typeWriter() {
        if (i < text.length) {
            let char = text.charAt(i);

            // Check for newline and space
            if (char === '\n') {
                element.innerHTML += '<br>'; // Add a line break for newline characters
            } else if (char === ' ') {
                element.innerHTML += '&nbsp;'; // Use non-breaking space for spaces
            } else {
                element.innerHTML += char; // Regular character
            }

            i++;
            setTimeout(typeWriter, speed); // Recursively call typeWriter to animate the next character
        }
    }

    typeWriter(); // Start the animation
};
window.addClassToElement = function (elementId, className) {
    var element = document.getElementById(elementId);
    if (element) {
        element.classList.add(className);
    }
};
