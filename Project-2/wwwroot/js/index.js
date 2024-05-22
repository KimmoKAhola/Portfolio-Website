import "./styles.css";

let elem = document.querySelector(".main-carousel");
const flkty = new Flickity(elem, {
    // options
    cellAlign: "left",
    wrapAround: true,
    contain: false
});
