Enter tags:
<form method="get">
    <input type="text" name="textbox" />
    <input type="submit" />
</form>


<?php
if(isset($_GET['textbox'])){
    $input = $_GET['textbox'];
    $arr = explode(', ', $input);
    $count = 0;
    foreach($arr as $item){
        echo "$count : $item <br>";
        $count++;
    }
}

?>