<?php

function NonRepeatDigits($input){
    $arr = array();

    for ($i = 102; $i <= $input; $i++) {
        if(strlen($i) >= 4) {
            break;
        }
        $firstDigit = (int)($i % 10);
        $secondDigit = (int)(($i / 10) % 10);
        $thirdDigit = (int)($i / 100);

        if($firstDigit != $secondDigit && $firstDigit != $thirdDigit) {
            if($secondDigit != $thirdDigit) {
                array_push($arr, $i);
            }
        }
    }
    if(count($arr) > 0) {
        echo implode(', ', $arr);
    } else {
        echo "no";
    }
}

NonRepeatDigits(1234);
NonRepeatDigits(145);
NonRepeatDigits(15);
NonRepeatDigits(247);

?>