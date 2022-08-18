//Contact page Show/Hide Map 
function mapFunction() {
    let contactMapHandler = document.querySelectorAll(".test");
    console.log('--->', contactMapHandler);
    contactMapHandler.forEach(function(map,index) {
        console.log('this', this);
        console.log('index', index);
        console.log('map--->>>',map)
        if (map.style.display === "none") {
            map.style.display = "block";
        }
        else {
            map.style.display = "none";
        }
    })

};
    
