function checkBrackets(str) {
    var brackets = 0;

    for (var ch in str) {
        if (str[ch] == '(') {
            brackets++;
        }
        else if (str[ch] == ')') {
            brackets--;
        }

        if (brackets < 0) {
            break;
        }
    }

    if (brackets == 0) {
        return "correct";
    }
    else {
        return "incorrect";
    }
}