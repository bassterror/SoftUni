<!DOCTYPE html>

<?php
if(isset($_POST['input'])) {
    $allStrings = explode(',', $_POST['input']);
    $result = '<table border="1">';
    for($i = 0; $i < count($allStrings) ;$i++) {
        $result .= "<tr><td>{$allStrings[$i]}</td><td>";
        if(is_numeric($allStrings[$i]) && !preg_match("/\\./", $allStrings[$i])) {
            $sum = array_sum(str_split($allStrings[$i]));
            $result .= $sum;
        } else {
            $result .= "I cannot sum that";
        }
        $result .= '</td></tr>';
    }
    $result .= '</table>';
}
?>

<html>
    <head>
        <title>Sum Of Digits</title>
    </head>
    <body>
        <form method="post">
            <label for="input">Input string:</label>
            <input type="text" name="input" id="input"/>
            <input type="submit" value="Submit"/>
        </form>
        <div id="result">
            <?php
            echo $result;
            ?>
        </div>
    </body>
</html>