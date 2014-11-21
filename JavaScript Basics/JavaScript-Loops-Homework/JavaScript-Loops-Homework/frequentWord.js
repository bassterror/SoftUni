function findMostFreqWord(str) {
    var strToLower = str.toLowerCase();
    var words = strToLower.match(/\b\w+\b/g);
    var results = [];
    var maxTimes = 0;

    for (var i in words) {
        var word = words[i];
        if (results[word] === undefined) {
            results[word] = { word: word, times: 1 };
        }
        else {
            results[word].times++;
        }

        if (results[word].times > maxTimes) {
            maxTimes = results[word].times;
        }
    }

    var bestWords = [];
    for (var i in results) {
        if (results[i].times === maxTimes) {
            bestWords.push(results[i]);
        }
    }

    bestWords.sort(
        function (lhs, rhs) {
            return lhs.word.localeCompare(rhs.word);
        }
    );

    for (var w in bestWords) {
        jsConsole.writeLine(bestWords[w].word + " -> " + bestWords[w].times + " times");
    }
    jsConsole.writeLine();
}