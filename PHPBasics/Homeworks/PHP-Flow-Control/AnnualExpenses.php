<!DOCTYPE html>
<?php
if(isset($_POST['years'])) {
    $years = $_POST['years'];
    $currentYear = date("Y");
    $result = "<table border='1'><thead><tr><th>Year</th><th>January</th><th>February</th><th>March</th><th>April</th><th>May</th><th>June</th>
                <th>July</th><th>August</th><th>September</th><th>October</th><th>November</th><th>December</th><th>Total:</th></tr></thead><tbody>";
    for($i = 0; $i < $years ;$i++) {
        $jan = rand(0, 999);
        $feb = rand(0, 999);
        $mar = rand(0, 999);
        $apr = rand(0, 999);
        $may = rand(0, 999);
        $jun = rand(0, 999);
        $jul = rand(0, 999);
        $aug = rand(0, 999);
        $sep = rand(0, 999);
        $oct = rand(0, 999);
        $nov = rand(0, 999);
        $dec = rand(0, 999);
        $total = $jan + $feb + $mar + $apr + $may + $jun + $jul + $aug + $sep + $oct + $nov + $dec;
        $result .= "<tr><td>{$currentYear}</td><td>{$jan}</td><td>{$feb}</td><td>{$mar}</td><td>{$apr}</td><td>{$may}</td><td>{$jun}</td>" .
            "<td>{$jul}</td><td>{$aug}</td><td>{$sep}</td><td>{$oct}</td><td>{$nov}</td><td>{$dec}</td><td>{$total}</td></tr>";
        $currentYear--;
    }
    $result .= "</tbody></table>";
}
?>
<html>
    <head>
        <title>Show Annual Expenses</title>
    </head>

    <body>
    <form method="post">
        <label for="years">Enter number of years:</label>
        <input type="text" id="years" name="years"/>
        <input type="submit" value="Show costs"/>
    </form>
    <?php
    echo $result;
    ?>
    </body>
</html>