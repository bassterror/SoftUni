<!DOCTYPE html>

<?php
if(isset($_POST['string']) && isset($_POST['operation'])) {
    $string = $_POST['string'];
    $operation = $_POST['operation'];
    $result = '';
    
    if($operation == 'palindrome') {
        if($string == strrev($string)) {
            $result = "{$string} is a palindrome!";
        } else {
            $result = "{$string} is not a palindrome!";
        }
    } else if($operation == 'reverse') {
        $result = strrev($string);
    } else if($operation == 'split') {
        $string = preg_replace('/\s+/', '', $string);
        $array = str_split($string);
        $result = implode($array, ' ');
    } else if($operation == 'hash') {
        $result = crypt($string);
    } else if($operation == 'shuffle') {
        $result = str_shuffle($string);
    }
}
?>

<html>
    <head>
        <title>Modify String</title>
    </head>
    <body>
        <form method="post">
            <input type="text" name="string" id="string"/>
            <input type="radio" name="operation" value="palindrome" id="palindrome"/>
            <label for="palindrome">Check Palindrome</label>
            <input type="radio" name="operation" value="reverse" id="reverse"/>
            <label for="reverse">Reverse String</label>
            <input type="radio" name="operation" value="split" id="split"/>
            <label for="split">Split</label>
            <input type="radio" name="operation" value="hash" id="hash"/>
            <label for="hash">Hash String</label>
            <input type="radio" name="operation" value="shuffle" id="shuffle"/>
            <label for="shuffle">Shuffle String</label>
            <input type="submit" name="submit" value="Submit"/>
        </form>
        <div id="result">
            <?php
            echo $result;
            ?>
        </div>
    </body>
</html>