


const mapEl = document.getElementById("map");
mapEl.innerHTML = `<div>somehting</div>`

mapboxgl.accessToken = "pk.eyJ1IjoibHBwNDIiLCJhIjoiY2wyYWZtNTFjMDUwMzNpcW50c3oyemp3aiJ9.EcrbBNeaSRbjO0IeCzlbnA";

let mapInit = async function() {
    map = new mapboxgl.Map({
        container: 'map',
        style: 'mapbox://styles/lpp42/cl2afumu6000k15numxokqvt6',
        center: [-75.765, 45.456],
        zoom: 13.5
    });
}

// let placeContacts = async function(){

//     contacts.forEach(element => {
    
// });

mapInit();