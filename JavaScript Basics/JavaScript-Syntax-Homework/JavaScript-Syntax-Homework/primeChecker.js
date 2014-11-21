function isPrime(value) {
    var start = 2;
    while (start <= Math.sqrt(value)) {
        if (value % start++ < 1) return false;
    }
    return value > 1;
}

console.log(isPrime(7));
console.log(isPrime(254));
console.log(isPrime(587));