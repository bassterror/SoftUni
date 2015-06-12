function parachute(input){
    var lines = input;
    for(var i = 0; i < lines.length; i++){
        if (i == 0) {
            var jumperIndex = lines[i].indexOf('o');
        }
        else {
            var symbols = lines[i].split("");
            var add = 0;
            for (var j = 0; j < symbols.length; j++) {                
                if (symbols[j] == '>') {
                    add++;
                }
                if (symbols[j] == '<') {
                    add--;
                }
            }
            jumperIndex += add;
            if (jumperIndex < 0) {
                jumperIndex = 0;
            }
            if (jumperIndex > symbols.length - 1) {
                jumperIndex = symbols.length - 1;
            }
            if (symbols[jumperIndex] == '_') {
                console.log("Landed on the ground like a boss!");
                console.log(i + " " + jumperIndex);
                break;
            }
            if (symbols[jumperIndex] == '~') {
                console.log("Drowned in the water like a cat!");
                console.log(i + " " + jumperIndex);
                break;
            }
            if (symbols[jumperIndex] == '|' || symbols[jumperIndex] == '\\' || symbols[jumperIndex] == '/') {
                console.log("Got smacked on the rock like a dog!");
                console.log(i + " " + jumperIndex);
                break;
            }
        }
    }

}


var input = ["--o----------------------", ">------------------------", ">------------------------", ">-----------------/\\-----", "-----------------/--\\----", ">---------/\\----/----\\---", "---------/--\\--/------\\--", "<-------/----\\/--------\\-", "\\------/----------------\\", "-\\____/------------------"];
parachute(input);