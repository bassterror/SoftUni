Enter tags:
<form method="get">
    <input type="text" name="textbox" />
    <input type="submit" />
</form>


<?php
if(isset($_GET['textbox'])){
    $input = $_GET['textbox'];
    $arr = explode(', ', $input);
    $tags = array();
    $counter = array();
    
    foreach($arr as $item){
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
    
    for ($i = sizeof($counter) - 1; $i >  0; $i--)
    {
        for ($j = $i - 1; $j >= 0; $j--)
        {
            if ($counter[$i] > $counter[$j])
            {
                $temp = $counter[$j];
                $counter[$j] = $counter[$i];
                $counter[$i] = $temp;
                
                $temp = $tags[$j];
                $tags[$j] = $tags[$i];
                $tags[$i] = $temp;
            }            
        }        
    }
    
    
    for ($i = 0; $i < sizeof($tags); $i++)
    {
    	echo "$tags[$i] : $counter[$i] times <br>";
    }
    echo "Most frequent tag is: $tags[0]";
}

?>