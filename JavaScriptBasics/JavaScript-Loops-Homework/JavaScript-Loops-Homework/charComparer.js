function compareChars(arr1, arr2) {    
    if (arr1.length != arr2.length)
        console.log('Not Equal');
    else {
        for (var i = 0; i < arr1.length; i++) {
            if (arr1[i] != arr2[i]) {
                console.log('Not Equal');
                return;
            }
        }
        console.log('Equal');
    }
}