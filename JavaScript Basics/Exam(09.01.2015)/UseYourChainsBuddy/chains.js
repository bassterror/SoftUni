function chains(input) {
    var strings = input[0].match(/<\s*p[^>]*>([^<]*)<\s*\/\s*p\s*>/g);
    var message = "";
    for (var i = 0; i < strings.length; i++) {
        strings[i] = strings[i].replace("<p>","");
        strings[i] = strings[i].replace("</p>", "");
        message += strings[i];
    }
    
    var first = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm'];
    var second = ['n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'];
    message = message.replace(/[^0-9a-z-]+/g, " ");
    var letters = message.split("");
    var output = "";
    for (var i = 0; i < letters.length; i++) {
        var char;
        if (letters[i] == " ") {
            char = ' ';
        }
        else if (letters[i] == "1") {
            char = '1';
        }
        else if (letters[i] == "2") {
            char = '2';
        }
        else if (letters[i] == "3") {
            char = '3';
        }
        else if (letters[i] == "4") {
            char = '4';
        }
        else if (letters[i] == "5") {
            char = '5';
        }
        else if (letters[i] == "6") {
            char = '6';
        }
        else if (letters[i] == "7") {
            char = '7';
        }
        else if (letters[i] == "8") {
            char = '8';
        }
        else if (letters[i] == "9") {
            char = '9';
        }
        else if (letters[i] == "0") {
            char = '0';
        }
        else {
            char = letters[i];
            var a = first.indexOf(char);
            var b = second.indexOf(char);
            if (a < 0) {
                char = first[b];
            }
            if (a >= 0) {
                char = second[a];
            }
        }
        output += char;
    }
    console.log(output);
}


var input = ["<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>", ""];
chains(input);