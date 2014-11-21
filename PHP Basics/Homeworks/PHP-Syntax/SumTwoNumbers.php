<?php

function SumTwoNumbers($firstNum, $secondNum)
{
    $firstNumber = $firstNum;
    $secondNumber = $secondNum;
    $sum = $firstNumber + $secondNumber;
    echo "\$firstNumber + \$secondNumber = $firstNumber + $secondNumber = " . number_format($sum,2) . "\n";
}

SumTwoNumbers(2, 5);
SumTwoNumbers(1.567808, 0.356);
SumTwoNumbers(1234.5678, 333);

?>