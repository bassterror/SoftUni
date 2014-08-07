function sortArray(arr) {
    var result = [];

    for (var i = 0; i < arr.length - 1; i++) {
        var min = i;
        for (var j = i + 1; j < arr.length; j++) {
            if (arr[j] < arr[min]) {
                min = j;
            }
        }

        if (min != i) {
            var temp = 0;
            temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
    }

    for (var i = 0; i < arr.length; i++) {
        result.push(arr[i]);
    }

    console.log(result.join(', '));

}