<form method="get">
    Enter Amount <input type="text" name="amount" /> <br />
    <input type="radio" name="currency" value="$"/> USD
    <input type="radio" name="currency" value="ˆ"/> EUR
    <input type="radio" name="currency" value="lv."/> BGN <br />
    Compound interest amount <input type="text" name="interest" /> <br />
    <select name="period">
        <option value="0.5">6 months</option>
        <option value="1">1 year</option>
        <option value="2">2 years</option>
        <option value="5">5 years</option>
    </select>
    <input type="submit" name="calc" value="Calculate" />
</form>

<?php
if (isset($_GET['amount']) && isset($_GET['currency']) && isset($_GET['interest']))
{
    $amount = $_GET['amount'];
    $interest = (100 + $_GET['interest'] / 12) / 100;
    $months = $_GET['period'] * 12;
    for ($i = 0; $i < $months; $i++)
    {
    	$amount *= $interest;
    }
    echo $_GET['currency'] . ' ' . round($amount, 2) . "<br>";
}

?>