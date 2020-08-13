var todayDag;

const date = new Date()
const dateTimeFormat = new Intl.DateTimeFormat('en', { weekday: 'long', hour12: false})

const [{ value: weekday }] = dateTimeFormat .formatToParts(date )
var toCheck = `${weekday}`

switch (toCheck) {
    case "Monday": todayDag = "Maandag"; break;
    case "Tuesday": todayDag = "Dinsdag"; break;
    case "Wednesday": todayDag = "Woensdag"; break;
    case "Thursday": todayDag = "Donderdag"; break;
    case "Friday": todayDag = "Vrijdag"; break;
    case "Saturday": todayDag = "Zaterdag"; break;
    case "Sunday": todayDag = "Zondag"; break;
}

var elements = document.getElementsByClassName("dag");
var elements2 = document.getElementsByClassName("vanaf");
var elements3 = document.getElementsByClassName("tot");

var names = elements;

for(var i=0; i<elements.length; i++) {
    if (elements[i].textContent === todayDag){
        elements[i].textContent = elements[i].textContent + " (vandaag)";
        elements[i].style.backgroundColor = "#cecece";
        elements2[i].style.backgroundColor = "#cecece";
        elements3[i].style.backgroundColor = "#cecece";
    };
}