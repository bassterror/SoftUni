function countSubstringOccur(arg) {
    var substr = arg[0];
    var str = arg[1];
    var strToLower = str.toLowerCase();

    var re = new RegExp(substr, 'g');
    var count = strToLower.match(re);

    return count.length;
}