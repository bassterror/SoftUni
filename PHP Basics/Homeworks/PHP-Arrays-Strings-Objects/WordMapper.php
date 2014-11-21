<form method="get">
    <textarea name="textbox" rows="4" cols="40"></textarea> <br>
    <input type="submit" value="Count words"/>
</form>


<?php
if(isset($_GET['textbox'])){
    $input = $_GET['textbox'];    
    $words = preg_split("/\W+/", strtolower($input), -1, PREG_SPLIT_NO_EMPTY);
    $tags = array();
    $counter = array();
    
    foreach($words as $item){
        $found = false;
        $index = 0;
        for ($i = 0; $i < sizeof($tags); $i++)
        {
        	if ($item == $tags[$i])
            {
            	$found = true;
                $index = $i;
                break;
            }            
        }
        if ($found)
        {
        	$counter[$index]++;
        } else {
            array_push($tags, $item);
            array_push($counter, 1);
        }        
    }
    
    $result = "<table border='1'><tbody>";
    for ($i = 0; $i < sizeof($tags); $i++)
    {
    	$result .= "<tr><td>{$tags[$i]}</td><td>{$counter[$i]}</td></tr>";
    }
    $result .= "</tbody></table>";
    echo $result;
}

?>