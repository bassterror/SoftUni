function findMaxSequence(arr) {
    var max = 1;
    var current = 1;
    var maxArray = arr[0];

    for (var i = 1; i < arr.length; i++) {
        if (arr[i - 1] == arr[i]) {
            current++;
            if (current > max) {
                max = current;
                maxArray = arr[i];
            }
        }
        else {
            current = 1;
        }
    }

    var arrayResult = []
    for (var i = 0; i < max; i++) {
        arrayResult.push(maxArray);
    }

    console.log(arrayResult);
}