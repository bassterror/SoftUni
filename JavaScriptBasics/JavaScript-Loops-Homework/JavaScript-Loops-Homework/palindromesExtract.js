function findPalindromes(str) {
    var words = str.toLowerCase().split(/\W+/);
    words = words.filter(Boolean);
    var result = [];

    for (var i = 0; i < words.length; i++) {
        if (words[i] == words[i].split('').reverse().join('')) {
            result.push(words[i]);
        }
    }
    return result.join(', ');
}