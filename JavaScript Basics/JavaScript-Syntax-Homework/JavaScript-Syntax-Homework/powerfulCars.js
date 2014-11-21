function convertKWtoHP(value) {
    return (value * 1.34102209).toFixed(2);
}

console.log(convertKWtoHP(75));
console.log(convertKWtoHP(150));
console.log(convertKWtoHP(1000));