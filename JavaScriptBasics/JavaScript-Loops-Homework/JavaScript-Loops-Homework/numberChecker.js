function numberChecker(n) {
    var nums = [];
    for (var i = 1; i <= n; i++) {
        if ((i % 4 == 0) || (i % 5 == 0)) {
            continue;
        }
        nums.push(i);
    }

    if (n <= 0) {
        nums.push('no');
    }
    console.log(nums.join(', '))
}