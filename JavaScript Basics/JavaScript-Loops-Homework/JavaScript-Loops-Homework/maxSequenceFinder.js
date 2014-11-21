function findMaxIncrSeq(arr) {

    var current = 1,
        longest = 1,
        index;

    for (var i = 0; i < arr.length; i++) {
        if (arr[i] < arr[i + 1]) {
            current++;
        } else {
            if (longest < current) {
                longest = current;
                index = i - current + 1;
                console.log(i);
            }
            current = 1;
        }
    }

    if (longest < 2) {
        jsConsole.writeLine('no');
    }
    else {
        var result = arr.slice(index, index + longest);
        console.log('[' + result + ']');
    }
}