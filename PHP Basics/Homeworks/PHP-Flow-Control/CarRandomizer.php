<!DOCTYPE html>

<?php
if(isset($_POST['cars'])) {
    $allCars = explode(',', $_POST['cars']);
    $allColors = array('black', 'blue', 'gray', 'green', 'orange', 'red', 'silver', 'white', 'yellow');
    $result = "<table border='1'><thead><tr><th>Car</th><th>Color</th><th>Count</th></tr></thead><tbody>";
    for($i = 0; $i < count($allCars) ;$i++) {
        $color = $allColors[rand(0, 8)];
        $count = rand(1, 5);
        $result .= "<tr><td>{$allCars[$i]}</td><td>{$color}</td><td>{$count}</td></tr>";
    }
    $result .= "</tbody></table>";
}
?>

<html>
    <head>
        <title>Rich People`s Problems</title>
    </head>

    <body>
        <form method="post">
            <label for="cars">Enter Cars</label>
            <input type="text" name="cars" id="cars"/>
            <input type="submit" value="Show Results"/>
        </form> 
            
        <?php
        echo $result;
        ?>
    </body>
</html>