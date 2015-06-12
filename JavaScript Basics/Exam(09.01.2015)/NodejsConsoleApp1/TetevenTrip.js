function tetevenTrip(input){
    var element = [input.length];
    var output = [];
    for (var i = 0; i < input.length; i++){
        element[i] = input[i].split(" ");
        var car = element[i][0];
        var fuel = element[i][1];
        var route = element[i][2];
        var luggage = element[i][3];
        
        var fuelCorrection;
        if (fuel == "petrol") {
            fuelCorrection = 10;
        }
        if (fuel == "gas") {
            fuelCorrection = 12;
        }
        if (fuel == "diesel") {
            fuelCorrection = 8;
        }

        var extraLuggageFuel = luggage * 0.01;
        fuelCorrection = fuelCorrection + extraLuggageFuel;

        var totalConsumption;
        var extraSnow;
        if (route == "1") {
            totalConsumption = 110 * (fuelCorrection / 100);
            extraSnow = 10 * ((0.3 * fuelCorrection) / 100);
        }
        if (route == "2") {
            totalConsumption = 95 * (fuelCorrection / 100);            
            extraSnow = 30 * ((0.3 * fuelCorrection) / 100);
        }

        fuelCorrection = Math.round(totalConsumption + extraSnow);
        output[i] = car + " " + fuel + " " + route + " " + fuelCorrection;
        console.log(output[i]);
    }
}


var input = ['BMW petrol 1 320.5', 'Golf petrol 2 150.75', 'Lada gas 1 202', 'Mercedes diesel 2 312.54'];
tetevenTrip(input);