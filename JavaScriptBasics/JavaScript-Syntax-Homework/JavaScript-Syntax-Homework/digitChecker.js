function checkDigit(value) {
    var string = value.toString();
    if (string.substr(string.length - 3, 1) == "3") {
        return true;
    } else {
        return false
    }
}

console.log(checkDigit(1235));
console.log(checkDigit(25368));
console.log(checkDigit(123456));